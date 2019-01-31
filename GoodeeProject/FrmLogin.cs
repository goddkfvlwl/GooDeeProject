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
    public partial class FrmLogin : Form
    {
        AccountInfo ai;

        private string tempPW;

        private int movePointX;
        private int movePointY;
        GoodeeDAO.GoodeeDAO gd;

        public FrmLogin()
        {
            InitializeComponent();
            gd = GoodeeDAO.GoodeeDAO.getInstance();
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            movePointX = e.X;
            movePointY = e.Y;
        }

        private void FrmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + (e.X - movePointX), this.Location.Y + (e.Y - movePointY));
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimum_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (!(String.IsNullOrEmpty(tboxID.Text) && String.IsNullOrEmpty(tboxPW.Text)))
            {
                ai = gd.AccountLogin(tboxID.Text, tboxPW.Text);
                if (ai.Id != null)
                {
                    FrmMain.Id = ai.Id;
                    
                    FrmMain.Authority = ai.Authority;
                    if (ai.Authority == 'C')
                    {
                        //기업로그인일 때
                    }
                    else
                    {
                        FrmMain.Mi = gd.SelectMember(ai.Id);
                        FrmMain fr = new FrmMain();
                        fr.Show();
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
    }
}
