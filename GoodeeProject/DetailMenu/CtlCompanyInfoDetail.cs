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

        
        private void lblMenu1_Click_1(object sender, EventArgs e)
        {
            JobInformation information = new JobInformation();
            information.Location = new Point(190, 3);

            Panel panel = (Panel)Parent;
            panel.Controls.Add(information);
            FrmMain main = (FrmMain)panel.Parent;
            main.RemoveUserControl();

        }
        
    }
}
