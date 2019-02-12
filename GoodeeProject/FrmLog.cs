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
        private int movePointX;
        private int movePointY;

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

        private void FrmLog_Load(object sender, EventArgs e)
        {
            lvLogFiles.BeginUpdate();
            lvLogFiles.View = View.Tile;

            lvLogFiles.LargeImageList = imgList;
            lvLogFiles.SmallImageList = imgList;

            foreach (var item in GetFileListArray())
            {
                ListViewItem lvi = new ListViewItem(item);
                lvi.ImageIndex = 0;
                lvLogFiles.Items.Add(lvi);
            }

            lvLogFiles.EndUpdate();
        }

        private string[] GetFileListArray()
        {
            string fileList = "";
            string logDir = "ftp://52.165.176.111:3333/Log/";
            FtpWebRequest req = WebRequest.Create(logDir) as FtpWebRequest;
            req.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

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

            return arrayFileList;
        }
    }
}
