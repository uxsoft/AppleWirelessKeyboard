using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Input;
using System.Threading;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using AppleWirelessKeyboardCore.Keyboard;
using static PInvoke.User32;

namespace AppleWirelessKeyboardCore.ControlInterfaces
{
    public static class KeyboardControl
    {
        static KeyboardControl()
        {
            KeyboardFilter = new KeyboardControlFilter();
        }

        public static void Send(VirtualKey vKey, KeyboardEvent e = KeyboardEvent.Both)
        {
            var extendedFlag = 
                ((int)vKey >= 16 && (int)vKey <= 18) || 
                ((int)vKey >= 160 && (int)vKey <= 165) ? 
                0 : 
                KEYEVENTF.KEYEVENTF_EXTENDED_KEY;

            var key = KeyInterop.KeyFromVirtualKey((int)vKey);

            if (e.HasFlag(KeyboardEvent.Down))
            {
                keybd_event((byte) vKey, 0, extendedFlag, IntPtr.Zero);
                KeyboardFilter.Expect(key, true);
            }

            if (e.HasFlag(KeyboardEvent.Up))
            {
                keybd_event((byte) vKey, 0, extendedFlag | KEYEVENTF.KEYEVENTF_KEYUP, IntPtr.Zero);
                KeyboardFilter.Expect(key, false);
            }
        }

        [Export(typeof(IInputFilter))]
        public static KeyboardControlFilter KeyboardFilter { get; set; }

        public static void SendLetter(char letter, KeyboardEvent direction = KeyboardEvent.Both)
        {
            // letter a is 65
            if (char.IsLetter(letter) && char.IsLower(letter))
                Send((VirtualKey)(letter - 32), direction);
            else if (char.IsLetter(letter) && char.IsUpper(letter))
                Send((VirtualKey)letter, direction);
        }

        public static void SendDigit(byte digit, KeyboardEvent direction = KeyboardEvent.Both)
        {
            // numpad 0 is 96
            if (digit <= 9)
                Send((VirtualKey)(96 + digit), direction);
        }


        [Export]
        [ExportMetadata("Name", "Insert")]
        public static Action<KeyboardEvent> SendInsert => 
            direction => Send(VirtualKey.VK_INSERT, direction);

        [Export]
        [ExportMetadata("Name", "Delete")]
        public static Action<KeyboardEvent> SendDelete => 
            direction => Send(VirtualKey.VK_DELETE, direction);

        [Export]
        [ExportMetadata("Name", "PrintScreen")]
        public static Action<KeyboardEvent> SendPrintScreen =>
            direction =>
            {
                Send(VirtualKey.VK_SNAPSHOT, direction);
                Thread.Sleep(250);
                NotificationCenter.NotifyPrintScreen();
            };

        [Export]
        [ExportMetadata("Name", "PauseTrack")]
        public static Action<KeyboardEvent> SendPlayPause =>
            direction =>
            {
                Send(VirtualKey.VK_MEDIA_PLAY_PAUSE, direction);
                NotificationCenter.NotifyPlayPause();
            };

        [Export]
        [ExportMetadata("Category", "Media")]
        [ExportMetadata("Name", "NextTrack")]
        public static Action<KeyboardEvent> SendNextTrack =>
            direction =>
            {
                Send(VirtualKey.VK_MEDIA_NEXT_TRACK, direction);
                NotificationCenter.NotifyNext();
            };

        [Export]
        [ExportMetadata("Category", "Media")]
        [ExportMetadata("Name", "PreviousTrack")]
        public static Action<KeyboardEvent> SendPreviousTrack =>
            direction =>
            {
                Send(VirtualKey.VK_MEDIA_PREV_TRACK, direction);
                NotificationCenter.NotifyPrevious();
            };

        [Export]
        [ExportMetadata("Name", "TaskManager")]
        public static Action<KeyboardEvent> OpenTaskManager =>
            direction =>
            {
                if (direction == KeyboardEvent.Down) return;
                
                var taskMgr = Process.GetProcessesByName("taskmgr.exe").FirstOrDefault();

                if (taskMgr != null)
                    PInvoke.User32.SetForegroundWindow(taskMgr.MainWindowHandle);
                else
                    Process.Start("taskmgr.exe");
                NotificationCenter.NotifyTaskManager();
            };

        [Export]
        [ExportMetadata("Name", "CapsLock")]
        public static Action<KeyboardEvent> SendCapsLock => 
            direction => Send(VirtualKey.VK_CAPITAL, direction);

        [Export]
        [ExportMetadata("Name", "PageUp")]
        public static Action<KeyboardEvent> SendPageUp => 
            direction => Send(VirtualKey.VK_PRIOR, direction);

        [Export]
        [ExportMetadata("Name", "PageDown")]
        public static Action<KeyboardEvent> SendPageDown => 
            direction => Send(VirtualKey.VK_NEXT, direction);

        [Export]
        [ExportMetadata("Name", "Home")]
        public static Action<KeyboardEvent> SendHome => 
            direction => Send(VirtualKey.VK_HOME, direction);

        [Export]
        [ExportMetadata("Name", "End")]
        public static Action<KeyboardEvent> SendEnd => 
            direction => Send(VirtualKey.VK_END, direction);

        [Export]
        [ExportMetadata("Name", "F3")]
        public static Action<KeyboardEvent> SendF3 => 
            direction => Send(VirtualKey.VK_F3, direction);

        [Export]
        [ExportMetadata("Name", "Ctrl")]
        public static Action<KeyboardEvent> SendCtrl => 
            direction => Send(VirtualKey.VK_CONTROL, direction);

        [Export]
        [ExportMetadata("Name", "Alt")]
        public static Action<KeyboardEvent> SendAlt => 
            direction => Send(VirtualKey.VK_MENU, direction);

        [Export]
        [ExportMetadata("Name", "Win")]
        public static Action<KeyboardEvent> SendWin => 
            direction => Send(VirtualKey.VK_LWIN, direction);
    }
}