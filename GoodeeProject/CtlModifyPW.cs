﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace GoodeeProject
{
    public partial class CtlModifyPW : UserControl
    {
        private string key;

        public CtlModifyPW()
        {
            InitializeComponent();
        }

        private void CtlModifyPW_Load(object sender, EventArgs e)
        {
            key = GetKey().Substring(8, 16);
            GetImage(key);
        }

        private string GetKey()
        {
            string key = "";
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
                key = reader.ReadToEnd();
            }
            return key;
        }

        private void GetImage(string key)
        {
            string Imgkey = key; //호출로 받은 키값
            string url = "https://openapi.naver.com/v1/captcha/ncaptcha.bin?key=" + Imgkey;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("X-Naver-Client-Id", "oiCEBfQBSNZSSXb6gyBC");
            request.Headers.Add("X-Naver-Client-Secret", "HgQRbnV8Z1");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string status = response.StatusCode.ToString();
            
            Stream input = response.GetResponseStream();
            pboxCaptcha.Image = Image.FromStream(input);
        }

        private bool CaptchaResult()
        {
            bool check = false;
            string code = "1"; 
            string key = this.key;  // 캡차 키 발급시 받은 키값
            string value = tboxCaptcha.Text;  // 사용자가 입력한 캡차 이미지 글자값
            string url = "https://openapi.naver.com/v1/captcha/nkey?code=" + code + "&key=" + key + "&value=" + value;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("X-Naver-Client-Id", "oiCEBfQBSNZSSXb6gyBC");
            request.Headers.Add("X-Naver-Client-Secret", "HgQRbnV8Z1");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            string status = response.StatusCode.ToString();

            if (status == "OK")
            {
                Stream stream = response.GetResponseStream();
                StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                string result = reader.ReadToEnd();
                if (result.Contains("true"))
                {
                    check = true;
                }
            }
            return check;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (CaptchaResult())
            {
                MessageBox.Show("성공");
            }
            else
            {
                MessageBox.Show("Test");
                CtlModifyPW_Load(null, null);
            }

        }
    }
}
