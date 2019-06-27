using AppleWirelessKeyboardCore.Keyboard;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace AppleWirelessKeyboardCore.Keyboard
{
    public static class BrightnessControl
    {
        static BrightnessControl()
        {
            WmiMonitorBrightness = WmiGetObject("WmiMonitorBrightness");
            WmiMonitorBrightnessMethods = WmiGetObject("WmiMonitorBrightnessMethods");

            if (WmiMonitorBrightness != null)
            {
                BrightnessLevels = GetBrightnessLevels();
                CanAdjustBrightness = true;
            }
            else
                CanAdjustBrightness = false;
        }

        private static byte[] BrightnessLevels { get; set; }
        public static bool CanAdjustBrightness { get; set; }

        private static ManagementObject WmiMonitorBrightness;
        private static ManagementObject WmiMonitorBrightnessMethods;

        internal static ManagementObject WmiGetObject(string query)
        {
            if (CanAdjustBrightness)
            {
                try
                {
                    System.Management.ManagementScope scope = new System.Management.ManagementScope("root\\WMI");

                    using (System.Management.ManagementObjectSearcher mos = new System.Management.ManagementObjectSearcher(scope, new SelectQuery(query)))
                    {
                        using (ManagementObjectCollection collection = mos.Get())
                        {
                            return collection.OfType<ManagementObject>().FirstOrDefault();
                        }
                    }
                }
                catch
                {
                    return null;
                } 
            }
            else
            {
                return null;
            }
        }

        private static int LevelToCubes(int level)
        {
            double percent = level / (double)(BrightnessLevels.Length - 1);
            return (int)(percent * 16);
        }

        [Export]
        [ExportMetadata("Name", "IncreaseBrightness")]
        public static Action<KeyboardEvent> IncreaseBrightness
        {
            get{
                return direction =>
                {
                    if (direction.HasFlag(KeyboardEvent.Down) && CanAdjustBrightness)
                    {
                        WmiMonitorBrightness = WmiGetObject("WmiMonitorBrightness");

                        int brightness = GetBrightness();
                        int level = Array.IndexOf(BrightnessLevels, (byte)brightness);
                        if (level + 1 < BrightnessLevels.Length)
                        {
                            SetBrightness(BrightnessLevels[level + 1]);
                            NotificationCenter.NotifyBrightnessLevel(LevelToCubes(level + 1));
                        }
                    }
                };
            }
        }

        [Export]
        [ExportMetadata("Name", "DecreaseBrightness")]
        public static Action<KeyboardEvent> DecreaseBrightness
        {
            get
            {
                return direction =>
                {
                    if (direction.HasFlag(KeyboardEvent.Down) && CanAdjustBrightness)
                    {
                        WmiMonitorBrightness = WmiGetObject("WmiMonitorBrightness");

                        int brightness = GetBrightness();
                        int level = Array.IndexOf(BrightnessLevels, (byte)brightness);
                        if (level >= 1)
                        {
                            SetBrightness(BrightnessLevels[level - 1]);
                            NotificationCenter.NotifyBrightnessLevel(LevelToCubes(level - 1));
                        }
                    }
                };
            }
        }

        private static int GetBrightness()
        {
            if (CanAdjustBrightness)
            {
                return 100;
            }
            else
            {
                return (int)(byte)WmiMonitorBrightness.GetPropertyValue("CurrentBrightness");
            }
        }

        private static byte[] GetBrightnessLevels()
        {
            return (byte[])WmiMonitorBrightness.GetPropertyValue("Level");
        }

        private static void SetBrightness(int targetBrightness)
        {
            WmiMonitorBrightnessMethods.InvokeMethod("WmiSetBrightness", new Object[] { UInt32.MaxValue, (byte)targetBrightness }); //note the reversed order - won't work otherwise!
        }
    }
}
