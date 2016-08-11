using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppleWirelessKeyboard
{
    public static class NotificationCenter
    {
        public static void NotifyMuteOn()
        {
            App.Window.ShowOff<Glyphs.MuteOn>();
        }
        public static void NotifyMuteOff()
        {
            App.Window.ShowOff<Glyphs.MuteOff>();
        }
        public static void NotifyNoVolume()
        {
            App.Window.ShowOff<Glyphs.VolumeOff>();
        }
        public static void NotifyVolumeLevel(int level)//1-16
        {
            App.Window.ShowOff<Glyphs.VolumeOn>(true, level);
        }
        public static void NotifyTaskManager()
        {
            App.Window.ShowOff<Glyphs.TaskManager>();
        }
        public static void NotifyPrintScreen()
        {
            App.Window.ShowOff<Glyphs.PrintScreen>();
        }
        public static void NotifyOn()
        {
            App.Window.ShowOff<Glyphs.On>();
        }
        public static void NotifyOff()
        {
            App.Window.ShowOff<Glyphs.Off>();
        }
        public static void NotifyPlayPause()
        {
            App.Window.ShowOff<Glyphs.PlayPause>();
        }
        public static void NotifyPrevious()
        {
            App.Window.ShowOff<Glyphs.Previous>();
        }
        public static void NotifyNext()
        {
            App.Window.ShowOff<Glyphs.Next>();
        }

        public static void NotifyEject()
        {
            App.Window.ShowOff<Glyphs.Eject>();
        }

        public static void NotifyMediaDeviceChanged()
        {
            App.Window.ShowOff<Glyphs.MediaDeviceSwitch>();
        }

        internal static void NotifyBrightnessLevel(int level) //0-16
        {
            if (level == 0)
                App.Window.ShowOff<Glyphs.Brightness>();
            else
                App.Window.ShowOff<Glyphs.Brightness>(true, level);
        }
    }
}
