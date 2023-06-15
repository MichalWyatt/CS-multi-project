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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void colorChangerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColor formColor = new frmColor();
            formColor.ShowDialog();
        }

        private void fileWriterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWriter formWriter = new frmWriter();
            formWriter.ShowDialog();
        }

        private void myCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculator formCalc = new frmCalculator();
            formCalc.ShowDialog();
        }

        private void stringWriterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStringy formStringy = new frmStringy();
            formStringy.ShowDialog();
        }

        private void gradeReaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReader formReader = new frmReader();
            formReader.ShowDialog();
        }

        private void monthlyPayrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPayroll formPayroll = new frmPayroll();
            formPayroll.ShowDialog();
        }

        private void clickMeQuickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClick formClick = new frmClick();
            formClick.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout formAbout = new frmAbout();
            formAbout.ShowDialog();
        }
    }
}
