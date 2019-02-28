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
    public partial class FrmSelfIntroduce : Form , IFormControl
    {
        private int movePointX;
        private int movePointY;
        public FrmSelfIntroduce()
        {
            InitializeComponent();
        }

        public FrmSelfIntroduce(string title, string body, string option, string date) : this()
        {
            label1.Text = option;
            label2.Text = date;
            tb_Title.Text = title;
            tb_Body.Text = body;

            tb_Title.ReadOnly = true;
            tb_Title.ForeColor = Color.Black;
            tb_Title.BackColor = Color.White;
            tb_Body.ReadOnly = true;
            tb_Body.BackColor = Color.White;
            tb_Body.ForeColor = Color.Black;

        }
        public void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void BtnMinimum_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public void Frm_BorderPaint(object sender, PaintEventArgs e)
        {
            Rectangle borderRectangle = this.ClientRectangle;
            borderRectangle.Inflate(0, 0);
            ControlPaint.DrawBorder(e.Graphics, borderRectangle, Color.DimGray, ButtonBorderStyle.Solid);
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
