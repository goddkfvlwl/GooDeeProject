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
    public partial class CtlProfile : UserControl
    {
        CtlProfile proFile;

        public CtlProfile()
        {
            InitializeComponent();
        }

        private void CtlProfile_Load(object sender, EventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            FrmModify fm = new FrmModify();
            fm.ShowDialog();
        }

        private void btnCreateID_Click(object sender, EventArgs e)
        {
            FrmCreateID createID = new FrmCreateID();
            createID.Show();
            
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
            FrmLogin fr = new FrmLogin();
            fr.Visible = true;
        }
    }
}
