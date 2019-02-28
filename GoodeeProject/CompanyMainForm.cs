using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeProject
{
    public partial class CompanyMainForm : Form, IFormControl
    {
        static MemberInfo mi = new MemberInfo();
        static AccountInfo ai = new AccountInfo();
        internal static MemberInfo Mi { get => mi; set => mi = value; }
        internal static AccountInfo Ai { get => ai; set => ai = value; }

        private int movePointX;
        private int movePointY;
        
        
        
        #region 인터페이스
        public CompanyMainForm()
        {
            InitializeComponent();
        }

        public void BtnMinimum_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
        #endregion

        TcpClient client;
        NetworkStream ns = null;
        string readDate = null;
        Thread thread;
        bool isConnected = false;


        int remainTime; // timer 시간
        bool Read;


        private void RequestButton_Click(object sender, EventArgs e)
        {
            if (client == null)
            {
                byte[] nickName = Encoding.UTF8.GetBytes(mi.Id + "$||$" + mi.Name + "$||$" + ai.Authority);
                client = new TcpClient();
                try
                {
                    client.Connect("192.168.0.248", 3389);   // 연결이 되었으니, Connteced에 true를 준다.
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

                remainTime = 300;
                timer1.Enabled = true;

                thread = new Thread(GetMessage);
                thread.Start();
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
                Open(readDate);

            }
        }

        private void Open(string readDate)
        {
            if (readDate.Contains("거부"))
            {
                timer1.Enabled = false;
                string logout = "$DisConnect$";
                byte[] a = Encoding.UTF8.GetBytes(logout);
                ns.Write(a, 0, a.Length);
                ns.Flush();
                Environment.Exit(0);
            }
            else if (readDate.Contains("허용"))
            {
                this.Visible = false;
                //timer1.Enabled = false;

                CompanyForm companyForm = new CompanyForm(client, ns);
                companyForm.ShowDialog();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            remainTime -= 1;
            lbl_Time.Text = (remainTime / 60) + " : " + (remainTime % 60);
            if (remainTime == 0)
            {
                timer1.Enabled = false;
                Read = false;
                MessageBox.Show("요청받을 수 없습니다. 잠시후 다시 실행해 주세요.");
                Environment.Exit(0);
            }
        }
    }
}
