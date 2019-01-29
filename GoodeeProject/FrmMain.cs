using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeProject
{
    public partial class FrmMain : Form
    {
        private int movePointX;
        private int movePointY;

        CtlSpecDetail spec;
        CtlCompanyInfoDetail companyInfo;
        CtlSurveyAdminDetail surveyAdmin;
        CtlSurveyUserDetail surveyUser;
        CtlMBTIDetail mbti;
        

        public FrmMain()
        {
            InitializeComponent();
            //사용자가 수강생일때
            //ctlProfile1.Size = new Size(224, 111);
            //ctlProfile1.Location = new Point(767, 29);
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSpec_Click(object sender, EventArgs e)
        {
            RemoveUserControl();

            sidePanel.Visible = true;
            sidePanel.Location = new Point(btnSpec.Size.Width - 10, btnSpec.Location.Y);

            spec = new CtlSpecDetail();
            panel2.Controls.Add(spec);
            spec.Location = new Point(192, 1);
            spec.Controls["iTalk_Label2"].Click += FrmMain_Click;
        }

        private void FrmMain_Click(object sender, EventArgs e)
        {
            portfolio1.Visible = true;
            portfolio1.BringToFront();
        }

        private void btnBoard_Click(object sender, EventArgs e)
        {
            RemoveUserControl();

            sidePanel.Visible = true;
            sidePanel.Location = new Point(btnBoard.Size.Width - 10, btnBoard.Location.Y);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            RemoveUserControl();

            sidePanel.Visible = true;
            sidePanel.Location = new Point(btnInfo.Size.Width - 10, btnInfo.Location.Y);

            companyInfo = new CtlCompanyInfoDetail();
            panel2.Controls.Add(companyInfo);
            companyInfo.Location = new Point(192, 211);
        }

        private void btnSurvey_Click(object sender, EventArgs e)
        {
            RemoveUserControl();

            sidePanel.Visible = true;
            sidePanel.Location = new Point(btnSurvey.Size.Width - 10, btnSurvey.Location.Y);

            //사용자
            surveyUser = new CtlSurveyUserDetail();
            panel2.Controls.Add(surveyUser);
            surveyUser.Location = new Point(192, 100);

            //관리자
            //surveyAdmin = new CtlSurveyAdminDetail();
            //panel2.Controls.Add(surveyAdmin);
            //surveyAdmin.Location = new Point(192, 71);
        }

        private void btnMBTI_Click(object sender, EventArgs e)
        {
            RemoveUserControl();

            sidePanel.Visible = true;
            sidePanel.Location = new Point(btnMBTI.Size.Width - 10, btnMBTI.Location.Y);

            mbti = new CtlMBTIDetail();
            panel2.Controls.Add(mbti);
            mbti.Location = new Point(192, 141);
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            RemoveUserControl();

            sidePanel.Visible = true;
            sidePanel.Location = new Point(btnChat.Size.Width - 10, btnChat.Location.Y);
        }

        private void btnMinimum_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            movePointX = e.X;
            movePointY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + (e.X - movePointX), this.Location.Y + (e.Y - movePointY));
            }
        }

        private void RemoveUserControl()
        {
            panel2.Controls.Remove(spec);
            panel2.Controls.Remove(companyInfo);
            panel2.Controls.Remove(surveyAdmin);
            panel2.Controls.Remove(surveyUser);
            panel2.Controls.Remove(mbti);
        }
    }
}
