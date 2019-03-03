using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeProject
{
    public partial class FrmLog : Form, IFormControl
    {
        SaveLog s = new SaveLog();
        FtpWebResponse res;
        FtpWebRequest req;
        FtpWebRequest req2;

        private int movePointX;
        private int movePointY;
        private string[] fileArr;

        public FrmLog()
        {
            InitializeComponent();
        }

        public void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void BtnMinimum_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public void Frm_BorderPaint(object sender, PaintEventArgs e)
        {
            Rectangle borderRectangle = this.ClientRectangle;
            borderRectangle.Inflate(0, 0);
            ControlPaint.DrawBorder(e.Graphics, borderRectangle, Color.DimGray, ButtonBorderStyle.Solid);
        }

        public void Frm_MouseDown(object sender, MouseEventArgs e)
        {
            movePointX = e.X;
            movePointY = e.Y;
        }

        public void Frm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + (e.X - movePointX), this.Location.Y + (e.Y - movePointY));
            }
        }
        /// <summary>
        /// 파일목록을 string배열로 받은거를 ListView에 넣는다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLog_Load(object sender, EventArgs e)
        {
            fileArr = GetFileListArray();
            lvLogFiles.BeginUpdate();
            lvLogFiles.View = View.Tile;

            lvLogFiles.LargeImageList = imgList;
            lvLogFiles.SmallImageList = imgList;

            foreach (var item in fileArr)
            {
                ListViewItem lvi = new ListViewItem(item);
                lvi.ImageIndex = 0;
                lvLogFiles.Items.Add(lvi);
            }

            lvLogFiles.EndUpdate();
        }
        /// <summary>
        /// FTP서버의 Log폴더안의 파일목록을 String배열로 변환한다.
        /// </summary>
        /// <returns></returns>
        private string[] GetFileListArray()
        {
            string fileList = "";
            string logDir = "ftp://52.165.176.111:3333/Log/";
            req = WebRequest.Create(logDir) as FtpWebRequest;
            req.Method = WebRequestMethods.Ftp.ListDirectory;

            try
            {
                FtpWebResponse resp = req.GetResponse() as FtpWebResponse;
                StreamReader sr = new StreamReader(resp.GetResponseStream(), Encoding.UTF8);
                
                fileList = sr.ReadToEnd();   //목록
                sr.Close();
                resp.Close();
            }
            catch (WebException)
            {
                MessageBox.Show("로그파일이 없습니다.");
            }
            string[] arrayFileList = fileList.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

            req = null;

            return arrayFileList;
        }
        /// <summary>
        /// ListView 더블클릭 시 해당 로그파일의 내용을 폼을띄우면서 매개변수로 보내준다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvLogFiles_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            long filesize = 0;
            string filename = lvLogFiles.SelectedItems[0].SubItems[0].Text;
            string path = Application.StartupPath + "/" + filename;
            try
            {
                req = (FtpWebRequest)WebRequest.Create("ftp://52.165.176.111:3333/Log/" + filename);

                req.Method = WebRequestMethods.Ftp.GetFileSize;
                res = (FtpWebResponse)req.GetResponse();
                filesize = res.ContentLength;

                req2 = (FtpWebRequest)WebRequest.Create("ftp://52.165.176.111:3333/Log/" + filename);
                req2.Method = WebRequestMethods.Ftp.DownloadFile;
                res = (FtpWebResponse)req2.GetResponse();

                Stream s = res.GetResponseStream();
                FileStream fs = new FileStream(path, FileMode.Create);
                byte[] buffer = new byte[99999];
                int readCount = s.Read(buffer, 0, buffer.Length);

                pBarDown.Visible = true;
                pBarDown.Value = 0;
                pBarDown.Maximum = Int32.Parse(filesize.ToString());
                pBarDown.Minimum = 0;
                while (readCount > 0)
                {
                    pBarDown.Value += readCount;
                    fs.Write(buffer, 0, readCount);
                    readCount = s.Read(buffer, 0, buffer.Length);
                }
                res.Close();
                fs.Close();
                
            }
            catch (WebException)
            {
                MessageBox.Show("파일을 찾을 수 없습니다", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                StreamReader sr = new StreamReader(path);
                string log = sr.ReadToEnd();
                FrmLogDetail ld = new FrmLogDetail(log);
                ld.ShowDialog();
                sr.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("읽어올 수 없습니다.");
            }
            pBarDown.Visible = false;
            File.Delete(path);
        }

        /// <summary>
        /// TextBox안에 있는 Text가 들어간 파일명을 ListView에 띄운다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tboxSearch.Text))
            {
                IEnumerable<string> result =
                        from filelst in fileArr
                        where filelst.Contains(tboxSearch.Text) == true
                        select filelst;

                lvLogFiles.BeginUpdate();
                lvLogFiles.Clear();
                lvLogFiles.View = View.Tile;

                lvLogFiles.LargeImageList = imgList;
                lvLogFiles.SmallImageList = imgList;

                foreach (var item in result)
                {
                    ListViewItem lvi = new ListViewItem(item);
                    lvi.ImageIndex = 0;
                    lvLogFiles.Items.Add(lvi);
                }
                s.AddList("로그 검색");
                lvLogFiles.EndUpdate(); 
            }
            else
            {
                MessageBox.Show("검색어를 입력해주세요", "정보", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 파일 전체목록을 다시 불러온다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAll_Click(object sender, EventArgs e)
        {
            FrmLog_Load(null, null);
        }
    }
}
