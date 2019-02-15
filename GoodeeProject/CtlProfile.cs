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
        SaveLog s = new SaveLog();

        public CtlProfile()
        {
            InitializeComponent();
        }

        private void CtlProfile_Load(object sender, EventArgs e)
        {

        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            s.AddList("정보수정 클릭");
            FrmModify fm = new FrmModify();
            fm.Owner = (FrmMain)this.Parent.Parent;
            fm.ShowDialog();
        }

        private void btnCreateID_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            FrmCreateID createID = new FrmCreateID();
            createID.Show();
            
=======
            s.AddList("관리자생성 클릭");
>>>>>>> 87ce42d64a49ec553bb1362e3ed1ff46afc7d920
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FrmLogin fr = new FrmLogin();
            if (FrmMain.Ai.Id != null)
            {
                s.AddList("로그아웃");
                //SaveLog.LogList.Add()
                s.WriteLog();
                s.SendLog(FrmMain.Ai.Id);
                s.DeleteLog();
                FrmLogin.LogoutCheck = true;
            }

            this.ParentForm.Close();
            fr.Visible = true;

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            s.AddList("수강생관리 클릭");
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            s.AddList("로그관리 클릭");
            FrmLog fl = new FrmLog();
            fl.Show();
        }
    }
}
