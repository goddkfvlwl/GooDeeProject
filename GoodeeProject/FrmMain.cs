using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeProject
{
    public partial class FrmMain : Form, IFormControl
    {
        SaveLog s = new SaveLog();
        private int movePointX;
        private int movePointY;
        

        //로그인 한 사용자의 정보를 담을 객체
        static MemberInfo mi = new MemberInfo();
        static AccountInfo ai = new AccountInfo();
        

        CtlSpecDetail spec;
        CtlCompanyInfoDetail companyInfo;
        CtlSurveyAdminDetail surveyAdmin;
        CtlSurveyUserDetail surveyUser;
        CtlMBTIDetail mbti;
        
        internal static MemberInfo Mi { get => mi; set => mi = value; }
        internal static AccountInfo Ai { get => ai; set => ai = value; }

        public FrmMain()
        {
            //InitializeComponent();
            LoadFrm();
            
        }

        public void LoadFrm()
        {
            InitializeComponent();
            ctlProfile1.lblEmailID.Text = mi.Id;
            ctlProfile1.lblName.Text = mi.Name;

            if (mi.Picture != null)
            {
                ctlProfile1.pboxProFile.Image = mi.Picture;
            }
            else
            {
                //ResourceManager rm = Properties.Resources.ResourceManager;
                //mi.Picture = rm.GetObject("profile2.png") as string;
                //ctlProfile1.pboxProFile.ImageLocation = mi.Picture;
                mi.Picture = Properties.Resources.profile2;
                ctlProfile1.pboxProFile.Image = mi.Picture;
            }

            if (ai.Authority == 'S')
            {
                //사용자가 수강생일때
                ctlProfile1.btnLog.Visible = false;
                ctlProfile1.btnStudent.Visible = false;
                ctlProfile1.Size = new Size(224, 111);
                ctlProfile1.Location = new Point(767, 29);
            }
            else if (ai.Authority == 'A')
            {
                //관리자일 때
                ctlProfile1.btnCreateID.Visible = false;
            }
        }

        

        private void btnSpec_Click(object sender, EventArgs e)
        {
            RemoveUserControl();
            
            sidePanel.Visible = true;
            sidePanel.Location = new Point(btnSpec.Size.Width - 10, btnSpec.Location.Y);

            spec = new CtlSpecDetail();
            panel2.Controls.Add(spec);
            spec.BringToFront();
            spec.Location = new Point(192, 1);
            //spec.Controls["iTalk_Label2"].Click += BtnPortfolio_Click;
            spec.Controls["lbl_SelfIntroduction"].Click += lbl_SelfIntroduction_Click;

        }

        private void lbl_SelfIntroduction_Click(object sender, EventArgs e)
        {
            RemoveUserControl();

            if (ai.Authority == 'S')
            {
                CtlSelfIntroductionList introductionList = new CtlSelfIntroductionList();
                introductionList.Location = new Point(186, 0);
                panel2.Controls.Add(introductionList);
            }
            else
            {
                CtlIntroductionListM introductionList = new CtlIntroductionListM();
                introductionList.Location = new Point(186, 0);
                panel2.Controls.Add(introductionList);
            }
 
            spec.Controls["lblResume"].Click += BtnResume_Click;
        }

        private void BtnResume_Click(object sender, EventArgs e)
        {
            s.AddList("이력서 클릭");
            CtlResume rs = new CtlResume();
            panel2.Controls.Add(rs);
            rs.Location = new Point(185, 0);
            spec.SendToBack();
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

            if (ai.Authority == 'S')
            {
                //사용자
                surveyUser = new CtlSurveyUserDetail();
                panel2.Controls.Add(surveyUser);
                surveyUser.Location = new Point(192, 100);
            }
            else
            {
                //관리자, 최상위 관리자
                surveyAdmin = new CtlSurveyAdminDetail();
                panel2.Controls.Add(surveyAdmin);
                surveyAdmin.Location = new Point(192, 71);
            }
        }

        private void btnMBTI_Click(object sender, EventArgs e)
        {
            RemoveUserControl();

            sidePanel.Visible = true;
            sidePanel.Location = new Point(btnMBTI.Size.Width - 10, btnMBTI.Location.Y);

            mbti = new CtlMBTIDetail();
            panel2.Controls.Add(mbti);
            mbti.BringToFront();
            mbti.Location = new Point(192, 141);
            mbti.Controls["lblWrite"].Click += MBTIWrite_Click;
            mbti.Controls["lblResult"].Click += MBTIResult_Click;
        }

        private void MBTIResult_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MBTIWrite_Click(object sender, EventArgs e)
        {
            mbti.SendToBack();
            FrmMBTIQuestion mq = new FrmMBTIQuestion();
            mq.Show();
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            RemoveUserControl();

            sidePanel.Visible = true;
            sidePanel.Location = new Point(btnChat.Size.Width - 10, btnChat.Location.Y);
        }

        private void RemoveUserControl()
        {
            panel2.Controls.Remove(spec);
            panel2.Controls.Remove(companyInfo);
            panel2.Controls.Remove(surveyAdmin);
            panel2.Controls.Remove(surveyUser);
            panel2.Controls.Remove(mbti);
        }

        private void portfolio1_Load(object sender, EventArgs e)
        {
            portfolio1.Controls["portfolioDetail1"].AutoSize = true;
            VerticalScroll.Maximum = portfolio1.Controls["portfolioDetail1"].Height;
            portfolio1.Controls["portfolioDetail1"].Resize += PortfolioDetail1_Resize;
        }

        private void PortfolioDetail1_Resize(object sender, EventArgs e)
        {
            VerticalScroll.Maximum = portfolio1.Controls["portfolioDetail1"].Height;
        }

        public void Frm_MouseDown(object sender, MouseEventArgs e)
        {
            movePointX = e.X;
            movePointY = e.Y;
        }

        public void Frm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + (e.X - movePointX), this.Location.Y + (e.Y - movePointY));
            }
        }

        public void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public void BtnMinimum_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public void Frm_BorderPaint(object sender, PaintEventArgs e)
        {
            Rectangle borderRectangle = this.ClientRectangle;
            borderRectangle.Inflate(0, 0);
            ControlPaint.DrawBorder(e.Graphics, borderRectangle, Color.DimGray, ButtonBorderStyle.Solid);
        }
    }
}
