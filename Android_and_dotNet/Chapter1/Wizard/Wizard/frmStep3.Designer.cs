namespace Wizard
{
    partial class frmStep3
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
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(142, 91);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(143, 12);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Input your age(integer)";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(137, 153);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(162, 21);
            this.txtAge.TabIndex = 5;
            // 
            // frmStep3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 365);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Name = "frmStep3";
            this.Text = "frmStep3";
            this.Load += new System.EventHandler(this.frmStep3_Load);
            this.Controls.SetChildIndex(this.lblAge, 0);
            this.Controls.SetChildIndex(this.txtAge, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
    }
}