using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
namespace BackgroundWorker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            System.ComponentModel.BackgroundWorker bw = sender as System.ComponentModel.BackgroundWorker;
            int result = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (bw.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }
                result += i;
                bw.ReportProgress(i, "已完成了" + (i).ToString() + "%");
                Thread.Sleep((int)e.Argument);
            }
            e.Result = result;
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            lblInfo.Text = e.UserState.ToString();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                toolStripStatusLabel1.Text = "用户取消了操作";
                btnStart.Enabled = true;
                return;
            }
            if (e.Error!=null)
            {
                toolStripStatusLabel1.Text = e.Error.Message;
                return;
            }
            lblResult.Text = e.Result.ToString();
            btnStart.Enabled = true;
            toolStripStatusLabel1.Text = "计算完成";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblResult.Text = "?";
            lblResult.Refresh();
            backgroundWorker1.RunWorkerAsync(200);
            btnStart.Enabled = false;
            toolStripStatusLabel1.Text = "正在工作";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
