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
        SaveLog log = new SaveLog();
        /// <summary>
        /// 생성자
        /// </summary>
        public ClassList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 폼이 로드될때 훈련과정정보를 데이터베이스에서 읽어와 데이터그리드뷰에 넣고 데이터그리드뷰의 컬럼헤더를 수정합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
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


        /// <summary>
        /// 선택된 훈련과정을 비활성화 합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void btnClassDelete_Click(object sender, EventArgs e)
        {
            GoodeeDAO.GoodeeDAO DAO = new GoodeeDAO.GoodeeDAO();
            string startDate = "";
            string endDate = "";
            if (string.IsNullOrEmpty(dataGridView1.SelectedRows[0].Cells[4].Value.ToString()))
            {
                startDate = "1753-11-11";
            }else
            {
                startDate = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            }
            if (string.IsNullOrEmpty(dataGridView1.SelectedRows[0].Cells[5].Value.ToString()))
            {
                endDate = "1753-11-11";
            }else
            {
                endDate = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            }
            DAO.UpdateClass(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), dataGridView1.SelectedRows[0].Cells[1].Value.ToString(), dataGridView1.SelectedRows[0].Cells[2].Value.ToString(), dataGridView1.SelectedRows[0].Cells[3].Value.ToString(), DateTime.Parse(startDate), DateTime.Parse(endDate), false);
            log.AddList("훈련과정 비활성화");
        }
        
        /// <summary>
        /// 훈련과정을 추가하는 폼을 로드합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void btnClassAdd_Click(object sender, EventArgs e)
        {
            FrmClassInfo info = new FrmClassInfo();
            info.ShowDialog();
        }

        /// <summary>
        /// 선택된 훈련과정을 수정하는 폼을 로드합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void btnClassModify_Click(object sender, EventArgs e)
        {
            FrmClassInfo info = new FrmClassInfo(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            info.ShowDialog();
        }
    }
}
