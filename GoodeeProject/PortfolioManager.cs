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
        /// <summary>
        /// 생성자
        /// </summary>
        public PortfolioManager()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 데이터 그리드뷰에 수강생의 정보를 데이터베이스에서 호출하여 넣고 데이터그리드뷰의 컬럼 헤더를 설정합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체입니다.</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
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
        /// <summary>
        /// 선택한 수강생의 포트폴리오 목록을 표시합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체입니다.</param>
        /// <param name="e"> DataGridView 셀 및 행 작업과 관련된 데이터를 제공하는 이벤트입니다.</param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                PortfolioList list = new PortfolioList(dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString());
                this.Parent.Controls.Add(list);
                list.Location = new Point(185, 0);
                list.BringToFront();
            }
            if (FrmMain.Ai.Authority=='C')
            {
                PortfolioList list = new PortfolioList(dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString());
                this.Parent.Controls.Add(list);
                list.Location = new Point(6,7);
                list.BringToFront();
            }
        }
        /// <summary>
        /// 현재의 폼을 종료시킵니다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls[0].Dispose();
        }
    }
}
