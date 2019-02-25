using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
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
        static string curriculum;
        CtlSpecDetail spec;
        CtlCompanyInfoDetail companyInfo;
        CtlSurveyAdminDetail surveyAdmin;
        CtlMBTIDetail mbti;
        public static string Id { get => id; set => id = value; }
        public static char Authority { get => authority; set => authority = value; }
        internal static MemberInfo Mi { get => mi; set => mi = value; }
        public static string Curriculum { get => curriculum; set => curriculum = value; }

        TcpClient client;
        NetworkStream ns = default(NetworkStream);
        bool isConnected = false;
        Thread loginThread;
        public static string chatContent;
        public FrmMain()
        {
            InitializeComponent();
            ctlProfile1.lblEmailID.Text = mi.Id;
            ctlProfile1.lblName.Text = mi.Name;
            ctlProfile1.btnClassModify.Click += BtnClassModify_Click;
            if (Authority == 'S')
            {
                //사용자가 수강생일때
                ctlProfile1.btnLog.Visible = false;
                ctlProfile1.btnStudent.Visible = false;
                ctlProfile1.btnClassModify.Visible = false;
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

        private void BtnClassModify_Click(object sender, EventArgs e)
        {
            ClassList list = new ClassList();
            panel2.Controls.Add(list);
            list.Location = new Point(185, 0);
            list.BringToFront();
        }

        private void BtnStudent_Click(object sender, EventArgs e)
        {
            StudentManagement studentManagement1 = new StudentManagement();
            panel2.Controls.Add(studentManagement1);
            studentManagement1.Location = new Point(185, 0);
            studentManagement1.Visible = true;
            studentManagement1.BringToFront();
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
            if (spec == null)
            {
                RemoveUserControl();
                sidePanel.Visible = true;
                sidePanel.Location = new Point(btnSpec.Size.Width - 10, btnSpec.Location.Y);
                spec = new CtlSpecDetail();
                panel2.Controls.Add(spec);
                spec.Location = new Point(192, 1);
                spec.BringToFront();
                spec.Controls["iTalk_Label2"].Click += BtnPortfolio_Click;
            }else
            {
                sidePanel.Visible = false;
                RemoveUserControl();
            }
        }

        private void BtnPortfolio_Click(object sender, EventArgs e)
        {
            if (authority == 'S')
            {
                PortfolioList list = new PortfolioList();
                panel2.Controls.Add(list);
                list.Location = new Point(185, 0);
                list.BringToFront(); 
            }else if(authority == 'A' || authority == 'M')
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
            if (companyInfo == null)
            {
                RemoveUserControl();

                sidePanel.Visible = true;
                sidePanel.Location = new Point(btnInfo.Size.Width - 10, btnInfo.Location.Y);

                companyInfo = new CtlCompanyInfoDetail();
                panel2.Controls.Add(companyInfo);
                companyInfo.Location = new Point(192, 211);
            }
            else
            {
                sidePanel.Visible = false;
                RemoveUserControl();
            }
        }

        private void btnSurvey_Click(object sender, EventArgs e)
        {
            if (surveyAdmin == null)
            {
                RemoveUserControl();

                sidePanel.Visible = true;
                sidePanel.Location = new Point(btnSurvey.Size.Width - 10, btnSurvey.Location.Y);

                if (Authority == 'S')
                {
                    SurveyList survey = new SurveyList();
                    panel2.Controls.Add(survey);
                    survey.Location = new Point(185, 0);
                    survey.BringToFront();
                }
                else
                {
                    //관리자, 최상위 관리자
                    if (surveyAdmin == null)
                    {
                        surveyAdmin = new CtlSurveyAdminDetail();
                    }
                    panel2.Controls.Add(surveyAdmin);
                    surveyAdmin.Location = new Point(192, 40);
                    surveyAdmin.Controls["iTalk_Label1"].Click += iTalk_Label1_Click;
                    surveyAdmin.Controls["lblMenu1"].Click += lblMenu1_Click;
                    surveyAdmin.BringToFront();
                }
            }
            else
            {
                sidePanel.Visible = false;
                RemoveUserControl();
            }
        }

        private void lblMenu1_Click(object sender, EventArgs e)
        {
            SurveyList list = new SurveyList();
            panel2.Controls.Add(list);
            list.Location = new Point(185, 0);
            list.BringToFront();
        }

        private void iTalk_Label1_Click(object sender, EventArgs e)
        {
            CreateSurvey survey = new CreateSurvey();
            panel2.Controls.Add(survey);
            survey.Location = new Point(185, 0);
            survey.BringToFront();
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
            if (isConnected)
            {
                Chat chat = new Chat(client, isConnected);
                panel2.Controls.Add(chat);
                chat.Location = new Point(185, 0);
                chat.BringToFront();
            }else
            {
                MessageBox.Show("채팅서버에 접속할수 없습니다. 잠시후 다시 시도해주세요.");
            }
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
            spec = null;
            panel2.Controls.Remove(companyInfo);
            companyInfo = null;
            panel2.Controls.Remove(surveyAdmin);
            surveyAdmin = null;
            panel2.Controls.Remove(mbti);
            surveyAdmin = null;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            loginThread = new Thread(ChatLogin);
            loginThread.Start();
        }
        /// <summary>
        /// 채팅서버에 접속
        /// </summary>
        private void ChatLogin()
        {
            if (Authority != 'C')
            {
                while (true)
                {
                    if (client == null && !isConnected)
                    {
                        client = new TcpClient();
                        byte[] nickName = Encoding.UTF8.GetBytes(mi.Id + "$||$" + mi.Name + "$||$" + curriculum + "$||$");

                        try
                        {
                            client.Connect("192.168.0.235", 3333);
                            isConnected = true;
                            ns = client.GetStream();
                            ns.Write(nickName, 0, nickName.Length);
                            ns.Flush();
                            return;
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("채팅 서버에 접속할 수 없습니다." + Environment.NewLine + "10초후 자동으로 재시도합니다.");
                            client = null;
                            Thread.Sleep(1000);
                        }
                    }
                } 
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (client != null && client.Connected)
            {
                byte[] nickName = Encoding.UTF8.GetBytes( mi.Name + "$DisConnect$");
                ns.Write(nickName, 0, nickName.Length);
                ns.Flush();
                isConnected = false;
            }
        }
    }
}
