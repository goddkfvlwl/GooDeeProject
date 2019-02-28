using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RichTextBoxEx;
using PrintRichTextBox;
using System.IO;
using GoodeeProject.GoodeeDAO;
using System.Net;

namespace GoodeeProject
{
    public partial class Agreement_enterprise : UserControl
    {
        //RichTextBoxEx.RichTextBoxEx
        
        public Agreement_enterprise()
        {
            InitializeComponent();
            boardBoby.AllowDrop = true;
            boardBoby.DragEnter += Attachments_DragEnter;
            boardBoby.DragDrop += Attachments_DragDrop;
        }

        private void Attachments_DragDrop(object sender, DragEventArgs e)
        {

            #region 이미지가 드래그가 됨
            Image img = default(Image);
            img = Image.FromFile(((Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString());
            Clipboard.SetImage(img);

            boardBoby.SelectionStart = 0;
            boardBoby.Paste();
            #endregion

            #region 드래그된 파일은 첨부파일에 들어간다.
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                string s = "";

                foreach (string File in FileList)
                {
                    s = s + " " + File;
                }
                //boardBoby.Text = s;
                attachments.Items.Add(s);
            } 
            #endregion
            
        }

        private void Attachments_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        string fileName = "";
        
        private static string attach;
        public static string Attachments { get { return attach; } set { attach = value; } }


        private void picAdd_Click(object sender, EventArgs e)
        {
            
             
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


        private void iTalk_Button_15_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                boardBoby.SelectionFont = fontDialog1.Font;
            }
        }

        private void iTalk_Button_16_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                boardBoby.SelectionColor = colorDialog1.Color;
            }
        }
        
        private void MedioButton_Click(object sender, EventArgs e)
        {
            attach = "";
            MedioButton medio = new MedioButton();
            medio.ShowDialog();
            
            if (attach != "")
            {
                attachments.Items.Add(attach);
            }
            
        }

        private void save_Click(object sender, EventArgs e)
        {

            string title = Title.Text;
            
            string path = "ftp://52.165.176.111:3333/CompanyBoard/"+title+".rtf";    // 뒤에 파일 이름 필요
            
            DateTime date =  DateTime.Now;
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

            //using (FtpWebResponse resp = (FtpWebResponse)req.GetResponse())
            //{
            //    // FTP 결과 상태 출력
            //    MessageBox.Show("Upload: {0}", resp.StatusDescription);
            //}
            
            File.Delete(Application.StartupPath + "/a.rtf");


        }

        string rtf = "";
        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {
            //richTextBox1.Text = boardBoby.Rtf;
            //rtf = richTextBox1.Text;
        }

        private void iTalk_Button_12_Click(object sender, EventArgs e)
        {
            //richTextBox2.Rtf = rtf;
            
        }

        
        private void Title_Click(object sender, EventArgs e)
        {
            this.Title.Text = " ";
        }
    }
}
