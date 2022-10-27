using System.Windows.Forms;

namespace Калькулятор
{
    public class Calc
    {
        public double first_number = 0; 
        public bool numb_sign = true; 

        public double Put_A(double first_number, Label lbl_numbchange)
        {
            if (lbl_numbchange.Text == "-")
                return this.first_number = (-1.0) * first_number;
            return this.first_number = first_number;
        }

        public void Clear_A() => first_number = 0;

        public double Multiplication(double second_number, Label lbl_numb_sign)
        {
            if (lbl_numb_sign.Text == "-")
                return (-1.0) * first_number * second_number;
            return first_number * second_number;
        }
        public double Division(double second_number, Label lbl_numb_sign)
        {
            if (lbl_numb_sign.Text == "-")
                return first_number / ((-1.0) * second_number);
            return first_number / second_number;
        }
        public double Sum(double second_number, Label lbl_numb_sign)
        {
            if (lbl_numb_sign.Text == "-")
                return first_number + ((-1.0) * second_number);
            return first_number + second_number;
        }
        public double Subtraction(double second_number, Label lbl_numb_sign)
        {
            if (lbl_numb_sign.Text == "-")
                return first_number - ((-1.0) * second_number);
            return first_number - second_number;
        }
    }
}
