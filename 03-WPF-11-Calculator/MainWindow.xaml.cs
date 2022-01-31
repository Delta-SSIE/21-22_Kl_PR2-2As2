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
        //private string currentText = "0";


        public string currentText
        {
            get { return (string)GetValue(currentTextProperty); }
            set { SetValue(currentTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for currentText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty currentTextProperty =
            DependencyProperty.Register("currentText", typeof(string), typeof(MainWindow), new PropertyMetadata("0"));



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
            //Display.Text = currentText;
        }

        private void DecimalBtn_Click(object sender, RoutedEventArgs e)
        {
            string decimalSeparator = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator;

            if (currentText.Contains(decimalSeparator))
            {
                return;
            }

            currentText += decimalSeparator;
            Render();
        }

        private void ACBtn_Click(object sender, RoutedEventArgs e)
        {
            currentText = "0";
            Render();
        }

        private void PlusMinusBtn_Click(object sender, RoutedEventArgs e)
        {
            if (currentText == "0")
                return;

            //currentText = Convert.ToString(double.Parse(currentText) * -1);

            if (currentText[0] == '-')
            {
                currentText = currentText.Substring(1);
            }
            else
            {
                currentText = "-" + currentText;
            }

            Render();
        }

        private void PercentBtn_Click(object sender, RoutedEventArgs e)
        {
            double currentValue = double.Parse(currentText);
            double percentValue = SimpleMath.Percent(currentValue);
            currentText = Convert.ToString(percentValue);
            Render();
        }

        private void OperationBtn_Click(object sender, RoutedEventArgs e)
        {

            if (sender == AdditionBtn)
                operation = SimpleMath.Operation.Addition;
            else if (sender == SubtractionBtn)
                operation = SimpleMath.Operation.Subtraction;
            else if (sender == MultiplicationBtn)
                operation = SimpleMath.Operation.Multiplication;
            else if (sender == DivisionBtn)
                operation = SimpleMath.Operation.Division;

            lastValue = double.Parse(currentText);

            currentText = "0";
            Render();
        }

        private void EqualsBtn_Click(object sender, RoutedEventArgs e)
        {
            double currentValue = double.Parse(currentText);

            double result;

            switch (operation)
            {
                case SimpleMath.Operation.Addition:
                    result = SimpleMath.Addition(lastValue, currentValue);
                    break;
                case SimpleMath.Operation.Subtraction:
                    result = SimpleMath.Subtraction(lastValue, currentValue);
                    break;
                case SimpleMath.Operation.Multiplication:
                    result = SimpleMath.Multiplication(lastValue, currentValue);
                    break;
                case SimpleMath.Operation.Division:
                    result = SimpleMath.Division(lastValue, currentValue);
                    break;
                default:
                    result = 0; //impossible case
                    break;
            }

            currentText = Convert.ToString(result);
            Render();
        }
    }
}
