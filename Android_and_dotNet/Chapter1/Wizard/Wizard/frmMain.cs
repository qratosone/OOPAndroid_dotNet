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
    public partial class frmMain : Form
    {
        private WizardControl ctrl;
        private void showinfo()
        {
            if (ctrl == null) MessageBox.Show("Please input the info");
            else
            {
                this.txtName.Text = ctrl.info.name;
                this.txtMail.Text = ctrl.info.mail;
                this.txtAge.Text = ctrl.info.age;
            }
        }
        public frmMain()
        {
            InitializeComponent();
        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void BTNStart_Click(object sender, EventArgs e)
        {
            ctrl = new WizardControl();
            ctrl.Start();
        }

        private void BTNInfo_Click(object sender, EventArgs e)
        {
            showinfo();

        }

        private void BTNClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
