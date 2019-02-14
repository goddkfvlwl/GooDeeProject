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
using System.IO;
using System.Net;

namespace GoodeeProject
{
    public partial class oneJobMatResult : UserControl
    {
        public oneJobMatResult()
        {
            InitializeComponent();
        }

        FontFamily comNameFont = new FontFamily("휴먼둥근헤드라인");
        FontFamily keywordFont = new FontFamily("함초롬돋움");
        string attribute = "";
        private void oneJobMatResult_Load(object sender, EventArgs e)
        {
            string job_category = "";

            foreach (FirstSubJob item in JobChoice.Jlistcheck)
            {
               job_category += "&job_category=" + item.Detailjob_Code;
            }
            
            #region XML파싱
            string strXml = "http://api.saramin.co.kr/job-search?" + job_category;
            MessageBox.Show(strXml);
            Uri url = new Uri(strXml);
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            HttpWebResponse ress = request.GetResponse() as HttpWebResponse;
            Stream stream = ress.GetResponseStream();

            XmlDocument xml = new XmlDocument(); // XmlDocument 생성
            xml.Load(stream);

            XmlNodeList list = xml.DocumentElement.SelectNodes("//company");
            foreach (XmlNode item in list)
            {
                companyName.Text = item.SelectSingleNode("name").InnerText;
                companyName.Font = new Font(comNameFont, 10f);
            }

            XmlNodeList title = xml.DocumentElement.SelectNodes("//position");
            foreach (XmlNode item in title)
            {
                companyTiltle.Text = item.SelectSingleNode("title").InnerText;
                companyIntroduce.Text = item.SelectSingleNode("experience-level").InnerText + "  /  " + item.SelectSingleNode("required-education-level").InnerText + "  /  " + item.SelectSingleNode("job-type").InnerText;
            }

            XmlNodeList job = xml.DocumentElement.SelectNodes("//job");
            foreach (XmlNode item in job)
            {
                keword.Text = "[키워드] " + item.SelectSingleNode("keyword").InnerText;
                keword.Font = new Font(keywordFont, 8f);
            } 
            #endregion

        }

        private void companyName_Click(object sender, EventArgs e)
        {
            
        }
    }
}
