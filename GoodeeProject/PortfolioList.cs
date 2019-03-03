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
        SaveLog log = new SaveLog();
        string id;

        /// <summary>
        /// 생성자
        /// </summary>
        public PortfolioList()
        {
            InitializeComponent();
            this.id = FrmMain.Mi.Id;
        }

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="id"></param>
        public PortfolioList(string id) : this()
        {
            this.id = id;
            log.AddList(id + "수강생의 포트폴리오 목록 열람");
        }

        /// <summary>
        /// 현재 창을 종료합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// 포트폴리오 목록을 데이터베이스에서 읽어와서 PortfolioListMenu 컨트롤을 동적으로 생성합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void PortfolioList_Load(object sender, EventArgs e)
        {
            this.ListMenuLayout.Controls.Clear();
            GoodeeDAO.GoodeeDAO DAO = GoodeeDAO.GoodeeDAO.GetInstance();
            var list = DAO.SelectPortfolioList(id);
            foreach (DataRow item in list.Rows)
            {
                PortfolioListMenu menu = new PortfolioListMenu();
                menu.Controls["lblTitle"].Text = item[1].ToString();
                menu.Controls["lblWriteDate"].Text = item[2].ToString();
                menu.DoubleClick += Menu_DoubleClick;
                this.ListMenuLayout.Controls.Add(menu);
            }
            if (FrmMain.Ai.Authority != 'S')
            {
                this.btnDelete.Visible = false;
                this.btnAddPortfolio.Visible = false;
            }
            
        }

        /// <summary>
        /// PortfolioListMenu 컨트롤을 더블클릭하면 해당 포트폴리오의 상세 내용을 호출합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void Menu_DoubleClick(object sender, EventArgs e)
        {
            string portfolioTitle = (sender as PortfolioListMenu).Controls["lblTitle"].Text;
            Portfolio portfolio = new Portfolio(id, portfolioTitle);
            this.Parent.Controls.Add(portfolio);
            portfolio.Location = new Point(0, 0);
            portfolio.BringToFront();
            if (FrmMain.Ai.Authority=='C')
            {
                portfolioTitle = (sender as PortfolioListMenu).Controls["lblTitle"].Text;
                portfolio = new Portfolio(id, portfolioTitle);
                this.Parent.Controls.Add(portfolio);
                portfolio.Location = new Point(6,7);
                portfolio.BringToFront();
            }
        }

        /// <summary>
        /// 포트폴리오를 작성하는 사용자 정의 컨트롤을 호출합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void btnAddPortfolio_Click(object sender, EventArgs e)
        {
            Portfolio portfolio = new Portfolio();
            this.Parent.Controls.Add(portfolio);
            portfolio.Location = new Point(0, 0);
            portfolio.Disposed += Portfolio_Disposed;
            portfolio.BringToFront();
            log.AddList("포트폴리오 추가");
        }

        /// <summary>
        /// 포트폴리오 사용자 정의 컨트롤이 종료되면 포트폴리오 리스트를 재호출 합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void Portfolio_Disposed(object sender, EventArgs e)
        {
            PortfolioList_Load(null, null);
        }

        /// <summary>
        /// 선택된 포트폴리오를 삭제합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
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

            GoodeeDAO.GoodeeDAO DAO = GoodeeDAO.GoodeeDAO.GetInstance();
            if (DAO.DeletePortfolio(id, portfolioName))
            {
                MessageBox.Show("포트폴리오가 삭제되었습니다.");
            }
            PortfolioList_Load(null, null);
            log.AddList("포트폴리오 삭제");
        }
    }
}
