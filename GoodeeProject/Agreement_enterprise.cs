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

        /// <summary>
        /// 저장버튼의 이벤트이다.
        /// DB에 저장을시키며 FTP서버에도 저장을 시킨다.
        /// FTP서버에 저장을 시킬경우 RTF로 변환을 해서 저장을 시킨다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 객체; 여기서는 글 저장 버튼</param>
        /// <param name="e"></param>
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

            FTPServer(path);

        }
        /// <summary>
        /// FTP서버에 연결을 하고 FTP서버에 해당 내용을 올린다.
        /// </summary>
        /// <param name="path"></param>
        private void FTPServer(string path)
        {
            //ftp서버에 업로드
            FtpWebRequest req = (FtpWebRequest)WebRequest.Create(path);
            req.Method = WebRequestMethods.Ftp.UploadFile;

            byte[] data;
            find.SaveFile(Application.StartupPath + "/a.rtf");
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

        /// <summary>
        /// 이벤트메서드이다. 해당 이벤트는 텍스트를 클릭시 내용이 초기화 된다.
        /// </summary>
        /// <param name="sender">이벤트 대상 객체이다. 현재 텍스트의 객체를 가리킨다.</param>
        /// <param name="e"></param>
        private void Title_Click(object sender, EventArgs e)
        {
            this.Title.Text = " ";
        }

        /// <summary>
        /// 해당 사용자 폼이 로드될 경우의 이벤트이다.
        /// 텍스트박스에 글을 적을때 필요한 폰트 설정에 대한 것 들이 들어있다.
        /// 로드시 콤보박스에 폰트에 설정할 수 있는 정보들이 들어간다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Agreement_enterprise_Load(object sender, EventArgs e)
        {
            foreach (FontFamily oneFontFamily in FontFamily.Families)
            {
                comFontStyle.Items.Add(oneFontFamily.Name);
            }
            comFontStyle.Text = comFontStyle.Items[1].ToString();
            Fontsize.Text = Fontsize.Items[1].ToString();
            ToolTip();
        }

        /// <summary>
        /// 폰트를 설정하는 부분을 현재 아이콘으로 되어있다. 
        /// 해당 아이콘의 설명을 위해서 툴팁을 사용
        /// </summary>
        private void ToolTip()
        {
            toolTip1.SetToolTip(FontColor, "글씨 색상 변경");
            toolTip1.SetToolTip(pictureButton, "사진 넣기");
            toolTip1.SetToolTip(FontBold, "진하게");
            toolTip1.SetToolTip(FontUnderLine, "밑줄");
            toolTip1.SetToolTip(Strikethrough, "취소선");
            toolTip1.SetToolTip(serchPic, "글찾기");
        }

        /// <summary>
        /// 이벤트 메서드이다.
        /// 글씨 색상 변경에 해당하는 픽쳐박스를 클릭시 텍스트에 줄 수 있는 색상들이 표시된다.
        /// 선택한 텍스트를 색상변경이 가능하다.
        /// </summary>
        /// <param name="sender">이벤트객체대상; 현재 픽쳐박스이다.</param>
        /// <param name="e"></param>
        private void FontColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                find.SelectionColor = colorDialog1.Color;
            }
        }

        /// <summary>
        /// 이벤트 메서드이다.
        /// 사진넣기에 해당하는 픽쳐박스를 선택시 파일탐색기가 뜬다
        /// 사진만의 파일만 뽑을수 있게 필터기능또한 있다.
        /// </summary>
        /// <param name="sender">이벤트 객체 대상 픽쳐박스</param>
        /// <param name="e"></param>
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Images Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg;*.jpeg;*.gif;*.bmp;*.png";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                fileName = openFileDialog1.FileName;
                ClipBoard();

            }
        }

        /// <summary>
        /// 클립보드를 사용해서 텍스트에 사진을 첨부한다.
        /// </summary>
        private void ClipBoard()
        {
            Bitmap myBitmap = new Bitmap(Image.FromFile(fileName));


            Clipboard.SetDataObject(myBitmap);
            DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
            if (find.CanPaste(myFormat))
            {

                find.Paste(myFormat);

            }
            else
            {
                MessageBox.Show("시도한 데이터 형식은 해당 컨트롤이 지원되지 않습니다.");
            }
        }

        /// <summary>
        /// 이벤트 메서드이다.
        /// 선택한 텍스트는 해당 콤보박스에서 선택한 폰트 형식으로 변환이된다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comFontStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            find.SelectionFont = new Font(comFontStyle.SelectedItem.ToString(), 12f);
        }

        /// <summary>
        /// 선택한 텍스트는 해당 콤보박스에서의 선택한 폰트사이즈로 형식이 변환이 된다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Fontsize_SelectedIndexChanged(object sender, EventArgs e)
        {
            find.SelectionFont = new Font(comFontStyle.SelectedItem.ToString(), float.Parse(Fontsize.SelectedItem.ToString()));
        }

        /// <summary>
        /// 콤보박스 선택만이 끝이아닌 폰트사이즈를 직접 사용자가 작성해서 정해주는 것
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Fontsize_TextChanged(object sender, EventArgs e)
        {
            find.SelectionFont = new Font(comFontStyle.SelectedItem.ToString(), float.Parse(Fontsize.Text));
        }
        
        /// <summary>
        /// 이벤트메서드이다.
        /// 진하게에 해당하는 픽쳐박스를 누르면 선택된 글씨가 진해진다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FontBold_Click(object sender, EventArgs e)
        {
            ClickFont += 1;
            if (ClickFont == 1)
            {
                find.SelectionFont = new Font(comFontStyle.SelectedItem.ToString(), float.Parse(Fontsize.SelectedItem.ToString()), FontStyle.Bold);
            }
            else
            {
                find.SelectionFont = new Font(comFontStyle.SelectedItem.ToString(), float.Parse(Fontsize.SelectedItem.ToString()), FontStyle.Regular);
            }

            if (ClickFont == 2)
            {
                ClickFont = 0;
            }
        }

        /// <summary>
        /// 이벤트메서드이다.
        /// 진하게에 해당하는 픽쳐박스를 누르면 선택된 글씨가 밑줄이 생긴다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FontUnderLine_Click(object sender, EventArgs e)
        {
            ClickFont2 += 1;
            
            if (ClickFont2 == 1)
            {
                find.SelectionFont = new Font(comFontStyle.SelectedItem.ToString(), float.Parse(Fontsize.SelectedItem.ToString()), FontStyle.Underline);
            }
            else
            {
                find.SelectionFont = new Font(comFontStyle.SelectedItem.ToString(), float.Parse(Fontsize.SelectedItem.ToString()), FontStyle.Regular);
            }

            if (ClickFont2 == 2)
            {
                ClickFont2 = 0;
            }
        }

        /// <summary>
        /// /// 이벤트메서드이다.
        /// 진하게에 해당하는 픽쳐박스를 누르면 선택된 글씨가 취소선이 생긴다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Strikethrough_Click(object sender, EventArgs e)
        {
            
            ClickFont3 += 1;
            if (ClickFont3 == 1)
            {
                find.SelectionFont = new Font(comFontStyle.SelectedItem.ToString(), float.Parse(Fontsize.SelectedItem.ToString()), FontStyle.Strikeout);
            }
            else
            {
                find.SelectionFont = new Font(comFontStyle.SelectedItem.ToString(), float.Parse(Fontsize.SelectedItem.ToString()), FontStyle.Regular);
            }


            if (ClickFont3 == 2)
            {
                ClickFont3 = 0;
            }
        }

        /// <summary>
        /// 해당 패널은 visible이 되어있어서 화면에 뜨지 않는다.
        /// 글찾기 픽쳐박스를 누를 경우 해당 패널이 Ture가 되며 활성화 된다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       private void serchPic_Click(object sender, EventArgs e)
       {
           flowLayoutPanel1.Visible = true;
       }

        /// <summary>
        /// 패널이 활성화가 된 후 글 검색 버튼을 누를 경우
        /// 해당 글 들을 찾아간다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iTalk_Button_11_Click_1(object sender, EventArgs e)
        {
            
            string[] words = serchtxt.Text.Split(',');
            foreach (string word in words)
            {
                int startIndex = 0;
                while(startIndex < find.TextLength)
                {
                    int wordsStartIndex = find.Find(word, startIndex, RichTextBoxFinds.None);
                    if (wordsStartIndex!=-1)
                    {
                        find.SelectionStart = wordsStartIndex;
                        find.SelectionLength = word.Length;
                        find.SelectionBackColor = Color.Yellow;
                    }
                    else
                    {
                        break;
                        
                    }
                    startIndex += wordsStartIndex + word.Length;
                }
            }

        }

        /// <summary>
        /// 패널의 활성화가 된 상태에서 지우기 버튼을 누를경우 찾아낸 텍스트들의 초기화가 된다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iTalk_Button_12_Click(object sender, EventArgs e)
        {
            find.SelectionStart = 0;
            find.SelectAll();
            find.SelectionBackColor = Color.White;
        }
        
    }
}
