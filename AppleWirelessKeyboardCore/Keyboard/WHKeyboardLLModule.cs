using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Input;
using System.Diagnostics;
using System.Windows;
using System.ComponentModel.Composition;

namespace AppleWirelessKeyboardCore.Keyboard
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

        public keyboardHookProc? HookProcessor { get; set; }

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

        const int WH_KEYBOARD_LL = 13;
        const int WM_KEYDOWN = 0x100;
        const int WM_KEYUP = 0x101;
        const int WM_SYSKEYDOWN = 0x104;
        const int WM_SYSKEYUP = 0x105;
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


        public void Start()
        {
            HookProcessor = Hook_Callback;
            var hInstance = GetModuleHandle(Process.GetCurrentProcess().MainModule.ModuleName);
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
                var key = KeyInterop.KeyFromVirtualKey(lParam.vkCode);
                var isPressed = wParam == WM_KEYDOWN || wParam == WM_SYSKEYDOWN;

                switch (key)
                {
                    case System.Windows.Input.Key.LeftAlt:
                    case System.Windows.Input.Key.RightAlt:
                    {
                        Alt?.Invoke(isPressed);
                        break;
                    }
                    case System.Windows.Input.Key.LeftCtrl:
                    case System.Windows.Input.Key.RightCtrl:
                    {
                        Ctrl?.Invoke(isPressed);
                        break;
                    }
                    case System.Windows.Input.Key.LeftShift:
                    case System.Windows.Input.Key.RightShift:
                    {
                        Shift?.Invoke(isPressed);
                        break;
                    }
                    case System.Windows.Input.Key.LWin:
                    case System.Windows.Input.Key.RWin:
                    {
                        Win?.Invoke(isPressed);
                        break;
                    }
                }
                
                if (Key?.Invoke(key, isPressed) ?? false)
                    return 1;
            }
            return CallNextHookEx(Hook, code, wParam, ref lParam);
        }

        public event KeyEventHandler? Key;
        public event PressedEventHandler? Fn;
        public event PressedEventHandler? Alt;
        public event PressedEventHandler? Win;
        public event PressedEventHandler? Ctrl;
        public event PressedEventHandler? Shift;
        public event PressedEventHandler? Eject;
        public event PressedEventHandler? Power;
        public event PressedEventHandler? FMode;
    }
}
