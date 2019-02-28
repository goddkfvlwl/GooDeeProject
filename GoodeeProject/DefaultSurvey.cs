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
        public DefaultSurvey()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Resize(object sender, EventArgs e)
        {
            this.Size = flowLayoutPanel1.Size;
        }
    }
}
