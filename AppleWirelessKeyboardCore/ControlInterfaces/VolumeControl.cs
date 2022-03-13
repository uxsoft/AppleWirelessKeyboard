using System;
using System.ComponentModel.Composition;
using AppleWirelessKeyboardCore.Keyboard;
using AppleWirelessKeyboardCore.Audio;
using CoreAudio;

namespace AppleWirelessKeyboardCore.ControlInterfaces
{
    public static class VolumeControl
    {
        [ExportMetadata("Category", "Media")]
        [ExportMetadata("Name", "VolumeUp")]
        [Export]
        public static Action<KeyboardEvent> VolumeUp => direction =>
            {
                if (direction.HasFlag(KeyboardEvent.Down))
                {
                    var controller = AudioEndPoints.GetDefaultMMDevice(EDataFlow.eRender).AudioEndpointVolume;

                    if (controller.MasterVolumeLevelScalar > 0.9375f)
                        controller.MasterVolumeLevelScalar = 1.0f;
                    else controller.MasterVolumeLevelScalar += 0.0625f;
                    NotificationCenter.NotifyVolumeLevel((int)(controller.MasterVolumeLevelScalar / 0.0625));
                }
            };

        [ExportMetadata("Category", "Media")]
        [ExportMetadata("Name", "VolumeDown")]
        [Export]
        public static Action<KeyboardEvent> VolumeDown => direction =>
            {
                if (direction.HasFlag(KeyboardEvent.Down))
                {
                    var controller = AudioEndPoints.GetDefaultMMDevice(EDataFlow.eRender).AudioEndpointVolume;
                    if (controller.MasterVolumeLevelScalar < 0.0625)
                    {
                        controller.MasterVolumeLevelScalar = 0;
                        NotificationCenter.NotifyNoVolume();
                    }
                    else
                    {
                        controller.MasterVolumeLevelScalar -= 0.0625f;
                        NotificationCenter.NotifyVolumeLevel((int)(controller.MasterVolumeLevelScalar / 0.0625));
                    }
                }
            };

        [ExportMetadata("Category", "Media")]
        [ExportMetadata("Name", "VolumeMute")]
        [Export]
        public static Action<KeyboardEvent> VolumeMute => direction =>
            {
                if (direction.HasFlag(KeyboardEvent.Down))
                {
                    var controller = AudioEndPoints.GetDefaultMMDevice(EDataFlow.eRender).AudioEndpointVolume;

                    controller.Mute = !controller.Mute;
                    if (controller.Mute)
                        NotificationCenter.NotifyMuteOff();
                    else
                        NotificationCenter.NotifyMuteOn();
                }
            };

        [ExportMetadata("Category", "Media")]
        [ExportMetadata("Name", "VolumeSwitchDevice")]
        [Export]
        public static Action<KeyboardEvent> VolumeSwitchDevice => direction =>
            {
                if (direction.HasFlag(KeyboardEvent.Down))
                {
                    AudioEndPoints.SetNextDefault(EDataFlow.eRender);
                    NotificationCenter.NotifyMediaDeviceChanged();
                }
            };
    }
}
