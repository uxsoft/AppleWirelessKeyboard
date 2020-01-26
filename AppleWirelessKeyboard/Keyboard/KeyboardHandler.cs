using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppleWirelessKeyboard.Keyboard;
using System.Windows.Input;
using System.Diagnostics;

namespace AppleWirelessKeyboard.Keyboard
{
    public class KeyboardHandler
    {
        public KeyboardHandler()
        {
            this.Inject();
        }

        public KeyboardHandler(Profile profile)
            : this()
        {
            Profile = profile;
        }

        [ImportMany]
        public IEnumerable<IInputAdapter> Adapters { get; set; }

        [Import]
        public Profile Profile { get; set; }

        [ImportMany]
        public IEnumerable<Lazy<Action<KeyboardEvent>, IFunctionalityModuleExportMetadata>> Modules { get; set; }

        [ImportMany]
        public IEnumerable<IInputFilter> Filters { get; set; }

        public bool Fn { get; set; }
        public bool Alt { get; set; }
        public bool Ctrl { get; set; }
        public bool Win { get; set; }
        public bool Shift { get; set; }
        public bool Eject { get; set; }
        public bool FMode { get; set; }
        public bool Power { get; set; }

        public void Start()
        {
            if (Properties.Settings.Default.FnOnAtStart)
            {
                App.Keyboard.FMode = true;
            }

            foreach (IInputAdapter adapter in Adapters)
            {
                adapter.Start();
                adapter.Fn += (pressed) => { if (Filters.All(f => f.Fn(pressed))) Fn = pressed; };
                adapter.Alt += (pressed) => { if (Filters.All(f => f.Alt(pressed))) Alt = pressed; };
                adapter.Ctrl += (pressed) => { if (Filters.All(f => f.Ctrl(pressed))) Ctrl = pressed; };
                adapter.Win += (pressed) => { if (Filters.All(f => f.Win(pressed))) Win = pressed; };
                adapter.Shift += (pressed) => { if (Filters.All(f => f.Shift(pressed))) Shift = pressed; };
                adapter.Eject += (pressed) => { if (Filters.All(f => f.Eject(pressed))) Eject = pressed; };
                adapter.Power += (pressed) => { if (Filters.All(f => f.Power(pressed))) Power = pressed; };
                adapter.Key += ProcessKey;
            }
        }

        public void Stop()
        {
            foreach (IInputAdapter adapter in Adapters)
            {
                adapter.Stop();
            }
        }

        bool ProcessKey(Key key, bool pressed)
        {
            if (!Filters.All(f => f.Key(key, pressed)))
                return false;

            bool handled = false;
            foreach (KeyBinding binding in Profile
                .Where(b => b.Key == key 
                    && (!b.Alt || Alt) 
                    && (!b.Ctrl || Ctrl) 
                    && (!b.Win || Win) 
                    && (!b.Fn || Fn) 
                    && (!b.Shift || Shift) 
                    && (!b.FMode || FMode)))
            {
                Action<KeyboardEvent> module = Modules.SingleOrDefault(l => l.Metadata.Name == binding.Module).Value;
                if (module != null)
                {
                    Task freezing = Task.Factory.StartNew(() => module(pressed ? KeyboardEvent.Down : KeyboardEvent.Up));
                    handled = true;
                }
            }
            return handled;
        }
    }
}
