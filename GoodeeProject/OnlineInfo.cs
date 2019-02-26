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
    public partial class OnlineInfo : UserControl
    {
        private string id;
        public OnlineInfo()
        {
            InitializeComponent();
        }

        public string Id { get => id; set => id = value; }

        private void OnlineInfo_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Parent.Controls)
            {
                item.BackColor = Control.DefaultBackColor;
            }
            this.BackColor = Color.LightGray;
        }

        private void OnlineInfo_DoubleClick(object sender, EventArgs e)
        {
        }

        private void OnlineInfo_ControlRemoved(object sender, ControlEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
