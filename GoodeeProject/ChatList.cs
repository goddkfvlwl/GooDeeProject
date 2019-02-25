using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeProject
{
    public partial class ChatList : UserControl
    {
        public ChatList()
        {
            InitializeComponent();
        }

        private void ChatList_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Parent.Controls)
            {
                item.BackColor = Control.DefaultBackColor;
            }
            this.BackColor = Color.LightGray;
        }

        private void ChatList_DoubleClick(object sender, EventArgs e)
        {
            //FrmChat chat = new FrmChat(this.chatTitle.Text);
            //chat.Show();
        }
    }
}
