using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wizard
{
    public partial class frmBase : Form
    {
        public frmBase()
        {
            InitializeComponent();
        }
        public WizardControl WZCtrl = null;
        public void DisableButton()
        {
            if (WZCtrl == null) return;
            if (this.WZCtrl.isFirstForm) BTNPrev.Enabled = false;
            else
                BTNPrev.Enabled = true;
            if (this.WZCtrl.isLastForm) BTNNext.Enabled = false;
            else
                BTNNext.Enabled = true;
        }
        protected virtual void getInfo()
        {

        }
        public void goNext()
        {
            getInfo();
            WZCtrl.Next();
        }
        public void goPrev()
        {
            getInfo();
            WZCtrl.Prev();
        }
        protected virtual void goFinish()
        {
            getInfo();
            WZCtrl.Finish();
            this.Visible = false;
        }
        protected virtual void Cancel()
        {
            this.WZCtrl.info = null;
            this.Close();
        }
        private void frmBase_Load(object sender, EventArgs e)
        {

        }

        private void BTNPrev_Click(object sender, EventArgs e)
        {
            this.goPrev();
        }

        private void BTNNext_Click(object sender, EventArgs e)
        {
            this.goNext();
        }

        private void BTNFinish_Click(object sender, EventArgs e)
        {
            this.goFinish();
        }

        private void BTNCancel_Click(object sender, EventArgs e)
        {
            this.Cancel();

        }
    }
}
