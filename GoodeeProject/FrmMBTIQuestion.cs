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
        Dictionary<int, string> mbtiDic;
        Dictionary<char, int> tendency;
        List<CtlMBTIQuestion> mqList = new List<CtlMBTIQuestion>();
        GoodeeDAO.GoodeeDAO gd;
        DataTable question;
        DataTable choice;
        string mbtiResult;

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
            CtlMBTIDivide md = new CtlMBTIDivide();
            flowpanelQuestion.Controls.Add(md);
            md.lblDivide.Text = "제 1부 : 자신에게 자연스럽고, 습관처럼 편안하게 느껴지고, 자주 행동하는 경향과 \n 가깝다고 생각되는 것을 선택하여 답안지에 표시하십시오.";
            flowpanelQuestion.AutoScroll = true;
            question = gd.SelectMBTI_Question();
            choice = gd.SelectMBTI_Choice();
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
                mq.lblNum.Text = question.DataSet.Tables[0].Rows[i]["QuestionNum"].ToString() + ". ";
                mq.lblQuestion.Text = question.DataSet.Tables[0].Rows[i]["Question"].ToString();

                mq.rdoA.Text = "(" + aList[i].Item + ") " + aList[i].ItemDetail.ToString();
                mq.rdoB.Text = "(" + bList[i].Item + ") " + bList[i].ItemDetail.ToString();
                mq.rdoA.Tag = new KeyValuePair<int, string>(aList[i].QuestionNum, "A");
                mq.rdoB.Tag = new KeyValuePair<int, string>(bList[i].QuestionNum, "B");

                if (mq.rdoA.Width + mq.rdoB.Width > mq.flowpanelChoice.Width)
                {
                    mq.flowpanelChoice.Size = new Size(750, 50);

                    mq.Size = new Size(771, 82);
                }
                
                foreach (var item in cList)
                {
                    RadioButton rdoC = new RadioButton();
                    if (mq.lblNum.Text == item.QuestionNum.ToString() + ". ")
                    {
                        if (item.QuestionNum != 24)
                        {

                            mq.flowpanelChoice.Size = new Size(750, 80);
                            mq.Size = new Size(771, 108);
                            rdoC.Name = "rdoC";
                            rdoC.AutoSize = true;
                            rdoC.Text = "(" + item.Item + ") " + item.ItemDetail;
                            rdoC.Tag = new KeyValuePair<int, string>(item.QuestionNum, "C");
                            mq.flowpanelChoice.Controls.Add(rdoC); 
                        }
                        else
                        {
                            CheckBox cbA = new CheckBox();
                            CheckBox cbB = new CheckBox();
                            CheckBox cbC = new CheckBox();

                            cbA.Name = "cbA";
                            cbB.Name = "cbB";
                            cbC.Name = "cbC";

                            cbA.Tag = new KeyValuePair<int, string>(item.QuestionNum, "A");
                            cbB.Tag = new KeyValuePair<int, string>(item.QuestionNum, "B");
                            cbC.Tag = new KeyValuePair<int, string>(item.QuestionNum, "C");

                            mq.flowpanelChoice.Size = new Size(750, 80);
                            mq.Size = new Size(771, 108);

                            mq.flowpanelChoice.Controls.Add(cbA);
                            mq.flowpanelChoice.Controls.Add(cbB);
                            mq.flowpanelChoice.Controls.Add(cbC);
                            cbA.AutoSize = true;
                            cbB.AutoSize = true;
                            cbC.AutoSize = true;

                            cbA.Text = mq.rdoA.Text;
                            cbB.Text = mq.rdoB.Text;
                            cbC.Text = "(" + item.Item + ") " + item.ItemDetail;

                            mq.flowpanelChoice.Controls.RemoveByKey("rdoA");
                            mq.flowpanelChoice.Controls.RemoveByKey("rdoB");
                            //mq.flowpanelChoice.Controls.RemoveByKey("rdoC");
                            rdoC.Visible = false;
                        }
                    }
                    
                }

                mqList.Add(mq);
                flowpanelQuestion.Controls.Add(mq);

                if (i == 29)
                {
                    CtlMBTIDivide md = new CtlMBTIDivide();
                    flowpanelQuestion.Controls.Add(md);
                    md.lblDivide.Text = "    제 2부 : 두 개의 낱말이 있는 문항에서는 자신에게 더 가깝다고 생각되는 말을 \n 선택하여 답안지에 표시하십시오.";
                }
            }

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            mbtiDic = new Dictionary<int, string>();

            foreach (var item in mqList)
            {
                if (item.flowpanelChoice.Controls.ContainsKey("cbA"))
                {
                    string value = "";
                    CheckBox cbA = (CheckBox)item.flowpanelChoice.Controls["cbA"];
                    CheckBox cbB = (CheckBox)item.flowpanelChoice.Controls["cbB"];
                    CheckBox cbC = (CheckBox)item.flowpanelChoice.Controls["cbC"];
                    KeyValuePair<int, string> tempA = (KeyValuePair<int, string>)cbA.Tag;
                    KeyValuePair<int, string> tempB = (KeyValuePair<int, string>)cbB.Tag;
                    KeyValuePair<int, string> tempC = (KeyValuePair<int, string>)cbC.Tag;
                    if (cbA.Checked)
                    {
                        value += tempA.Value.ToString() + ",";
                    }
                    if (cbB.Checked)
                    {
                        value += tempB.Value.ToString() + ",";
                    }
                    if (cbC.Checked)
                    {
                        value += tempC.Value.ToString() + ",";
                    }

                    if (value.Length != 0)
                    {
                        value = value.Remove(value.Length - 1, 1); 
                    }
                    mbtiDic.Add(tempA.Key, value);
                }

                if (item.rdoA.Checked)
                {
                    KeyValuePair<int, string> temp = (KeyValuePair<int, string>)item.rdoA.Tag;
                    mbtiDic.Add(temp.Key, temp.Value);
                }
                if (item.rdoB.Checked)
                {
                    KeyValuePair<int, string> temp = (KeyValuePair<int, string>)item.rdoB.Tag;
                    mbtiDic.Add(temp.Key, temp.Value);
                }
                if (item.flowpanelChoice.Controls.ContainsKey("rdoC"))
                {
                    RadioButton rdoC = (RadioButton)item.flowpanelChoice.Controls["rdoC"];
                    if (rdoC.Checked)
                    {
                        KeyValuePair<int, string> temp = (KeyValuePair<int, string>)rdoC.Tag;
                        mbtiDic.Add(temp.Key, temp.Value);
                    }
                }
            }
            MBTI_Calculator();

        }

        public void MBTI_Calculator()
        {
            tendency = new Dictionary<char, int>();
            char[] temp = { 'E', 'I', 'S', 'N', 'T', 'F', 'J', 'P' };
            foreach (var item in temp)
            {
                tendency.Add(item, 0);
            }

            foreach (DataRow item in choice.Rows)
            {
                if (FrmMain.Mi.Gender == 'F' || FrmMain.Mi.Gender == 'f')
                {
                    foreach (var item2 in mbtiDic)
                    {
                        if ((Int32.Parse(item["QuestionNum"].ToString().Trim()) == item2.Key) && (item["Item"].ToString().Trim() == item2.Value))
                        {
                            tendency[item["Detail_Tendency"].ToString()[0]] += Int32.Parse(item["FeMale_Score"].ToString().Trim());
                        }
                    }
                }
                if (FrmMain.Mi.Gender == 'M' || FrmMain.Mi.Gender == 'm')
                {
                    foreach (var item2 in mbtiDic)
                    {
                        if ((Int32.Parse(item["QuestionNum"].ToString().Trim()) == item2.Key) && (item["Item"].ToString().Trim() == item2.Value))
                        {
                            tendency[item["Detail_Tendency"].ToString()[0]] += Int32.Parse(item["Male_Score"].ToString().Trim());
                        }
                    }
                }
            }

            int ei = ChangeScore(tendency['E'], tendency['I']);
            int ns = ChangeScore(tendency['N'], tendency['S']);
            int ft = ChangeScore(tendency['F'], tendency['T']);
            int pj = ChangeScore(tendency['P'], tendency['J']);

            if (gd.InsertMBTI_Stats(FrmMain.Mi.Id, ei, ns, ft, pj, GetResult(), DateTime.Today))
            {
                FrmMain fm = new FrmMain();
                CtlMBTIResult mr = new CtlMBTIResult();
                fm.panel2.Controls.Add(mr);
                mr.Location = new Point(185, 0);
                MessageBox.Show("제출 완료");
                this.Close();
            }
            else
            {
                MessageBox.Show("제출을 실패했습니다.\n잠시후 다시 시도해주세요.");
            }
        }

        private int ChangeScore(int a, int b)
        {
            int result = 0;

            if (a == b)
            {
                result = 1;
            }
            else if (a > b)
            {
                result = (a - b) * 2 + 1;
            }
            else
            {
                result = (b - a) * 2 - 1;
            }

            return result;
        }

        private string GetResult()
        {
            string temp = "";

            if (tendency['E'] < tendency['I'])
            {
                temp = "I";
            }
            else
            {
                temp = "E";
            }

            if (tendency['S'] > tendency['N'])
            {
                temp += "S";
            }
            else
            {
                temp += "N";
            }

            if (tendency['T'] > tendency['F'])
            {
                temp += "T";
            }
            else
            {
                temp += "F";
            }

            if (tendency['J'] > tendency['P'])
            {
                temp += "J";
            }
            else
            {
                temp += "P";
            }

            return temp;
        }
    }
}