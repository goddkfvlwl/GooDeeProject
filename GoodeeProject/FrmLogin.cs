using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeProject
{
    public partial class FrmLogin : Form, IFormControl
    {
        AccountInfo ai;
        
        FrmModify modify = new FrmModify();
        SaveLog s = new SaveLog();



        static bool logoutCheck = false;

        private int movePointX;
        private int movePointY;
        GoodeeDAO.GoodeeDAO gd;

        public static bool LogoutCheck { get => logoutCheck; set => logoutCheck = value; }

        public FrmLogin()
        {
            InitializeComponent();

            gd = GoodeeDAO.GoodeeDAO.GetInstance();
        }

        /// <summary>
        /// AccountInfo 테이블에 데이터와 비교하여 기업일경우 기업 폼을, 그 외엔 메인 폼을 띄운다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (!(String.IsNullOrEmpty(tboxID.Text) && String.IsNullOrEmpty(tboxPW.Text)))
            {
                FrmMain.Ai = gd.AccountLogin(tboxID.Text, tboxPW.Text);
                CompanyMainForm.Ai = gd.AccountLogin(tboxID.Text, tboxPW.Text);
                if (FrmMain.Ai.Id != null)
                {
                    if (FrmMain.Ai.Authority == 'C')
                    {
                        CompanyMainForm.Ai.Pw = tboxPW.Text;
                        CompanyMainForm.Mi = gd.SelectMember(CompanyMainForm.Ai.Id);
                        CompanyMainForm companyMainForm = new CompanyMainForm();
                        companyMainForm.Show();
                        s.AddList("로그인");
                        this.Visible = false;

                    }
                    else
                    {
                        FrmMain.Mi = gd.SelectMember(FrmMain.Ai.Id);
                        FrmMain.Curriculum = gd.GetCurriculum(FrmMain.Mi.ClassNum);
                        FrmMain.Ai.Pw = tboxPW.Text;
                        FrmMain.Mi = gd.SelectMember(FrmMain.Ai.Id);
                        FrmMain fr = new FrmMain();
                        fr.Show();
                        s.AddList("로그인");
                        this.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("올바르지 않은 회원정보입니다.");
                }
            }
            else
            {
                MessageBox.Show("ID 혹은 비밀번호를 입력해주세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnFindPW_Click(object sender, EventArgs e)
        {
            FrmSendEmail fs = new FrmSendEmail();
            fs.Show();
        }

        public void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void BtnMinimum_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
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

        public void Frm_BorderPaint(object sender, PaintEventArgs e)
        {
            Rectangle borderRectangle = this.ClientRectangle;
            borderRectangle.Inflate(0, 0);
            ControlPaint.DrawBorder(e.Graphics, borderRectangle, Color.DimGray, ButtonBorderStyle.Solid);
        }

        /// <summary>
        /// 프로그램 종료될때 리스트에 쌓인 로그들을 파일로 만들어 보낸후 만든 파일은 삭제한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FrmMain.Ai.Id != null && LogoutCheck == false)
            {
                s.AddList("프로그램 종료");
                s.WriteLog();
                s.SendLog(FrmMain.Ai.Id);
                s.DeleteLog();
            }
        }

        
    }
}
