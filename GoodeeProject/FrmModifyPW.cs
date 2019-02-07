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
    public partial class FrmModifyPW : Form, IFormControl
    {
        private int movePointX;
        private int movePointY;
        private string email;
        public string Email { get { return email; } set { email = value; } }
        public FrmModifyPW()
        {
            InitializeComponent();
            Frm_DrawLine();
            FrmSendEmail frm = (FrmSendEmail)Owner;
            email = frm.Email;
        }

        public void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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

        public void Frm_DrawLine()
        {
            Graphics graphics = CreateGraphics();
            graphics.DrawRectangle(new Pen(Color.Red), new Rectangle(new Point(1, 1), new Size(this.Width-1, this.Height-1)));
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
