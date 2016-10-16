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
    public partial class frmStep2 : Wizard.frmBase
    {
        public frmStep2()
        {
            InitializeComponent();
        }
        protected override void getInfo()
        {
            WZCtrl.info.mail = txtMail.Text;
        }
        private void frmStep2_Load(object sender, EventArgs e)
        {

        }
    }
}
