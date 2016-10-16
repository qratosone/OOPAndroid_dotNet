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
    public partial class frmStep1 : Wizard.frmBase
    {
        public frmStep1()
        {
            InitializeComponent();
        }
        protected override void getInfo()
        {
            WZCtrl.info.name = txtName.Text;
        }
        private void frmStep1_Load(object sender, EventArgs e)
        {

        }
    }
}
