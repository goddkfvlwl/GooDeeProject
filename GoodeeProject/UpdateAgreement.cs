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
    public partial class UpdateAgreement : UserControl
    {

        GoodeeDAO.GoodeeDAO gd;
        private string title;
        private string body;
        private int postnum;
        private AgreementBoard ab = null;

        public UpdateAgreement()
        {
            InitializeComponent();
        }

        public UpdateAgreement(string title, string body, int postNum) : this()
        {
            this.title = title;
            this.body = body;
            this.postnum = postNum;
            gd = GoodeeDAO.GoodeeDAO.GetInstance();

            ab = gd.ReadCountUP(postNum);

        }

        private void UpdateAgreement_Load(object sender, EventArgs e)
        {
            txtTitle.Text = title;
            FtpWebRequest req = (FtpWebRequest)WebRequest.Create(body);
            req.Method = WebRequestMethods.Ftp.DownloadFile;

            using (FtpWebResponse resp = (FtpWebResponse)req.GetResponse())
            {
                // FTP 결과 스트림
                Stream stream = resp.GetResponseStream();

                // 결과를 문자열로 읽기 (바이너리로 읽을 수도 있다)
                string data;
                using (StreamReader reader = new StreamReader(stream))
                {
                    data = reader.ReadToEnd();
                }

                // 로컬 파일로 출력
                boardBoby.Rtf = data;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {

            DateTime date = DateTime.Now;
            string id = FrmMain.Ai.Id;

            if (!String.IsNullOrEmpty(title) || !String.IsNullOrEmpty(ab.Body))
            {
                var board = new AgreementBoard()
                {
                    Title = title,
                    Body = ab.Body,
                    WriteDate = date,
                    Id = id
                };
                try
                {
                    new GoodeeDAO.GoodeeDAO().UpdateBoard(ab.BoardNum, board);
                    MessageBox.Show("수정완료");
                }
                catch (Exception se)
                {
                    MessageBox.Show("수정실패 원인 : \n" + se.Message);


                }
            }

            //ftp서버에 업로드
            FtpWebRequest req = (FtpWebRequest)WebRequest.Create(ab.Body);
            req.Method = WebRequestMethods.Ftp.UploadFile;

            byte[] data;
            boardBoby.SaveFile(Application.StartupPath + "/a.rtf");
            using (StreamReader reader = new StreamReader(Application.StartupPath + "/a.rtf"))
            {
                data = Encoding.UTF8.GetBytes(reader.ReadToEnd());
            }

            // RequestStream에 데이타를 쓴다
            req.ContentLength = data.Length;
            using (Stream reqStream = req.GetRequestStream())
            {
                reqStream.Write(data, 0, data.Length);
            }

            //using (FtpWebResponse resp = (FtpWebResponse)req.GetResponse())
            //{
            //    // FTP 결과 상태 출력
            //    MessageBox.Show("Upload: {0}", resp.StatusDescription);
            //}

            File.Delete(Application.StartupPath + "/a.rtf");
        }
    }

}
