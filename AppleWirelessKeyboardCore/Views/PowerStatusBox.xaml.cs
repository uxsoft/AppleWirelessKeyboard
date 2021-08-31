using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Timers;
using System.Windows.Threading;

namespace AppleWirelessKeyboardCore
{
    /// <summary>
    /// Interaction logic for PowerStatusBox.xaml
    /// </summary>
    public partial class PowerStatusBox : Window
    {
        public PowerStatusBox(string action, int seconds)
        {
            InitializeComponent();
            Action = action;
            Seconds = seconds;
            T.Elapsed += new ElapsedEventHandler(T_Elapsed);
        }

        public string Action { get; set; } 
        public int Seconds { get; set; }
        public Timer T { get; set; } = new Timer(1000);

        void T_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (Seconds > 0)
            {
                Seconds--;
                Status();
            }
            else
            {
                T.Stop();
                Dispatcher.Invoke(delegate
                {
                    DialogResult = true;
                    Close();
                });
            }
        }

        void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            T.Stop();
            DialogResult = false;
        }

        void btnOK_Click(object sender, RoutedEventArgs e)
        {
            T.Stop();
            DialogResult = true;
        }

        public void Status()
        {
            Dispatcher.Invoke(delegate
            {
                txtStatus.Text = string.Format("The system is about to {0} in {1} seconds.", Action, Seconds);
            });
        }

        public static bool PowerAction(string action, int seconds)
        {
            bool ret = false;

            Application.Current.Dispatcher.Invoke(delegate
            {
                PowerStatusBox frm = new PowerStatusBox(action, seconds);
                frm.Status();
                ret = frm.ShowDialog() ?? false;
            });

            return ret;
        }

        void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!DialogResult.HasValue)
            {
                T.Stop();
                DialogResult = false;
            }
        }

        void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Status();
            T.Start();
        }
    }
}
