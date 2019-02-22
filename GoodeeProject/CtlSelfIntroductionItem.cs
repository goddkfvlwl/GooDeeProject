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
        internal bool selected = false;
        internal int num;
        public CtlSelfIntroductionItem()
        {
            InitializeComponent();

            panel1.Location = new Point(this.Location.X+1, this.Location.Y+1);
            panel1.Width = 18;
            panel1.Height = this.Height-2;
            panel1.BackColor = Color.FromArgb(106, 187, 104);
            panel1.Click += CtlSelfIntroductionItem_Click;
        }

        //public CtlSelfIntroductionItem(DataRow row)
        //{
        //    this.lbl_Title.Text = row["Title"].ToString();
        //    this.lbl_Body.Text = row["Body"].ToString();
        //    DateTime dt = (DateTime)row["WriteDate"];
        //    this.lbl_Date.Text = dt.ToShortDateString();
        //    this.num = (int)row["Num"];
        //}
        internal void CtlSelfIntroductionItem_Click(object sender, EventArgs e)
        {
            Selected();
        }

        public void Selected()
        {
            if (!this.selected)
            {
                this.BackColor = Color.SkyBlue;
                selected = true;
            }
            else
            {
                this.BackColor = Color.White;
                selected = false;
            }
        }

        private void CtlSelfIntroductionItem_Paint(object sender, PaintEventArgs e)
        {
            Rectangle borderRectangle = this.ClientRectangle;
            borderRectangle.Inflate(0, 0);
            ControlPaint.DrawBorder(e.Graphics, borderRectangle, Color.DimGray, ButtonBorderStyle.Solid);

            ControlPaint.DrawReversibleLine(new Point(0, this.Height-1), new Point(this.Width, this.Height-1), Color.Black);
        }

        internal void CtlSelfIntroductionItem_DoubleClick(object sender, EventArgs e)
        {
            CtlSelfIntroduce ctl = new CtlSelfIntroduce(lbl_Title.Text, lbl_Body.Text, num);
            ctl.Location = this.Parent.Parent.Location;


            this.Parent.Parent.Parent.Controls.Add(ctl);
            this.Parent.Parent.Parent.Controls.Remove(this.Parent.Parent);
        }
    }
}
