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
    public partial class FrmModify : Form, IFormControl
    {
        private int movePointX;
        private int movePointY;

        public FrmModify()
        {
            InitializeComponent();
        }

        private void btnSurvey_Click(object sender, EventArgs e)
        {
            bottomPanel.Visible = true;
            bottomPanel.Width = btnModifyPW.Width;
            bottomPanel.Left = btnModifyPW.Left;

            CtlModifyPW cp = new CtlModifyPW();
            panel1.Controls.Add(cp);
        }

        private void btnModifyMember_Click(object sender, EventArgs e)
        {
            bottomPanel.Visible = true;
            bottomPanel.Width = btnModifyMember.Width;
            bottomPanel.Left = btnModifyMember.Left;

            CtlModifyMemberInfo cm = new CtlModifyMemberInfo();
            panel1.Controls.Add(cm);
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
    }
}
