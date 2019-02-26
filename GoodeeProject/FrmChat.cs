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
        string manager;
        string student;
        string studentEmail;
        string managerEmail;
        string user;
        string target;
        string targetName;
        TcpClient client;
        Thread msg;
        string readData;

        public string ChatTitle { get => chatTitle; set => chatTitle = value; }
        public string Manager { get => manager; set => manager = value; }
        public string Student { get => student; set => student = value; }
        public string StudentEmail { get => studentEmail; set => studentEmail = value; }
        public string ManagerEmail { get => managerEmail; set => managerEmail = value; }
        public string User { get => user; set => user = value; }
        public string Target { get => target; set => target = value; }
        public string TargetName { get => targetName; set => targetName = value; }
        private delegate void GetMsgInvoke(string msg);
        public FrmChat()
        {
            InitializeComponent();
        }
        public FrmChat(string manager, string managerEmail, string student, string studentEmail, string title,  System.Net.Sockets.TcpClient client) : this()
        {
            chatTitle = title;
            this.client = client;
            this.manager = manager;
            this.student = student;
            this.studentEmail = studentEmail;
            this.managerEmail = managerEmail;
            if (FrmMain.Authority == 'S')
            {
                user = student;
                target = managerEmail;
                targetName = manager;
            }else
            {
                user = manager;
                target = studentEmail;
                targetName = student;
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
            GoodeeDAO.GoodeeDAO DAO = GoodeeDAO.GoodeeDAO.getInstance();
            DAO.InsertChat(managerEmail + studentEmail, managerEmail, studentEmail, manager, student);
            DataTable content = DAO.SelectChatContent(managerEmail + studentEmail);
            if (content.Rows.Count > 0)
            {
                foreach (DataRow item in content.Rows)
                {
                    txtChatContent.Text += item["Content"].ToString();
                }
            }
            txtChatContent.Select(0, txtChatContent.TextLength);
            txtChatContent.ScrollToCaret();
        }

        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            NetworkStream ns = client.GetStream();
            txtChatContent.Text += user + " : " + txtSendMsg.Text + Environment.NewLine;
            GoodeeDAO.GoodeeDAO DAO = GoodeeDAO.GoodeeDAO.getInstance();
            DAO.InsertChatContent(managerEmail + studentEmail, user + " : " + txtSendMsg.Text + Environment.NewLine);
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
