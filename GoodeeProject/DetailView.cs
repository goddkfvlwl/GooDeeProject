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
    public partial class DetailView : UserControl
    {
        GoodeeDAO.GoodeeDAO gd;
        private int postNum;
        private AgreementBoard ab = null;
        List<AgreementBoard> lst;
        
        public DetailView()
        {
            InitializeComponent();
            lst = new List<AgreementBoard>();
            
        }

        public DetailView(int postNum) : this()
        {
            gd = GoodeeDAO.GoodeeDAO.GetInstance();
            this.postNum = postNum;
            
            ab = gd.ReadCountUP(postNum);
            
        }

        private void DetailView_Load(object sender, EventArgs e)
        {

            title.Text = "제목 : " + ab.Title + "  | 협약기업게시판"; ;

            FtpWebRequest req = (FtpWebRequest)WebRequest.Create(ab.Body);
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

        private void butDelete_Click(object sender, EventArgs e)
        {
            Uri serverUri = new Uri(ab.Body);
            if (FtpDelete(serverUri))
            {
                gd.DeleteBoard(ab.BoardNum);
                MessageBox.Show("정말삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
            }
        }

        private static bool FtpDelete(Uri serverUri)
        {
            try
            {
                if (serverUri.Scheme != Uri.UriSchemeFtp)   // 주소의 앞을 반환 즉 http://~~이면 http만 반환
                {
                    return false;
                }
                // Get the object used to communicate with the server.
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(serverUri);
                request.Method = WebRequestMethods.Ftp.DeleteFile;

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                //Console.WriteLine("Delete status: {0}", response.StatusDescription);
                response.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }
        }
    }
}
