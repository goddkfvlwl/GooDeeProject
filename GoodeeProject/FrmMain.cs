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

        private static string id;
        private static char authority;

        //로그인 한 사용자의 정보를 담을 객체
        static MemberInfo mi = new MemberInfo();

        CtlSpecDetail spec;
        CtlCompanyInfoDetail companyInfo;
        CtlSurveyAdminDetail surveyAdmin;
        CtlSurveyUserDetail surveyUser;
        CtlMBTIDetail mbti;
        
        public static string Id { get => id; set => id = value; }
        public static char Authority { get => authority; set => authority = value; }
        internal static MemberInfo Mi { get => mi; set => mi = value; }

        public FrmMain()
        {
            InitializeComponent();
            ctlProfile1.lblEmailID.Text = mi.Id;
            ctlProfile1.lblName.Text = mi.Name;
            
            if (Authority == 'S')
            {
                //사용자가 수강생일때
                ctlProfile1.btnLog.Visible = false;
                ctlProfile1.btnStudent.Visible = false;
                ctlProfile1.Size = new Size(224, 111);
                ctlProfile1.Location = new Point(767, 29);
            }
            else if (Authority == 'A')
            {
                //관리자일 때
                ctlProfile1.btnCreateID.Visible = false;
            }
            ctlProfile1.Controls["flowLayoutPanel1"].Controls["btnStudent"].Click += BtnStudent_Click;
        }

        private void BtnStudent_Click(object sender, EventArgs e)
        {
            StudentManagement studentManagement1 = new StudentManagement();
            panel2.Controls.Add(studentManagement1);
            studentManagement1.Location = new Point(185, 0);
            studentManagement1.Visible = true;
            studentManagement1.BringToFront();
            GoodeeDAO.GoodeeDAO goodeeDAO = new GoodeeDAO.GoodeeDAO();
            studentManagement1.gViewStudentInfo.DataSource = goodeeDAO.SelectMemberList();
            studentManagement1.gViewStudentInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            studentManagement1.gViewStudentInfo.Columns[0].HeaderText = "분류";
            studentManagement1.gViewStudentInfo.Columns[1].HeaderText = "과정명";
            studentManagement1.gViewStudentInfo.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            studentManagement1.gViewStudentInfo.Columns[2].HeaderText = "이름";
            studentManagement1.gViewStudentInfo.Columns[3].HeaderText = "생년월일";
            studentManagement1.gViewStudentInfo.Columns[4].HeaderText = "성별";
            studentManagement1.gViewStudentInfo.Columns[5].HeaderText = "휴대폰";
            studentManagement1.gViewStudentInfo.Columns[6].HeaderText = "주소";
            studentManagement1.gViewStudentInfo.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            studentManagement1.gViewStudentInfo.Columns[7].Visible = false;
        }

        //public FrmMain(string id, char authority) : this()
        //{
        //    this.Id = id;
        //    this.Authority = authority;
        //}

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
            spec.BringToFront();
            spec.Controls["iTalk_Label2"].Click += BtnPortfolio_Click;
        }

        private void BtnPortfolio_Click(object sender, EventArgs e)
        {
            if (authority == 'S')
            {
                Portfolio portfolio1 = new Portfolio();
                panel2.Controls.Add(portfolio1);
                portfolio1.Location = new Point(185, 0);
                portfolio1.Visible = true;
                portfolio1.Controls["portfolioDetail1"].AutoSize = true;
                VerticalScroll.Maximum = portfolio1.Controls["portfolioDetail1"].Height;
                portfolio1.BringToFront(); 
            }else if(authority == 'M')
            {
                PortfolioManager manager = new PortfolioManager();
                panel2.Controls.Add(manager);
                manager.Location = new Point(185, 0);
                manager.BringToFront();
            }
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

            if (Authority == 'S')
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
