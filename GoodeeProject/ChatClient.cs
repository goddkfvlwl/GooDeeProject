using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace GoodeeProject
{
    class ChatClient : Form
    {
        private static List<FrmChat> chatList = new List<FrmChat>();
        TcpClient client;
        NetworkStream ns = default(NetworkStream);
        Thread getMassageThread;
        string readData;
        public static List<FrmChat> ChatList { get => chatList; set => chatList = value; }
        public TcpClient Client { get => client; set => client = value; }

        FrmMain main;
        public ChatClient(FrmMain main)
        {
            this.main = main;
        }

        internal void ChatLogin()
        {
            if (FrmMain.Authority != 'C')
            {
                GoodeeDAO.GoodeeDAO DAO = GoodeeDAO.GoodeeDAO.getInstance();

                string curriculum = DAO.GetCurriculum(FrmMain.Mi.ClassNum);
                while (true)
                {
                    if (client == null && !FrmMain.IsConnected)
                    {
                        client = new TcpClient();
                        byte[] nickName = Encoding.UTF8.GetBytes(FrmMain.Id + "$||$" + FrmMain.Mi.Name + "$||$" + curriculum + "$||$");

                        try
                        {
                            client.Connect("192.168.0.235", 3333);
                            ns = client.GetStream();
                            ns.Write(nickName, 0, nickName.Length);
                            ns.Flush();
                            FrmMain.IsConnected = true;
                            getMassageThread = new Thread(GetMassage);
                            getMassageThread.Start();
                            return;
                        }
                        catch (Exception a)
                        {
                            MessageBox.Show("채팅 서버에 접속할 수 없습니다." + Environment.NewLine + "10초후 자동으로 재시도합니다.");
                            client = null;
                            Thread.Sleep(10000);
                        }
                    }
                }
            }
        }

        internal void RequestMemberList()
        {
            ns = client.GetStream();
            byte[] msg = Encoding.UTF8.GetBytes("$GetMember$");
            ns.Write(msg, 0, msg.Length);
            ns.Flush();
        }

        private void GetMassage()
        {
            while (FrmMain.IsConnected)
            {
                NetworkStream ns = client.GetStream();
                byte[] receiveMsg = new byte[client.ReceiveBufferSize];
                ns.Read(receiveMsg, 0, receiveMsg.Length);
                ns.Flush();
                readData = Encoding.UTF8.GetString(receiveMsg);
                if (readData.Contains("$member$"))
                {
                    GetMembers();
                }
                else if (readData.Contains("$Msg$"))
                {
                    Msg();
                }
                else if (readData.Contains("$Overlap$"))
                {
                    MessageBox.Show("동일한 계정이 이미 접속중입니다.");
                    Environment.Exit(0);
                }
            }
        }

        private void GetMembers()
        {
            if (readData.Contains("$member$"))
            {
                main.Controls["panel2"].Controls["Chat"].Controls["LoginPanel"].Controls.Clear();
                string[] members = default(string[]);

                if (readData.Contains("$Msg$"))
                {
                    members = readData.Substring(readData.IndexOf("$member$")).Replace("\0", "").Split(new string[] { "$member$" }, StringSplitOptions.None);
                }
                else
                {
                    members = readData.Replace("\0", "").Split(new string[] { "$member$" }, StringSplitOptions.None);
                }

                GoodeeDAO.GoodeeDAO DAO = GoodeeDAO.GoodeeDAO.getInstance();

                foreach (string item in members)
                {
                    if (item != "!" && item != FrmMain.Mi.Id && !string.IsNullOrEmpty(item))
                    {
                        var member = DAO.SelectMemberInfo(item);
                        OnlineInfo info = new OnlineInfo();
                        info.DoubleClick += Info_DoubleClick;
                        info.Controls["lblName"].Text = member.Rows[0]["Name"].ToString();
                        info.Controls["lblCurriculum"].Text = member.Rows[0]["Curriculum"].ToString();
                        info.Controls["lblEmail"].Text = member.Rows[0]["ID"].ToString();
                        (main.Controls["panel2"].Controls["Chat"] as Chat).GetMember(info);
                    }
                }
            }
        }

        private void Msg()
        {
            string[] str = readData.Split(new string[] { "$To$" }, StringSplitOptions.None);
            string target = str[1].Substring(0, str[1].IndexOf("$Name$"));
            string content = str[0].Substring(0, str[0].IndexOf("$From$"));
            string user = str[0].Replace(content + "$From$", "");
            bool isRead = false;
            foreach (FrmChat item in chatList)
            {
                if (item.ManagerEmail == target.Replace(user, "") || item.StudentEmail == target.Replace(user, ""))
                {
                    item.GetMsg(user + " : " + content);
                    item.GetMsg(Environment.NewLine);
                    isRead = true;
                }
            }

            if (!isRead)
            {
            }
        }

        private void Popup()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(Popup));
            }else
            {
                PopupNotifier pop = new PopupNotifier();
                pop.ContentText = "asdfasd";
                pop.Popup();
            }
        }

        private void Info_DoubleClick(object sender, EventArgs e)
        {
            OnlineInfo info = sender as OnlineInfo;
            string manager = "";
            string student = "";
            string managetEmail = "";
            string studentEmail = "";
            if (FrmMain.Authority != 'S')
            {
                manager = FrmMain.Mi.Name;
                managetEmail = FrmMain.Id;
                student = info.Controls["lblName"].Text;
                studentEmail = info.Controls["lblEmail"].Text;
                FrmChat chat = new FrmChat(manager, managetEmail, student, studentEmail, manager + ", " + student + "의 대화방", client);
                chatList.Add(chat);
                chat.Show();
            }
            else
            {
                manager = info.Controls["lblName"].Text;
                student = FrmMain.Mi.Name;
                managetEmail = info.Controls["lblEmail"].Text;
                studentEmail = FrmMain.Id;
                FrmChat chat = new FrmChat(manager, managetEmail, student, studentEmail, manager + ", " + student + "의 대화방", client);
                chatList.Add(chat);
                chat.Show();
            }
        }

        internal void DisConnect()
        {
            if (client != null && client.Connected)
            {
                byte[] nickName = Encoding.UTF8.GetBytes(FrmMain.Mi.Name + "$DisConnect$");
                ns.Write(nickName, 0, nickName.Length);
                ns.Flush();
            }
        }
    }
}
