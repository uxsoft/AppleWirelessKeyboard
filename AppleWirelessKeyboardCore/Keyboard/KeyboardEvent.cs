using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
