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
    public partial class FrmLogDetail : Form
    {
        private string log;

        public FrmLogDetail()
        {
            InitializeComponent();
        }

        public FrmLogDetail(string log) : this()
        {
            this.log = log;
            tboxLogDetail.Text = this.log;
        }
    }
}
