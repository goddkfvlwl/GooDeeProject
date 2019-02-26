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
        string readData = null;
        bool isConnected = false;
        Thread thread;
        NetworkStream ns;
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
           GoodeeDAO.GoodeeDAO DAO = GoodeeDAO.GoodeeDAO.getInstance();
           DataTable chat = DAO.SelectChat(FrmMain.Id);
           GetChatList(chat);
        }

        private void GetChatList(DataTable chat)
        {
            foreach (DataRow item in chat.Rows)
            {
                ChatList list = new ChatList();
                list.Controls["lblChatTitle"].Text = item[0].ToString();
                list.ManagetEmail = item[1].ToString();
                list.StudentEmail = item[2].ToString();
                list.Manager = item[3].ToString();
                list.Student = item[4].ToString();
                list.Controls["lblLastChatContent"].Text = item[5].ToString();
                list.DoubleClick += List_DoubleClick;
                ChatPanel.Controls.Add(list);
            }
        }

        private void List_DoubleClick(object sender, EventArgs e)
        {
            ChatList info = sender as ChatList;
            string manager = "";
            string student = "";
            string managetEmail = "";
            string studentEmail = "";
            if (FrmMain.Authority != 'S')
            {
                manager = FrmMain.Mi.Name;
                managetEmail = FrmMain.Id;
                student = info.Student;
                studentEmail = info.StudentEmail;
                FrmChat chat = new FrmChat(manager, managetEmail, student, studentEmail, manager + ", " + student + "의 대화방", client);
                chat.Show();
            }
            else
            {
                manager = info.Manager;
                student = FrmMain.Mi.Name;
                managetEmail = info.ManagetEmail;
                studentEmail = FrmMain.Id;
                FrmChat chat = new FrmChat(manager, managetEmail, student, studentEmail, manager + ", " + student + "의 대화방", client);
                chat.Show();
            }
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
