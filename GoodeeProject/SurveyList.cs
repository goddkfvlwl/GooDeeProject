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
    public partial class SurveyList : UserControl
    {
        List<Survey> list;
        public SurveyList()
        {
            InitializeComponent();
        }

        private void SurveyList_Load(object sender, EventArgs e)
        {
            GoodeeDAO.GoodeeDAO DAO = GoodeeDAO.GoodeeDAO.GetInstance();
            if ((this.Controls["panel1"].Controls["rdoInclude"] as RadioButton).Checked)
            {
                list = DAO.SelectSurvey(false);
            }else
            {
                list = DAO.SelectSurvey(true);
            }
            dataGridView1.DataSource = list;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridView1.Columns[0].HeaderText = "번호";
            dataGridView1.Columns[1].HeaderText = "설문 제목";
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns[2].HeaderText = "작성자";
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].HeaderText = "시작일";
            dataGridView1.Columns[5].HeaderText = "종료일";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (DateTime.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString()) <= DateTime.Today)
                {
                    foreach (DataGridViewCell item in dataGridView1.Rows[i].Cells)
                    {
                        item.Style.BackColor = Color.Yellow;
                    }
                }
            }
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SurveyDetail detail = new SurveyDetail(new Survey(int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()), dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(), bool.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()), DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()), DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString())));
            this.Parent.Controls.Add(detail);
            detail.Location = new Point(185, 0);
            detail.BringToFront();
        }
    }
}
