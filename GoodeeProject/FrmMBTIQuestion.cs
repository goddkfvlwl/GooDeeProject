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
            List<MBTIChoice> aList = new List<MBTIChoice>();
            List<MBTIChoice> bList = new List<MBTIChoice>();
            List<MBTIChoice> cList = new List<MBTIChoice>();

            foreach (DataRow item in choice.Rows)
            {
                if (item["item"].ToString().Trim() == "A")
                {
                    aList.Add(new MBTIChoice(Int32.Parse(item["QuestionNum"].ToString()), char.Parse(item["Item"].ToString().Trim()), item["ItemDetail"].ToString(), Int32.Parse(item["FeMale_Score"].ToString()), Int32.Parse(item["Male_Score"].ToString()), char.Parse(item["Detail_Tendency"].ToString().Trim())));
                }
                if (item["item"].ToString().Trim() == "B")
                {
                    bList.Add(new MBTIChoice(Int32.Parse(item["QuestionNum"].ToString()), char.Parse(item["Item"].ToString().Trim()), item["ItemDetail"].ToString(), Int32.Parse(item["FeMale_Score"].ToString()), Int32.Parse(item["Male_Score"].ToString()), char.Parse(item["Detail_Tendency"].ToString().Trim())));
                }
                if (item["item"].ToString().Trim() == "C")
                {
                    cList.Add(new MBTIChoice(Int32.Parse(item["QuestionNum"].ToString()), char.Parse(item["Item"].ToString().Trim()), item["ItemDetail"].ToString(), Int32.Parse(item["FeMale_Score"].ToString()), Int32.Parse(item["Male_Score"].ToString()), char.Parse(item["Detail_Tendency"].ToString().Trim())));
                }
            }

            for (int i = 0; i < aList.Count; i++)
            {
                CtlMBTIQuestion mq = new CtlMBTIQuestion();
                mq.flowpanelChoice.FlowDirection = FlowDirection.TopDown;
                mq.flowpanelChoice.Controls.SetChildIndex(mq.rdoA, 0);
                mq.flowpanelChoice.Controls.SetChildIndex(mq.rdoB, 1);
                mq.lblNum.Text = question.DataSet.Tables[0].Rows[i]["QuestionNum"].ToString() + ". ";
                mq.lblQuestion.Text = question.DataSet.Tables[0].Rows[i]["Question"].ToString();

                if (mq.rdoB.Location.X + mq.rdoB.Size.Width > mq.flowpanelChoice.Width)
                {
                    mq.flowpanelChoice.Size = new Size(750, 40);

                    mq.Size = new Size(771, 82);
                    mq.flowpanelChoice.Refresh();
                }

                foreach (var item in cList)
                {
                    if (mq.lblNum.Text == item.QuestionNum.ToString() + ". ")
                    {
                        mq.flowpanelChoice.Size = new Size(750, 60);

                        mq.Size = new Size(771, 102);
                        RadioButton rdoC = new RadioButton();
                        rdoC.AutoSize = true;
                        rdoC.Text = "(" + item.Item + ") " + item.ItemDetail.ToString();
                        mq.flowpanelChoice.Controls.Add(rdoC);
                        mq.flowpanelChoice.Controls.SetChildIndex(rdoC, mq.flowpanelChoice.Controls.Count);
                        mq.flowpanelChoice.Refresh();
                    }
                }


                mq.rdoA.Text = "(" + aList[i].Item + ") " + aList[i].ItemDetail.ToString();
                mq.rdoB.Text = "(" + bList[i].Item + ") " + bList[i].ItemDetail.ToString();
                flowpanelQuestion.Controls.Add(mq);
                //if (i == 23)
                //{
                //    CheckBox cbA = new CheckBox();
                //    CheckBox cbB = new CheckBox();
                //    CheckBox cbC = new CheckBox();

                //    mq.flowpanelChoice.Controls.Add(cbA);
                //    mq.flowpanelChoice.Controls.Add(cbB);
                //    mq.flowpanelChoice.Controls.Add(cbC);
                //    cbA.Text = mq.rdoA.Text;
                //    cbB.Text = mq.rdoB.Text;
                //    cbC.Text = "";
                //    mq.flowpanelChoice.Controls.RemoveByKey("rdoA");
                //    mq.flowpanelChoice.Controls.RemoveByKey("rdoB");
                //}

                if (i == 29)
                {
                    CtlMBTIDivde md = new CtlMBTIDivde();
                    flowpanelQuestion.Controls.Add(md);
                    md.lblDivide.Text = "    제 2부 : 두 개의 낱말이 있는 문항에서는 자신에게 더 가깝다고 생각되는 말을 \n 선택하여 답안지에 표시하십시오.";
                }
            }

        }
    }
}
