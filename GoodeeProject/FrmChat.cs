using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeProject
{
    public partial class FrmChat : Form
    {
        string chatTitle;
        string chat1;
        string chat2;
        string chat2Email;
        string chatEmail;
        string user;
        string userEmail;
        string target;
        string targetName;
        TcpClient client;

        public string ChatTitle { get => chatTitle; set => chatTitle = value; }
        public string Chat1 { get => chat1; set => chat1 = value; }
        public string Chat2 { get => chat2; set => chat2 = value; }
        public string Chat2Email { get => chat2Email; set => chat2Email = value; }
        public string Chat1Email { get => chatEmail; set => chatEmail = value; }
        public string User { get => user; set => user = value; }
        public string Target { get => target; set => target = value; }
        public string TargetName { get => targetName; set => targetName = value; }
        public string UserEmail { get => userEmail; set => userEmail = value; }

        private delegate void GetMsgInvoke(string msg);

        /// <summary>
        /// 생성자
        /// </summary>
        public FrmChat()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 채팅방의 대화내역을 데이터베이스에서 읽어옵니다.
        /// </summary>
        /// <param name="chat">참여자1의 이름입니다.</param>
        /// <param name="chatEmail">참여자1의 이메일주소입니다.</param>
        /// <param name="chat2">참여자2의 이름입니다.</param>
        /// <param name="chat2Email">참여자2의 이메일주소입니다.</param>
        /// <param name="title">채팅방의 제목입니다.</param>
        /// <param name="client">채팅서버과 통신을 하기위한 TcpClient 객체입니다./</param>
        public FrmChat(string chat, string chatEmail, string chat2, string chat2Email, string title,  System.Net.Sockets.TcpClient client) : this()
        {
            chatTitle = title;
            this.client = client;
            this.chat1 = chat;
            this.chat2 = chat2;
            this.chat2Email = chat2Email;
            this.chatEmail = chatEmail;
            if (FrmMain.Mi.Name == chat2)
            {
                user = chat2;
                userEmail = chat2Email;
                target = chatEmail;
                targetName = chat;
            }else
            {
                user = chat;
                userEmail = chatEmail;
                target = chat2Email;
                targetName = chat2;
            }
        }
        
        /// <summary>
        /// 채팅방을 등록합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void FrmChat_Load(object sender, EventArgs e)
        {
            this.Text = chatTitle;
            InsertChatList();
        }

        /// <summary>
        /// 채팅목록을 저장하거나 저장된  채팅목록의 채팅내용을 불러오는 메서드입니다.
        /// </summary>
        private void InsertChatList()
        {
            GoodeeDAO.GoodeeDAO DAO = GoodeeDAO.GoodeeDAO.GetInstance();
            DAO.InsertChat(chat1 + ", " + chat2 + "의 대화방", chatEmail, chat2Email, chat1, chat2);
            DataTable content = DAO.SelectChatContent(chatEmail,  chat2Email);
            if (content.Rows.Count > 0)
            {
                foreach (DataRow item in content.Rows)
                {
                    txtChatContent.Text += item["Content"].ToString();
                }
            }
        }

        /// <summary>
        /// 채팅서버로 메세지를 보내고 채팅내역을 저장합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            NetworkStream ns = client.GetStream();
            txtChatContent.Text += user + " : " + txtSendMsg.Text + Environment.NewLine;
            GoodeeDAO.GoodeeDAO DAO = GoodeeDAO.GoodeeDAO.GetInstance();
            DAO.InsertChatContent(user + " : " + txtSendMsg.Text + Environment.NewLine, chatEmail, chat2Email);
            byte[] msg = Encoding.UTF8.GetBytes(txtSendMsg.Text + "$From$" + user + "$FromEmail$" + userEmail + "$To$" + target + "$Name$" + targetName + "$Target$" + "$Msg$");
            ns.Write(msg, 0, msg.Length);
            ns.Flush();
            txtSendMsg.Text = string.Empty;
            txtSendMsg.Focus();
        }

        /// <summary>
        /// 채팅서버로부터 받은 메세지를 처리하는 메서드입니다.
        /// </summary>
        /// <param name="msg"></param>
        internal void GetMsg(string msg)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new GetMsgInvoke(GetMsg), msg);
            }
            else
            {
                txtChatContent.Text += msg;
            }
        }

        /// <summary>
        /// txtChatContent의 내용이 변경될때 txtChatContent 의 스크롤을 가장 아래로 이동시킵니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void txtChatContent_TextChanged(object sender, EventArgs e)
        {
            txtChatContent.Select(0, txtChatContent.TextLength);
            txtChatContent.ScrollToCaret();
        }

        /// <summary>
        /// Enter키를 누르면 btnSendMsg_Click 이벤트를 실행시킵니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void txtSendMsg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(txtSendMsg.Text))
            {
                btnSendMsg_Click(null, null);
            }
        }
    }
}
