using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AppleWirelessKeyboardCore.Keyboard
{
    public class KeyBinding
    {
        public Key Key { get; set; }
        public string Module { get; set; }
        public bool Ctrl { get; set; }
        public bool Alt { get; set; }
        public bool Fn { get; set; }
        public bool Win { get; set; }
        public bool Shift { get; set; }
        public bool FMode { get; set; }
    }
}
