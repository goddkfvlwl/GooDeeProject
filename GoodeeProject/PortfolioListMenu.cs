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
    public partial class PortfolioListMenu : UserControl
    {
        /// <summary>
        /// 생성자
        /// </summary>
        public PortfolioListMenu()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 데이터 그리드뷰에 수강생의 정보를 데이터베이스에서 호출하여 넣고 데이터그리드뷰의 컬럼 헤더를 설정합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체입니다.</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void PortfolioListMenu_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Parent.Controls)
            {
                item.BackColor = Control.DefaultBackColor;
            }
            this.BackColor = Color.LightGray;
        }
    }
}
