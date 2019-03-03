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
using GoodeeProject.GoodeeDAO;
using System.Net;

namespace GoodeeProject
{
    public partial class Agreement_enterprise : UserControl
    {
        int ClickFont = 1;
        int ClickFont2 = 1;
        int ClickFont3 = 1;
        public Agreement_enterprise()
        {
            InitializeComponent();
            
        }

        string fileName = "";

        private static string attach;
        public static string Attachments { get { return attach; } set { attach = value; } }

        private void save_Click(object sender, EventArgs e)
        {

            string title = Title.Text;

            string path = "ftp://52.165.176.111:3333/%2FCompanyBoard/" + title + ".rtf";    // 뒤에 파일 이름 필요

            DateTime date = DateTime.Now;
            string id = FrmMain.Ai.Id;

            if (!String.IsNullOrEmpty(title) || !String.IsNullOrEmpty(path))
            {
                var board = new AgreementBoard()
                {
                    Title = title,
                    Body = path,
                    WriteDate = date,
                    Id = id
                };
                try
                {
                    new GoodeeDAO.GoodeeDAO().InsertBoard(board);
                    MessageBox.Show("저장성공");
                }
                catch (Exception se)
                {
                    MessageBox.Show("저장실패 원인 : \n" + se.Message);


                }
            }

            //ftp서버에 업로드
            FtpWebRequest req = (FtpWebRequest)WebRequest.Create(path);
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

        private void Title_Click(object sender, EventArgs e)
        {
            this.Title.Text = " ";
        }

        private void Agreement_enterprise_Load(object sender, EventArgs e)
        {
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

        private void pictureBox2_Click(object sender, EventArgs e)
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

        private void Fontsize_TextChanged(object sender, EventArgs e)
        {
            boardBoby.SelectionFont = new Font(comFontStyle.SelectedItem.ToString(), float.Parse(Fontsize.Text));
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
