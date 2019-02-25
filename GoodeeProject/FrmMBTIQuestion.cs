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
    public partial class FrmMBTIQuestion : Form, IFormControl
    {
        GoodeeDAO.GoodeeDAO gd;
        DataTable question;
        DataTable choice;

        private int movePointX;
        private int movePointY;

        public FrmMBTIQuestion()
        {
            InitializeComponent();
            gd = GoodeeDAO.GoodeeDAO.GetInstance();
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

        private void FrmMBTIQuestion_Load(object sender, EventArgs e)
        {
            flowpanelQuestion.AutoScroll = true;
            
            GetMBTI();
        }

        private void GetMBTI()
        {
            question = gd.SelectMBTI_Question();
            choice = gd.SelectMBTI_Choice();
            List<MBTIChoice> mcList = new List<MBTIChoice>();
            foreach (DataRow item in choice.Rows)
            {
                mcList.Add(new MBTIChoice(Int32.Parse(item[0].ToString()), char.Parse(item[1].ToString()), item[2].ToString(), Int32.Parse(item[3].ToString()), Int32.Parse(item[4].ToString()), char.Parse(item[5].ToString())));
            }
            var resultA = mcList.Where(c => c.Item == 'A')
                .Select(c => mcList);



            CtlMBTIQuestion[] mq = new CtlMBTIQuestion[10];

            for (int i = 0; i < mq.Length; i++)
            {
                mq[i] = new CtlMBTIQuestion();
                flowpanelQuestion.Controls.Add(mq[i]);
                mq[i].lblNum.Text = question.DataSet.Tables[0].Rows[i]["QuestionNum"].ToString() + ". ";
                mq[i].lblQuestion.Text = question.DataSet.Tables[0].Rows[i]["Question"].ToString();

                //mq[i].rdoA.Text = "(" + choice.DataSet.Tables[0].Rows[i]["Item"].ToString() + ") " + choice.DataSet.Tables[0].Rows[i]["ItemDetail"].ToString();
            }
            


        }
    }
}
