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
        /// <summary>
        /// 생성자
        /// </summary>
        public SurveyList()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 데이터 그리드뷰에 설문목록을 입력하고 컬럼헤더를 설정합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체입니다.</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
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

        /// <summary>
        /// 선택된 설문 목록의 상세 내용을 표시합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체입니다.</param>
        /// <param name="e">DataGridView 셀 및 행 작업과 관련된 데이터를 제공하는 이벤트입니다. </param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SurveyDetail detail = new SurveyDetail(new Survey(int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()), dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(), bool.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()), DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()), DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString())));
            this.Parent.Controls.Add(detail);
            detail.Location = new Point(0, 0);
            detail.BringToFront();
        }
    }
}
