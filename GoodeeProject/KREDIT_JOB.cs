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
    public partial class KREDIT_JOB : UserControl
    {
        string keyword = "";
        public KREDIT_JOB()
        {
            InitializeComponent();
            
        }

        Panel panel;
        KREDIT_JOBlist kREDIT_;
        private void JobSearch_Click(object sender, EventArgs e)
        {
            JobSearch.Text = "";
        }

        private void JobSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                keyword.JobKeyword(JobSearch.Text);
                kREDIT_ = new KREDIT_JOBlist();
                kREDIT_.Location = new Point(190, 3);
                panel = (Panel)Parent;
                panel.Controls.Remove(this);
                FrmMain frm = (FrmMain)panel.Parent;
                panel.Controls.Add(kREDIT_);
            }
        }

        private void JobSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                keyword.JobKeyword(JobSearch.Text);
            }
        }
    }
}
