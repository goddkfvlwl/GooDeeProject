using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace GoodeeProject
{
    public partial class CtlModifyPassWord : UserControl
    {
        public CtlModifyPassWord()
        {
            InitializeComponent();
        }

        private void CtlModifyPassWord_Load(object sender, EventArgs e)
        {
            GetKey();
        }

        private void GetKey()
        {
            string code = "0"; // 키 발급시 0,  캡차 이미지 비교시 1로 세팅
            string url = "https://openapi.naver.com/v1/captcha/nkey?code=" + code;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("X-Naver-Client-Id", "oiCEBfQBSNZSSXb6gyBC");
            request.Headers.Add("X-Naver-Client-Secret", "HgQRbnV8Z1");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string status = response.StatusCode.ToString();
            if (status == "OK")
            {
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                string text = reader.ReadToEnd();
                MessageBox.Show(text);
            }
            else
            {
                MessageBox.Show("Error 발생=" + status);
            }
        }
    }
}
