using System;
using System.IO;
using AppleWirelessKeyboard;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.ComponentModel.Composition;

namespace AppleWirelessKeyboard.Keyboard.Apple
{
    [Export(typeof(IInputAdapter))]
    public class AppleKeyboardHID2 : IInputAdapter
    {
        // Fields
        private Stream _stream;
        public const int VIDApple = 0x5ac;

        // Events
        public event EventHandler Disconnected;

        //Properties
        public bool FnDown { get; set; }
        public bool EjectDown { get; set; }
        public bool PowerButtonDown { get; set; }
        public bool Registered
        {
            get { return _stream != null; }
        }

        public void Stop()
        {
            if (_stream != null)
            {
                _stream.Close();
                _stream = null;
            }

            if (FnDown)
            {
                if (Fn != null)
                    Fn(false);
                if (FMode != null)
                    FMode(false);

                FnDown = false;
            }

            if (EjectDown)
            {
                if (Eject != null)
                    Eject(false);
                EjectDown = false;
            }

        }

        private void SpecialKeyStateChanged(IAsyncResult ar)
        {
            if ((_stream != null) && ar.IsCompleted)
            {
                try
                {
                    _stream.EndRead(ar);
                }
                catch (OperationCanceledException)
                { }
                catch (IOException)
                {
                    if (Disconnected != null)
                        Disconnected(null, EventArgs.Empty);

                    Stop();
                    Start();

                    return;
                }
                byte[] asyncState = ar.AsyncState as byte[];

                if (asyncState[0] == 0x11 || asyncState[0] == 0x00)
                {
                    bool fnDown = (asyncState[1] & 0x10) == 0x10;
                    bool ejectDown = (asyncState[1] & 0x8) == 0x8;

                    if (fnDown != FnDown)
                    {
                        FnDown = fnDown;
                        if (Fn != null)
                            Fn(FnDown);

                        if (FMode != null)
                            FMode(FnDown);
                    }

                    if (ejectDown != EjectDown)
                    {
                        EjectDown = ejectDown;
                        if (Eject != null)
                            Eject(EjectDown);

                        if (Key != null)
                            Key(System.Windows.Input.Key.F13, EjectDown);
                    }
                }
                else if (asyncState[0] == 0x13)
                {
                    PowerButtonDown = asyncState[1] == 1;
                    if (Power != null)
                        Power(PowerButtonDown);
                }

                _stream.BeginRead(asyncState, 0, asyncState.Length, new AsyncCallback(SpecialKeyStateChanged), asyncState);
            }
        }

        public void Start()
        {
            Guid guid;
            HIDImports.SP_DEVICE_INTERFACE_DATA sp_device_interface_data = new HIDImports.SP_DEVICE_INTERFACE_DATA() { cbSize = Marshal.SizeOf(typeof(HIDImports.SP_DEVICE_INTERFACE_DATA)) };

            if (_stream != null)
            {
                throw new InvalidOperationException("Connected to a different stream already!");
            }

            HIDImports.HidD_GetHidGuid(out guid);
            IntPtr hDevInfo = HIDImports.SetupDiGetClassDevs(ref guid, null, IntPtr.Zero, 0x10);

            int num = 0;
            while (HIDImports.SetupDiEnumDeviceInterfaces(hDevInfo, IntPtr.Zero, ref guid, num++, ref sp_device_interface_data))
            {
                uint num2;
                HIDImports.SP_DEVICE_INTERFACE_DETAIL_DATA deviceInterfaceDetailData = new HIDImports.SP_DEVICE_INTERFACE_DETAIL_DATA { cbSize = (IntPtr.Size == 8) ? (uint)8 : (uint)5 };

                HIDImports.SetupDiGetDeviceInterfaceDetail(hDevInfo, ref sp_device_interface_data, IntPtr.Zero, 0, out num2, IntPtr.Zero);
                if (HIDImports.SetupDiGetDeviceInterfaceDetail(hDevInfo, ref sp_device_interface_data, ref deviceInterfaceDetailData, num2, out num2, IntPtr.Zero))
                {
                    HIDImports.HIDD_ATTRIBUTES hidd_attributes = new HIDImports.HIDD_ATTRIBUTES() { Size = Marshal.SizeOf(typeof(HIDImports.HIDD_ATTRIBUTES)) };

                    SafeFileHandle handle = HIDImports.CreateFile(deviceInterfaceDetailData.DevicePath, FileAccess.ReadWrite, FileShare.ReadWrite, IntPtr.Zero, FileMode.Open, HIDImports.EFileAttributes.Overlapped, IntPtr.Zero);

                    if (HIDImports.HidD_GetAttributes(handle.DangerousGetHandle(), ref hidd_attributes))
                    {
                        if (IsAppleWirelessKeyboard(hidd_attributes.VendorID, hidd_attributes.ProductID))
                            _stream = new FileStream(handle, FileAccess.ReadWrite, 0x16, true);
                        else
                            handle.Close();
                    }
                }
            }

            HIDImports.SetupDiDestroyDeviceInfoList(hDevInfo);

            if (_stream != null)
            {
                byte[] buffer = new byte[0x16];
                _stream.BeginRead(buffer, 0, buffer.Length, new AsyncCallback(SpecialKeyStateChanged), buffer);
            }
        }

        private static bool IsAppleWirelessKeyboard(int vid, int pid)
        {
            if (vid == VIDApple)
            {
                Guid HIDGUID;
                HIDImports.HidD_GetHidGuid(out HIDGUID);

                IntPtr DeviceInfo = HIDImports.SetupDiGetClassDevs(ref HIDGUID, null, IntPtr.Zero, 16);

                uint MemberIndex = 0;

                HIDImports.SP_DEVINFO_DATA DID = new HIDImports.SP_DEVINFO_DATA() { cbSize = (uint)Marshal.SizeOf(typeof(HIDImports.SP_DEVINFO_DATA)) };

                while (HIDImports.SetupDiEnumDeviceInfo(DeviceInfo, MemberIndex++, ref DID))
                {
                    uint RequiredSize = 0;
                    uint PropertyDataType = 0;
                    IntPtr buffer = Marshal.AllocHGlobal(512);
                    string CLASS = "";

                    if (HIDImports.SetupDiGetDeviceRegistryProperty(DeviceInfo, ref DID, (uint)HIDImports.SPDRP.SPDRP_CLASS, out PropertyDataType, buffer, 512, out RequiredSize))
                        CLASS = Marshal.PtrToStringAuto(buffer);

                    if (CLASS.Equals("Keyboard", StringComparison.InvariantCultureIgnoreCase))
                        return true;
                }

                HIDImports.SetupDiDestroyDeviceInfoList(DeviceInfo);

            }
            return false;
        }

        public event KeyEventHandler Key;

        public event PressedEventHandler Fn;

        public event PressedEventHandler Alt;

        public event PressedEventHandler Win;

        public event PressedEventHandler Ctrl;

        public event PressedEventHandler Shift;

        public event PressedEventHandler Eject;

        public event PressedEventHandler Power;

        public event PressedEventHandler FMode;
    }
}