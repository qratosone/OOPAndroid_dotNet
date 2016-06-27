using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace updateUIThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ThreadMethod(Object info)
        {
            Action del = delegate ()//Action 表示无参，无返回值的委托
            {
                label1.Text = "hello";
            };
            Action<string> del2 = delegate (string infovalue)
            {
                label1.Text = infovalue;
            };
            label1.Invoke(del);
            Thread.Sleep(2000);
            label1.Invoke(del2, new object[] { info });
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Thread th1 = new Thread(ThreadMethod);
            th1.Start(txtArgs.Text);
        }
    }
}
