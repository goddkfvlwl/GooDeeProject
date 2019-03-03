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
    public partial class OnlineInfo : UserControl
    {
        private string id;
        /// <summary>
        /// 생성자
        /// </summary>
        public OnlineInfo()
        {
            InitializeComponent();
        }

        public string Id { get => id; set => id = value; }

        /// <summary>
        /// 해당 컨트롤 클릭시 해당 컨트롤의 색을 회색으로 그외에 형제 컨트롤의 색을 기본 컨트롤 색으로 변경
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void OnlineInfo_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Parent.Controls)
            {
                item.BackColor = Control.DefaultBackColor;
            }
            this.BackColor = Color.LightGray;
        }
    }
}
