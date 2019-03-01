using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeProject
{
    public partial class FrmClassInfo : Form
    {
        private string classNum;
        SaveLog log = new SaveLog();
        bool ismodify = false;
        /// <summary>
        /// 생성자
        /// </summary>
        public FrmClassInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 훈련과정 번호에 해당하는 훈련과정의 정보를 데이터베이스에서 읽어옵니다.
        /// </summary>
        /// <param name="classNum">훈련과정 번호</param>
        public FrmClassInfo(string classNum)
        {
            this.classNum = classNum;
            GoodeeDAO.GoodeeDAO DAO = new GoodeeDAO.GoodeeDAO();
            var c = DAO.SelectClass(int.Parse(classNum));
            txtClass.Text = c.Class_Name;
            txtCurriculm.Text = c.Curriculum;
            txtTurn.Text = c.Turn;
            dtpStartDate.Value = c.Startdate;
            dtpEndDate.Value = c.Enddate;
            ismodify = true;
        }

        /// <summary>
        /// 작성한 훈련과정정보를 저장합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            GoodeeDAO.GoodeeDAO DAO = new GoodeeDAO.GoodeeDAO();
            DAO.InsertClass(txtClass.Text, txtCurriculm.Text, txtTurn, dtpStartDate.Value, dtpEndDate.Value, true);
            if (ismodify)
            {
                log.AddList("훈련과정정보 수정");
            }else
            {
                log.AddList("훈련과정 추가");
            }
            
        }
        /// <summary>
        /// 현재 폼을 종료합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
