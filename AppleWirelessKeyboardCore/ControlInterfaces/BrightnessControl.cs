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
            {
                BrightnessLevels = Array.Empty<byte>();
                CanAdjustBrightness = false;
            }
        }

        static byte[] BrightnessLevels { get; set; }
        public static bool CanAdjustBrightness { get; set; }

        static ManagementObject? WmiMonitorBrightness;
        static ManagementObject? WmiMonitorBrightnessMethods;

        internal static ManagementObject? WmiGetObject(string query)
        {
            if (CanAdjustBrightness)
            {
                try
                {
                    var scope = new ManagementScope("root\\WMI");

                    using var mos = new ManagementObjectSearcher(scope, new SelectQuery(query));
                    using var collection = mos.Get();
                    return collection.OfType<ManagementObject>().FirstOrDefault();
                }
                catch
                {
                    return null;
                }
            }
            else
                return null;
        }

        static int LevelToCubes(int level)
        {
            var percent = level / (double)(BrightnessLevels.Length - 1);
            return (int)(percent * 16);
        }

        [Export]
        [ExportMetadata("Name", "IncreaseBrightness")]
        public static Action<KeyboardEvent> IncreaseBrightness => 
            direction =>
            {
                if (direction.HasFlag(KeyboardEvent.Down) && CanAdjustBrightness)
                {
                    WmiMonitorBrightness = WmiGetObject("WmiMonitorBrightness");

                    var brightness = GetBrightness();
                    var level = Array.IndexOf(BrightnessLevels, (byte)brightness);
                    if (level + 1 < BrightnessLevels.Length)
                    {
                        SetBrightness(BrightnessLevels[level + 1]);
                        NotificationCenter.NotifyBrightnessLevel(LevelToCubes(level + 1));
                    }
                }
            };

        [Export]
        [ExportMetadata("Name", "DecreaseBrightness")]
        public static Action<KeyboardEvent> DecreaseBrightness =>
            direction =>
            {
                if (direction.HasFlag(KeyboardEvent.Down) && CanAdjustBrightness)
                {
                    WmiMonitorBrightness = WmiGetObject("WmiMonitorBrightness");
            
                    var brightness = GetBrightness();
                    var level = Array.IndexOf(BrightnessLevels, (byte)brightness);
                    if (level >= 1)
                    {
                        SetBrightness(BrightnessLevels[level - 1]);
                        NotificationCenter.NotifyBrightnessLevel(LevelToCubes(level - 1));
                    }
                }
            };

        static int GetBrightness()
        {
            if (CanAdjustBrightness)
                return 100;
            else
                return (byte)(WmiMonitorBrightness?.GetPropertyValue("CurrentBrightness") ?? 0);
        }

        static byte[] GetBrightnessLevels()
        {
            return (byte[])(WmiMonitorBrightness?.GetPropertyValue("Level") ?? Array.Empty<byte>());
        }

        static void SetBrightness(int targetBrightness)
        {
            WmiMonitorBrightnessMethods?.InvokeMethod("WmiSetBrightness", new object[] { uint.MaxValue, (byte)targetBrightness });
            //note the reversed order - won't work otherwise!
        }
    }
}
