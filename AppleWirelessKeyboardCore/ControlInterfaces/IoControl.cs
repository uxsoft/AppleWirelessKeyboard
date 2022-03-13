using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using AppleWirelessKeyboardCore.Keyboard;
using static PInvoke.Kernel32;

namespace AppleWirelessKeyboardCore
{
    public static class IoControl
    {
        const uint IOCTL_STORAGE_EJECT_MEDIA = 2967560;

        public static void EjectMedia(char driveLetter)
        {
            try
            {
                var path = "\\\\.\\" + driveLetter + ":";
                var handle = CreateFile(
                    path, 
                    ACCESS_MASK.GenericRight.GENERIC_READ, 
                    PInvoke.Kernel32.FileShare.FILE_SHARE_WRITE, 
                    IntPtr.Zero, 
                    CreationDisposition.OPEN_EXISTING,
                    0, 
                    SafeObjectHandle.Null);
                

                if (handle == null || handle.IsClosed || handle.IsInvalid)
                    throw new IOException("Unable to open drive " + driveLetter);
 
                DeviceIoControl(handle, (int)IOCTL_STORAGE_EJECT_MEDIA, IntPtr.Zero, 0, IntPtr.Zero, 0, out var bytesReturned, IntPtr.Zero);

                CloseHandle(handle.DangerousGetHandle());
            }
            catch { }
        }

        [ExportMetadata("Name", "Eject")]
        [Export]
        public static Action<KeyboardEvent> EjectAllMedia
        {
            get
            {
                return direction =>
                {
                    if (direction.HasFlag(KeyboardEvent.Down))
                    {
                        NotificationCenter.NotifyEject();
                        foreach (var drive in DriveInfo.GetDrives())
                            if (drive.DriveType == DriveType.CDRom)
                            {
                                EjectMedia(drive.Name[0]);
                            }
                    }
                };
            }
        }
    }
}
