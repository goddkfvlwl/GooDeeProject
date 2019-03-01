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
    public partial class DefaultSurvey : UserControl
    {
        /// <summary>
        /// 생성자
        /// </summary>
        public DefaultSurvey()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 현재 폼의 크기를 flowLayoutPanel1의 크기로 변경합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void flowLayoutPanel1_Resize(object sender, EventArgs e)
        {
            this.Size = flowLayoutPanel1.Size;
        }
    }
}
