using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace GoodeeProject
{
    public partial class FrmMain : Form, IFormControl
    {
        private int movePointX;
        private int movePointY;


        public Panel Panel2 { get { return panel2; } set { panel2 = value; } }


        //로그인 한 사용자의 정보를 담을 객체
        static MemberInfo mi = new MemberInfo();
        static AccountInfo ai = new AccountInfo();

        
        CtlSpecDetail spec;
        CtlCompanyInfoDetail companyInfo;
        CtlSurveyAdminDetail surveyAdmin;
        CtlSurveyUserDetail surveyUser;
        CtlMBTIDetail mbti;
        Agreement_enterprise_list agreement;
        

        internal static MemberInfo Mi { get => mi; set => mi = value; }
        internal static AccountInfo Ai { get => ai; set => ai = value; }

        static string serverDate = "";
       
        public static string ServerDate { get => serverDate; set => serverDate = value; }
       
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
            MessageBox.Show(ai.Authority.ToString());
            Network();

            ctlProfile1.Controls["flowLayoutPanel1"].Controls["btnStudent"].Click += BtnStudent_Click;

        }

        TcpClient client;
        NetworkStream ns = null;
        string readDate = null;
        Thread thread;
        bool isConnected = false;

        public void Network()
        {
            if (ai.Authority=='M')
            {
                if (client == null)
                {
                    byte[] nickName = Encoding.UTF8.GetBytes(mi.Name+"!###%%)))");
                    client = new TcpClient();
                    try
                    {
                        client.Connect("192.168.0.233", 3389);   // 연결이 되었으니, Connteced에 true를 준다.
                        isConnected = true;
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show("서버 또는 포트번호를 확인해주세요." + a.Message);
                        return;
                    }

                    // TcpClient 객체의 GetStream() 메서드는 TCP 네트워크 스트림을 리턴한다. 이 네트워크 스트림을 이용해서 네트워크으로 데이타 송수신하게 된다
                    ns = client.GetStream();
                    ns.Write(nickName, 0, nickName.Length);
                    ns.Flush();

                    thread = new Thread(GetMessage);
                    thread.Start();
                }
            }
        }

        private void GetMessage()
        {
            // 서버가 보내준 메서드를 받음
            while (isConnected)
            {
                NetworkStream ns = client.GetStream();
                byte[] receiveMsg = new byte[client.ReceiveBufferSize];
                ns.Read(receiveMsg, 0, receiveMsg.Length);
                ns.Flush();
                readDate = Encoding.UTF8.GetString(receiveMsg);
                //if (readDate.Contains("!"))
                //{

                //}
                Msg();
            }
        }

        private void Msg()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(Msg));
            }
            else
            {
                //MessageBox.Show(readDate);
                if (MessageBox.Show(readDate, "기업요청", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("승인버튼");
                    SendMessage();
                }
                else if (MessageBox.Show(readDate, "기업요청", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    MessageBox.Show("거절버튼");
                    NoSendMessage();
                }

            }
            if (!isConnected)
            {
                client.Close();
                client = null;
            }
        }

        private void NoSendMessage()
        {
            string text = "요청거부&&&&%%%%%_____";
            byte[] message = Encoding.UTF8.GetBytes(text);
            ns.Write(message, 0, message.Length);
            ns.Flush();
        }

        private void SendMessage()
        {
            string text = "요청허용$$$$!!@@@__+++";
            byte[] message = Encoding.UTF8.GetBytes(text);
            ns.Write(message, 0, message.Length);
            ns.Flush();
        }
        
        private void BtnStudent_Click(object sender, EventArgs e)
        {
            studentManagement1.Visible = true;
            GoodeeDAO.GoodeeDAO goodeeDAO = new GoodeeDAO.GoodeeDAO();
            studentManagement1.gViewStudentInfo.DataSource = goodeeDAO.SelectMemberList();
            studentManagement1.gViewStudentInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            studentManagement1.gViewStudentInfo.Columns[0].HeaderText = "과정명";
            studentManagement1.gViewStudentInfo.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            studentManagement1.gViewStudentInfo.Columns[1].HeaderText = "이름";
            studentManagement1.gViewStudentInfo.Columns[2].HeaderText = "생년월일";
            studentManagement1.gViewStudentInfo.Columns[3].HeaderText = "성별";
            studentManagement1.gViewStudentInfo.Columns[4].HeaderText = "휴대폰";
            studentManagement1.gViewStudentInfo.Columns[5].HeaderText = "주소";
            studentManagement1.gViewStudentInfo.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            
        }


        private void btnSpec_Click(object sender, EventArgs e)
        {
            RemoveUserControl();

            sidePanel.Visible = true;
            sidePanel.Location = new Point(btnSpec.Size.Width - 10, btnSpec.Location.Y);

            spec = new CtlSpecDetail();
            panel2.Controls.Add(spec);
            spec.Location = new Point(192, 1);
            spec.Controls["iTalk_Label2"].Click += BtnPortfolio_Click;
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
 
        }

        private void BtnPortfolio_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBoard_Click(object sender, EventArgs e)
        {
            RemoveUserControl();

            sidePanel.Visible = true;
            sidePanel.Location = new Point(btnBoard.Size.Width - 10, btnBoard.Location.Y);
            agreement = new Agreement_enterprise_list();
            panel2.Controls.Add(agreement);
            agreement.Location = new Point(192, 3);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            RemoveUserControl();

            sidePanel.Visible = true;
            sidePanel.Location = new Point(btnInfo.Size.Width - 10, btnInfo.Location.Y);

            companyInfo = new CtlCompanyInfoDetail();
            companyInfo.Parent = this;
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
            mbti.Location = new Point(192, 141);
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            RemoveUserControl();

            sidePanel.Visible = true;
            sidePanel.Location = new Point(btnChat.Size.Width - 10, btnChat.Location.Y);
        }


        private void portfolio1_Load(object sender, EventArgs e)
        {
            //portfolio1.Controls["portfolioDetail1"].AutoSize = true;
            //VerticalScroll.Maximum = portfolio1.Controls["portfolioDetail1"].Height;
            //portfolio1.Controls["portfolioDetail1"].Resize += PortfolioDetail1_Resize;
        }

        private void PortfolioDetail1_Resize(object sender, EventArgs e)
        {
            //VerticalScroll.Maximum = portfolio1.Controls["portfolioDetail1"].Height;
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


        public void RemoveUserControl()
        {
            panel2.Controls.Remove(spec);
            panel2.Controls.Remove(companyInfo);
            panel2.Controls.Remove(surveyAdmin);
            panel2.Controls.Remove(surveyUser);
            panel2.Controls.Remove(mbti);
            panel2.Controls.Remove(agreement);
        }
        public void BtnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);

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
