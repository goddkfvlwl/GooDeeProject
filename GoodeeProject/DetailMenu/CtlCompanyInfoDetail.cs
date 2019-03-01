using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeProject
{
    public partial class CtlCompanyInfoDetail : UserControl
    {
        public CtlCompanyInfoDetail()
        {
            InitializeComponent();
           
        }
        
        //KREDIT_JOB kREDIT_;
        //Panel panel;
        //JobInformation information;
        private void lblMenu1_Click_1(object sender, EventArgs e)
        {
            //information = new JobInformation();
            //information.Location = new Point(190, 3);

            //panel = (Panel)Parent;
            //panel.Controls.Add(information);
            //FrmMain main = (FrmMain)panel.Parent;
            
            //main.RemoveUserControl();
            
        }


        private void iTalk_Label1_Click(object sender, EventArgs e)
        {
            //kREDIT_ = new KREDIT_JOB();
            //kREDIT_.Location = new Point(190, 3);

            //panel = (Panel)Parent;
            //panel.Controls.Add(kREDIT_);
            //FrmMain main = (FrmMain)panel.Parent;
            //main.RemoveUserControl();
        }

        public void RemoveControl()
        {
            //panel.Controls.Remove(kREDIT_);
        }
    }
}
