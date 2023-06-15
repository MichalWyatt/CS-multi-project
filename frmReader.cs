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
    public partial class frmReader : Form
    {
        double[] gradesArray = new double[6];

        public frmReader()
        {
            InitializeComponent();
        }
        //calculates and displays the total of the grades in the array,
        //the average of the grades in the array, and the letter grade of the grades in the array.  
        private void btnGrades_Click(object sender, EventArgs e)
        {
            lblLetterGrade.Text = "";
            double total = gradesArray.Sum();
            double length = gradesArray.Length;
            double average = total / length;
            average = Math.Round(average, 2);
            
            for (int i = 0; i < gradesArray.Length; i++) {
                
                if (gradesArray[i] >= 90) {
                    lblLetterGrade.Text += "A ";
                } else if (gradesArray[i] >= 80 && gradesArray[i] < 90) {
                    lblLetterGrade.Text += "B ";
                } else if (gradesArray[i] >= 70 && gradesArray[i] < 80) {
                    lblLetterGrade.Text += "C ";
                } else if (gradesArray[i] >= 60 && gradesArray[i] < 70) {
                    lblLetterGrade.Text += "D ";
                } else if (gradesArray[i] < 60) {
                    lblLetterGrade.Text += "F ";
                }
                
                
            }
            lblTotal.Text = total.ToString();
            lblAverageGrade.Text = average.ToString();



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); //closes form back to main menu
        }

        private void frmReader_Load(object sender, EventArgs e)
        {
            string fileName = @"grades.txt";

            int i = 0;
            if (System.IO.File.Exists(fileName)) //check file exists
            {
                using (System.IO.StreamReader strdr = System.IO.File.OpenText(fileName))
                {
                    string data;
                    while ((data = strdr.ReadLine()) != null)
                    {
                        gradesArray[i] = double.Parse(data);
                        lbxContents.Items.Add(gradesArray[i]);
                        i++;
                    }
                }
            }
            else
            {
                MessageBox.Show("Non-existent file."); //error if file doesn't exist
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblTotal.Text = "";
            lblAverageGrade.Text = "";
            lblLetterGrade.Text = "";
        }
    }
}
