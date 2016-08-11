using AppleWirelessKeyboard.Keyboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppleWirelessKeyboard.Keyboard
{
    public interface IInputAdapter
    {
        void Start();
        void Stop();
        event KeyEventHandler Key;
        event PressedEventHandler Fn;
        event PressedEventHandler Alt;
        event PressedEventHandler Win;
        event PressedEventHandler Ctrl;
        event PressedEventHandler Shift;
        event PressedEventHandler Eject;
        event PressedEventHandler Power;
        event PressedEventHandler FMode;
    }

    public delegate void PressedEventHandler(bool pressed);
    public delegate bool KeyEventHandler(Key key, bool pressed);
}
