using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeProject
{
    public partial class FrmLogin : Form, IFormControl
    {
        private int movePointX;
        private int movePointY;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            movePointX = e.X;
            movePointY = e.Y;
        }

        private void FrmLogin_MouseMove(object sender, MouseEventArgs e)
        {

        }

        //private void btnExit_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}

        //private void btnMinimum_Click(object sender, EventArgs e)
        //{
        //    WindowState = FormWindowState.Minimized;
        //}

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmMain fr = new FrmMain();
            fr.Show();
            this.Visible = false;
        }

        private void btnFindPW_Click(object sender, EventArgs e)
        {
            FrmSendEmail fs = new FrmSendEmail();
            fs.Show();
        }


        public void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void BtnMinimum_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public void Frm_MouseDown(object sender, MouseEventArgs e)
        {
            movePointX = e.X;
            movePointY = e.Y;
        }

        public void Frm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + (e.X - movePointX), this.Location.Y + (e.Y - movePointY));
            }
        }
    }
}
