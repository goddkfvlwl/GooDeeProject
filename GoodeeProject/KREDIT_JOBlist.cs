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
using System.Xml.XPath;

namespace GoodeeProject
{
    public partial class KREDIT_JOBlist : UserControl
    {
        string keyword = " ";
        string serviceKey = "xHuTDf0%2FQp0HDzRAEV4eJFw%2F8hAJu7mZ8oFyqowX7jn6I56Au1cimmwHtweVDfYznMmcv6cXg%2BnXwmnOtHQ%2FOw%3D%3D";
        int pageNo = 1; // 페이지 넘버
        int numOfCount = 10;    // 한 페이지당 출력할 개수
        int totalCount = 0;  // 데이터 총 개수
        
        string companyName = "";    //회사이름
        string companyArea = "";    // 회사지역
        string seq = "";    // 사업분류코드
        List<KREDIT> kREDITs = new List<KREDIT>();

        public KREDIT_JOBlist()
        {
            InitializeComponent();
        }
        
        private void KREDIT_JOBlist_Load(object sender, EventArgs e)
        {
            string companyKeyword = System.Web.HttpUtility.UrlEncode(ExtensionXML.Key);
            
            string url = "http://apis.data.go.kr/B552015/NpsBplcInfoInqireService/getBassInfoSearch?serviceKey=" + serviceKey + "&wkpl_nm=" + companyKeyword + "&pageNo=" + pageNo + "&numOfRows=" + numOfCount;
            
            XPathDocument rd = url.XPathReader(url);

            XPathNavigator nav = rd.CreateNavigator();
            XPathNodeIterator nodes = nav.Select("/response/body/items/item");
            while (nodes.MoveNext())
            {
                KREDIT kREDIT = new KREDIT();
                if (nodes.Current.MoveToChild("dataCrtYm", ""))
                {
                    kREDIT.DataCrtYm = DateTime.Parse(nodes.Current.Value.ToString().Insert(nodes.Current.Value.ToString().Length, "-01").Insert(4, "-"));
                }

                //if (nodes.Current.MoveToChild)
                //{

                //}
            }
            
        }
    }
}
