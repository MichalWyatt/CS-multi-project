using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MichalDowningMyFinalProjectCS
{
    public partial class frmCalculator : Form
    {

        public frmCalculator()
        {
            InitializeComponent();
        }


        private void btnCalculate_Click(object sender, EventArgs e)
        {

            string operand = tbxOperand.Text;
            string firstNumber = tbxNum1.Text;
            string secondNumber = tbxNum2.Text;


            string[]math = new string[] {"+", "-", "*",};
            double num1 = 0;
            double num2 = 0;
            bool validated = true;

            if (!Double.TryParse(tbxNum1.Text, out num1)) //if statement checking for valid input
            {
                validated = false;
                MessageBox.Show("Please enter an integer in First Number!"); //checks for integer
            }

            if (validated && !Double.TryParse(tbxNum2.Text, out num2))
            {
                validated = false;
                MessageBox.Show("Please enter a number in Second Number!");  //checks for integer
            }

            if (validated && Array.IndexOf(math, tbxOperand.Text) < 0)
            {
                MessageBox.Show("Please enter valid operators! (+,-,*)"); //checks for valid operator input
            }
            else if (validated)   //calculations
            {
                double result = 0;
                switch (operand)
                {
                    case "+":
                        result = num1 + num2; 
                        break;
                    case "-": 
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                   
                    default: 
                        result = 0;
                        break;
                } //end switch

                lblResult.Text = Math.Round(result, 4).ToString();  //results
            };
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear form
            lblResult.Text = "";
            tbxNum1.Clear();
            tbxNum2.Clear();
            tbxOperand.Clear();
            tbxNum1.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); //closes form
        }
    }
}
