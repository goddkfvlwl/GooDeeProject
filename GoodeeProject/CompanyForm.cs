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
    public partial class CompanyForm : Form, IFormControl
    {
        private int movePointX;
        private int movePointY;
        public CompanyForm()
        {
            InitializeComponent();
        }

        #region 인터페이스
        public void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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


        #endregion

        private void CompanyForm_Load(object sender, EventArgs e)
        {
            ctlProfile1.btnStudent.Visible = false;
            ctlProfile1.btnLog.Visible = false;
            ctlProfile1.btnModify.Visible = false;
            ctlProfile1.btnCreateID.Visible = false;
            
            ctlProfile1.lblName.Text = CompanyMainForm.Mi.Name;
            ctlProfile1.lblEmailID.Text = CompanyMainForm.Mi.Id;
        }

        private void btnSpec_Click(object sender, EventArgs e)
        {
            CtlIntroductionListM introductionList = new CtlIntroductionListM();
            introductionList.Location = new Point(20, 3);
            panel2.Controls.Add(introductionList);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
