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
        private delegate void GetMsgInvoke(string msg);

        public FrmChat()
        {
            InitializeComponent();
        }

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
                target = chatEmail;
                targetName = chat;
            }else
            {
                user = chat;
                target = chat2Email;
                targetName = chat2;
            }
        }

        private void FrmChat_Load(object sender, EventArgs e)
        {
            this.Text = chatTitle;
            InsertChatList();
        }
        /// <summary>
        /// 상담목록을 저장하거나 저장된 상담 목록의 상담내용을 불러오는 메서드입니다.
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

        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            NetworkStream ns = client.GetStream();
            txtChatContent.Text += user + " : " + txtSendMsg.Text + Environment.NewLine;
            GoodeeDAO.GoodeeDAO DAO = GoodeeDAO.GoodeeDAO.GetInstance();
            DAO.InsertChatContent(user + " : " + txtSendMsg.Text + Environment.NewLine, chatEmail, chat2Email);
            byte[] msg = Encoding.UTF8.GetBytes(txtSendMsg.Text + "$From$" + user + "$To$" + target + "$Name$" + targetName + "$Target$" + "$Msg$");
            ns.Write(msg, 0, msg.Length);
            ns.Flush();
            txtSendMsg.Text = string.Empty;
            txtSendMsg.Focus();
        }

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

        private void txtChatContent_TextChanged(object sender, EventArgs e)
        {
            txtChatContent.Select(0, txtChatContent.TextLength);
            txtChatContent.ScrollToCaret();
        }

        private void txtSendMsg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrEmpty(txtSendMsg.Text))
            {
                btnSendMsg_Click(null, null);
            }
        }
    }
}
