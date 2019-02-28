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
using Tulpep.NotificationWindow;

namespace GoodeeProject
{
    public partial class Chat : UserControl
    {
        private TcpClient client;
        bool isConnected = false;
        private delegate void GetmemberInvoke(OnlineInfo info);

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
           GoodeeDAO.GoodeeDAO DAO = GoodeeDAO.GoodeeDAO.GetInstance();
           DataTable chat = DAO.SelectChat(FrmMain.Mi.Id);
           GetChatList(chat);
        }

        private void GetChatList(DataTable chat)
        {
            foreach (DataRow item in chat.Rows)
            {
                ChatList list = new ChatList();
                list.Controls["lblChatTitle"].Text = item[0].ToString();
                list.Chat1Email = item[1].ToString();
                list.Chat2Email = item[2].ToString();
                list.Chat1 = item[3].ToString();
                list.Chat2 = item[4].ToString();
                list.Controls["lblLastChatContent"].Text = item[5].ToString();
                list.DoubleClick += List_DoubleClick;
                ChatPanel.Controls.Add(list);
            }
        }

        private void List_DoubleClick(object sender, EventArgs e)
        {
            ChatList info = sender as ChatList;
            string chat1 = "";
            string chat2 = "";
            string chat1Email = "";
            string chat2Email = "";
            //if (FrmMain.Ai.Authority != 'S')
            //{
            //    chat1 = info.Chat1;
            //    chat1Email = info.Chat1Email;
            //    chat2 = info.Chat2;
            //    chat2Email = info.Chat2Email;
            //    FrmChat chat = new FrmChat(chat1, chat1Email, chat2, chat2Email, chat1 + ", " + chat2 + "의 대화방", client);
            //    ChatClient.ChatList.Add(chat);
            //    chat.Show();
            //}
            //else
            //{
            //    chat1 = info.Chat1;
            //    chat1Email = info.Chat1Email;
            //    chat2 = info.Chat2;
            //    chat2Email = info.Chat2Email;
            //    FrmChat chat = new FrmChat(chat1, chat1Email, chat2, chat2Email, chat1 + ", " + chat2 + "의 대화방", client);
            //    ChatClient.ChatList.Add(chat);
            //    chat.Show();
            //}
            chat1 = info.Chat1;
            chat1Email = info.Chat1Email;
            chat2 = info.Chat2;
            chat2Email = info.Chat2Email;
            FrmChat chat = new FrmChat(chat1, chat1Email, chat2, chat2Email, chat1 + ", " + chat2 + "의 대화방", client);
            ChatClient.ChatList.Add(chat);
            chat.Show();
        }

        internal void GetMember(OnlineInfo info)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new GetmemberInvoke(GetMember), info);
            }else
            {
                LoginPanel.Controls.Add(info);
            }
        }
    }
}
