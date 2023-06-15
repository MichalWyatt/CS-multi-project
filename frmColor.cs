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
    public partial class frmColor : Form
    {
        public frmColor()
        {
            InitializeComponent();
        }

        private void btnColorMe_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int num = rand.Next(0, 5);

            if (num == 0)  //generate back ground colors
            {
               this.BackColor = Color.Yellow;
            }
            else if (num == 1)
            {
                this.BackColor = Color.Red;
            }
            else if (num == 2)
            {
                this.BackColor = Color.Blue;
            }
            else if (num == 3)
            {
                this.BackColor = Color.Green;
            }
            else if (num == 4)
            {
                this.BackColor = Color.Purple;
            }
            else if (num == 5)
            {
                this.BackColor = Color.Orange;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();  //closes form
        }
    }
}
