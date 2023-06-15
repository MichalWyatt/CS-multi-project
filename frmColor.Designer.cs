
namespace MichalDowningMyFinalProjectCS
{
    partial class frmColor
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
            this.btnColorMe = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnColorMe
            // 
            this.btnColorMe.Location = new System.Drawing.Point(82, 88);
            this.btnColorMe.Name = "btnColorMe";
            this.btnColorMe.Size = new System.Drawing.Size(131, 36);
            this.btnColorMe.TabIndex = 0;
            this.btnColorMe.Text = "Color &Me";
            this.btnColorMe.UseVisualStyleBackColor = true;
            this.btnColorMe.Click += new System.EventHandler(this.btnColorMe_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(110, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "C&lose";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 206);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnColorMe);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmColor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Me Random";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnColorMe;
        private System.Windows.Forms.Button button1;
    }
}