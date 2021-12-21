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

namespace _03_WPF_08_Scitacka_II
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

        /// <summary>
        /// Ověří zda hodnota ve vstupu lze parsovat na číslo a podle toho jí nastaví barvu
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns>True, když lze parsovat</returns>
        private bool ValidateInput(TextBox textBox)
        {
            double number;

            if (double.TryParse(textBox.Text, out number) && number < 10000 & number > -10000)
            {
                textBox.Background = Brushes.White;
                return true;
            }
            else
            {
                textBox.Background = Brushes.Red;
                return false;
            }
        }

        /// <summary>
        /// Při změně textu v jakémkoli vstupu ověřím, jestli lze parsovat na číslo. Pokud lze všechny, uvolním sčítací tlačítko, jinak ho zakážu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AnyTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            bool OK1 = (Number1TB == null) || ValidateInput(Number1TB); //je hodnota ve vstupu OK?
            bool OK2 = (Number2TB == null) || ValidateInput(Number2TB); //je hodnota ve vstupu OK?
            bool OK3 = (Number3TB == null) || ValidateInput(Number3TB); //je hodnota ve vstupu OK?4

            if (AddBtn != null) //na začátku ještě není AddBtn nastaven, proto testuju null
            {
                if (OK1 && OK2 && OK3)
                    AddBtn.IsEnabled = true;
                else
                    AddBtn.IsEnabled = false;
            }

        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            double result = double.Parse(Number1TB.Text) 
                            + double.Parse(Number2TB.Text) 
                            + double.Parse(Number3TB.Text);

            OutTB.Text = result.ToString();
        }
    }
}
