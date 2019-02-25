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
        string user;
        string target;
        string targetName;
        TcpClient client;
        Thread msg;
        string readData;
        public FrmChat()
        {
            InitializeComponent();
        }

        public FrmChat(string user, string target, string targetName, string title,  System.Net.Sockets.TcpClient client) : this()
        {
            chatTitle = title;
            this.client = client;
            this.user = user;
            this.target = target;
            this.targetName = targetName;
        }

        private void FrmChat_Load(object sender, EventArgs e)
        {
            this.Text = chatTitle;
            msg = new Thread(GetMassage);
            msg.Start();
        }

        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            NetworkStream ns = client.GetStream();
            textBox1.Text += user + " : " + textBox2.Text + Environment.NewLine;
            byte[] msg = Encoding.UTF8.GetBytes(textBox2.Text + "$From$" + user + "$To$" + target + "$Name$" + targetName + user + target + "$Target$" + "$Msg$");
            ns.Write(msg, 0, msg.Length);
            ns.Flush();
            textBox2.Text = string.Empty;
            textBox2.Focus();
        }

        private void GetMassage()
        {
            while (client.Connected)
            {
                NetworkStream ns = client.GetStream();
                byte[] receiveMsg = new byte[client.ReceiveBufferSize];
                ns.Read(receiveMsg, 0, receiveMsg.Length);
                ns.Flush();
                readData = Encoding.UTF8.GetString(receiveMsg);
                if (readData.Contains(target + user + "$Msg$"))
                {
                    Msg();
                }
            }
            if (!client.Connected)
            {
                client.Close();
                client = null;
            }
        }

        private void Msg()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(Msg));
            }
            else
            {
                textBox1.Text += readData.Replace("$Msg$", "");
                textBox1.Text += Environment.NewLine; 
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSendMsg_Click(null, null);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Select(0, textBox1.TextLength);
            textBox1.ScrollToCaret();
        }
    }
}
