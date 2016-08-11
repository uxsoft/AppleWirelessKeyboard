using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Input;
using System.Diagnostics;
using System.Windows;
using System.ComponentModel.Composition;

namespace AppleWirelessKeyboard.Keyboard
{
    /// <summary>
    /// A class that manages a global low level keyboard hook
    /// </summary>
    [Export(typeof(IInputAdapter))]
    public class WHKeyboardLLModule : IInputAdapter
    {
        public WHKeyboardLLModule()
        {
            Hook = IntPtr.Zero;
        }

        #region PInvoke Structures
        public delegate int keyboardHookProc(int code, int wParam, ref keyboardHookStruct lParam);

        public struct keyboardHookStruct
        {
            public int vkCode;
            public int scanCode;
            public int flags;
            public int time;
            public int dwExtraInfo;
        }

        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x100;
        private const int WM_KEYUP = 0x101;
        private const int WM_SYSKEYDOWN = 0x104;
        private const int WM_SYSKEYUP = 0x105;
        internal IntPtr Hook { get; set; }
        #endregion
        #region DLL imports
        [DllImport("user32.dll")]
        static extern IntPtr SetWindowsHookEx(int idHook, keyboardHookProc callback, IntPtr hInstance, uint threadId);

        [DllImport("user32.dll")]
        static extern bool UnhookWindowsHookEx(IntPtr hInstance);

        [DllImport("user32.dll")]
        static extern int CallNextHookEx(IntPtr idHook, int nCode, int wParam, ref keyboardHookStruct lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        #endregion

        public keyboardHookProc HookProcessor { get; set; }

        public void Start()
        {
            HookProcessor = Hook_Callback;
            IntPtr hInstance = GetModuleHandle(Process.GetCurrentProcess().MainModule.ModuleName);
            Hook = SetWindowsHookEx(WH_KEYBOARD_LL, HookProcessor, hInstance, 0);
        }

        public void Stop()
        {
            UnhookWindowsHookEx(Hook);
        }

        public int Hook_Callback(int code, int wParam, ref keyboardHookStruct lParam)
        {
            if (code >= 0)
            {
                Key key = (Key)System.Windows.Input.KeyInterop.KeyFromVirtualKey(lParam.vkCode);
                bool IsPressed = (wParam == WM_KEYDOWN || wParam == WM_SYSKEYDOWN);

                if (key == System.Windows.Input.Key.LeftAlt || key == System.Windows.Input.Key.RightAlt)
                {
                    if (Alt != null)
                        Alt(IsPressed);
                }
                else if (key == System.Windows.Input.Key.LeftCtrl || key == System.Windows.Input.Key.RightCtrl)
                {
                    if (Ctrl != null)
                        Ctrl(IsPressed);
                }
                else if (key == System.Windows.Input.Key.LeftShift || key == System.Windows.Input.Key.RightShift)
                {
                    if (Shift != null)
                        Shift(IsPressed);
                }
                else if (key == System.Windows.Input.Key.LWin || key == System.Windows.Input.Key.RWin)
                {
                    if (Win != null)
                        Win(IsPressed);
                }

                if (Key != null)
                    if (Key(key, IsPressed))
                        return 1;
            }
            return CallNextHookEx(Hook, code, wParam, ref lParam);
        }

        public event KeyEventHandler Key;

        public event PressedEventHandler Fn;

        public event PressedEventHandler Alt;

        public event PressedEventHandler Win;

        public event PressedEventHandler Ctrl;

        public event PressedEventHandler Shift;


        public event PressedEventHandler Eject;

        public event PressedEventHandler Power;


        public event PressedEventHandler FMode;
    }
}
