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

namespace AppleWirelessKeyboardCore.ControlInterfaces
{
    public static class KeyboardControl
    {
        static KeyboardControl()
        {
            KeyboardFilter = new KeyboardControlFilter();
        }

        #region PInvoke
        const int VK_SNAPSHOT = 44;
        const int VK_DELETE = 46;
        const int VK_MEDIA_NEXT_TRACK = 176;
        const int VK_MEDIA_PREV_TRACK = 177;
        const int VK_MEDIA_STOP = 178;
        const int VK_MEDIA_PLAY_PAUSE = 179;
        const int VK_END = 35;
        const int VK_HOME = 36;
        const int VK_PAGEUP = 33;
        const int VK_PAGEDOWN = 34;
        const int VK_F3 = 114;
        const int VK_INSERT = 45;
        const int VK_SHIFT = 16;
        const int VK_CONTROL = 17;
        const int VK_ALT = 18;
        const int VK_WIN = 91;
        const int VK_CAPITAL = 20;
        const uint KEYEVENTF_EXTENDEDKEY = 1;
        const uint KEYEVENTF_KEYUP = 2;

        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        #endregion
        public static void Send(int VKey, KeyboardEvent e = KeyboardEvent.Both)
        {
            uint extended_flag = (VKey >= 16 && VKey <= 18) || (VKey >= 160 && VKey <= 165) ? 0 : KEYEVENTF_EXTENDEDKEY;
            Key key = (Key)System.Windows.Input.KeyInterop.KeyFromVirtualKey(VKey);

            if (e.HasFlag(KeyboardEvent.Down))
            {
                keybd_event((byte)VKey, 0, extended_flag, 0);
                KeyboardFilter.Expect(key, true);
            }
            if (e.HasFlag(KeyboardEvent.Up))
            {
                keybd_event((byte)VKey, 0, extended_flag | KEYEVENTF_KEYUP, 0);
                KeyboardFilter.Expect(key, false);
            }
        }

        [Export(typeof(IInputFilter))]
        public static KeyboardControlFilter KeyboardFilter { get; set; }

        public static void SendLetter(char letter, KeyboardEvent direction = KeyboardEvent.Both)
        { //a=65
            if (char.IsLetter(letter) && char.IsLower(letter))
                Send((int)letter - 32, direction);
            else if (char.IsLetter(letter) && char.IsUpper(letter))
                Send((int)letter, direction);
        }

        public static void SendDigit(byte digit, KeyboardEvent direction = KeyboardEvent.Both)
        {
            if (digit >= 0 && digit <= 9)
                Send(96 + digit, direction);
        }


        [Export]
        [ExportMetadata("Name", "Insert")]
        public static Action<KeyboardEvent> SendInsert
        {
            get
            {
                return direction => Send(VK_INSERT, direction);
            }
        }


        [Export]
        [ExportMetadata("Name", "Delete")]
        public static Action<KeyboardEvent> SendDelete
        {
            get
            {
                return direction => Send(VK_DELETE, direction);
            }
        }

        [Export]
        [ExportMetadata("Name", "PrintScreen")]
        public static Action<KeyboardEvent> SendPrintScreen
        {
            get
            {
                return direction =>
                {
                    Send(VK_SNAPSHOT, direction);
                    Thread.Sleep(250);
                    NotificationCenter.NotifyPrintScreen();
                };
            }
        }

        [Export]
        [ExportMetadata("Name", "PauseTrack")]
        public static Action<KeyboardEvent> SendPlayPause
        {
            get
            {
                return direction =>
                {
                    Send(VK_MEDIA_PLAY_PAUSE, direction);
                    NotificationCenter.NotifyPlayPause();
                };
            }
        }

        [Export]
        [ExportMetadata("Category", "Media")]
        [ExportMetadata("Name", "NextTrack")]
        public static Action<KeyboardEvent> SendNextTrack
        {
            get
            {
                return direction =>
                {
                    Send(VK_MEDIA_NEXT_TRACK, direction);
                    NotificationCenter.NotifyNext();
                };
            }
        }

        [Export]
        [ExportMetadata("Category", "Media")]
        [ExportMetadata("Name", "PreviousTrack")]
        public static Action<KeyboardEvent> SendPreviousTrack
        {
            get
            {
                return direction =>
                {
                    Send(VK_MEDIA_PREV_TRACK, direction);
                    NotificationCenter.NotifyPrevious();
                };
            }
        }

        [Export]
        [ExportMetadata("Name", "TaskManager")]
        public static Action<KeyboardEvent> OpenTaskManager
        {
            get
            {
                return direction =>
                {
                    Process taskmgr = Process.GetProcessesByName("taskmgr.exe").FirstOrDefault();
                    if (taskmgr != null)
                        SetForegroundWindow(taskmgr.MainWindowHandle);
                    else
                        Process.Start("taskmgr.exe");
                    NotificationCenter.NotifyTaskManager();
                };
            }
        }

        [Export]
        [ExportMetadata("Name", "CapsLock")]
        public static Action<KeyboardEvent> SendCapsLock
        {
            get
            {
                return direction => Send(VK_CAPITAL, direction);
            }
        }

        [Export]
        [ExportMetadata("Name", "PageUp")]
        public static Action<KeyboardEvent> SendPageUp
        {
            get
            {
                return direction => Send(VK_PAGEUP, direction);
            }
        }

        [Export]
        [ExportMetadata("Name", "PageDown")]
        public static Action<KeyboardEvent> SendPageDown
        {
            get
            {
                return direction => Send(VK_PAGEDOWN, direction);
            }
        }

        [Export]
        [ExportMetadata("Name", "Home")]
        public static Action<KeyboardEvent> SendHome
        {
            get
            {
                return direction => Send(VK_HOME, direction);
            }
        }

        [Export]
        [ExportMetadata("Name", "End")]
        public static Action<KeyboardEvent> SendEnd
        {
            get
            {
                return direction => Send(VK_END, direction);
            }
        }

        [Export]
        [ExportMetadata("Name", "F3")]
        public static Action<KeyboardEvent> SendF3
        {
            get
            {
                return direction => Send(VK_F3, direction);
            }
        }

        [Export]
        [ExportMetadata("Name", "Ctrl")]
        public static Action<KeyboardEvent> SendCtrl
        {
            get
            {
                return direction => Send(VK_CONTROL, direction);
            }
        }

        [Export]
        [ExportMetadata("Name", "Alt")]
        public static Action<KeyboardEvent> SendAlt
        {
            get
            {
                return direction => Send(VK_ALT, direction);
            }
        }

        [Export]
        [ExportMetadata("Name", "Win")]
        public static Action<KeyboardEvent> SendWin
        {
            get
            {
                return direction => Send(VK_WIN, direction);
            }
        }
    }
}
