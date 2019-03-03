using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace GoodeeProject
{
    public static class ExtensionXML
    {
        private static string key;  // 검색어 키워드
        public static string Key { get => key; set => key = value; }

        /// <summary>
        /// 확장메서드의 종류로, String을 받으며 XElement를 반환한다.
        /// xml 을 파싱하는 부분이다.
        /// </summary>
        /// <param name="stx"></param>
        /// <param name="strXml"></param>
        /// <returns></returns>
        public static XElement XmlParsing(this String stx, string strXml)
        {
            Uri url = new Uri(strXml);
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            Stream stream = response.GetResponseStream();

            XElement xElem = XElement.Load(stream);

            return xElem;

        }

        /// <summary>
        /// XML을 파싱하여, jobs에 해당하는 것을 반환한다.
        /// 확장메서드의 일 부분
        /// </summary>
        /// <param name="xElem"></param>
        /// <param name="element"></param>
        /// <returns></returns>
        public static int XmlTotal(this XElement xElem, XElement element)
        {
            var result = from xe in element.Elements("jobs")
                         select xe;
            int total = 0;
            foreach (var item in result)
            {
                total = Int32.Parse(item.Attribute("total").Value.ToString());

            }
            return total;

        }

        /// <summary>
        /// string의 타입만 사용이 가능한 확장메서드이다.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="strUrl"></param>
        /// <returns></returns>
        public static XmlReader ReaderCreate(this String str, string strUrl)
        {
            Uri url = new Uri(strUrl);
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            Stream stream = response.GetResponseStream();

            XmlReader reader = XmlReader.Create(stream);

            return reader;

        }
        // XPathDocument xdoc = new XPathDocument(@"C:\Temp\Emp.xml")
        public static XPathDocument XPathReader(this String str,string Url)
        {
            Uri url = new Uri(Url);
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            Stream stream = response.GetResponseStream();

            XPathDocument xdoc = new XPathDocument(stream);
            return xdoc;
            
        }

        public static void JobKeyword(this String s, string kword)
        {
            Key = kword;
        }

    }
}
