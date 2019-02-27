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
        GoodeeDAO.GoodeeDAO gd;

        CtlModifyMemberInfo cm;
        CtlModifyPW cp;

        private string addr;
        private int movePointX;
        private int movePointY;

        public string Addr { get => addr; set => addr = value; }

        public FrmModify()
        {
            InitializeComponent();
            gd = GoodeeDAO.GoodeeDAO.GetInstance();
        }

        private void btnModifyPW_Click(object sender, EventArgs e)
        {
            panel1.Controls.Remove(cm);
            bottomPanel.Visible = true;
            bottomPanel.Width = btnModifyPW.Width;
            bottomPanel.Left = btnModifyPW.Left;

            cp = new CtlModifyPW();
            panel1.Controls.Add(cp);
        }

        private void btnModifyMember_Click(object sender, EventArgs e)
        {
            panel1.Controls.Remove(cp);
            bottomPanel.Visible = true;
            bottomPanel.Width = btnModifyMember.Width;
            bottomPanel.Left = btnModifyMember.Left;

            cm = new CtlModifyMemberInfo();
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

        private void FrmModify_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMain fm = (FrmMain)Owner;
            FrmMain.Mi = gd.SelectMember(FrmMain.Ai.Id);
            fm.ctlProfile1.pboxProFile.Image = FrmMain.Mi.Picture;
            
        }
    }
}
