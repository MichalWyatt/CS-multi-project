
namespace MichalDowningMyFinalProjectCS
{
    partial class frmStringy
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
            this.lblWord = new System.Windows.Forms.Label();
            this.tbxWord = new System.Windows.Forms.TextBox();
            this.lblPigLatin = new System.Windows.Forms.Label();
            this.btnConverter = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWord
            // 
            this.lblWord.Location = new System.Drawing.Point(12, 23);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(119, 31);
            this.lblWord.TabIndex = 0;
            this.lblWord.Text = "Enter a word";
            this.lblWord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxWord
            // 
            this.tbxWord.Location = new System.Drawing.Point(154, 24);
            this.tbxWord.Name = "tbxWord";
            this.tbxWord.Size = new System.Drawing.Size(208, 31);
            this.tbxWord.TabIndex = 1;
            // 
            // lblPigLatin
            // 
            this.lblPigLatin.Location = new System.Drawing.Point(12, 100);
            this.lblPigLatin.Name = "lblPigLatin";
            this.lblPigLatin.Size = new System.Drawing.Size(119, 31);
            this.lblPigLatin.TabIndex = 2;
            this.lblPigLatin.Text = "Pig Latin";
            this.lblPigLatin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(197, 61);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(119, 34);
            this.btnConverter.TabIndex = 4;
            this.btnConverter.Text = "C&hange";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(243, 164);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 34);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(103, 164);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 34);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(154, 103);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(208, 31);
            this.lblResult.TabIndex = 7;
            // 
            // frmStringy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 210);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.lblPigLatin);
            this.Controls.Add(this.tbxWord);
            this.Controls.Add(this.lblWord);
            this.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmStringy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cheesy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.TextBox tbxWord;
        private System.Windows.Forms.Label lblPigLatin;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblResult;
    }
}