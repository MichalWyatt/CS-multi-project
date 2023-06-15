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
    public partial class frmStringy : Form
    {
        public frmStringy()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbxWord.Clear();
            lblResult.Text = "";
        }

        private void btnConverter_Click(object sender, EventArgs e)
        {
            const string suff = "ay";
            string word =  tbxWord.Text;

            //Check the length to make sure it is at least 2
            if (word.Length < 2)
            {
                MessageBox.Show("Try again.  Enter 2 or more characters");
                return;
            }
            lblResult.Text = string.Format("{0}{1}{2}",
                word.Substring(1),
                word.Substring(0, 1),
                suff);
        }
    }
}
