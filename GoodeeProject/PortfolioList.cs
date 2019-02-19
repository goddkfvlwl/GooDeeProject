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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                Portfolio portfolio = new Portfolio(this.dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(),this.dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                this.Parent.Controls.Add(portfolio);
                portfolio.Location = new Point(185, 0);
                portfolio.BringToFront();
            }
        }

        private void PortfolioList_Load(object sender, EventArgs e)
        {
            GoodeeDAO.GoodeeDAO DAO = new GoodeeDAO.GoodeeDAO();
            this.dataGridView1.DataSource = DAO.SelectPortfolioList(id);
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "프로잭트이름";
            dataGridView1.Columns[2].HeaderText = "작성일";
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            if (dataGridView1.Rows.Count == 0)
            {
                btnAddPortfolio_Click(null, null);
                this.Visible = false;
            }
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
