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
    public partial class PortfolioList : UserControl
    {
        string id;
        public PortfolioList()
        {
            InitializeComponent();
            this.id = FrmMain.Id;
        }
        public PortfolioList(string id) : this()
        {
            this.id = id;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void PortfolioList_Load(object sender, EventArgs e)
        {
            this.ListMenuLayout.Controls.Clear();
            GoodeeDAO.GoodeeDAO DAO = new GoodeeDAO.GoodeeDAO();
            var list = DAO.SelectPortfolioList(id);
            foreach (DataRow item in list.Rows)
            {
                PortfolioListMenu menu = new PortfolioListMenu();
                menu.Controls["lblTitle"].Text = item[1].ToString();
                menu.Controls["lblWriteDate"].Text = item[2].ToString();
                menu.DoubleClick += Menu_DoubleClick;
                this.ListMenuLayout.Controls.Add(menu);
            }
            if (FrmMain.Authority != 'S')
            {
                this.btnDelete.Visible = false;
                this.btnAddPortfolio.Visible = false;
            }
            
        }

        private void Menu_DoubleClick(object sender, EventArgs e)
        {
            string portfolioTitle = (sender as PortfolioListMenu).Controls["lblTitle"].Text;
            Portfolio portfolio = new Portfolio(id, portfolioTitle);
            this.Parent.Controls.Add(portfolio);
            portfolio.Location = new Point(185, 0);
            portfolio.BringToFront();
        }

        private void btnAddPortfolio_Click(object sender, EventArgs e)
        {
            Portfolio portfolio = new Portfolio();
            this.Parent.Controls.Add(portfolio);
            portfolio.Location = new Point(185, 0);
            portfolio.Disposed += Portfolio_Disposed;
            portfolio.BringToFront();
        }

        private void Portfolio_Disposed(object sender, EventArgs e)
        {
            PortfolioList_Load(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("삭제하면 복구할수없습니다. 삭제하시겠습니까?", "포트폴리오 삭제", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) != DialogResult.OK)
            {
                return;
            }
            string portfolioName = "";
            foreach (Control item in this.ListMenuLayout.Controls)
            {
                if (item.BackColor == Color.LightGray)
                {
                    portfolioName = item.Controls["lblTitle"].Text;
                }
            }
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://52.165.176.111:3333/Portfolio/" + id + "/" + portfolioName);
            request.Method = WebRequestMethods.Ftp.ListDirectory;
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());
            List<string> list = new List<string>();
            while (!reader.EndOfStream)
            {
                string strr = reader.ReadLine();
                list.Add(strr);
            }
            foreach (var item in list)
            {
                request = (FtpWebRequest)WebRequest.Create("ftp://52.165.176.111:3333/Portfolio/" + id + "/" + portfolioName + "/" + item);
                request.Method = WebRequestMethods.Ftp.DeleteFile;
                response = (FtpWebResponse)request.GetResponse();
            }
            request = (FtpWebRequest)WebRequest.Create("ftp://52.165.176.111:3333/Portfolio/" + id + "/" + portfolioName);
            request.Method = WebRequestMethods.Ftp.RemoveDirectory;
            response = (FtpWebResponse)request.GetResponse();

            GoodeeDAO.GoodeeDAO DAO = new GoodeeDAO.GoodeeDAO();
            if (DAO.DeletePortfolio(id, portfolioName))
            {
                MessageBox.Show("포트폴리오가 삭제되었습니다.");
            }
            PortfolioList_Load(null, null);
        }
    }
}
