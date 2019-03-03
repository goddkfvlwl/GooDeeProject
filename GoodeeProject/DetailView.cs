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
using System.Diagnostics;

namespace GoodeeProject
{
    public partial class DetailView : UserControl
    {
        int ClickFont = 1;
        int ClickFont2 = 1;
        int ClickFont3 = 1;
        GoodeeDAO.GoodeeDAO gd;
        private int postNum;
        private AgreementBoard ab = null;
        List<AgreementBoard> lst;
        string fileName = "";
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
        string data = "";
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
            toolTip1.SetToolTip(Strikethrough, "취소선");
            toolTip1.SetToolTip(serchPic, "글찾기");
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            Uri serverUri = new Uri(ab.Body);
            if (FtpDelete(serverUri))
            {
                DialogResult result =  MessageBox.Show("정말삭제하시겠습니까?", "삭제", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        gd.DeleteBoard(ab.BoardNum);
                        MessageBox.Show("삭제성공.");
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
                

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

        private void boardBoby_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            Process.Start("chrome.exe", e.LinkText);

        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            Panel panel = (Panel)Parent;
            FrmMain main = (FrmMain)panel.Parent;
            main.RemoveControls();
            panel.Controls.Remove(this);

            UpdateAgreement detail = new UpdateAgreement(ab.Title, ab.Body, postNum);
            detail.Location = new Point(190, 3);
            detail.BringToFront();
            panel.Controls.Add(detail);
        }

        private void boardBoby_LinkClicked_1(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("Chrome.exe", e.LinkText);
        }

        private void FontColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                boardBoby.SelectionColor = colorDialog1.Color;
            }
        }

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

        private void comFontStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            boardBoby.SelectionFont = new Font(comFontStyle.SelectedItem.ToString(), 12f);
        }

        private void Fontsize_SelectedIndexChanged(object sender, EventArgs e)
        {
            boardBoby.SelectionFont = new Font(comFontStyle.SelectedItem.ToString(), float.Parse(Fontsize.SelectedItem.ToString()));
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

        private void serchPic_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Visible = true;
        }

        private void iTalk_Button_12_Click(object sender, EventArgs e)
        {
            boardBoby.SelectionStart = 0;
            boardBoby.SelectAll();
            boardBoby.SelectionBackColor = Color.White;
        }

        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {
            string[] words = serchtxt.Text.Split(',');
            foreach (string word in words)
            {
                int startIndex = 0;
                while (startIndex < boardBoby.TextLength)
                {
                    int wordsStartIndex = boardBoby.Find(word, startIndex, RichTextBoxFinds.None);
                    if (wordsStartIndex != -1)
                    {
                        boardBoby.SelectionStart = wordsStartIndex;
                        boardBoby.SelectionLength = word.Length;
                        boardBoby.SelectionBackColor = Color.Yellow;
                    }
                    else
                    {
                        break;

                    }
                    startIndex += wordsStartIndex + word.Length;
                }
            }
        }
    }
}
