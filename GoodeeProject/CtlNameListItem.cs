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
    public partial class CtlNameListItem : UserControl
    {
        public CtlNameListItem()
        {
            InitializeComponent();
        }

        private void CtlIntroductionMItem_Paint(object sender, PaintEventArgs e)
        {
            Rectangle borderRectangle = this.ClientRectangle;
            borderRectangle.Inflate(0, 0);
            ControlPaint.DrawBorder(e.Graphics, borderRectangle, Color.DimGray, ButtonBorderStyle.Solid);
            ControlPaint.DrawReversibleLine(new Point(0, this.Height - 1), new Point(this.Width, this.Height - 1), Color.Black);
        }
    }
}
