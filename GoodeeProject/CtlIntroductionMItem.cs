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
    public partial class CtlIntroductionMItem : UserControl
    {
        internal string name;
        public CtlIntroductionMItem()
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

        internal void CtlSelfIntroductionItem_DoubleClick(object sender, EventArgs e)
        {
            FrmSelfIntroduce ctl = new FrmSelfIntroduce(lbl_Title.Text, lbl_Body.Text, name,lbl_Date.Text);
            ctl.Show();
            
        }
    }
}
