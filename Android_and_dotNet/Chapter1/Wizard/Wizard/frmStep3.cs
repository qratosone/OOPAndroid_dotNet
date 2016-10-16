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
    public partial class frmStep3 : Wizard.frmBase
    {
        public frmStep3()
        {
            InitializeComponent();
        }
        protected override void getInfo()
        {
            WZCtrl.info.age = txtAge.Text;
        }
        private void frmStep3_Load(object sender, EventArgs e)
        {

        }
    }
}
