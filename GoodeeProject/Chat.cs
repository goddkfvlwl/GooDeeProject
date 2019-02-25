using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;

namespace GoodeeProject
{
    public partial class Chat : UserControl
    {
        private TcpClient client;
        string readData = null;
        bool isConnected = false;
        Thread thread;
        NetworkStream ns;
        public Chat()
        {
            InitializeComponent();
        }

        public Chat(TcpClient client, bool isConnected) : this()
        {
            this.client = client;
            this.isConnected = isConnected;
        }

        public bool IsConnected { get => isConnected; set => isConnected = value; }

        internal void Chat_Load(object sender, EventArgs e)
        {
            ns = client.GetStream();
            byte[] getmember = Encoding.UTF8.GetBytes("$GetMember$");
            ns.Write(getmember, 0, getmember.Length);
            ns.Flush();
            thread = new Thread(GetMassage);
            thread.Start();
        }

        private void GetMassage()
        {
            // 서버가 보내준 메시지를 받음
            while (isConnected)
            {
                NetworkStream ns = client.GetStream();
                byte[] receiveMsg = new byte[client.ReceiveBufferSize];
                ns.Read(receiveMsg, 0, receiveMsg.Length);
                ns.Flush();
                readData = Encoding.UTF8.GetString(receiveMsg);
                if (readData.Contains("$member$"))
                {
                    GetMembers();
                    break;
                }
            }
        }

        private void GetMembers()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(GetMembers));
            }
            else
            {
                if (readData.Contains("$member$"))
                {
                    LoginPanel.Controls.Clear();
                    string[] members = readData.Replace("\0", "").Split(new string[] { "$member$" }, StringSplitOptions.None);
                    GoodeeDAO.GoodeeDAO DAO = GoodeeDAO.GoodeeDAO.getInstance();
                    foreach (string item in members)
                    {
                        if (item != "!")
                        {
                            OnlineInfo info = new OnlineInfo();
                            info.DoubleClick += Info_DoubleClick;
                            var member = DAO.SelectMemberInfo(item);
                            info.Controls["lblName"].Text = member.Rows[0]["Name"].ToString();
                            info.Controls["lblCurriculum"].Text = member.Rows[0]["Curriculum"].ToString();
                            info.Controls["lblEmail"].Text = member.Rows[0]["ID"].ToString();
                            LoginPanel.Controls.Add(info); 
                        }
                    }
                    isConnected = false;
                }
            }
        }

        private void Info_DoubleClick(object sender, EventArgs e)
        {
            string user = "";
            string target = "";
            OnlineInfo info = sender as OnlineInfo;
            if (FrmMain.Authority != 'S')
            {
                user = FrmMain.Mi.Name;
                target = info.Controls["lblEmail"].Text;
                FrmChat chat = new FrmChat(user, target, info.Controls["lblName"].Text, user + ", " + info.Controls["lblName"].Text + "의 대화방", client);
                chat.Show();
            }
            else
            {
                user = FrmMain.Mi.Name;
                target = info.Controls["lblEmail"].Text;
                FrmChat chat = new FrmChat(user, target, info.Controls["lblName"].Text, info.Controls["lblName"].Text + ", " + user + "의 대화방", client);
                chat.Show();
            }
        }
    }
}
