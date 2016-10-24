using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonCounterForMultiFormUseReference
{
    public partial class frmOther : Form
    {
        public frmOther(frmMain main)
        {
            InitializeComponent();
            MainForm = main;
        }
        private frmMain MainForm = null;

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            //调用主窗体的公有方法，显示按钮计数
            if (MainForm != null)
                MainForm.ShowCounter();
        }

       
    }
}
