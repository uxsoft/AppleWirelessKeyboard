using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using AppleWirelessKeyboardCore.Services;

namespace AppleWirelessKeyboardCore.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void ShowOff(UserControl glyph, bool valueBar = false, int value = 0)
        {
            if (SettingsService.Default.EnableOverlay)
                App.Window.Dispatcher.Invoke(() =>
                {
                    DataContext = new { Glyph = glyph };

                    ValueBar.Visibility = valueBar ? Visibility.Visible : Visibility.Collapsed;

                    MakeValue(value);

                    Show();

                    DoubleAnimationUsingKeyFrames fade = new DoubleAnimationUsingKeyFrames();
                    fade.Duration = new Duration(TimeSpan.FromSeconds(1));
                    fade.KeyFrames.Add(new LinearDoubleKeyFrame(1, KeyTime.FromPercent(0)));
                    fade.KeyFrames.Add(new LinearDoubleKeyFrame(1, KeyTime.FromPercent(0.5)));
                    fade.KeyFrames.Add(new LinearDoubleKeyFrame(0, KeyTime.FromPercent(1)));
                    BeginAnimation(OpacityProperty, fade);
                });
        }

        public void ShowOff<TGlyph>(bool valueBar = false, int value = 0) where TGlyph : UserControl
        {
            ShowOff(Activator.CreateInstance<TGlyph>(), valueBar, value);
        }
        public void MakeValue(int value)
        {
            ValueBar.Children.Clear();

            for (int i = 0; i <= value; i++)
            {
                Rectangle rect = new Rectangle();
                rect.Fill = new SolidColorBrush(Colors.White);
                rect.Width = 6;
                rect.Height = 6;
                rect.Margin = new Thickness(0, 0, 3, 0);
                ValueBar.Children.Add(rect);
            }
        }
    }
}
