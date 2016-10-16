namespace Wizard
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.BTNStart = new System.Windows.Forms.Button();
            this.BTNInfo = new System.Windows.Forms.Button();
            this.BTNClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(128, 69);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(135, 21);
            this.txtName.TabIndex = 3;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(128, 107);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(135, 21);
            this.txtMail.TabIndex = 4;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(128, 150);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(133, 21);
            this.txtAge.TabIndex = 5;
            // 
            // BTNStart
            // 
            this.BTNStart.Location = new System.Drawing.Point(57, 268);
            this.BTNStart.Name = "BTNStart";
            this.BTNStart.Size = new System.Drawing.Size(98, 57);
            this.BTNStart.TabIndex = 6;
            this.BTNStart.Text = "Start";
            this.BTNStart.UseVisualStyleBackColor = true;
            this.BTNStart.Click += new System.EventHandler(this.BTNStart_Click);
            // 
            // BTNInfo
            // 
            this.BTNInfo.Location = new System.Drawing.Point(166, 268);
            this.BTNInfo.Name = "BTNInfo";
            this.BTNInfo.Size = new System.Drawing.Size(96, 56);
            this.BTNInfo.TabIndex = 7;
            this.BTNInfo.Text = "Info";
            this.BTNInfo.UseVisualStyleBackColor = true;
            this.BTNInfo.Click += new System.EventHandler(this.BTNInfo_Click);
            // 
            // BTNClose
            // 
            this.BTNClose.Location = new System.Drawing.Point(268, 268);
            this.BTNClose.Name = "BTNClose";
            this.BTNClose.Size = new System.Drawing.Size(98, 55);
            this.BTNClose.TabIndex = 8;
            this.BTNClose.Text = "Close";
            this.BTNClose.UseVisualStyleBackColor = true;
            this.BTNClose.Click += new System.EventHandler(this.BTNClose_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 404);
            this.Controls.Add(this.BTNClose);
            this.Controls.Add(this.BTNInfo);
            this.Controls.Add(this.BTNStart);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button BTNStart;
        private System.Windows.Forms.Button BTNInfo;
        private System.Windows.Forms.Button BTNClose;
    }
}