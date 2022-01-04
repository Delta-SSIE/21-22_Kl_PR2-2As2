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

using Microsoft.Win32;

namespace _03_WPF_09_Fotoprohlizec
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

        private void LoadBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Please select image";
            ofd.Filter =  "All supported formats|*.jpg;*.jpeg;*.png|"
                        + "JPEG image (*.jpg;*.jpeg)|*.jpg;*.jpeg|"
                        + "Portable network graphics (*.png)|*.png";
            if (ofd.ShowDialog() == true)
            {
                FilenameLbl.Content = ofd.FileName;
                try
                {
                    PhotoImg.Source = new BitmapImage(new Uri(ofd.FileName));
                }
                catch
                {
                    MessageBox.Show("Invalid file", 
                        "File format not valid", 
                        MessageBoxButton.OK, 
                        MessageBoxImage.Error
                    );
                }

            }
        }
    }
}
