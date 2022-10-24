using System;
using System.Windows.Forms;
using System.Text;
using System.Data;

namespace Калькулятор
{
    public class Calc
    {
        private double a = 0; // первое вводимое число (по умолчанию, равно 0)
        public bool numb_sign = true; //переменная для проверки знака числа (при верном значени - положительное число, при другом - отрицательное)

        public double Put_A(double a, Label lbl)
        {
            if (lbl.Text == "-")
                return this.a = (-1.0) * a;
            return this.a = a;
        }

        public void Clear_A() => a = 0;

        public double Multiplication(double b, Label lbl)
        {
            if (lbl.Text == "-")
                return (-1.0) * a * b;
            return a * b;
        }
        public double Division(double b, Label lbl)
        {
            if (lbl.Text == "-")
                return a / ((-1.0) * b);
            return a / b;
        }
        public double Sum(double b, Label lbl)
        {
            if (lbl.Text == "-")
                return a + ((-1.0) * b);
            return a + b;
        }
        public double Subtraction(double b, Label lbl)
        {
            if (lbl.Text == "-")
                return a - ((-1.0) * b);
            return a - b;
        }
    }
}
