using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using AppleWirelessKeyboardCore.Services;

namespace AppleWirelessKeyboardCore.Keyboard
{
    public class KeyboardHandler
    {
        public KeyboardHandler()
        {
            this.Inject();
        }

        [ImportMany]
        public IEnumerable<IInputAdapter> Adapters { get; set; } = default!;

        [ImportMany]
        public IEnumerable<Lazy<Action<KeyboardEvent>, IFunctionalityModuleExportMetadata>> Modules { get; set; } =
            default!;

        [ImportMany]
        public IEnumerable<IInputFilter> Filters { get; set; } = default!;

        public State<bool> Fn { get; set; } = new State<bool>(false);
        public State<bool> Alt { get; set; } = new State<bool>(false);
        public State<bool> Ctrl { get; set; } = new State<bool>(false);
        public State<bool> Win { get; set; } = new State<bool>(false);
        public State<bool> Shift { get; set; } = new State<bool>(false);
        public State<bool> Eject { get; set; } = new State<bool>(false);
        public State<bool> FMode { get; set; } = new State<bool>(SettingsService.Default.StartupFMode);
        public State<bool> Power { get; set; } = new State<bool>(false);

        public void Start()
        {
            foreach (IInputAdapter adapter in Adapters)
            {
                adapter.Start();
                adapter.Fn += (pressed) =>
                {
                    if (Filters.All(f => f.Fn(pressed))) Fn.Value = pressed;
                };
                adapter.Alt += (pressed) =>
                {
                    if (Filters.All(f => f.Alt(pressed))) Alt.Value = pressed;
                };
                adapter.Ctrl += (pressed) =>
                {
                    if (Filters.All(f => f.Ctrl(pressed))) Ctrl.Value = pressed;
                };
                adapter.Win += (pressed) =>
                {
                    if (Filters.All(f => f.Win(pressed))) Win.Value = pressed;
                };
                adapter.Shift += (pressed) =>
                {
                    if (Filters.All(f => f.Shift(pressed))) Shift.Value = pressed;
                };
                adapter.Power += (pressed) =>
                {
                    if (Filters.All(f => f.Power(pressed))) Power.Value = pressed;
                };
                adapter.Eject += (pressed) => ProcessKey(Key.F13, pressed);
                adapter.Key += ProcessKey;
            }
        }

        public void Stop()
        {
            foreach (IInputAdapter adapter in Adapters)
                adapter.Stop();
        }

        bool ProcessKey(Key key, bool pressed)
        {
            if (!Filters.All(f => f.Key(key, pressed)))
                return false;

            var handlers = SettingsService.Default.KeyBindings
                .Where(b => b.Key == key
                            && (!b.Alt || Alt.Value)
                            && (!b.Ctrl || Ctrl.Value)
                            && (!b.Win || Win.Value)
                            && (!b.Fn || Fn.Value)
                            && (!b.Shift || Shift.Value)
                            && (!b.FMode || FMode.Value))
                .Count(binding =>
                {
                    var module = Modules.SingleOrDefault(l => l.Metadata.Name == binding.Module)?.Value;
                    if (module == null) return false;
                    
                    Task.Factory.StartNew(() => module(pressed ? KeyboardEvent.Down : KeyboardEvent.Up));
                    return true;
                });
            return handlers > 0;
        }
    }
}