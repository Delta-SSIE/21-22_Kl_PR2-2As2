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

namespace _03_WPF_11_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //proměnné: 

        //aktuální číslo
        private string currentText = "0";
        //minulé číslo
        private double lastValue = 0;
        //zapamatovaná operace
        private SimpleMath.Operation operation;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumberBtn_Click(object sender, RoutedEventArgs e)
        {            
            Button clickedBtn = (Button)sender; //pracuj s proměnnou sender jako by to byl button
            
            //vezmi aktuální text v tlačítku
            string number = clickedBtn.Content.ToString();

            //přilep za současné číslo číslo z tlačítka
            if (currentText != "0")
                currentText += number;
            else
                currentText = number;

            //zobraz na displeji
            Render();
        }

        private void Render()
        {
            Display.Text = currentText;
        }
    }
}
