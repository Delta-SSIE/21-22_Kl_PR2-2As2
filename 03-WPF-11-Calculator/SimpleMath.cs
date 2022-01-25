using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_WPF_11_Calculator
{
    static class SimpleMath
    {
        public enum Operation { Addition, Subtraction, Multiplication, Division }
        public static double Addition(double num1, double num2)
        {
            return num1 + num2;
        }
        public static double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }
        public static double Division(double num1, double num2)
        {
            return num1 / num2;
        }
        public static double Percent(double num)
        {
            return num / 100;
        }

    }
}
