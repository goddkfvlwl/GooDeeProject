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
        }

        private void iTalk_Button_12_Click(object sender, EventArgs e)
        {
            Area seoul = new Area();
            seoul.Location = new Point(254, 58);
            seoul.Parent = this;
            
        }
    }
}
