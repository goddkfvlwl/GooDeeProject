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
    public partial class CtlModifyMemberInfo : UserControl
    {
        public CtlModifyMemberInfo()
        {
            InitializeComponent();
            pboxPic.Image = FrmMain.Mi.Picture;
        }

        private void btnSearhAddr_Click(object sender, EventArgs e)
        {
            FrmSearchAddr sa = new FrmSearchAddr();
            sa.Owner = (FrmModify)this.Parent.Parent;
            sa.FormClosed += Sa_FormClosed;
            sa.Show();


        }

        private void Sa_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmModify parent = (FrmModify)this.Parent.Parent;
            this.tboxAddr.Text = parent.Addr;
        }
    }
}
