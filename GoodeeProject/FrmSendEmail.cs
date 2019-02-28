using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeProject
{
    public partial class FrmSendEmail : Form, IFormControl
    {
        private int movePointX;
        private int movePointY;
        string tempPassword = "";
        int remainTime;
        private string email;

        public FrmSendEmail()
        {
            InitializeComponent();
            btn_Change.Enabled = false;
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
            this.Close();
        }

        public void BtnMinimum_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
  
        private void SendMail()
        {
            MailAddress fromAddr;
            MailMessage mail;
            MailAddress toAddr;
            if (String.IsNullOrEmpty(tb_Email.Text))
            {
                MessageBox.Show("인증번호를 전송할 이메일을 입력해주세요.", "오류");
                return;
            }
            fromAddr = new MailAddress("pca03160@naver.com", "GoodeeAcademy", Encoding.UTF8);
            try
            {
                toAddr = new MailAddress(tb_Email.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("잘못된 형식의 이메일입니다", "오류");
                return;
            }
         
            SmtpClient smtp = new SmtpClient("smtp.naver.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;  //SSL ( Secure Service Line)
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential("pca03160@naver.com", "cg40277589");

            mail = new MailMessage(fromAddr, toAddr);
            mail.Subject = "비밀번호 변경 인증 이메일";

            Random ran = new Random();
            tempPassword = "";
            for (int i = 0; i < 8; i++)
            {
                int rndVal = (int)(ran.Next(62));
                if (rndVal < 10)
                {
                    tempPassword += rndVal;
                }
                else if (rndVal > 35)
                {
                    tempPassword += (char)(rndVal + 61);
                }
                else
                {
                    tempPassword += (char)(rndVal + 55);
                }
            } 

            mail.Body = "인증번호 : " + tempPassword;

            mail.BodyEncoding = Encoding.UTF8;
            mail.SubjectEncoding = Encoding.UTF8;

            try
            {
                smtp.Send(mail);
                MessageBox.Show("메일 전송 완료", "전송 완료");
                email = tb_Email.Text;
                timer1.Enabled = true;
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
                MessageBox.Show("실패, 관리자에게 문의바람", "오류");
            }
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            remainTime = 301;
            SendMail();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            remainTime -= 1;
            lbl_Time.Text = (remainTime / 60) + " : " + (remainTime % 60);

            if (remainTime == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("인증시간이 만료되었습니다. 재발송을 해주세요.", "인증 실패", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            if (tempPassword == tb_Check.Text)
            {
                MessageBox.Show("인증 성공하였습니다.", "인증 성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Properties.Resources._326572_48;
                timer1.Enabled = false;
                btn_Change.Enabled = true;
            }
            else
            {
                MessageBox.Show("잘못된 인증번호입니다.", "인증 실패");
            }
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {
            bool checkForm = true;
            FrmModifyPW modify = new FrmModifyPW(email, checkForm);
            modify.Show();
        }

        public void Frm_BorderPaint(object sender, PaintEventArgs e)
        {
            Rectangle borderRectangle = this.ClientRectangle;
            borderRectangle.Inflate(0, 0);
            ControlPaint.DrawBorder(e.Graphics, borderRectangle, Color.DimGray, ButtonBorderStyle.Solid);
        }
    }
}

