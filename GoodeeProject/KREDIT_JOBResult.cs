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


namespace GoodeeProject
{
    public partial class KREDIT_JOBResult : UserControl
    {
        KREDIT_JOBResult kREDIT_;
        Panel panel;
        
        string keyword = " ";
        string serviceKey = "xHuTDf0%2FQp0HDzRAEV4eJFw%2F8hAJu7mZ8oFyqowX7jn6I56Au1cimmwHtweVDfYznMmcv6cXg%2BnXwmnOtHQ%2FOw%3D%3D";
        int pageNo = 1; // 페이지 넘버
        int numOfCount = 10;    // 한 페이지당 출력할 개수
        int totalCount = 0;  // 데이터 총 개수
        string seq = "";
        public KREDIT_JOBResult()
        {
            InitializeComponent();
        }

        private void jobSearch_Click(object sender, EventArgs e)
        {
            //jobSearch.Text = " ";
        }
        
        private void jobSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                keyword.JobKeyword(jobSearch.Text);
                
            }
        }

        private void jobSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                keyword.JobKeyword(jobSearch.Text);

                kREDIT_ = new KREDIT_JOBResult();
                kREDIT_.Location = new Point(190, 3);
                panel = (Panel)Parent;
                panel.Controls.Remove(this);
                FrmMain frm = (FrmMain)panel.Parent;
                panel.Controls.Add(kREDIT_);

            }
        }

        private void KREDIT_JOBResult_Load(object sender, EventArgs e)
        {
            // System.Web을 찹조한다.
            // 크레딧잡에서의 검색키워드는 익스플로어로 열리는 경우 인코딩이 필요
            
            //XElement xml = url.XmlParsing(url);
            //IEnumerable<XElement> eXml = xml.Elements("body");
            //IEnumerable<XElement> items = eXml.Elements();

            //var result = from xm in items.Elements()
            //             where xm.Element("wkplRoadNmDtlAddr").Value.Contains("금천구")
            //             select xm;
            
            //foreach (var item in result)
            //{
            //    companyname.Text = item.Element("wkplNm").Value;
              
            //}
            

            //seq = "65106579";
            //string url2 = "http://apis.data.go.kr/B552015/NpsBplcInfoInqireService/getDetailInfoSearch?serviceKey="+serviceKey+"&seq="+seq;

            //XElement xml2 = url2.XmlParsing(url2);
            //IEnumerable<XElement> eXm = xml2.Elements("body");
            

            //var result2 = from x in eXm.Elements()
            //              select x;
            //foreach (var item in result2)
            //{
            //    personNumber.Text = item.Element("jnngpCnt").Value+"명";
            //    companyJob.Text = item.Element("vldtVlKrnNm").Value;
            //}

        }
    }
}
