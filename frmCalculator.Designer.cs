
namespace MichalDowningMyFinalProjectCS
{
    partial class frmCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculator));
            this.lblTxtNum1 = new System.Windows.Forms.Label();
            this.lblTxtNum2 = new System.Windows.Forms.Label();
            this.tbxNum1 = new System.Windows.Forms.TextBox();
            this.tbxNum2 = new System.Windows.Forms.TextBox();
            this.lblTxtResult = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tbxOperand = new System.Windows.Forms.TextBox();
            this.lblTextOp = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTxtNum1
            // 
            this.lblTxtNum1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTxtNum1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtNum1.Location = new System.Drawing.Point(14, 26);
            this.lblTxtNum1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTxtNum1.Name = "lblTxtNum1";
            this.lblTxtNum1.Size = new System.Drawing.Size(165, 31);
            this.lblTxtNum1.TabIndex = 0;
            this.lblTxtNum1.Text = "First Number";
            this.lblTxtNum1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTxtNum2
            // 
            this.lblTxtNum2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTxtNum2.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtNum2.Location = new System.Drawing.Point(15, 131);
            this.lblTxtNum2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTxtNum2.Name = "lblTxtNum2";
            this.lblTxtNum2.Size = new System.Drawing.Size(165, 31);
            this.lblTxtNum2.TabIndex = 1;
            this.lblTxtNum2.Text = "Second Number";
            this.lblTxtNum2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbxNum1
            // 
            this.tbxNum1.Location = new System.Drawing.Point(187, 27);
            this.tbxNum1.Name = "tbxNum1";
            this.tbxNum1.Size = new System.Drawing.Size(194, 31);
            this.tbxNum1.TabIndex = 2;
            this.tbxNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxNum2
            // 
            this.tbxNum2.Location = new System.Drawing.Point(188, 131);
            this.tbxNum2.Name = "tbxNum2";
            this.tbxNum2.Size = new System.Drawing.Size(194, 31);
            this.tbxNum2.TabIndex = 3;
            this.tbxNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTxtResult
            // 
            this.lblTxtResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTxtResult.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTxtResult.Location = new System.Drawing.Point(12, 225);
            this.lblTxtResult.Name = "lblTxtResult";
            this.lblTxtResult.Size = new System.Drawing.Size(165, 31);
            this.lblTxtResult.TabIndex = 4;
            this.lblTxtResult.Text = "Result";
            this.lblTxtResult.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(188, 223);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(194, 33);
            this.lblResult.TabIndex = 5;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnClear.Location = new System.Drawing.Point(42, 281);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 52);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnExit.Location = new System.Drawing.Point(247, 281);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(135, 52);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "&Close";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbxOperand
            // 
            this.tbxOperand.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOperand.Location = new System.Drawing.Point(276, 78);
            this.tbxOperand.Name = "tbxOperand";
            this.tbxOperand.Size = new System.Drawing.Size(37, 31);
            this.tbxOperand.TabIndex = 8;
            this.tbxOperand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTextOp
            // 
            this.lblTextOp.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextOp.Location = new System.Drawing.Point(183, 81);
            this.lblTextOp.Name = "lblTextOp";
            this.lblTextOp.Size = new System.Drawing.Size(85, 28);
            this.lblTextOp.TabIndex = 9;
            this.lblTextOp.Text = "(+ or  - or *)";
            this.lblTextOp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCalculate.Location = new System.Drawing.Point(229, 178);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(111, 31);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "C&alculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(430, 356);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTextOp);
            this.Controls.Add(this.tbxOperand);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblTxtResult);
            this.Controls.Add(this.tbxNum2);
            this.Controls.Add(this.tbxNum1);
            this.Controls.Add(this.lblTxtNum2);
            this.Controls.Add(this.lblTxtNum1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "frmCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FuN CaLcuLAtoR";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTxtNum1;
        private System.Windows.Forms.Label lblTxtNum2;
        private System.Windows.Forms.TextBox tbxNum1;
        private System.Windows.Forms.TextBox tbxNum2;
        private System.Windows.Forms.Label lblTxtResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox tbxOperand;
        private System.Windows.Forms.Label lblTextOp;
        private System.Windows.Forms.Button btnCalculate;
    }
}