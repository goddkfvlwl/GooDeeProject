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
    public partial class ClassList : UserControl
    {
        public ClassList()
        {
            InitializeComponent();
        }

        private void ClassList_Load(object sender, EventArgs e)
        {
            GoodeeDAO.GoodeeDAO DAO = new GoodeeDAO.GoodeeDAO();
            var list = DAO.selectClassList();
            dataGridView1.DataSource = list;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[0].HeaderText = "번호";
            dataGridView1.Columns[1].HeaderText = "분류";
            dataGridView1.Columns[2].HeaderText = "회차";
            dataGridView1.Columns[3].HeaderText = "과정명";
            dataGridView1.Columns[4].HeaderText = "시작일";
            dataGridView1.Columns[5].HeaderText = "종료일";
        }

        private void btnClassDelete_Click(object sender, EventArgs e)
        {
            GoodeeDAO.GoodeeDAO DAO = new GoodeeDAO.GoodeeDAO();
            string startDate = "";
            string endDate = "";
            if (string.IsNullOrEmpty(dataGridView1.SelectedRows[0].Cells[4].Value.ToString()))
            {
                startDate = "1753-11-11";
            }
            if (string.IsNullOrEmpty(dataGridView1.SelectedRows[0].Cells[5].Value.ToString()))
            {
                endDate = "1753-11-11";
            }
            DAO.UpdateClass(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), dataGridView1.SelectedRows[0].Cells[1].Value.ToString(), dataGridView1.SelectedRows[0].Cells[2].Value.ToString(), dataGridView1.SelectedRows[0].Cells[3].Value.ToString(), DateTime.Parse(startDate), DateTime.Parse(endDate), false);
        }

        private void btnClassAdd_Click(object sender, EventArgs e)
        {
            FrmClassInfo info = new FrmClassInfo();
            info.ShowDialog();
        }

        private void btnClassModify_Click(object sender, EventArgs e)
        {
            FrmClassInfo info = new FrmClassInfo(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            info.ShowDialog();
        }
    }
}
