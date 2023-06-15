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
    public partial class frmPayroll : Form
    {
        public frmPayroll()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxHoursWorked.Text = "";
            tbxRateOfPay.Text = "";
            lbxOutput.Text = "";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {   //constants
            const double baseHours = 40;
            const double overTimeRate = 1.5;

            // variables 
            double hoursWorked;
            double hourlyPayRate;
            double basePay;
            double overtimeHours;
            double overtimePay = 0;
            double grossPay;

            // Get the hours worked and hourly pay rate. 
            hoursWorked = double.Parse(tbxHoursWorked.Text);
            hourlyPayRate = double.Parse(tbxRateOfPay.Text);
            // Determine the gross pay. 
            double grossPayMethod()
            {
                if (hoursWorked > baseHours)
                {
                    basePay = hourlyPayRate * baseHours;
                    overtimeHours = hoursWorked - baseHours;
                    overtimePay = overtimeHours * hourlyPayRate * overTimeRate;
                    grossPay = basePay + overtimePay;
                    return grossPay;
                }
                else
                {
                    grossPay = hoursWorked * hourlyPayRate;
                    return grossPay;
                }
            }

            const double FICA = .065;
            double tax = 0;

            double deductions() //deductions method
            {
                double FICAtax = FICA * grossPay;
                if (grossPay <= 200)
                {
                    tax = 0;
                    tax = FICAtax + tax;
                }
                else if (200 < grossPay && grossPay <= 500)
                {
                    tax = grossPay * .05;
                    tax = FICAtax + tax;
                }
                else if (grossPay > 500)
                {
                    tax = grossPay * .075;
                    tax = FICAtax + tax;
                }
                return tax;
            }
            void NetPay()
            {
                grossPayMethod();
                deductions();
                double netPay = grossPay - tax;

                //displays listbox items
                lbxOutput.Items.Add("Hours Worked: " + hoursWorked);
                lbxOutput.Items.Add("Hourly Pay Rate:" + hourlyPayRate);
                lbxOutput.Items.Add("Overtime Pay:" + overtimePay);
                lbxOutput.Items.Add("Gross Pay:" + grossPay);
                lbxOutput.Items.Add("Tax Deduction:" + tax);
                lbxOutput.Items.Add("Net Pay:" + netPay);
            }
            NetPay();
        }
    }
}

