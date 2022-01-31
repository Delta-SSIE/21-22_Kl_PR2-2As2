using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace _03_WPF_12_Timery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer = new DispatcherTimer();
        private DispatcherTimer clockTimer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();

            timer.Interval = TimeSpan.FromMilliseconds(1500);
            timer.Tick += Timer_Tick;

            clockTimer.Interval = TimeSpan.FromMilliseconds(200);
            clockTimer.Tick += ClockTimer_Tick;
            clockTimer.Start();
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            Clock.Text = $"{now.Hour:00}:{now.Minute:00}:{now.Second:00}";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // System.Threading.Thread.Sleep(1500); // takhle ne - zmrzne
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            MessageBox.Show("Varování");
        }
    }
}
