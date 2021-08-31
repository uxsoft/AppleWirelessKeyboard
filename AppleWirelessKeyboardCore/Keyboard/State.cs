namespace AppleWirelessKeyboardCore.Keyboard
{
    public class State<T> : NotifyPropertyChanged
    {
        public State()
        {
            _value = default!;
        }

        public State(T initialValue)
        {
            _value = initialValue;
        }

        T _value;
        public T Value
        {
            get => _value;
            set => SetField(ref _value, value);
        }
    }
}