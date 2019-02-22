using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeProject
{
    public partial class FrmCreateID : Form, IFormControl
    {

        private int movePointX;
        private int movePointY;

        public string Addr { get => addr; set => addr = value; }

        private string addr;

        public FrmCreateID()
        {
            InitializeComponent();
            CreateManager();
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

        public void Frm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + (e.X - movePointX), this.Location.Y + (e.Y - movePointY));
            }
        }

        public void Frm_BorderPaint(object sender, PaintEventArgs e)
        {
            Rectangle borderRectangle = this.ClientRectangle;
            borderRectangle.Inflate(0, 0);
            ControlPaint.DrawBorder(e.Graphics, borderRectangle, Color.DimGray, ButtonBorderStyle.Solid);
        }

        private void btn_CreateManager_Click(object sender, EventArgs e)
        {
            CreateManager();
        }

        private void CreateManager()
        {
            panel1.Controls.Clear();
            CtlCreateManager ctl = new CtlCreateManager();
            ctl.Location = new Point(0, 0);
            this.panel1.Controls.Add(ctl);
        }

        private void btn_CreateCom_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            CtlCreateCom ctl = new CtlCreateCom();
            ctl.Location = new Point(0, 0);
            this.panel1.Controls.Add(ctl);
        }
    }
}
