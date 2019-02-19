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

        private int movePointX;
        private int movePointY;
        GoodeeDAO.GoodeeDAO gd;

        public FrmLogin()
        {
            InitializeComponent();
            gd = GoodeeDAO.GoodeeDAO.GetInstance();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(tboxID.Text) && String.IsNullOrEmpty(tboxPW.Text)))
            {
                FrmMain.Ai = gd.AccountLogin(tboxID.Text, tboxPW.Text);
                if (FrmMain.Ai.Id != null)
                {
                    if (FrmMain.Ai.Authority == 'C')
                    {
                        //기업로그인일 때
                    }
                    else
                    {
                        FrmMain.Ai.Pw = tboxPW.Text;
                       // FrmMain.Mi = gd.SelectMember(FrmMain.Ai.Id);
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
            s.AddList("비밀번호 찾기");
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

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            s.AddList("프로그램 종료");
            //SaveLog.LogList.Add()
            s.WriteLog();
            s.SendLog(FrmMain.Ai.Id);
            s.DeleteLog();
            
        }
    }
}
