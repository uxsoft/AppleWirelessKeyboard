using System;
using System.Collections.Generic;
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
        // the amount of animatable key presses that haven't run through the handler
        private HashSet<AnimationTimeline> unhandledKeyPresses;

        public MainWindow()
        {
            this.unhandledKeyPresses = new HashSet<AnimationTimeline>();
            InitializeComponent();
        }
        public void ShowOff<TGlyph>(bool valueBar = false, int value = 0) where TGlyph : UserControl
        {
            if (SettingsService.Default.EnableOverlay)
                App.Window.Dispatcher.Invoke(() =>
                {
                    DataContext = new { Glyph = Activator.CreateInstance<TGlyph>() };

                    ValueBar.Visibility = valueBar ? Visibility.Visible : Visibility.Collapsed;

                    MakeValue(value);

                    Show();

                    DoubleAnimationUsingKeyFrames fade = new DoubleAnimationUsingKeyFrames();
                    fade.Duration = new Duration(TimeSpan.FromSeconds(1));
                    fade.KeyFrames.Add(new LinearDoubleKeyFrame(1, KeyTime.FromPercent(0)));
                    fade.KeyFrames.Add(new LinearDoubleKeyFrame(1, KeyTime.FromPercent(0.5)));
                    fade.KeyFrames.Add(new LinearDoubleKeyFrame(0, KeyTime.FromPercent(1)));
                    fade.Completed += (s, _) => this.AnimationCompletedHandler(fade);

                    unhandledKeyPresses.Add(fade);
                    BeginAnimation(OpacityProperty, fade);
                });
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
        public void AnimationCompletedHandler(AnimationTimeline animation)
        {
            this.unhandledKeyPresses.Remove(animation);

            if (this.unhandledKeyPresses.Count == 0)
            {
                Hide();
            }
        }
    }
}
