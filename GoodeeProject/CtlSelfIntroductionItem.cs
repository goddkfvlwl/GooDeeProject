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
    public partial class CtlSelfIntroductionItem : UserControl
    {
        bool selected = false;
        public CtlSelfIntroductionItem()
        {
            InitializeComponent();
        }

        private void CtlSelfIntroductionItem_Click(object sender, EventArgs e)
        {
            Select(true);
        }

        public void Select(bool select)
        {
            this.selected = select;
            if (this.selected)
            {
                this.BackColor = Color.SkyBlue;
            }
        }
    }
}
