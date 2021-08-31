using System.Collections.Generic;
using System.Drawing;
using System.IO;
using CoreAudio;

namespace AppleWirelessKeyboardCore.Audio
{
    public static class AudioEndPoints
    {
        static readonly List<string> DeviceNames = new();
        static int _defaultDeviceId;

        static readonly MMDeviceEnumerator DeviceEnumerator = new();
        static readonly Dictionary<int, string> DeviceIDs = new();
        static readonly CPolicyConfigClient PolicyConfig = new();

        public static void RefreshDeviceList(EDataFlow renderType)
        {
            DeviceNames.Clear();
            DeviceIDs.Clear();

            var pDevices = DeviceEnumerator.EnumerateAudioEndPoints(renderType, DEVICE_STATE.DEVICE_STATE_ACTIVE);
            var defaultDeviceId = DeviceEnumerator.GetDefaultAudioEndpoint(renderType, ERole.eMultimedia).ID;
            var devCount = pDevices.Count;

            for (var i = 0; i < devCount; i++)
            {
                var device = pDevices[i];
                DeviceNames.Add(device.FriendlyName);
                DeviceIDs.Add(i, device.ID);

                if (device.ID == defaultDeviceId)
                    _defaultDeviceId = i;
            }
        }

        public static string SetNextDefault(EDataFlow rType)
        {
            RefreshDeviceList(rType);

            if (_defaultDeviceId == DeviceNames.Count - 1)
                _defaultDeviceId = 0;
            else
                _defaultDeviceId++;

            SetDefaultDevice(_defaultDeviceId);
            return DeviceNames[_defaultDeviceId];
        }

        public static MMDevice GetDefaultMMDevice(EDataFlow renderType)
        {
            return DeviceEnumerator.GetDefaultAudioEndpoint(renderType, ERole.eMultimedia);
        }

        public static Dictionary<MMDevice, Icon> GetAllDeviceList()
        {
            var devices = new Dictionary<MMDevice, Icon>();
            var pDevices =
                DeviceEnumerator.EnumerateAudioEndPoints(EDataFlow.eAll, DEVICE_STATE.DEVICE_STATE_ACTIVE);
            var devCount = pDevices.Count;

            for (var i = 0; i < devCount; i++)
            {
                var device = pDevices[i];
                devices.Add(device, new Icon(Stream.Null)); //TODO When PR accepted change to DeviceIcons.GetIcon(device.IconPath));
            }

            return devices;
        }

        public static void SetDefaultDevice(int devId)
        {
            SetDefaultDevice(DeviceIDs[devId]);
        }

        public static void SetDefaultDevice(string devId)
        {
            try
            {
                PolicyConfig.SetDefaultDevie(devId);
            }
            catch
            {
                // ignored
            }
        }
    }
}