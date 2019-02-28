using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeProject
{
    public partial class CtlIntroductionListM : UserControl
    {
        GoodeeDAO.GoodeeDAO goodee;
        public CtlIntroductionListM()
        {
            InitializeComponent();
            goodee = GoodeeDAO.GoodeeDAO.GetInstance();
            List<Control> controls = GetClass();
            int i= 0;
            flpSList.FlowDirection = FlowDirection.TopDown;

            foreach (CtlNameListItem item in controls)
            {
                FlowLayoutPanel fs = new FlowLayoutPanel();
                fs.Margin = new Padding(0, 0, 0, 0);
                fs.Size = new Size(240, 26);
                fs.Controls.Add(item);
                flpSList.Controls.Add(fs);
                //flpSList.Controls.SetChildIndex(fs, item.TabIndex);
                flpSList.Invalidate();
            }
        }

        private List<Control> GetClass()
        {
            DataTable dt = goodee.SelectAllClass();

            List<Control> controls = new List<Control>();
            foreach (DataRow item in dt.Rows)
            {
                if (item["Curriculum"].ToString().Trim() == "Manager")
                {
                    continue;
                }
                CtlNameListItem ctl = new CtlNameListItem();
                if (item["Curriculum"].ToString().Contains(' '))
                {
                    ctl.label1.Text = item["Curriculum"].ToString().Substring(0, item["Curriculum"].ToString().IndexOf(' ')) + " " + item["Turn"].ToString();
                }
                else
                {
                    ctl.label1.Text = item["Curriculum"].ToString() + " " + item["Turn"].ToString();
                }
                ctl.label1.Tag = Int32.Parse(item["ClassNum"].ToString().Trim());
                ctl.panel1.BackgroundImage = Properties.Resources.plus;
                ctl.panel1.Tag = "plus";
                ctl.BackColor = Color.Gainsboro;
                ctl.panel1.Click += Ctl_Click;
                controls.Add(ctl);
            }
            return controls;
        }

        private void Ctl_Click(object sender, EventArgs e)
        {
            Panel control = (Panel)sender;
            CtlNameListItem ctl = (CtlNameListItem)control.Parent;
            FlowLayoutPanel fs = (FlowLayoutPanel)ctl.Parent;
            if (control.Tag.ToString() == "plus")
            {
                DataTable dt = goodee.SelectMemberInfoINClassNum((int)ctl.label1.Tag);
                int i = 1;

                foreach (DataRow item in dt.Rows)
                {
                    CtlNameListItem stu = new CtlNameListItem();
                    stu.label1.Text = item["Name"].ToString();
                    stu.label1.Click += Stu_Click;
                    stu.label1.Tag = item["ID"].ToString();

                    stu.Controls.RemoveByKey("panel1");
                    stu.Tag = item["ID"].ToString();

                    stu.Click += Stu_Click;

                    fs.Controls.Add(stu);
                    fs.Size = new Size(240, fs.Controls.Count * 26);
                    i++;
                }
                flpSList.Invalidate();
                ctl.panel1.BackgroundImage = Properties.Resources.minus;
                ctl.panel1.Tag = "minus";
            }
            else
            {
                for (int i = 1; i < fs.Controls.Count; i++)
                {
                    fs.Controls.RemoveAt(i);
                }
                if (fs.Controls.Count>1)
                {
                    fs.Controls.RemoveAt(1);
                }
                fs.Size = new Size(240, fs.Controls.Count * 26);

                ctl.panel1.BackgroundImage = Properties.Resources.plus;
                ctl.panel1.Tag = "plus";
            }
        }

        private void Stu_Click(object sender, EventArgs e)
        {
            Control stu = (Control)sender;
            
            flpIntroductionList.Controls.Clear();
            DataTable introductionList = goodee.SelectSelfIntroduction(stu.Tag.ToString());
            if (introductionList.Rows.Count != 0)
            {
                foreach (DataRow item in introductionList.Rows)
                {
                    CtlIntroductionMItem introductionitem = new CtlIntroductionMItem();
                    introductionitem.lbl_Title.Text = item["Title"].ToString();
                    //introductionitem.lbl_Body.Text = item["Body"].ToString();
                    introductionitem.lbl_Body.Text = item["Body"].ToString().Length > 20 ? item["Body"].ToString().Remove(20) : item["Body"].ToString();
                    DateTime dt = (DateTime)item["WriteDate"];
                    introductionitem.lbl_Date.Text = dt.ToLongDateString();
                    introductionitem.name = stu.Tag.ToString();
                    flpIntroductionList.Controls.Add(introductionitem);
                }
            }
            else
            {
                CtlIntroductionMItem introductionitem = new CtlIntroductionMItem();
                introductionitem.lbl_Title.Text = "등록된 자기소개서가 없습니다.";
                introductionitem.lbl_Body.Text = "새로운 자기소개서를 등록해주세요.";
                introductionitem.lbl_Date.Text = "";
                introductionitem.DoubleClick -= introductionitem.CtlSelfIntroductionItem_DoubleClick;
                flpIntroductionList.Controls.Add(introductionitem);
            }
        }
    }
}
