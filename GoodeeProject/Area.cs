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
    public partial class CheckBoxAdd : UserControl
    {
        public CheckBoxAdd()
        {
            InitializeComponent();
        }

        public void RemoveControl()
        {
            this.Controls.Clear();
        }
    }
}
