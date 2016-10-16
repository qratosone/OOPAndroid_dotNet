using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Wizard
{
    public class WizardControl
    {
        private List<Form> frmList = new List<Form>();
        public Info info = new Info();
        private int curIndex = 0;
        public WizardControl()
        {
            frmList.Add(new frmStep1());
            frmList.Add(new frmStep2());
            frmList.Add(new frmStep3());
            foreach(frmBase frm in frmList)
            {
                frm.WZCtrl = this;
            }
        }
        public Boolean isFirstForm
        {
            get { return curIndex == 0; }
        }
        public Boolean isLastForm
        {
            get { return curIndex == frmList.Count - 1; }
        }
        public void Next()
        {
            if (curIndex + 1 < frmList.Count)
            {
                ((frmBase)frmList[curIndex]).Visible = false;
                curIndex++;
            }
            else return;
            ((frmBase)frmList[curIndex]).Show();
            ((frmBase)frmList[curIndex]).DisableButton();

        }
        public void Prev()
        {
            if (curIndex - 1 >=0)
            {
                ((frmBase)frmList[curIndex]).Visible = false;
                curIndex--;
            }
            else return;
            ((frmBase)frmList[curIndex]).Show();
            ((frmBase)frmList[curIndex]).DisableButton();
        }
        public void Start()
        {
            ((frmBase)frmList[0]).Show();
            ((frmBase)frmList[0]).DisableButton();
        }
        public void Finish()
        {
            curIndex = 0;
            foreach(Form frm in frmList)
            {
                frm.Close();
            }
        }
    }
}
