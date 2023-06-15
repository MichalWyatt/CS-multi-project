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
    public partial class frmClick : Form
    {

        public frmClick()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.DarkGreen;
        }

        private void frmClick_MouseClick(object sender, MouseEventArgs e)
        {
            //displays x y coordinates
            Point point = new Point(e.X, e.Y);
            if (e.X == 250 && e.Y == 250)
            {
                MessageBox.Show("Awesome Job!  Dead center!");
            }
            else
                MessageBox.Show("Coordinates are: " + (new Point(e.X, e.Y)).ToString());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
