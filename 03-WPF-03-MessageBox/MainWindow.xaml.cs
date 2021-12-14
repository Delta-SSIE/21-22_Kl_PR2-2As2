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

namespace _03_WPF_03_MessageBox
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

        private void ShowPopupBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Pozor, smažu vše na disku C:\\!", "Varování", MessageBoxButton.YesNoCancel, MessageBoxImage.Warning);

            switch (result)
            {
                case MessageBoxResult.Cancel:
                    OutputTB.Text = "Nic";
                    break;

                case MessageBoxResult.Yes:
                    OutputTB.Text = "Mažu";
                    break;

                case MessageBoxResult.No:
                    OutputTB.Text = "Nemažu";
                    break;
            }
        }
    }
}
