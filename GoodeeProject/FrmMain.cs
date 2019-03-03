﻿using System;
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
        public Panel Panel2 { get { return panel2; } set { panel2 = value; } }
        CtlSpecDetail spec;
        CtlCompanyInfoDetail companyInfo;
        CtlSurveyAdminDetail surveyAdmin;
        CtlMBTIDetail mbti;
        Chat chat;
        ChatClient chatClinet;
        ClassList classlist;
        StudentManagement studentManagement;
        PortfolioList portfolioList;
        PortfolioManager portfolioManager;
        CtlResume rs;
        SurveyList surveyList;
        CreateSurvey createSurvey;
        CtlMBTIResult mr;
        FrmMBTIQuestion mq;
        JobInformation information;
        DetailView detail;
        Agreement_enterprise agreement_Enterprise;
        
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
            LoadFrm();
        }

        public void LoadFrm()
        {
            InitializeComponent();
            ctlProfile1.lblEmailID.Text = mi.Id;
            ctlProfile1.lblName.Text = mi.Name;
            ctlProfile1.btnClassModify.Click += BtnClassModify_Click;
            if (ai.Authority == 'S')
            {

            }

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
            classlist = new ClassList();
            panel2.Controls.Add(classlist);
            classlist.Location = new Point(185, 0);
            classlist.BringToFront();
        }
        /// <summary>
        /// 수강생을 관리하는 폼을 호출합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void BtnStudent_Click(object sender, EventArgs e)
        {
            studentManagement = new StudentManagement();
            panel2.Controls.Add(studentManagement);
            studentManagement.Location = new Point(185, 0);
            studentManagement.Visible = true;
            studentManagement.BringToFront();
        }

        /// <summary>
        /// 세부목록을 표시합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void btnSpec_Click(object sender, EventArgs e)
        {
            RemoveUserControl();
            if (spec == null)
            {
                
                sidePanel.Visible = true;
                sidePanel.Location = new Point(btnSpec.Size.Width - 10, btnSpec.Location.Y);
                spec = new CtlSpecDetail();
                panel2.Controls.Add(spec);
                spec.Location = new Point(192, 1);
                spec.BringToFront();
                spec.Controls["iTalk_Label2"].Click += BtnPortfolio_Click; ;
                spec.Controls["lblResume"].Click += BtnResume_Click;
                spec.Controls["lbl_SelfIntroduction"].Click += lbl_SelfIntroduction_Click;
            }
            else
            {
                sidePanel.Visible = false;
                RemoveUserControl();
            }
        }

        /// <summary>
        /// 현재 로그인된 계정의 권한에 따라 포트폴리오목록 또는 포트폴리오 매니저폼을 호출합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void BtnPortfolio_Click(object sender, EventArgs e)
        {
            RemoveUserControl();
            if (ai.Authority == 'S')
            {
                portfolioList = new PortfolioList();
                panel2.Controls.Add(portfolioList);
                portfolioList.Location = new Point(185, 0);
                portfolioList.BringToFront();
            }
            else if (ai.Authority == 'A' || ai.Authority == 'M')
            {
                portfolioManager = new PortfolioManager();
                panel2.Controls.Add(portfolioManager);
                portfolioManager.Location = new Point(185, 0);
                portfolioManager.BringToFront();
            }  
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

        private void BtnResume_Click(object sender, EventArgs e)
        {
            RemoveUserControl();
            s.AddList("이력서 클릭");
            rs = new CtlResume();
            panel2.Controls.Add(rs);
            rs.Location = new Point(185, 0);
            spec.SendToBack();

        }

        private void btnBoard_Click(object sender, EventArgs e)
        {
            RemoveUserControl();

            sidePanel.Visible = true;
            sidePanel.Location = new Point(btnBoard.Size.Width - 10, btnBoard.Location.Y);

            if (ai.Authority!='S')
            {
                agreement = new Agreement_enterprise_list();
                panel2.Controls.Add(agreement);
                agreement.Location = new Point(192, 3);
                agreement.BringToFront();
            }
            else
            {
                agreement = new Agreement_enterprise_list();
                agreement.btnwrite.Visible = false;
                panel2.Controls.Add(agreement);
                agreement.Location = new Point(192, 3);
                agreement.BringToFront();
            }

            agreement.agreementList1.ItemSelectionChanged += AgreementList1_ItemSelectionChanged;
            agreement.btnwrite.Click += Btnwrite_Click;


        }

        int boardNum = 0; // 게시물번호
        private void AgreementList1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            RemoveUserControl();
             
            if (ai.Authority == 'S')    // 학생일 경우
            {
                if (e.IsSelected)
                {
                    ListViewItem listViewItem = e.Item;
                    boardNum = Int32.Parse(listViewItem.SubItems[0].Text);

                    detail = new DetailView(boardNum);
                    detail.butDelete.Visible = false;
                    detail.butUpdate.Visible = false;
                    detail.Location = new Point(190, 3);
                    detail.BringToFront();
                    panel2.Controls.Add(detail);
                }
            }
            else if (ai.Authority != 'S')
            {
                if (e.IsSelected)
                {
                    ListViewItem listViewItem = e.Item;
                    boardNum = Int32.Parse(listViewItem.SubItems[0].Text);

                    detail = new DetailView(boardNum);
                    detail.Location = new Point(190, 3);
                    detail.BringToFront();
                    panel2.Controls.Add(detail); 
                }
            }
           
        }

        
        private void Btnwrite_Click(object sender, EventArgs e)
        {
            RemoveUserControl();
            agreement_Enterprise = new Agreement_enterprise();
            panel2.Controls.Add(agreement_Enterprise);
            agreement_Enterprise.Location = new Point(192, 3);
            agreement_Enterprise.BringToFront();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            RemoveUserControl();

            sidePanel.Visible = true;
            sidePanel.Location = new Point(btnInfo.Size.Width - 10, btnInfo.Location.Y);

            information = new JobInformation();
            information.Location = new Point(190, 3);
            information.BringToFront();
            panel2.Controls.Add(information);
            
            
        }

        private void FrmMain_Click(object sender, EventArgs e)
        {
            RemoveUserControl();
            information = new JobInformation();
            information.Location = new Point(190, 3);
            panel2.Controls.Add(information);
        }


        /// <summary>
        /// 현재 로그인된 계정의 권한에 따라 설문목록 또는 설문 관리폼을 호출합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void btnSurvey_Click(object sender, EventArgs e)
        {
            RemoveUserControl();
            if (surveyAdmin == null)
            {

                sidePanel.Visible = true;
                sidePanel.Location = new Point(btnSurvey.Size.Width - 10, btnSurvey.Location.Y);
                if (ai.Authority == 'S')
                {
                    surveyList = new SurveyList();
                    panel2.Controls.Add(surveyList);
                    surveyList.Location = new Point(185, 0);
                    surveyList.BringToFront();
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
        }

        /// <summary>
        /// 설문목록을 호출합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void lblMenu1_Click(object sender, EventArgs e)
        {
            RemoveUserControl();
            surveyList = new SurveyList();
            panel2.Controls.Add(surveyList);
            surveyList.Location = new Point(185, 0);
            surveyList.BringToFront();
        }

        /// <summary>
        /// 새로운 설문을 작성하는 폼을 호출합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void iTalk_Label1_Click(object sender, EventArgs e)
        {
            RemoveUserControl();
            createSurvey = new CreateSurvey();
            panel2.Controls.Add(createSurvey);
            createSurvey.Location = new Point(185, 0);
            createSurvey.BringToFront();
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
            mr = new CtlMBTIResult();
            panel2.Controls.Add(mr);
            mr.Location = new Point(185, 0);
            mbti.SendToBack();
        }

        private void MBTIWrite_Click(object sender, EventArgs e)
        {
            mbti.SendToBack();
            mq = new FrmMBTIQuestion();
            mq.Show();
        }

        /// <summary>
        /// 채팅폼을 호출합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void btnChat_Click(object sender, EventArgs e)
        {
            RemoveUserControl();
                if (isConnected)
                {
                    chat = new Chat(ChatClinet.Client, isConnected);
                    panel2.Controls.Add(chat);
                    chat.Location = new Point(185, 0);
                    chat.BringToFront();
                    chatClinet.RequestMemberList();
                }
                else
                {
                    isConnected = false;
                    MessageBox.Show("채팅서버에 접속할수 없습니다. 잠시후 다시 시도해주세요.");
                }
        }

        /// <summary>
        /// 현제 활성화된 폼을 모두 삭제합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        internal void RemoveUserControl()
        {
            panel2.Controls.Remove(spec);
            spec = null;
            panel2.Controls.Remove(companyInfo);
            companyInfo = null;
            panel2.Controls.Remove(surveyAdmin);
            surveyAdmin = null;
            panel2.Controls.Remove(mbti);
            mbti = null;
            panel2.Controls.Remove(chat);
            chat = null;
            panel2.Controls.Remove(classlist);
            classlist = null;
            panel2.Controls.Remove(studentManagement);
            studentManagement = null;
            panel2.Controls.Remove(portfolioList);
            portfolioList = null;
            panel2.Controls.Remove(portfolioManager);
            portfolioManager = null;
            panel2.Controls.Remove(rs);
            rs = null;
            panel2.Controls.Remove(surveyList);
            surveyList = null;
            panel2.Controls.Remove(createSurvey);
            createSurvey = null;
            panel2.Controls.Remove(mr);
            mr = null;
            panel2.Controls.Remove(mq);
            mq = null;
            panel2.Controls.Remove(agreement);
            agreement = null;
            panel2.Controls.Remove(information);
            information = null;
            panel2.Controls.Remove(detail);
            detail = null;
            panel2.Controls.Remove(agreement_Enterprise);
            agreement_Enterprise = null;
            panel2.Controls.Remove(detail);
            detail = null;
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
        }
    }
}
