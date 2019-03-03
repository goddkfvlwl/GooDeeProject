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
        SaveLog log = new SaveLog();

        /// <summary>
        /// 생성자
        /// </summary>
        public Chat()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="client">TcpClient</param>
        /// <param name="isConnected">연결 여부</param>
        public Chat(TcpClient client, bool isConnected) : this()
        {
            this.client = client;
            this.isConnected = isConnected;
        }

        public bool IsConnected { get => isConnected; set => isConnected = value; }

        /// <summary>
        /// 사용자의 채팅방 목록을 읽어옵니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal void Chat_Load(object sender, EventArgs e)
        {
           GoodeeDAO.GoodeeDAO DAO = GoodeeDAO.GoodeeDAO.GetInstance();
           DataTable chat = DAO.SelectChat(FrmMain.Mi.Id);
           GetChatList(chat);
        }

        /// <summary>
        /// 채팅방의 목록을 ChatList객체로 변환하여 생성합니다.
        /// </summary>
        /// <param name="chat"></param>
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
                foreach (Control control in list.Controls)
                {
                    control.DoubleClick += Control_DoubleClick;
                }
                ChatPanel.Controls.Add(list);
            }
            log.AddList("접속목록요청");
        }

        private void Control_DoubleClick(object sender, EventArgs e)
        {
            Label label = sender as Label;
            List_DoubleClick(label.Parent, e);
        }

        /// <summary>
        /// 접속명단을 더블클릭하면 해당 인원과의 채팅방을 생성합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void List_DoubleClick(object sender, EventArgs e)
        {
            ChatList info = sender as ChatList;
            string chat1 = "";
            string chat2 = "";
            string chat1Email = "";
            string chat2Email = "";

            chat1 = info.Chat1;
            chat1Email = info.Chat1Email;
            chat2 = info.Chat2;
            chat2Email = info.Chat2Email;
            FrmChat chat = new FrmChat(chat1, chat1Email, chat2, chat2Email, chat1 + ", " + chat2 + "의 대화방", client);
            ChatClient.ChatList.Add(chat);
            chat.Show();
        }

        /// <summary>
        /// 접속명단을 등록합니다.
        /// </summary>
        /// <param name="info">접속명단의 정보를 가지고있는 OnlineInfo객체입니다.</param>
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
