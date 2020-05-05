using System;
using System.Runtime.InteropServices;
using System.IO;
using Microsoft.Win32.SafeHandles;

namespace AppleWirelessKeyboardCore.Keyboard.Apple
{
    /// <summary>
    /// Win32 import information for use with the Wiimote library
    /// </summary>
    class HIDImports
    {
        //
        // Flags controlling what is included in the device information set built
        // by SetupDiGetClassDevs
        //
        public const int DIGCF_DEFAULT = 0x00000001; // only valid with DIGCF_DEVICEINTERFACE
        public const int DIGCF_PRESENT = 0x00000002;
        public const int DIGCF_ALLCLASSES = 0x00000004;
        public const int DIGCF_PROFILE = 0x00000008;
        public const int DIGCF_DEVICEINTERFACE = 0x00000010;

        [Flags]
        public enum EFileAttributes : uint
        {
            Readonly = 0x00000001,
            Hidden = 0x00000002,
            System = 0x00000004,
            Directory = 0x00000010,
            Archive = 0x00000020,
            Device = 0x00000040,
            Normal = 0x00000080,
            Temporary = 0x00000100,
            SparseFile = 0x00000200,
            ReparsePoint = 0x00000400,
            Compressed = 0x00000800,
            Offline = 0x00001000,
            NotContentIndexed = 0x00002000,
            Encrypted = 0x00004000,
            Write_Through = 0x80000000,
            Overlapped = 0x40000000,
            NoBuffering = 0x20000000,
            RandomAccess = 0x10000000,
            SequentialScan = 0x08000000,
            DeleteOnClose = 0x04000000,
            BackupSemantics = 0x02000000,
            PosixSemantics = 0x01000000,
            OpenReparsePoint = 0x00200000,
            OpenNoRecall = 0x00100000,
            FirstPipeInstance = 0x00080000
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SP_DEVINFO_DATA
        {
            public uint cbSize;
            public Guid ClassGuid;
            public uint DevInst;
            public IntPtr Reserved;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SP_DEVICE_INTERFACE_DATA
        {
            public int cbSize;
            public Guid InterfaceClassGuid;
            public int Flags;
            public IntPtr RESERVED;
        }

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public struct SP_DEVICE_INTERFACE_DETAIL_DATA
        {
            public UInt32 cbSize;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string DevicePath;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct HIDD_ATTRIBUTES
        {
            public int Size;
            public short VendorID;
            public short ProductID;
            public short VersionNumber;
        }

        [DllImport(@"hid.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern void HidD_GetHidGuid(out Guid gHid);

        [DllImport("hid.dll")]
        public static extern Boolean HidD_GetAttributes(IntPtr HidDeviceObject, ref HIDD_ATTRIBUTES Attributes);

        [DllImport("hid.dll")]
        internal extern static bool HidD_SetOutputReport(
            IntPtr HidDeviceObject,
            byte[] lpReportBuffer,
            uint ReportBufferLength);

        [DllImport(@"setupapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr SetupDiGetClassDevs(
            ref Guid ClassGuid,
            [MarshalAs(UnmanagedType.LPTStr)] string? Enumerator,
            IntPtr hwndParent,
            UInt32 Flags
            );

        [DllImport(@"setupapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern Boolean SetupDiEnumDeviceInterfaces(
            IntPtr hDevInfo,
            //ref SP_DEVINFO_DATA devInfo,
            IntPtr devInvo,
            ref Guid interfaceClassGuid,
            Int32 memberIndex,
            ref SP_DEVICE_INTERFACE_DATA deviceInterfaceData
        );

        [DllImport(@"setupapi.dll", SetLastError = true)]
        public static extern Boolean SetupDiGetDeviceInterfaceDetail(
            IntPtr hDevInfo,
            ref SP_DEVICE_INTERFACE_DATA deviceInterfaceData,
            IntPtr deviceInterfaceDetailData,
            UInt32 deviceInterfaceDetailDataSize,
            out UInt32 requiredSize,
            IntPtr deviceInfoData
        );

        [DllImport(@"setupapi.dll", SetLastError = true)]
        public static extern Boolean SetupDiGetDeviceInterfaceDetail(
            IntPtr hDevInfo,
            ref SP_DEVICE_INTERFACE_DATA deviceInterfaceData,
            ref SP_DEVICE_INTERFACE_DETAIL_DATA deviceInterfaceDetailData,
            UInt32 deviceInterfaceDetailDataSize,
            out UInt32 requiredSize,
            IntPtr deviceInfoData
        );

        [DllImport(@"setupapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern UInt16 SetupDiDestroyDeviceInfoList(IntPtr hDevInfo);

        [DllImport("Kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern SafeFileHandle CreateFile(
            string fileName,
            [MarshalAs(UnmanagedType.U4)] FileAccess fileAccess,
            [MarshalAs(UnmanagedType.U4)] FileShare fileShare,
            IntPtr securityAttributes,
            [MarshalAs(UnmanagedType.U4)] FileMode creationDisposition,
            [MarshalAs(UnmanagedType.U4)] EFileAttributes flags,
            IntPtr template);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool CloseHandle(IntPtr hObject);

        [DllImport("setupapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetupDiGetDeviceRegistryProperty(
            IntPtr DeviceInfoSet,
            ref SP_DEVINFO_DATA DeviceInfoData,
            uint Property,
            out UInt32 PropertyRegDataType,
            IntPtr PropertyBuffer,
            uint PropertyBufferSize,
            out UInt32 RequiredSize);

        public enum SPDRP
        {
            SPDRP_DEVICEDESC = 0x00000000,
            SPDRP_HARDWAREID = 0x00000001,
            SPDRP_COMPATIBLEIDS = 0x00000002,
            SPDRP_NTDEVICEPATHS = 0x00000003,
            SPDRP_SERVICE = 0x00000004,
            SPDRP_CONFIGURATION = 0x00000005,
            SPDRP_CONFIGURATIONVECTOR = 0x00000006,
            SPDRP_CLASS = 0x00000007,
            SPDRP_CLASSGUID = 0x00000008,
            SPDRP_DRIVER = 0x00000009,
            SPDRP_CONFIGFLAGS = 0x0000000A,
            SPDRP_MFG = 0x0000000B,
            SPDRP_FRIENDLYNAME = 0x0000000C,
            SPDRP_LOCATION_INFORMATION = 0x0000000D,
            SPDRP_PHYSICAL_DEVICE_OBJECT_NAME = 0x0000000E,
            SPDRP_CAPABILITIES = 0x0000000F,
            SPDRP_UI_NUMBER = 0x00000010,
            SPDRP_UPPERFILTERS = 0x00000011,
            SPDRP_LOWERFILTERS = 0x00000012,
            SPDRP_MAXIMUM_PROPERTY = 0x00000013,
        }

        [DllImport("setupapi.dll", SetLastError = true)]
        public static extern bool SetupDiEnumDeviceInfo(IntPtr DeviceInfoSet, uint MemberIndex, ref SP_DEVINFO_DATA DeviceInfoData);
    }
}
