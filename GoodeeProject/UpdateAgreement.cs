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
        int ClickFont = 1;
        int ClickFont2 = 1;
        int ClickFont3 = 1;

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
            

            File.Delete(Application.StartupPath + "/a.rtf");
        }

        private void UpdateAgreement_Load_1(object sender, EventArgs e)
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

            foreach (FontFamily oneFontFamily in FontFamily.Families)
            {
                comFontStyle.Items.Add(oneFontFamily.Name);
            }
            comFontStyle.Text = comFontStyle.Items[1].ToString();
            Fontsize.Text = Fontsize.Items[1].ToString();

            toolTip1.SetToolTip(FontColor, "글씨 색상 변경");
            toolTip1.SetToolTip(pictureButton, "사진 넣기");
            toolTip1.SetToolTip(FontBold, "진하게");
            toolTip1.SetToolTip(FontUnderLine, "밑줄");
        }

        private void FontColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                boardBoby.SelectionColor = colorDialog1.Color;
            }
        }
        string fileName = "";
        private void pictureButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Images Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg;*.jpeg;*.gif;*.bmp;*.png";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;

                Bitmap myBitmap = new Bitmap(Image.FromFile(fileName));


                Clipboard.SetDataObject(myBitmap);
                DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
                if (boardBoby.CanPaste(myFormat))
                {

                    boardBoby.Paste(myFormat);

                    //MessageBox.Show(boardBoby.Location.ToString());
                }
                else
                {
                    MessageBox.Show("시도한 데이터 형식은 해당 컨트롤이 지원되지 않습니다.");
                }

            }
        }

        private void FontBold_Click(object sender, EventArgs e)
        {
            ClickFont += 1;
            if (ClickFont == 1)
            {
                boardBoby.SelectionFont = new Font(comFontStyle.SelectedItem.ToString(), float.Parse(Fontsize.SelectedItem.ToString()), FontStyle.Bold);
            }
            else
            {
                boardBoby.SelectionFont = new Font(comFontStyle.SelectedItem.ToString(), float.Parse(Fontsize.SelectedItem.ToString()), FontStyle.Regular);
            }

            if (ClickFont == 2)
            {
                ClickFont = 0;
            }
        }

        private void FontUnderLine_Click(object sender, EventArgs e)
        {
            ClickFont2 += 1;

            if (ClickFont2 == 1)
            {
                boardBoby.SelectionFont = new Font(comFontStyle.SelectedItem.ToString(), float.Parse(Fontsize.SelectedItem.ToString()), FontStyle.Underline);
            }
            else
            {
                boardBoby.SelectionFont = new Font(comFontStyle.SelectedItem.ToString(), float.Parse(Fontsize.SelectedItem.ToString()), FontStyle.Regular);
            }

            if (ClickFont2 == 2)
            {
                ClickFont2 = 0;
            }
        }

        private void Strikethrough_Click(object sender, EventArgs e)
        {

            ClickFont3 += 1;
            if (ClickFont3 == 1)
            {
                boardBoby.SelectionFont = new Font(comFontStyle.SelectedItem.ToString(), float.Parse(Fontsize.SelectedItem.ToString()), FontStyle.Strikeout);
            }
            else
            {
                boardBoby.SelectionFont = new Font(comFontStyle.SelectedItem.ToString(), float.Parse(Fontsize.SelectedItem.ToString()), FontStyle.Regular);
            }


            if (ClickFont3 == 2)
            {
                ClickFont3 = 0;
            }
        }
    }

}
