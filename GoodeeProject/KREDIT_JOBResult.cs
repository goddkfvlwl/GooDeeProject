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
    public partial class KREDIT_JOBResult : UserControl
    {
        KREDIT_JOBResult kREDIT_;
        Panel panel;
        string keyword = " ";

        public KREDIT_JOBResult()
        {
            InitializeComponent();
        }

        private void jobSearch_Click(object sender, EventArgs e)
        {
            jobSearch.Text = " ";
        }
        
        private void jobSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                keyword.JobKeyword(jobSearch.Text);

                panel = (Panel)Parent;
                FrmMain frm = (FrmMain)panel.Parent;
                panel.Controls.Remove(this);

                kREDIT_ = new KREDIT_JOBResult();
                kREDIT_.Location = new Point(190, 3);
                
                
                
                //panel.Controls.Add(kREDIT_);

            }
        }

        private void jobSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                keyword.JobKeyword(jobSearch.Text);

                kREDIT_ = new KREDIT_JOBResult();
                kREDIT_.Location = new Point(190, 3);
                panel = (Panel)Parent;
                panel.Controls.Remove(this);
                FrmMain frm = (FrmMain)panel.Parent;
                panel.Controls.Add(kREDIT_);

            }
        }
    }
}
