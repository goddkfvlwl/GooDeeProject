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

namespace GoodeeProject
{
    public partial class JobInformation : UserControl
    {
        
        public JobInformation()
        {
            InitializeComponent();
        }

        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {
            JobAreaChoice choice = new JobAreaChoice();
            choice.Location = new Point(38, 111);
            choice.Parent = this;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loc_cd = "";
            foreach (FirstSubArea item in JobAreaChoice.Lst)
            {
                MessageBox.Show(item.SubAreaCode);
                loc_cd += "loc_cd=" + item.SubAreaCode;
            }


            //MessageBox.Show(loc_cd);

            //string strXml = "http://api.saramin.co.kr/job-search?";
            //XmlDocument xml = new XmlDocument(); // XmlDocument 생성
            //xml.LoadXml(strXml);
            //XmlNodeList xnList = xml.GetElementsByTagName("item"); //접근할 노드

            //foreach (XmlNode xn in xnList)
            //{
            //    string address = xn["address"].InnerText;
            //    string lat = xn["point"]["x"].InnerText;
            //    string lng = xn["point"]["y"].InnerText;
            //}


        }
    }
}
