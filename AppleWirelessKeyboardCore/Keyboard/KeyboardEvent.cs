using System;

namespace AppleWirelessKeyboardCore.Keyboard
{
    [Flags]
    public enum KeyboardEvent : int
    {
        Up = 1,
        Down = 2,
        Both = 3
    }
}
