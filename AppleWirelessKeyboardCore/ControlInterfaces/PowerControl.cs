using System;
using System.ComponentModel.Composition;
using System.Diagnostics;
using System.Runtime.InteropServices;
using AppleWirelessKeyboardCore.Keyboard;

namespace AppleWirelessKeyboardCore.ControlInterfaces
{
    public class PowerControl
    {
        [DllImport("powrprof.dll", SetLastError = true)]
        static extern bool SetSuspendState(bool hibernate, bool forceCritical, bool disableWakeEvent);

        [ExportMetadata("Name", "Hibernate")]
        [Export]
        public static Action<KeyboardEvent> Hibernate =>
            direction =>
            {
                if (direction.HasFlag(KeyboardEvent.Down))
                    if (PowerStatusBox.PowerAction("Hibernate", 10))
                        SetSuspendState(true, true, true);
            };

        [ExportMetadata("Name", "Shutdown")]
        [Export]
        public static Action<KeyboardEvent> Shutdown =>
            direction =>
            {
                if (direction.HasFlag(KeyboardEvent.Down))
                    if (PowerStatusBox.PowerAction("Shut Down", 10))
                    {
                        ProcessStartInfo si = new ProcessStartInfo("shutdown", "/s /t 0")
                        {
                            CreateNoWindow = true, 
                            WindowStyle = ProcessWindowStyle.Hidden
                        };
                        Process.Start(si);
                    }
            };

        [ExportMetadata("Name", "ToggleFMode")]
        [Export]
        public static Action<KeyboardEvent> ToggleFMode =>
            direction =>
            {
                if (!direction.HasFlag(KeyboardEvent.Down)) return;
                    
                App.Keyboard.FMode.Value = !App.Keyboard.FMode.Value;
                if (App.Keyboard.FMode.Value)
                    NotificationCenter.NotifyOn();
                else NotificationCenter.NotifyOff();
            };
    }
}
