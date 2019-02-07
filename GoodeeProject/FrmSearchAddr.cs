using Newtonsoft.Json.Linq;
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
using System.Xml.Linq;

namespace GoodeeProject
{
    public partial class FrmSearchAddr : Form, IFormControl
    {
        Rectangle borderRectangle;
        iTalk.iTalk_Button_1 btnPrev;
        iTalk.iTalk_Button_1 btnNext;
        FlowLayoutPanel lp = new FlowLayoutPanel();

        int currentPage = 1;
        int resultCount;
        int totalPageNum;

        private int movePointX;
        private int movePointY;

        public FrmSearchAddr()
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
            borderRectangle = this.ClientRectangle;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lp.Controls.Clear();
            PaintRect(Color.FromArgb(240, 238, 233));

            this.Size = new Size(724, 600);
            

            btnPrev = new iTalk.iTalk_Button_1();
            btnNext = new iTalk.iTalk_Button_1();
            btnPrev.Click += BtnPrev_Click;
            btnNext.Click += BtnNext_Click;

            this.Controls.Add(lp);
            this.Controls.Add(btnPrev);
            this.Controls.Add(btnNext);

            lp.Size = new Size(710, 332);
            lp.Location = new Point(5, 166);
            lp.AutoScroll = true;
            lp.BackColor = Color.White;

            btnPrev.Size = new Size(44, 27);
            btnNext.Size = new Size(44, 27);

            btnPrev.Text = "<<";
            btnNext.Text = ">>";

            btnPrev.Location = new Point(315, 512);
            btnNext.Location = new Point(395, 512);

            PaintRect(Color.DimGray);
            string confirmKey = "U01TX0FVVEgyMDE5MDIwNzA5NDQ1NTEwODQ5MjM=";
            int countPerPage = 10;
            string keyword = "풍무로96번길";

            var url = "http://www.juso.go.kr/addrlink/addrLinkApi.do?currentPage="+ currentPage + "&countPerPage=" + countPerPage + "&confmKey=" + confirmKey +"&resultType=json&keyword=" + keyword;

            var jObj = JObject.Parse(GetJson(url));
            var itemsArr = JArray.Parse(jObj["results"]["juso"].ToString());

            resultCount = Int32.Parse(jObj["results"]["common"]["totalCount"].ToString());

            lblText.Text = "\"" + tboxSearch.Text + "\" 을(를) 검색한 결과 총" + resultCount + "건 입니다.";

            if (resultCount % 10 == 0)
            {
                totalPageNum = resultCount / 10;
            }
            else
            {
                totalPageNum = (resultCount / 10) + 1;
            }

            CtlAddr[] addr = new CtlAddr[resultCount];
            for (int i = 0; i < resultCount; i++)
            {
                addr[i] = new CtlAddr();
                addr[i].Location = new Point(0, 0);
                lp.Controls.Add(addr[i]);
                try
                {
                    addr[i].lblRoadAddr.Text = itemsArr[i]["roadAddr"].ToString();
                }
                catch (ArgumentOutOfRangeException)
                {
                    lp.Controls.Remove(addr[i]);
                    break;
                }
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (currentPage != totalPageNum)
            {
                currentPage++;
                btnSearch_Click(null, null); 
            }
            else
            {
                MessageBox.Show("마지막 페이지 입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            if (currentPage != 1)
            {
                currentPage--;
                btnSearch_Click(null, null); 
            }
            else
            {
                MessageBox.Show("처음 페이지 입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PaintRect(Color color)
        {
            Graphics g = this.CreateGraphics();
            borderRectangle = this.ClientRectangle;
            borderRectangle.Inflate(0, 0);
            ControlPaint.DrawBorder(g, borderRectangle, color, ButtonBorderStyle.Solid);
        }

        public string GetJson(string url)
        {
            string json = "";
            HttpWebRequest req = WebRequest.Create(url) as HttpWebRequest;
            HttpWebResponse resp = req.GetResponse() as HttpWebResponse;

            var statusCode = resp.StatusCode.ToString();

            if (statusCode == "OK")
            {
                Stream stream = resp.GetResponseStream();
                StreamReader sr = new StreamReader(stream, Encoding.UTF8);
                json = sr.ReadToEnd();
            }

            return json;
        }
        
    }
}
