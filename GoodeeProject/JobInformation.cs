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
    public partial class JobInformation : UserControl
    {
        public JobInformation()
        {
            InitializeComponent();
        }

        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {
            JobAreaChoice choice = new JobAreaChoice();
            choice.Location = new Point(36, 62);
            choice.Parent = this;
            
        }
    }
}
