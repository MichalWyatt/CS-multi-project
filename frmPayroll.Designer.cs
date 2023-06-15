
namespace MichalDowningMyFinalProjectCS
{
    partial class frmPayroll
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
            this.lblTxtHoursWorked = new System.Windows.Forms.Label();
            this.lblTxtRateOfPay = new System.Windows.Forms.Label();
            this.tbxHoursWorked = new System.Windows.Forms.TextBox();
            this.tbxRateOfPay = new System.Windows.Forms.TextBox();
            this.lbxOutput = new System.Windows.Forms.ListBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTxtHoursWorked
            // 
            this.lblTxtHoursWorked.Location = new System.Drawing.Point(12, 32);
            this.lblTxtHoursWorked.Name = "lblTxtHoursWorked";
            this.lblTxtHoursWorked.Size = new System.Drawing.Size(120, 26);
            this.lblTxtHoursWorked.TabIndex = 0;
            this.lblTxtHoursWorked.Text = "Hours Worked:";
            this.lblTxtHoursWorked.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTxtRateOfPay
            // 
            this.lblTxtRateOfPay.Location = new System.Drawing.Point(12, 77);
            this.lblTxtRateOfPay.Name = "lblTxtRateOfPay";
            this.lblTxtRateOfPay.Size = new System.Drawing.Size(120, 26);
            this.lblTxtRateOfPay.TabIndex = 1;
            this.lblTxtRateOfPay.Text = "Rate Of Pay:";
            this.lblTxtRateOfPay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbxHoursWorked
            // 
            this.tbxHoursWorked.Location = new System.Drawing.Point(138, 29);
            this.tbxHoursWorked.Name = "tbxHoursWorked";
            this.tbxHoursWorked.Size = new System.Drawing.Size(238, 28);
            this.tbxHoursWorked.TabIndex = 2;
            // 
            // tbxRateOfPay
            // 
            this.tbxRateOfPay.Location = new System.Drawing.Point(138, 77);
            this.tbxRateOfPay.Name = "tbxRateOfPay";
            this.tbxRateOfPay.Size = new System.Drawing.Size(238, 28);
            this.tbxRateOfPay.TabIndex = 3;
            // 
            // lbxOutput
            // 
            this.lbxOutput.FormattingEnabled = true;
            this.lbxOutput.ItemHeight = 23;
            this.lbxOutput.Location = new System.Drawing.Point(28, 134);
            this.lbxOutput.Name = "lbxOutput";
            this.lbxOutput.Size = new System.Drawing.Size(348, 211);
            this.lbxOutput.TabIndex = 4;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(28, 369);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(104, 44);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "C&alculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(150, 369);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 44);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(272, 369);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(104, 44);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 439);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lbxOutput);
            this.Controls.Add(this.tbxRateOfPay);
            this.Controls.Add(this.tbxHoursWorked);
            this.Controls.Add(this.lblTxtRateOfPay);
            this.Controls.Add(this.lblTxtHoursWorked);
            this.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmPayroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payroll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTxtHoursWorked;
        private System.Windows.Forms.Label lblTxtRateOfPay;
        private System.Windows.Forms.TextBox tbxHoursWorked;
        private System.Windows.Forms.TextBox tbxRateOfPay;
        private System.Windows.Forms.ListBox lbxOutput;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}