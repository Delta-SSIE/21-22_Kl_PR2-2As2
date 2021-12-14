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

namespace _03_WPF_04_O_deset_vic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //InputTB.RaiseEvent(new TextChangedEventArgs( );
            InputTB_TextChanged(null, null);
            {
                //AddBtn.RaiseEvent(new RoutedEventArgs(System.Windows.Controls.Primitives.ButtonBase.ClickEvent));
            }
        }



        private void InputTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (OutputTB == null)
                return;

            if (double.TryParse(InputTB.Text, out double number))
            {
                number += 10;
                OutputTB.Text = number.ToString();

                InputTB.BorderBrush = Brushes.Black;
            }
            else
            {
                OutputTB.Text = "N/A";
                InputTB.BorderBrush = Brushes.Red;
            }
        }
    }
}
