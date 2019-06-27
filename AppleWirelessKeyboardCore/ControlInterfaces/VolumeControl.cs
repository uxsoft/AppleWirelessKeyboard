using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using AudioSwitch.CoreAudioApi;
using AudioSwitch.Classes;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using AppleWirelessKeyboardCore.Keyboard;

namespace AppleWirelessKeyboardCore
{
    public static class VolumeControl
    {
        [ExportMetadata("Category", "Media")]
        [ExportMetadata("Name", "VolumeIncrease")]
        [Export]
        public static Action<KeyboardEvent> VolumeUp
        {
            get
            {
                return direction =>
                {
                    if (direction.HasFlag(KeyboardEvent.Down))
                    {
                        AudioEndpointVolume Controller = EndPoints.GetDefaultMMDevice(EDataFlow.eRender).AudioEndpointVolume;

                        if (Controller.MasterVolumeLevelScalar > 0.9375f)
                            Controller.MasterVolumeLevelScalar = 1.0f;
                        else Controller.MasterVolumeLevelScalar += 0.0625f;
                        NotificationCenter.NotifyVolumeLevel((int)(Controller.MasterVolumeLevelScalar / 0.0625));
                    }
                };
            }
        }

        [ExportMetadata("Category", "Media")]
        [ExportMetadata("Name", "VolumeDecrease")]
        [Export]
        public static Action<KeyboardEvent> VolumeDown
        {
            get
            {
                return direction =>
                {
                    if (direction.HasFlag(KeyboardEvent.Down))
                    {
                        AudioEndpointVolume Controller = EndPoints.GetDefaultMMDevice(EDataFlow.eRender).AudioEndpointVolume;
                        if (Controller.MasterVolumeLevelScalar < 0.0625)
                        {
                            Controller.MasterVolumeLevelScalar = 0;
                            NotificationCenter.NotifyNoVolume();
                        }
                        else
                        {
                            Controller.MasterVolumeLevelScalar -= 0.0625f;
                            NotificationCenter.NotifyVolumeLevel((int)(Controller.MasterVolumeLevelScalar / 0.0625));
                        }
                    }
                };
            }
        }

        [ExportMetadata("Category", "Media")]
        [ExportMetadata("Name", "VolumeMute")]
        [Export]
        public static Action<KeyboardEvent> Mute
        {
            get
            {
                return direction =>
                {
                    if (direction.HasFlag(KeyboardEvent.Down))
                    {
                        AudioEndpointVolume Controller = EndPoints.GetDefaultMMDevice(EDataFlow.eRender).AudioEndpointVolume;

                        Controller.Mute = !Controller.Mute;
                        if (Controller.Mute)
                            NotificationCenter.NotifyMuteOff();
                        else
                            NotificationCenter.NotifyMuteOn();
                    }
                };
            }        
        }

        [ExportMetadata("Category", "Media")]
        [ExportMetadata("Name", "VolumeSwitchDevice")]
        [Export]
        public static Action<KeyboardEvent> NextAudioDeviceExport
        {
            get
            {
                return direction =>
                {
                    if (direction.HasFlag(KeyboardEvent.Down))
                    {
                        EndPoints.SetNextDefault(EDataFlow.eRender);
                        NotificationCenter.NotifyMediaDeviceChanged();
                    }
                };
            }
        }
    }
}
