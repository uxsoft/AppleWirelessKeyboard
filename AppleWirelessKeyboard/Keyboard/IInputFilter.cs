using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppleWirelessKeyboard.Keyboard
{
    public interface IInputFilter
    {
        bool Key(Key key, bool pressed);
        bool Fn(bool pressed);
        bool Alt(bool pressed);
        bool Win(bool pressed);
        bool Ctrl(bool pressed);
        bool Shift(bool pressed);
        bool Eject(bool pressed);
        bool Power(bool pressed);
        bool FMode(bool pressed);
    }
}
