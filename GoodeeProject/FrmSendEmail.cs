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
        bool check = false;

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
            MailAddress fromAddr = new MailAddress("pca03160@naver.com", "SendMail", Encoding.UTF8);
            var toAddr = new MailAddress(tb_Email.Text);


            SmtpClient smtp = new SmtpClient("smtp.naver.com", 587);
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;  //SSL ( Secure Service Line)
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential("pca03160@naver.com", "cg40277589");

            MailMessage mail = new MailMessage(fromAddr, toAddr);
            mail.Subject = "비밀번호 변경 인증 이메일";

            Random ran = new Random();
           
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

            mail.Body = tempPassword;

            mail.BodyEncoding = Encoding.UTF8;
            mail.SubjectEncoding = Encoding.UTF8;

            try
            {
                smtp.Send(mail);
                MessageBox.Show("메일 전송 완료");
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
                MessageBox.Show("실패, 관리자에게 문의바람");
            }
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            remainTime = 301;
            SendMail();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            remainTime -= 1;
            lbl_Time.Text = (remainTime / 60) + " : " + (remainTime % 60);

            if (remainTime == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("인증시간이 만료되었습니다. 재발송을 해주세요.");
            }
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            if (tempPassword == tb_Check.Text)
            {
                check = true;
                MessageBox.Show("인증성공");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = Properties.Resources._326572_48;
                timer1.Enabled = false;
                btn_Change.Enabled = true;
            }
        }

        private void btn_Change_Click(object sender, EventArgs e)
        {

        }
    }
}

