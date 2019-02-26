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
        string manager;
        string student;
        string managetEmail;
        string studentEmail;
        public ChatList()
        {
            InitializeComponent();
        }

        public string Manager { get => manager; set => manager = value; }
        public string Student { get => student; set => student = value; }
        public string ManagetEmail { get => managetEmail; set => managetEmail = value; }
        public string StudentEmail { get => studentEmail; set => studentEmail = value; }

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
