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

namespace AppleWirelessKeyboard
{
    /// <summary>
    /// Interaction logic for PowerStatusBox.xaml
    /// </summary>
    public partial class PowerStatusBox : Window
    {
        public PowerStatusBox()
        {
            InitializeComponent();
            T = new Timer(1000);
            T.Elapsed += new ElapsedEventHandler(T_Elapsed);
        }

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
                Dispatcher.Invoke((Action)delegate
                {
                    DialogResult = true;
                    Close();
                });
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            T.Stop();
            DialogResult = false;
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            T.Stop();
            DialogResult = true;
        }

        public void Status()
        {
            Dispatcher.Invoke((Action)delegate
            {
                txtStatus.Text = string.Format("The system is about to {0} in {1} seconds.", Action, Seconds);
            });
        }

        public string Action { get; set; }
        public int Seconds { get; set; }
        public Timer T { get; set; }

        public static bool PowerAction(string action, int seconds)
        {
            bool ret = false;

            App.Current.Dispatcher.Invoke((Action)delegate
            {
                PowerStatusBox frm = new PowerStatusBox();

                frm.Action = action;
                frm.Seconds = seconds;
                frm.Status();
                ret = (bool)frm.ShowDialog();
            });

            return ret;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!DialogResult.HasValue)
            {
                T.Stop();
                DialogResult = false;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Status();
            T.Start();
        }
    }
}
