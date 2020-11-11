using System;
using System.ComponentModel.Composition;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace AppleWirelessKeyboardCore.Keyboard.Apple
{
    [Export(typeof(IInputAdapter))]
    public class AppleKeyboardHID2 : IInputAdapter
    {
        // Fields
        private Stream? stream;
        private const int VIDApple = 0x5ac;

        // Events
        public event EventHandler? Disconnected;

        //Properties
        public bool FnDown { get; set; }
        public bool EjectDown { get; set; }
        public bool PowerButtonDown { get; set; }
        public bool Registered => stream != null;

        public void Stop()
        {
            if (stream != null)
            {
                stream.Close();
                stream = null;
            }

            if (FnDown)
            {
                Fn?.Invoke(false);
                FMode?.Invoke(false);

                FnDown = false;
            }

            if (EjectDown)
            {
                Eject?.Invoke(false);
                EjectDown = false;
            }
        }

        private void SpecialKeyStateChanged(IAsyncResult ar)
        {
            // Check Stream
            if (stream == null || !ar.IsCompleted) return;

            // Process Event
            if (ar.AsyncState is not byte[] asyncState) return;

            if (asyncState[0] == 0x11 || asyncState[0] == 0x00)
            {
                var fnDown = (asyncState[1] & 0x10) == 0x10;
                var ejectDown = (asyncState[1] & 0x8) == 0x8;

                if (fnDown != FnDown)
                {
                    FnDown = fnDown;
                    Fn?.Invoke(FnDown);
                    FMode?.Invoke(FnDown);
                }

                if (ejectDown != EjectDown)
                {
                    EjectDown = ejectDown;
                    Eject?.Invoke(EjectDown);
                    Key?.Invoke(System.Windows.Input.Key.F13, EjectDown);
                }
            }
            else if (asyncState[0] == 0x13)
            {
                PowerButtonDown = asyncState[1] == 1;
                Power?.Invoke(PowerButtonDown);
            }

            // End this read
            try
            {
                stream.EndRead(ar);
            }
            catch (IOException)
            {
                // TODO maybe move this restart logic elsewhere?
                Disconnected?.Invoke(null, EventArgs.Empty);

                Stop();
                Start();

                return;
            }
            catch
            {
                // ignored
            }

            //TODO Convert to Observable<byte[0x16]>

            // Next read next
            stream.BeginRead(asyncState, 0, asyncState.Length, SpecialKeyStateChanged, asyncState);
        }

        public void Start()
        {
            HIDImports.SP_DEVICE_INTERFACE_DATA spDeviceInterfaceData = new HIDImports.SP_DEVICE_INTERFACE_DATA()
            {
                cbSize = Marshal.SizeOf(typeof(HIDImports.SP_DEVICE_INTERFACE_DATA))
            };

            if (stream != null)
            {
                throw new InvalidOperationException("Connected to a different stream already!");
            }

            HIDImports.HidD_GetHidGuid(out Guid guid);
            IntPtr hDevInfo = HIDImports.SetupDiGetClassDevs(ref guid, null, IntPtr.Zero, 0x10);

            int num = 0;
            while (HIDImports.SetupDiEnumDeviceInterfaces(hDevInfo, IntPtr.Zero, ref guid, num++, ref spDeviceInterfaceData))
            {
                HIDImports.SP_DEVICE_INTERFACE_DETAIL_DATA deviceInterfaceDetailData = new HIDImports.SP_DEVICE_INTERFACE_DETAIL_DATA
                {
                    cbSize = (uint)(IntPtr.Size == 8 ? 8 : 5)
                };

                HIDImports.SetupDiGetDeviceInterfaceDetail(hDevInfo, ref spDeviceInterfaceData, IntPtr.Zero, 0, out uint requiredSize, IntPtr.Zero);
                if (HIDImports.SetupDiGetDeviceInterfaceDetail(hDevInfo, ref spDeviceInterfaceData, ref deviceInterfaceDetailData, requiredSize, out requiredSize, IntPtr.Zero))
                {
                    HIDImports.HIDD_ATTRIBUTES hiddAttributes = new HIDImports.HIDD_ATTRIBUTES()
                    {
                        Size = Marshal.SizeOf(typeof(HIDImports.HIDD_ATTRIBUTES))
                    };

                    SafeFileHandle handle = HIDImports.CreateFile(deviceInterfaceDetailData.DevicePath, FileAccess.Read, FileShare.Read, IntPtr.Zero, FileMode.Open, HIDImports.EFileAttributes.Overlapped, IntPtr.Zero);

                    if (HIDImports.HidD_GetAttributes(handle.DangerousGetHandle(), ref hiddAttributes))
                    {
                        if (IsAppleWirelessKeyboard(hiddAttributes.VendorID, hiddAttributes.ProductID))
                            stream = new FileStream(handle, FileAccess.Read, 0x16, true);
                        else
                            handle.Close();
                    }
                }
            }

            HIDImports.SetupDiDestroyDeviceInfoList(hDevInfo);

            if (stream != null)
            {
                byte[] buffer = new byte[0x16];
                stream.BeginRead(buffer, 0, buffer.Length, SpecialKeyStateChanged, buffer);
            }
        }

        private static bool IsAppleWirelessKeyboard(int vid, int pid)
        {
            if (vid == VIDApple)
            {
                HIDImports.HidD_GetHidGuid(out Guid HIDGUID);

                IntPtr deviceInfoListPointer = HIDImports.SetupDiGetClassDevs(ref HIDGUID, null, IntPtr.Zero, 16);

                HIDImports.SP_DEVINFO_DATA DID = new HIDImports.SP_DEVINFO_DATA()
                {
                    cbSize = (uint)Marshal.SizeOf(typeof(HIDImports.SP_DEVINFO_DATA))
                };

                uint memberIndex = 0;
                while (HIDImports.SetupDiEnumDeviceInfo(deviceInfoListPointer, memberIndex++, ref DID))
                {
                    IntPtr buffer = Marshal.AllocHGlobal(512);

                    if (HIDImports.SetupDiGetDeviceRegistryProperty(deviceInfoListPointer, ref DID, (uint)HIDImports.SPDRP.SPDRP_CLASS, out _, buffer, 512, out _))
                    {
                        string? CLASS = Marshal.PtrToStringAuto(buffer);
                        if ("Keyboard".Equals(CLASS, StringComparison.InvariantCultureIgnoreCase))
                            return true;
                    }
                }

                HIDImports.SetupDiDestroyDeviceInfoList(deviceInfoListPointer);

            }
            return false;
        }

        public event KeyEventHandler? Key;
        public event PressedEventHandler? Fn;
        public event PressedEventHandler? Alt;
        public event PressedEventHandler? Win;
        public event PressedEventHandler? Ctrl;
        public event PressedEventHandler? Shift;
        public event PressedEventHandler? Eject;
        public event PressedEventHandler? Power;
        public event PressedEventHandler? FMode;
    }
}