using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace GoodeeProject
{
    public static class ExtensionXML
    {
        private static string key;  // 검색어 키워드
        public static string Key { get => key; set => key = value; }

        public static XElement SaraminXml(this String stx, string strXml)
        {
            Uri url = new Uri(strXml);
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            Stream stream = response.GetResponseStream();

            XElement xElem = XElement.Load(stream);

            return xElem;

        }
        public static void JobKeyword(this String s, string kword)
        {
            Key = kword;
        }

    }
}
