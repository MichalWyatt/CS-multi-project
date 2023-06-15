using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MichalDowningMyFinalProjectCS
{
    public partial class frmWriter : Form
    {
        public frmWriter()
        {
            InitializeComponent();
        }


        private void btnGenerate_Click(object sender, EventArgs e)
        {
            const string sPath = "even.txt";
            for (int i = 100; i < 202; i++) //i picks even number until 200
            {
                int num = 0;
                num = i % 2;

                if (num == 0)
                {
                    lbxEven.Items.Add(i);
                }
            }
            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(sPath);
            foreach (var evenNum in lbxEven.Items)
            {
                SaveFile.WriteLine(evenNum);
            }

            SaveFile.Close();

            MessageBox.Show("Programs saved!");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
