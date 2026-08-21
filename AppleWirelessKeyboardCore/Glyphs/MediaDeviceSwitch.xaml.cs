using System.Windows;
using System.Windows.Controls;

namespace AppleWirelessKeyboardCore.Glyphs
{
    /// <summary>
    /// Interaction logic for MediaDeviceSwitch.xaml
    /// </summary>
    public partial class MediaDeviceSwitch : UserControl
    {
        public static readonly DependencyProperty DeviceNameProperty =
            DependencyProperty.Register(nameof(DeviceName), typeof(string), typeof(MediaDeviceSwitch),
                new PropertyMetadata(string.Empty));

        public string DeviceName
        {
            get => (string)GetValue(DeviceNameProperty);
            set => SetValue(DeviceNameProperty, value);
        }

        public MediaDeviceSwitch()
        {
            InitializeComponent();
        }

        public MediaDeviceSwitch(string deviceName) : this()
        {
            DeviceName = deviceName;
        }
    }
}

