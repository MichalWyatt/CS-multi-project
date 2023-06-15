
namespace MichalDowningMyFinalProjectCS
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuColorChangerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileWriterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMyCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStringWriterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGradeReaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMonthlyPayrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClickMeQuickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.BackColor = System.Drawing.Color.Coral;
            this.mnuMainMenu.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileToolStripMenuItem,
            this.mnuViewToolStripMenuItem,
            this.mnuHelpToolStripMenuItem});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.mnuMainMenu.Size = new System.Drawing.Size(538, 42);
            this.mnuMainMenu.TabIndex = 0;
            this.mnuMainMenu.Text = "menuStrip1";
            // 
            // mnuFileToolStripMenuItem
            // 
            this.mnuFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExitToolStripMenuItem});
            this.mnuFileToolStripMenuItem.Name = "mnuFileToolStripMenuItem";
            this.mnuFileToolStripMenuItem.Size = new System.Drawing.Size(55, 40);
            this.mnuFileToolStripMenuItem.Text = "&File";
            // 
            // mnuExitToolStripMenuItem
            // 
            this.mnuExitToolStripMenuItem.Name = "mnuExitToolStripMenuItem";
            this.mnuExitToolStripMenuItem.Size = new System.Drawing.Size(120, 40);
            this.mnuExitToolStripMenuItem.Text = "Exit";
            this.mnuExitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // mnuViewToolStripMenuItem
            // 
            this.mnuViewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuColorChangerToolStripMenuItem,
            this.mnuFileWriterToolStripMenuItem,
            this.mnuMyCalculatorToolStripMenuItem,
            this.mnuStringWriterToolStripMenuItem,
            this.mnuGradeReaderToolStripMenuItem,
            this.mnuMonthlyPayrollToolStripMenuItem,
            this.mnuClickMeQuickToolStripMenuItem});
            this.mnuViewToolStripMenuItem.Name = "mnuViewToolStripMenuItem";
            this.mnuViewToolStripMenuItem.Size = new System.Drawing.Size(63, 40);
            this.mnuViewToolStripMenuItem.Text = "&View";
            // 
            // mnuColorChangerToolStripMenuItem
            // 
            this.mnuColorChangerToolStripMenuItem.Name = "mnuColorChangerToolStripMenuItem";
            this.mnuColorChangerToolStripMenuItem.Size = new System.Drawing.Size(203, 40);
            this.mnuColorChangerToolStripMenuItem.Text = "&Color Changer";
            this.mnuColorChangerToolStripMenuItem.Click += new System.EventHandler(this.colorChangerToolStripMenuItem_Click);
            // 
            // mnuFileWriterToolStripMenuItem
            // 
            this.mnuFileWriterToolStripMenuItem.Name = "mnuFileWriterToolStripMenuItem";
            this.mnuFileWriterToolStripMenuItem.Size = new System.Drawing.Size(203, 40);
            this.mnuFileWriterToolStripMenuItem.Text = "File &Writer";
            this.mnuFileWriterToolStripMenuItem.Click += new System.EventHandler(this.fileWriterToolStripMenuItem_Click);
            // 
            // mnuMyCalculatorToolStripMenuItem
            // 
            this.mnuMyCalculatorToolStripMenuItem.Name = "mnuMyCalculatorToolStripMenuItem";
            this.mnuMyCalculatorToolStripMenuItem.Size = new System.Drawing.Size(203, 40);
            this.mnuMyCalculatorToolStripMenuItem.Text = "My Ca&lculator";
            this.mnuMyCalculatorToolStripMenuItem.Click += new System.EventHandler(this.myCalculatorToolStripMenuItem_Click);
            // 
            // mnuStringWriterToolStripMenuItem
            // 
            this.mnuStringWriterToolStripMenuItem.Name = "mnuStringWriterToolStripMenuItem";
            this.mnuStringWriterToolStripMenuItem.Size = new System.Drawing.Size(203, 40);
            this.mnuStringWriterToolStripMenuItem.Text = "&String Writer";
            this.mnuStringWriterToolStripMenuItem.Click += new System.EventHandler(this.stringWriterToolStripMenuItem_Click);
            // 
            // mnuGradeReaderToolStripMenuItem
            // 
            this.mnuGradeReaderToolStripMenuItem.Name = "mnuGradeReaderToolStripMenuItem";
            this.mnuGradeReaderToolStripMenuItem.Size = new System.Drawing.Size(203, 40);
            this.mnuGradeReaderToolStripMenuItem.Text = "Grade &Reader";
            this.mnuGradeReaderToolStripMenuItem.Click += new System.EventHandler(this.gradeReaderToolStripMenuItem_Click);
            // 
            // mnuMonthlyPayrollToolStripMenuItem
            // 
            this.mnuMonthlyPayrollToolStripMenuItem.Name = "mnuMonthlyPayrollToolStripMenuItem";
            this.mnuMonthlyPayrollToolStripMenuItem.Size = new System.Drawing.Size(203, 40);
            this.mnuMonthlyPayrollToolStripMenuItem.Text = "Monthly &Payroll";
            this.mnuMonthlyPayrollToolStripMenuItem.Click += new System.EventHandler(this.monthlyPayrollToolStripMenuItem_Click);
            // 
            // mnuClickMeQuickToolStripMenuItem
            // 
            this.mnuClickMeQuickToolStripMenuItem.Name = "mnuClickMeQuickToolStripMenuItem";
            this.mnuClickMeQuickToolStripMenuItem.Size = new System.Drawing.Size(203, 40);
            this.mnuClickMeQuickToolStripMenuItem.Text = "Click &Me Quick";
            this.mnuClickMeQuickToolStripMenuItem.Click += new System.EventHandler(this.clickMeQuickToolStripMenuItem_Click);
            // 
            // mnuHelpToolStripMenuItem
            // 
            this.mnuHelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAboutToolStripMenuItem});
            this.mnuHelpToolStripMenuItem.Name = "mnuHelpToolStripMenuItem";
            this.mnuHelpToolStripMenuItem.Size = new System.Drawing.Size(61, 40);
            this.mnuHelpToolStripMenuItem.Text = "&Help";
            // 
            // mnuAboutToolStripMenuItem
            // 
            this.mnuAboutToolStripMenuItem.Name = "mnuAboutToolStripMenuItem";
            this.mnuAboutToolStripMenuItem.Size = new System.Drawing.Size(133, 40);
            this.mnuAboutToolStripMenuItem.Text = "&About";
            this.mnuAboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(538, 604);
            this.Controls.Add(this.mnuMainMenu);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mnuMainMenu;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# Final Project";
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuColorChangerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuFileWriterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuMyCalculatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuStringWriterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuGradeReaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuMonthlyPayrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuClickMeQuickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuAboutToolStripMenuItem;
    }
}

