using System;
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
        SaveLog s = new SaveLog();

        private string key;
        private bool pwCheck = false;
        GoodeeDAO.GoodeeDAO gd;

        public CtlModifyPW()
        {
            InitializeComponent();
            gd = GoodeeDAO.GoodeeDAO.GetInstance();
        }

        private void CtlModifyPW_Load(object sender, EventArgs e)
        {
            key = GetKey().Substring(8, 16);
            GetImage(key);
            s.AddList("비밀번호 수정 클릭");
        }
        /// <summary>
        /// 캡챠API에서 Key를 받는다.
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// 캡챠 API에서 이미지를 받는다.
        /// </summary>
        /// <param name="key"></param>
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
        /// <summary>
        /// 캡챠 API의 이미지와 입력받은 TextBox의 값과 일치하는지 판단하는 메서드
        /// </summary>
        /// <returns></returns>
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

        private void tboxNewPW_TextChanged(object sender, EventArgs e)
        {
            NewPWCheck();
        }

        private void tboxNewREPW_TextChanged(object sender, EventArgs e)
        {
            NewPWCheck();
        }
        /// <summary>
        /// 새 비밀번호와 새비밀번호 확인의 text내용이 일치하는 경우를 구분하는 메서드
        /// </summary>
        private void NewPWCheck()
        {
            if (tboxNewPW.Text == tboxNewREPW.Text && tboxNewPW.Text != "")
            {
                lblError.ForeColor = Color.Blue;
                lblError.Text = "비밀번호가 일치합니다.";
                pwCheck = true;
            }
            else
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = "비밀번호가 일치하지 않습니다.";
                pwCheck = false;
            }
        }
        /// <summary>
        /// 유효성검사를 마친 데이터를 Update하는 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            string email = "";
            bool chkForm;
            try
            {
                FrmModifyPW frm = (FrmModifyPW)Parent;
                chkForm = frm.CheckForm;
                email = frm.Email;
            }
            catch (Exception)
            {
                chkForm = false;
            }

            if (chkForm)
            {
              
                AccountInfo asd = gd.AccountLogin(email, tboxNowPW.Text);

                if (asd != null && pwCheck == true)
                {
                    if (CaptchaResult())
                    {

                        if (gd.UpdatePassWord(asd.Id, tboxNewPW.Text))
                        {
                            MessageBox.Show("수정 성공", "완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.ParentForm.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("자동방지입력이 올바르지 않습니다.");
                        CtlModifyPW_Load(null, null);
                    }
                    s.AddList("정보수정 완료");
                }
                else
                {
                    MessageBox.Show("현재비밀번호가 일치하지 않거나 새 비밀번호를 확인해주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
            }
            else
            {
                if (FrmMain.Ai.Pw == tboxNowPW.Text && pwCheck == true)
                {
                    if (CaptchaResult())
                    {
                        if (gd.UpdatePassWord(FrmMain.Mi.Id, tboxNewPW.Text))
                        {
                            MessageBox.Show("수정 성공", "완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.ParentForm.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("자동방지입력이 올바르지 않습니다.");
                        CtlModifyPW_Load(null, null);
                    }
                    s.AddList("비밀번호수정 완료");
                }
                else
                {
                    MessageBox.Show("현재비밀번호가 일치하지 않거나 새 비밀번호를 확인해주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// 캡챠이미지를 다시 불러온다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReload_Click(object sender, EventArgs e)
        {
            CtlModifyPW_Load(null, null);
        }

        private void CtlModifyPW_Paint(object sender, PaintEventArgs e)
        {
            Rectangle borderRectangle = this.ClientRectangle;
            borderRectangle.Inflate(0, 0);
            ControlPaint.DrawBorder(e.Graphics, borderRectangle, Color.DimGray, ButtonBorderStyle.Solid);
        }
    }
}
