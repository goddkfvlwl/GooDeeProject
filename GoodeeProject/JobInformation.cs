using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Net;
using System.IO;

namespace GoodeeProject
{
    public partial class JobInformation : UserControl
    {
        List<XmlSaramin> slist = new List<XmlSaramin>();

        JobAreaChoice choice;
        JobChoice achoice;
        oneJobMatResult oneJobMat;
        FlowLayoutPanel panel;
        string search = "";
        public JobInformation()
        {
            InitializeComponent();
        }

        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {
            RemoveControl();
            choice = new JobAreaChoice();
            choice.Location = new Point(38, 111);
            choice.Parent = this;
            
        }


        private void iTalk_Button_13_Click(object sender, EventArgs e)
        {
            RemoveControl();
            achoice = new JobChoice();
            achoice.Location = new Point(38, 111);
            achoice.Parent = this;

        }

        public void RemoveControl()
        {
            this.Controls.Remove(choice);
            this.Controls.Remove(achoice);
            this.Controls.Remove(panel);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(jobSearch.Text) && jobSearch.Text != "기업을 입력하세요")
            {
                search.JobKeyword(jobSearch.Text);
            }
            else if ((!String.IsNullOrEmpty(jobSearch.Text) && jobSearch.Text == "기업을 입력하세요") || JobAreaChoice.CheckResultlist.Count == 0 || JobChoice.Jlistcheck.Count == 0)
            {
                MessageBox.Show("검색어가 없습니다.");
            }

            RemoveControl();

            //foreach (var item in JobAreaChoice.CheckResultlist)
            //{
            //    MessageBox.Show("2차 지역 코드 : "+item.SubAreaCode);
            //}
            //foreach (var item in JobChoice.Jlistcheck)
            //{
            //    MessageBox.Show("3차지역코드 :"+item.Detailjob_Code);
            //}

            //string url = "http://api.saramin.co.kr/job-search?keywords="+ExtensionXML.Key+ "&job_category=" + JobChoice.Jlistcheck+"&";
            //XElement xml = url.XmlParsing(url);

            panel = new FlowLayoutPanel();
            oneJobMat = new oneJobMatResult();
            panel.Parent = this;
            panel.Size = new Size(845, 401);
            panel.Location = new Point(39, 141);
            panel.Controls.Add(oneJobMat);
            panel.VerticalScroll.Visible = true;    // 패널에 스크롤 생성 
            //foreach (var item in collection)
            //{
            //    FlowLayoutPanel panel = new FlowLayoutPanel();
            //    oneJobMatResult oneJobMat = new oneJobMatResult();
            //    panel.Parent = this;
            //    panel.Size = new Size(845, 401);
            //    panel.Location = new Point(39, 141);
            //    panel.Controls.Add(oneJobMat);
            //    panel.VerticalScroll.Visible = true;    // 패널에 스크롤 생성 

            //}
        }

        private void jobSearch_Click(object sender, EventArgs e)
        {
            jobSearch.Text = " ";
        }
    }
}
