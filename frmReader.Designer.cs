
namespace MichalDowningMyFinalProjectCS
{
    partial class frmReader
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
            this.btnGrades = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblAverageGrade = new System.Windows.Forms.Label();
            this.lblLetterGrade = new System.Windows.Forms.Label();
            this.lbxContents = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGrades
            // 
            this.btnGrades.Location = new System.Drawing.Point(227, 325);
            this.btnGrades.Name = "btnGrades";
            this.btnGrades.Size = new System.Drawing.Size(117, 44);
            this.btnGrades.TabIndex = 0;
            this.btnGrades.Text = "&Grades";
            this.btnGrades.UseVisualStyleBackColor = true;
            this.btnGrades.Click += new System.EventHandler(this.btnGrades_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(387, 325);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 44);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbl1
            // 
            this.lbl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl1.Location = new System.Drawing.Point(267, 20);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(237, 37);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Total of the grades";
            // 
            // lbl2
            // 
            this.lbl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl2.Location = new System.Drawing.Point(267, 116);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(237, 37);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Average Grade";
            // 
            // lbl3
            // 
            this.lbl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl3.Location = new System.Drawing.Point(267, 208);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(237, 37);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "Letter Grade";
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(267, 71);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(237, 37);
            this.lblTotal.TabIndex = 5;
            // 
            // lblAverageGrade
            // 
            this.lblAverageGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAverageGrade.Location = new System.Drawing.Point(267, 163);
            this.lblAverageGrade.Name = "lblAverageGrade";
            this.lblAverageGrade.Size = new System.Drawing.Size(237, 37);
            this.lblAverageGrade.TabIndex = 6;
            // 
            // lblLetterGrade
            // 
            this.lblLetterGrade.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLetterGrade.Location = new System.Drawing.Point(267, 255);
            this.lblLetterGrade.Name = "lblLetterGrade";
            this.lblLetterGrade.Size = new System.Drawing.Size(237, 37);
            this.lblLetterGrade.TabIndex = 7;
            // 
            // lbxContents
            // 
            this.lbxContents.FormattingEnabled = true;
            this.lbxContents.ItemHeight = 33;
            this.lbxContents.Location = new System.Drawing.Point(12, 26);
            this.lbxContents.Name = "lbxContents";
            this.lbxContents.Size = new System.Drawing.Size(249, 268);
            this.lbxContents.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(68, 325);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 44);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 393);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lbxContents);
            this.Controls.Add(this.lblLetterGrade);
            this.Controls.Add(this.lblAverageGrade);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGrades);
            this.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MaximizeBox = false;
            this.Name = "frmReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Read It";
            this.Load += new System.EventHandler(this.frmReader_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGrades;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblAverageGrade;
        private System.Windows.Forms.Label lblLetterGrade;
        private System.Windows.Forms.ListBox lbxContents;
        private System.Windows.Forms.Button btnClear;
    }
}