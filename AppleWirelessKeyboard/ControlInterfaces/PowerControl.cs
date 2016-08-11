using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.ComponentModel.Composition;
using AppleWirelessKeyboard.Keyboard;

namespace AppleWirelessKeyboard
{
    public class PowerControl
    {

        [DllImport("powrprof.dll", SetLastError = true)]
        static extern bool SetSuspendState(bool hibernate, bool forceCritical, bool disableWakeEvent);

        [ExportMetadata("Name", "Hibernate")]
        [Export]
        public static Action<KeyboardEvent> Hibernate
        {
            get
            {
                return direction =>
                {
                    if (direction.HasFlag(KeyboardEvent.Down))
                        if (PowerStatusBox.PowerAction("Hibernate", 10))
                            SetSuspendState(true, true, true);
                };
            }
        }

        [ExportMetadata("Name", "Shutdown")]
        [Export]
        public static Action<KeyboardEvent> Shutdown
        {
            get
            {
                return direction =>
                {
                    if (direction.HasFlag(KeyboardEvent.Down))
                        if (PowerStatusBox.PowerAction("Shut Down", 10))
                        {
                            ProcessStartInfo si = new ProcessStartInfo("shutdown", "/s /t 0");
                            si.CreateNoWindow = true;
                            si.WindowStyle = ProcessWindowStyle.Hidden;
                            Process.Start(si);
                        }
                };
            }
        }

        [ExportMetadata("Name", "ToggleFMode")]
        [Export]
        public static Action<KeyboardEvent> ToggleFMode
        {
            get
            {
                return direction =>
                {
                    if (direction.HasFlag(KeyboardEvent.Down))
                    {
                        App.Keyboard.FMode = !App.Keyboard.FMode;
                        if (App.Keyboard.FMode)
                            NotificationCenter.NotifyOn();
                        else NotificationCenter.NotifyOff();
                    }
                };
            }
        }
    }
}
