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
    public partial class FrmMBTIResult : Form, IFormControl
    {
        GoodeeDAO.GoodeeDAO gd;
        DataTable result;
        DataTable resultDetail;
        private int movePointX;
        private int movePointY;

        public FrmMBTIResult()
        {
            InitializeComponent();
            gd = GoodeeDAO.GoodeeDAO.GetInstance();
        }

        public FrmMBTIResult(DataTable result) : this()
        {
            this.result = result;
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

        private void panelChnageScInfo_Paint(object sender, PaintEventArgs e)
        {
            Rectangle borderRectangle = panelChnageScInfo.ClientRectangle;
            borderRectangle.Inflate(0, 0);
            ControlPaint.DrawBorder(e.Graphics, borderRectangle, Color.DimGray, ButtonBorderStyle.Solid);
        }

        private void FrmMBTIResult_Load(object sender, EventArgs e)
        {
            resultDetail = gd.SelectMBTI_Detail(result.DataSet.Tables[0].Rows[0]["Result"].ToString());
            lblResult.Text = result.DataSet.Tables[0].Rows[0]["Result"] + "형 (" + resultDetail.DataSet.Tables[0].Rows[0]["Tendency"].ToString() + ")";
            lblresultDetail.Text = resultDetail.DataSet.Tables[0].Rows[0]["Detail"].ToString();

            lblNickname.Text = resultDetail.DataSet.Tables[0].Rows[0]["Nickname"].ToString();
            lblChar.Text = resultDetail.DataSet.Tables[0].Rows[0]["Character"].ToString();
            lblCelebrity.Text = resultDetail.DataSet.Tables[0].Rows[0]["Celebrity"].ToString();
            
            lblEI.Text += " : " + result.DataSet.Tables[0].Rows[0]["E,I Score"].ToString();
            lblSN.Text += " : " + result.DataSet.Tables[0].Rows[0]["S,N Score"].ToString();
            lblTF.Text += " : " + result.DataSet.Tables[0].Rows[0]["T,F Score"].ToString();
            lblJP.Text += " : " + result.DataSet.Tables[0].Rows[0]["J,P Score"].ToString();

            string id = result.DataSet.Tables[0].Columns["id"].ToString();


        }

        
    }
}
