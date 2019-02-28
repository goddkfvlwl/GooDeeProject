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
        string chat1;
        string chat2;
        string chat1Email;
        string chat2Email;
        public ChatList()
        {
            InitializeComponent();
        }

        public string Chat1 { get => chat1; set => chat1 = value; }
        public string Chat2 { get => chat2; set => chat2 = value; }
        public string Chat1Email { get => chat1Email; set => chat1Email = value; }
        public string Chat2Email { get => chat2Email; set => chat2Email = value; }

        private void ChatList_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Parent.Controls)
            {
                item.BackColor = Control.DefaultBackColor;
            }
            this.BackColor = Color.LightGray;
        }
    }
}
