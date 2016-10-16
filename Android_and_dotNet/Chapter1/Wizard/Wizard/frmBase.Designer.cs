namespace Wizard
{
    partial class frmBase
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
            this.BTNPrev = new System.Windows.Forms.Button();
            this.BTNNext = new System.Windows.Forms.Button();
            this.BTNFinish = new System.Windows.Forms.Button();
            this.BTNCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTNPrev
            // 
            this.BTNPrev.Location = new System.Drawing.Point(34, 300);
            this.BTNPrev.Name = "BTNPrev";
            this.BTNPrev.Size = new System.Drawing.Size(61, 41);
            this.BTNPrev.TabIndex = 0;
            this.BTNPrev.Text = "Prev";
            this.BTNPrev.UseVisualStyleBackColor = true;
            this.BTNPrev.Click += new System.EventHandler(this.BTNPrev_Click);
            // 
            // BTNNext
            // 
            this.BTNNext.Location = new System.Drawing.Point(144, 300);
            this.BTNNext.Name = "BTNNext";
            this.BTNNext.Size = new System.Drawing.Size(61, 41);
            this.BTNNext.TabIndex = 1;
            this.BTNNext.Text = "Next";
            this.BTNNext.UseVisualStyleBackColor = true;
            this.BTNNext.Click += new System.EventHandler(this.BTNNext_Click);
            // 
            // BTNFinish
            // 
            this.BTNFinish.Location = new System.Drawing.Point(251, 300);
            this.BTNFinish.Name = "BTNFinish";
            this.BTNFinish.Size = new System.Drawing.Size(61, 41);
            this.BTNFinish.TabIndex = 2;
            this.BTNFinish.Text = "Finish";
            this.BTNFinish.UseVisualStyleBackColor = true;
            this.BTNFinish.Click += new System.EventHandler(this.BTNFinish_Click);
            // 
            // BTNCancel
            // 
            this.BTNCancel.Location = new System.Drawing.Point(354, 300);
            this.BTNCancel.Name = "BTNCancel";
            this.BTNCancel.Size = new System.Drawing.Size(61, 41);
            this.BTNCancel.TabIndex = 3;
            this.BTNCancel.Text = "Cancel";
            this.BTNCancel.UseVisualStyleBackColor = true;
            this.BTNCancel.Click += new System.EventHandler(this.BTNCancel_Click);
            // 
            // frmBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 395);
            this.Controls.Add(this.BTNCancel);
            this.Controls.Add(this.BTNFinish);
            this.Controls.Add(this.BTNNext);
            this.Controls.Add(this.BTNPrev);
            this.Name = "frmBase";
            this.Text = "frmBase";
            this.Load += new System.EventHandler(this.frmBase_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTNPrev;
        private System.Windows.Forms.Button BTNNext;
        private System.Windows.Forms.Button BTNFinish;
        private System.Windows.Forms.Button BTNCancel;
    }
}