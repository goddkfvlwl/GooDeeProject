using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            portfolio.BringToFront();
        }
    }
}
