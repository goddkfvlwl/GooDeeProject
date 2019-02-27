using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Net;

namespace GoodeeProject
{
    public partial class PortfolioManager : UserControl
    {
        public PortfolioManager()
        {
            InitializeComponent();
        }

        private void PortfolioManager_Load(object sender, EventArgs e)
        {
            GoodeeDAO.GoodeeDAO dao = GoodeeDAO.GoodeeDAO.GetInstance();
            dataGridView1.DataSource = dao.SelectMemberList();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "분류";
            dataGridView1.Columns[2].HeaderText = "과정명";
            dataGridView1.Columns[3].HeaderText = "회차";
            dataGridView1.Columns[4].HeaderText = "이름";
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].HeaderText = "주소";
            dataGridView1.Columns[9].HeaderText = "이메일";
            dataGridView1.Columns[10].HeaderText = "수강여부";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                PortfolioList list = new PortfolioList(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                this.Parent.Controls.Add(list);
                list.Location = new Point(185, 0);
                list.BringToFront();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls[0].Dispose();
        }
    }
}
