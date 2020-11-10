using AppleWirelessKeyboardCore.Keyboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppleWirelessKeyboardCore.ControlInterfaces
{
    public class KeyboardControlFilter : IInputFilter
    {
        private class KeyEventEntry
        {
            public KeyEventEntry()
            { }

            public KeyEventEntry(Key key, bool pressed)
            {
                Key = key;
                Pressed = pressed;
            }

            public Key Key { get; set; }
            public bool Pressed { get; set; }
        }

        private List<KeyEventEntry> Expected = new List<KeyEventEntry>();

        public void Expect(Key key, bool pressed)
        {
            Expected.Add(new KeyEventEntry(key, pressed));
            if (key == System.Windows.Input.Key.LeftAlt
                || key == System.Windows.Input.Key.RightAlt
                || key == System.Windows.Input.Key.RWin
                || key == System.Windows.Input.Key.LWin
                || key == System.Windows.Input.Key.RightCtrl
                || key == System.Windows.Input.Key.LeftCtrl
                || key == System.Windows.Input.Key.RightShift
                || key == System.Windows.Input.Key.LeftShift)
                Expected.Add(new KeyEventEntry(key, pressed));
        }

        public bool Key(Key key, bool pressed)
        {
            var entry = Expected.FirstOrDefault(e => e.Key == key && e.Pressed == pressed);
            if (entry != null)
            {
                Expected.Remove(entry);
                return false;
            }

            return true;
        }

        public bool Fn(bool pressed)
        {
            return true;
        }

        public bool Alt(bool pressed)
        {
            return Key(System.Windows.Input.Key.LeftAlt, pressed) && Key(System.Windows.Input.Key.RightAlt, pressed);
        }

        public bool Win(bool pressed)
        {
            return Key(System.Windows.Input.Key.LWin, pressed) && Key(System.Windows.Input.Key.RWin, pressed);
        }

        public bool Ctrl(bool pressed)
        {
            return Key(System.Windows.Input.Key.LeftCtrl, pressed) && Key(System.Windows.Input.Key.RightCtrl, pressed);
        }

        public bool Shift(bool pressed)
        {
            return Key(System.Windows.Input.Key.LeftShift, pressed) && Key(System.Windows.Input.Key.RightShift, pressed);
        }

        public bool Eject(bool pressed)
        {
            return true;
        }

        public bool Power(bool pressed)
        {
            return true;
        }

        public bool FMode(bool pressed)
        {
            return true;
        }
    }
}
