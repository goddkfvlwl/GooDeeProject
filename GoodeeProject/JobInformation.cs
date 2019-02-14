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

        private void button1_Click(object sender, EventArgs e)
        {

            //Panel panel = (Panel)Parent;
            //panel.Controls.Remove(this);
            //FrmMain frm = (FrmMain)panel.Parent;
            //jobMatResult jobMat = new jobMatResult();
            //jobMat.Location = new Point(190, 3);
            //panel.Controls.Add(jobMat);


            #region XML읽기
            //string loc_cd = "";
            //foreach (FirstSubArea item in JobAreaChoice.Lst)
            //{
            //    //MessageBox.Show(item.SubAreaCode);
            //    loc_cd += "loc_cd=" + item.SubAreaCode;
            //}

            //// 강동구
            //// http://api.saramin.co.kr/job-search?loc_cd=101020

            //string strXml = "http://api.saramin.co.kr/job-search?" + loc_cd;
            //Uri url = new Uri(strXml);
            //HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            //HttpWebResponse ress = request.GetResponse() as HttpWebResponse;
            //Stream stream = ress.GetResponseStream();

            //XmlDocument xml = new XmlDocument(); // XmlDocument 생성
            //xml.Load(stream);

            //XmlNodeList list = xml.DocumentElement.SelectNodes("//company");
            //foreach (XmlNode item in list)
            //{
            //    MessageBox.Show(item.SelectSingleNode("name").InnerText);
            //} 
            #endregion

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
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RemoveControl();
            FlowLayoutPanel panel = new FlowLayoutPanel();
            oneJobMatResult oneJobMat = new oneJobMatResult();
            panel.Parent = this;
            panel.Size = new Size(730, 342);
            panel.Location = new Point(43, 91);
            panel.Controls.Add(oneJobMat);
            panel.VerticalScroll.Visible = true;    // 패널에 스크롤 생성

        }
    }
}
