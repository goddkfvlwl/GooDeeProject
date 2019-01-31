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
    public partial class JobAreaChoice : UserControl
    {
        public JobAreaChoice()
        {
            InitializeComponent();
        }

        private void souelButton_Click(object sender, EventArgs e)
        {
            Area seoul = new Area();
            seoul.Location = new Point(254, 58);
            seoul.Parent = this;



            // 1. 서울의 하위 지역 값을 DB에서 아래 형태로 count의 수를 구한 후 
            // select count(*) from dbo.DetailArea
            // where FirstArea_Code = 101000; 그 count의 개수 만큼
            iTalk.iTalk_CheckBox checkBox= new iTalk.iTalk_CheckBox();
            //CheckBox check = new CheckBox();
            checkBox.Text = "서울전체";
            checkBox.Location = new Point(91, 15);
            seoul.Controls.Add(checkBox);
            
         
           
        }

        private void iTalk_Button_12_Click(object sender, EventArgs e)
        {
            Area seoul = new Area();
            seoul.Location = new Point(254, 58);
            seoul.Parent = this;
            
        }
    }
}
