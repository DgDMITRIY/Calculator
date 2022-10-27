using System;
using System.Drawing;
using System.Windows.Forms;

namespace Калькулятор
{
    public partial class MyCalculator : Form
    { 

        private readonly Calc _calculatorServices = new Calc();

        public MyCalculator()
        {
            InitializeComponent();
            textBoxCalc.Text = "0";
            FocusTextBoxCalc();
            textBoxCalc.MaxLength = 9;
        }

        private void BtnClose_MouseEnter(object sender, EventArgs e2) => btnClose.BackColor = Color.Red;

        private void BtnCLose_MouseLeave(object sender, EventArgs e) => btnClose.BackColor = Color.WhiteSmoke;

        private void BtnClose_Click(object sender, EventArgs e) => Close();

        private void BtnMinimaze_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;
        
        private bool CanPress()
        {
            if (!BtnMult.Enabled || !BtnDiv.Enabled || !BtnPlus.Enabled || !BtnMinus.Enabled)
                return false;
            return true;
        }

        private void FreeButtons()
        {
            BtnMult.Enabled = true;
            BtnDiv.Enabled = true;
            BtnPlus.Enabled = true;
            BtnMinus.Enabled = true;
        }

        private void FocusTextBoxCalc()
        {
            textBoxCalc.Focus();
            textBoxCalc.SelectionStart = textBoxCalc.Text.Length;
        }

        private void DeleteZero()
        {
            if (textBoxCalc.Text == "0")
                textBoxCalc.Clear();
        }

        private void EraseNumbSign()
        {
            if (lblChange.Text == "-")
            {
                lblChange.Text = "";
                _calculatorServices.numb_sign = true;
            }
        }

        private void textBoxCalc_KeyPress(object sender, KeyPressEventArgs e)
        {
            DeleteZero();
            FocusTextBoxCalc();

            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
            if (e.KeyChar == (char)Keys.Add)
            {
                e.Handled = true;
            }

            FocusTextBoxCalc();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            textBoxCalc.Text = "0";

            EraseNumbSign();
            FocusTextBoxCalc();
            _calculatorServices.Clear_A();
            FreeButtons();
        }

        private void BtnChangeSign_Click(object sender, EventArgs e)
        {
            if (_calculatorServices.numb_sign && textBoxCalc.Text != " EXCEEDED")
            {
                DeleteZero();
                lblChange.Text = "-";
                _calculatorServices.numb_sign = false;
            }
            else if (!_calculatorServices.numb_sign)
            {
                lblChange.Text = "";
                _calculatorServices.numb_sign = true;
            }
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            if (!BtnMult.Enabled)
                textBoxCalc.Text = _calculatorServices.Multiplication(Convert.ToDouble(textBoxCalc.Text),lblChange).ToString();

            if (!BtnDiv.Enabled)
                textBoxCalc.Text = _calculatorServices.Division(Convert.ToDouble(textBoxCalc.Text),lblChange).ToString(); 

            if (!BtnPlus.Enabled)
                textBoxCalc.Text = _calculatorServices.Sum(Convert.ToDouble(textBoxCalc.Text),lblChange).ToString();

            if (!BtnMinus.Enabled)
                textBoxCalc.Text = _calculatorServices.Subtraction(Convert.ToDouble(textBoxCalc.Text),lblChange).ToString();

            if (textBoxCalc.Text.Length > 8 && textBoxCalc.Text != "  NOT ÷ 0")
                textBoxCalc.Text = " EXCEEDED";

            EraseNumbSign();

            if (textBoxCalc.Text[0] == '-')
            { 
                textBoxCalc.Text = textBoxCalc.Text.Remove(0, 1); 
                lblChange.Text = "-";
            }
            if (textBoxCalc.Text[0] == '∞')
            {
                EraseNumbSign();
                textBoxCalc.Text = textBoxCalc.Text.Remove(0, 1);
                textBoxCalc.Text = "  NOT ÷ 0";
            }

            _calculatorServices.Clear_A();
            FocusTextBoxCalc();
            FreeButtons();
        }

        private void Btn_Common_Number_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (textBoxCalc.Text.Length > 8) 
                return;
            DeleteZero();
            string variable = (string)btn.Text;
            textBoxCalc.Text += variable;
            FocusTextBoxCalc();
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            if (CanPress() && textBoxCalc.Text != " EXCEEDED" && textBoxCalc.Text != "  NOT ÷ 0")
            {
                _calculatorServices.Put_A(Convert.ToDouble(textBoxCalc.Text),lblChange);

                BtnPlus.Enabled = false;

                textBoxCalc.Text = "";

                FocusTextBoxCalc();

                EraseNumbSign();
            }
        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            if (CanPress() && textBoxCalc.Text != " EXCEEDED" && textBoxCalc.Text != "  NOT ÷ 0")
            {
                _calculatorServices.Put_A(Convert.ToDouble(textBoxCalc.Text), lblChange);

                BtnMult.Enabled = false;

                textBoxCalc.Text = "";

                FocusTextBoxCalc();

                EraseNumbSign();
            }
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            if (CanPress() && textBoxCalc.Text != " EXCEEDED" && textBoxCalc.Text != "  NOT ÷ 0")
            {
                _calculatorServices.Put_A(Convert.ToDouble(textBoxCalc.Text),lblChange);

                BtnDiv.Enabled = false;

                textBoxCalc.Text = "";

                FocusTextBoxCalc();

                EraseNumbSign();
            }
        }

        private void BtnMinus_Click(object sender, EventArgs e)
        {
            if (CanPress() && textBoxCalc.Text != " EXCEEDED" && textBoxCalc.Text != "  NOT ÷ 0")
            {
                _calculatorServices.Put_A(Convert.ToDouble(textBoxCalc.Text), lblChange);

                BtnMinus.Enabled = false;

                textBoxCalc.Text = "";

                FocusTextBoxCalc();

                EraseNumbSign();
            }
        }
    }
}
