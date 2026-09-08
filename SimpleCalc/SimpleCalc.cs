using System;
using System.Windows.Forms;

namespace SimpleCalc
{
    public partial class SimpleCalc : Form
    {
        public SimpleCalc()
        {
            InitializeComponent();

            this.AcceptButton = btnCalculate;
            this.CancelButton = btnExit;

            txtOperand1.TextChanged += TextBox_TextChanged;
            txtOperator.TextChanged += TextBox_TextChanged;
            txtOperand2.TextChanged += TextBox_TextChanged;
        }

        private decimal Calculate(decimal operand1, string operator1, decimal operand2)
        {
            switch (operator1)
            {
                case "+":
                    return operand1 + operand2;
                case "-":
                    return operand1 - operand2;
                case "*":
                    return operand1 * operand2;
                case "/":
                    return operand1 / operand2;
                default:
                    return 0;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            
                decimal operand1 = Convert.ToDecimal(txtOperand1.Text);
                string operator1 = txtOperator.Text;
                decimal operand2 = Convert.ToDecimal(txtOperand2.Text);

                decimal result = Calculate(operand1, operator1, operand2);

                txtResult.Text = result.ToString("F4");

                txtOperand1.Focus();
            
            
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            txtResult.Clear();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
