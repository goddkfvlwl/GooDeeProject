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
        SaveLog s = new SaveLog();
        private int movePointX;
        private int movePointY;
        static string curriculum;
        //로그인 한 사용자의 정보를 담을 객체
        static MemberInfo mi = new MemberInfo();
        static AccountInfo ai = new AccountInfo();
        #region Controls
        ChatClient chatClinet;
        Panel detailPanel;
        #endregion

        public static string Curriculum { get => curriculum; set => curriculum = value; }
        internal ChatClient ChatClinet { get => chatClinet; set => chatClinet = value; }
        public static bool IsConnected { get => isConnected; set => isConnected = value; }
        static bool isConnected = false;
        Thread loginThread;
        public static string chatContent;
        internal static MemberInfo Mi { get => mi; set => mi = value; }
        internal static AccountInfo Ai { get => ai; set => ai = value; }
        Agreement_enterprise_list agreement;
        public FrmMain()
        {
            //InitializeComponent();
            detailPanel = new Panel();
            LoadFrm();
        }

        public void LoadFrm()
        {
            InitializeComponent();
            ctlProfile1.lblEmailID.Text = mi.Id;
            ctlProfile1.lblName.Text = mi.Name;
            ctlProfile1.btnClassModify.Click += BtnClassModify_Click;

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
                ctlProfile1.btnClassModify.Visible = false;
                ctlProfile1.Size = new Size(224, 111);
                ctlProfile1.Location = new Point(767, 29);
            }
            else if (ai.Authority == 'A')
            {
                //관리자일 때
                ctlProfile1.btnCreateID.Visible = false;

            }
            ctlProfile1.Controls["flowLayoutPanel1"].Controls["btnStudent"].Click += BtnStudent_Click;
        }

        /// <summary>
        /// 훈련과정을 수정하는 폼을 호출합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void BtnClassModify_Click(object sender, EventArgs e)
        {

            ClassList classlist = new ClassList();
            classlist.Location = new Point(0, 0);

            panel3.Controls.Add(classlist);
        }

        /// <summary>
        /// 수강생을 관리하는 폼을 호출합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void BtnStudent_Click(object sender, EventArgs e)
        {
            RemoveControls();

            StudentManagement studentManagement = new StudentManagement();
            studentManagement.Location = new Point(0, 0);
            studentManagement.Visible = true;

            panel3.Controls.Add(studentManagement);

        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }

        /// <summary>
        /// 스펙괸리의 세부목록을 표시합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void btnSpec_Click(object sender, EventArgs e)
        {
            if (detailPanel.Controls.ContainsKey("CtlSpecDetail"))
            {
                panel2.Controls.Remove(detailPanel);
                detailPanel.Controls.Clear();
                sidePanel.Visible = false;
                return;
            }
            sidePanel.Visible = true;
            sidePanel.Location = new Point(btnSpec.Size.Width - 10, btnSpec.Location.Y);

            CtlSpecDetail spec = new CtlSpecDetail();
            spec.Controls["iTalk_Label2"].Click += BtnPortfolio_Click;
            spec.Controls["lblResume"].Click += BtnResume_Click;
            spec.Controls["lbl_SelfIntroduction"].Click += lbl_SelfIntroduction_Click;
            spec.Location = new Point(0, 0);

            AddPanel(spec, btnSpec.Size, btnSpec.Location);
        }


        private void AddPanel(Control item, Size size, Point point)
        {
            detailPanel.Controls.Clear();
            detailPanel.Controls.Add(item);
            detailPanel.Location = new Point(size.Width, point.Y);
            detailPanel.Size = item.Size;

            panel2.Controls.Add(detailPanel);
            detailPanel.BringToFront();
        }

        private void lbl_SelfIntroduction_Click(object sender, EventArgs e)
        {
            RemoveControls();

            if (ai.Authority == 'S')
            {
                CtlSelfIntroductionList introductionList = new CtlSelfIntroductionList();
                introductionList.Location = new Point(0, 0);
                panel3.Controls.Add(introductionList);
            }
            else
            {
                CtlIntroductionListM introductionListM = new CtlIntroductionListM();
                introductionListM.Location = new Point(0, 0);
                panel3.Controls.Add(introductionListM);
            }
        }

        /// <summary>
        /// 현재 로그인된 계정의 권한에 따라 포트폴리오목록 또는 포트폴리오 매니저폼을 호출합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void BtnPortfolio_Click(object sender, EventArgs e)
        {
            RemoveControls();
            if (ai.Authority == 'S')
            {
                PortfolioList portfolioList = new PortfolioList();
                panel3.Controls.Add(portfolioList);
                portfolioList.Location = new Point(0, 0);
            }
            else if (ai.Authority == 'A' || ai.Authority == 'M')
            {
                PortfolioManager portfolioManager = new PortfolioManager();
                panel3.Controls.Add(portfolioManager);
                portfolioManager.Location = new Point(0, 0);
            }
        }
        /// <summary>
        /// 이력서 사용자정의컨트롤을 띄워주는 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnResume_Click(object sender, EventArgs e)
        {
            RemoveControls();

            s.AddList("이력서 클릭");
            CtlResume rs = new CtlResume();
            panel3.Controls.Add(rs);
            rs.Location = new Point(0, 0);
        }

        private void btnBoard_Click(object sender, EventArgs e)
        {
            s.AddList("협약기업게시판");
            RemoveControls();
            Agreement_enterprise_list agreement = new Agreement_enterprise_list();
            sidePanel.Visible = true;
            sidePanel.Location = new Point(btnBoard.Size.Width - 10, btnBoard.Location.Y);
            if (ai.Authority != 'S')
            {

                panel3.Controls.Add(agreement);
                panel3.Location = new Point(192, 0);
                agreement.Location = new Point(0, 0);
                agreement.BringToFront();
            }
            else
            {
                agreement.btnwrite.Visible = false;
                panel3.Controls.Add(agreement);
                panel3.Location = new Point(192, 0);
                agreement.Location = new Point(0, 0);
                agreement.BringToFront();
            }

            agreement.agreementList1.ItemSelectionChanged += AgreementList1_ItemSelectionChanged;
            agreement.btnwrite.Click += Btnwrite_Click;
        }

        int boardNum = 0; // 게시물번호
        private void AgreementList1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            RemoveControls();
            if (ai.Authority == 'S')    // 학생일 경우
            {
                if (e.IsSelected)
                {
                    ListViewItem listViewItem = e.Item;
                    boardNum = Int32.Parse(listViewItem.SubItems[0].Text);

                    DetailView detail = new DetailView(boardNum);
                    detail.butDelete.Visible = false;
                    detail.butUpdate.Visible = false;
                    detail.Location = new Point(0, 0);
                    panel3.Controls.Add(detail);
                    detail.btnComment.Click += BtnComment_Click;
                }
            }
            else if (ai.Authority != 'S')
            {
                if (e.IsSelected)
                {
                    ListViewItem listViewItem = e.Item;
                    boardNum = Int32.Parse(listViewItem.SubItems[0].Text);

                    DetailView detail = new DetailView(boardNum);
                    detail.Location = new Point(0, 0);
                    detail.BringToFront();
                    panel3.Controls.Add(detail);
                    detail.btnComment.Click += BtnComment_Click;
                }
            }

        }

        private void BtnComment_Click(object sender, EventArgs e)
        {
            RemoveControls();

            CommantLsit cmlist = new CommantLsit(boardNum);
            cmlist.Location = new Point(0, 0);
            cmlist.BringToFront();
            panel3.Controls.Add(cmlist);
            panel3.Location = new Point(185, 0);

            cmlist.board.Click += Board_Click;
        }

        private void Board_Click(object sender, EventArgs e)
        {
            RemoveControls();
            DetailView detail = new DetailView(boardNum);
            detail.Location = new Point(0, 0);
            detail.BringToFront();
            panel3.Controls.Add(detail);
        }
        private void Btnwrite_Click(object sender, EventArgs e)
        {
            RemoveControls();
            Agreement_enterprise agreement_Enterprise = new Agreement_enterprise();
            panel3.Controls.Add(agreement_Enterprise);
            agreement_Enterprise.Location = new Point(0, 0);
            agreement_Enterprise.BringToFront();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            s.AddList("기업정보확인");
            RemoveControls();

            sidePanel.Visible = true;
            sidePanel.Location = new Point(btnInfo.Size.Width - 10, btnInfo.Location.Y);

            JobInformation information = new JobInformation();
            information.Location = new Point(0, 0);
            information.BringToFront();
            panel3.Controls.Add(information);
        }

        /// <summary>
        /// 현재 로그인된 계정의 권한에 따라 설문목록 또는 설문 관리폼을 호출합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void btnSurvey_Click(object sender, EventArgs e)
        {
            if (detailPanel.Controls.ContainsKey("CtlSurveyAdminDetail"))
            {
                panel2.Controls.Remove(detailPanel);
                detailPanel.Controls.Clear();
                sidePanel.Visible = false;
                return;
            }
            sidePanel.Visible = true;
            sidePanel.Location = new Point(btnSurvey.Size.Width - 10, btnSurvey.Location.Y);
            sidePanel.BringToFront();
            if (ai.Authority == 'S')
            {
                panel2.Controls.Remove(detailPanel);
                detailPanel = null;
                panel3.Controls.Clear();
                SurveyList surveyList = new SurveyList();
                surveyList.BackColor = Color.Transparent;
                surveyList.Location = new Point(0, 0);
                panel3.Controls.Add(surveyList);
            }
            else
            {
                //관리자, 최상위 관리자
                CtlSurveyAdminDetail surveyAdmin = new CtlSurveyAdminDetail();

                surveyAdmin.Location = new Point(0, 0);
                surveyAdmin.Controls["btnNewSurvey"].Click += btnNewSurvey_Click;
                surveyAdmin.Controls["btnSurveyList"].Click += btnSurveyList_Click;

                AddPanel(surveyAdmin, btnSurvey.Size, btnSurvey.Location);
            }
        }

        /// <summary>
        /// 설문목록을 호출합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void btnSurveyList_Click(object sender, EventArgs e)
        {
            RemoveControls();

            SurveyList surveyList = new SurveyList();
            surveyList.Location = new Point(0, 0);
            panel3.Controls.Add(surveyList);
        }

        /// <summary>
        /// 새로운 설문을 작성하는 폼을 호출합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void btnNewSurvey_Click(object sender, EventArgs e)
        {
            RemoveControls();

            CreateSurvey createSurvey = new CreateSurvey();
            createSurvey.Location = new Point(0, 0);
            panel3.Controls.Add(createSurvey);
        }

        /// <summary>
        /// MBTI 세부메뉴를 띄워주는 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMBTI_Click(object sender, EventArgs e)
        {
            if (detailPanel.Controls.ContainsKey("CtlMBTIDetail"))
            {
                panel2.Controls.Remove(detailPanel);
                detailPanel.Controls.Clear();
                sidePanel.Visible = false;
                return;
            }
            sidePanel.Visible = true;
            sidePanel.Location = new Point(btnMBTI.Size.Width - 10, btnMBTI.Location.Y);

            CtlMBTIDetail mbti = new CtlMBTIDetail();
            mbti.Location = new Point(0, 0);
            mbti.Controls["lblWrite"].Click += MBTIWrite_Click;
            mbti.Controls["lblResult"].Click += MBTIResult_Click;

            AddPanel(mbti, btnMBTI.Size, btnMBTI.Location);
        }
        /// <summary>
        /// MBTI 결과 사용자정의컨트롤을 띄워주는 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MBTIResult_Click(object sender, EventArgs e)
        {
            RemoveControls();

            CtlMBTIResult mr = new CtlMBTIResult();
            panel3.Controls.Add(mr);
            mr.BackColor = Color.FromArgb(0, 0, 0, 0);
            mr.Location = new Point(0, 0);
        }
        /// <summary>
        /// MBTI 설문 작성 사용자정의컨트롤을 띄워주는 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MBTIWrite_Click(object sender, EventArgs e)
        {
            panel2.Controls.Remove(detailPanel);
            detailPanel.Controls.Clear();
            FrmMBTIQuestion mq = new FrmMBTIQuestion();
            mq.Show();
        }

        /// <summary>
        /// 채팅폼을 호출합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void btnChat_Click(object sender, EventArgs e)
        {
            RemoveControls();
            if (isConnected)
            {
                Chat chat = new Chat(ChatClinet.Client, isConnected);
                panel3.Controls.Add(chat);
                chat.Location = new Point(0, 0);
                chat.BringToFront();
                chatClinet.RequestMemberList();
            }
            else
            {
                isConnected = false;
                MessageBox.Show("채팅서버에 접속할수 없습니다. 잠시후 다시 시도해주세요.");
            }
        }

        public void RemoveControls()
        {
            detailPanel.Controls.Clear();
            panel3.Controls.Clear();
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

        /// <summary>
        /// 폼이 로드될때 채팅서버에 접속합니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            ChatClinet = new ChatClient(this);
            loginThread = new Thread(ChatClinet.ChatLogin);
            loginThread.Start();
        }

        /// <summary>
        /// 현재 폼이 종료될때 채팅서버의 접속을 종료합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">FormClosing 이벤트에 대한 데이터를 제공합니다.</param>
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            ChatClinet.DisConnect();
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

        /// <summary>
        /// 현재 폼을 종료합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        public void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
            ChatClinet.DisConnect();
        }

        private void SetCtlsArgb()
        {
            Control.ControlCollection coll = this.Controls;
            foreach (Control item in coll)
            {
                if (item != null)
                {
                    item.BackColor = Color.FromArgb(0, 0, 0, 0);
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
