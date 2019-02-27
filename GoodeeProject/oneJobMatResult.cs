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
using System.Xml.Linq;

namespace GoodeeProject
{
    public partial class oneJobMatResult : UserControl
    {
        public oneJobMatResult()
        {
            InitializeComponent();
        }

        FontFamily comNameFont = new FontFamily("휴먼둥근헤드라인");
        FontFamily keywordFont = new FontFamily("Microsoft Sans Serif");
        string url = "";
        private void oneJobMatResult_Load(object sender, EventArgs e)
        {
            string job_category = "";
            string key = ExtensionXML.Key;

            foreach (FirstSubJob item in JobChoice.Jlistcheck)
            {
                job_category += "&job_category=" + item.Detailjob_Code;
            }


            #region XML파싱
            string strXml = "http://api.saramin.co.kr/job-search?" + job_category;

            XElement xml = strXml.XmlParsing(strXml);   // 루트노드의 자식이 출력될텐데 현재 사람인의 자식은 jobs

            // jobs
            IEnumerable<XElement> jobs = xml.Elements();
            // job
            IEnumerable<XElement> job = jobs.Elements();

            var result = from xe in job.Elements("company")  // name
                         select xe;

            foreach (var item in result)
            {
                url = item.Element("name").Attribute("href").Value;
                companyName.Text = item.Value;
            }

            var result2 = from xe in job.Elements("position")
                          select xe;

            foreach (var item in result2)
            {
                //충남 & ; 아산시
                string location = item.Element("location").Value;
                location = location.Replace("&gt;", " ");

                companyTiltle.Text = item.Element("title").Value;
                companyIntroduce.Text = item.Element("experience-level").Value + " ｜ " + item.Element("required-education-level").Value + " ｜ " + item.Element("job-type").Value + " ｜ " + location;
            }

            #endregion

        }

        private void oneJobMatResult_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(url);
        }
    }
}
