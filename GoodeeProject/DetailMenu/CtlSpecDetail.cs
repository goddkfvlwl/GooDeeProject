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
    public partial class CtlSpecDetail : UserControl
    {
        public CtlSpecDetail()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
=======
        public void Frm_BorderPaint(object sender, PaintEventArgs e)
        {
            Rectangle borderRectangle = this.ClientRectangle;
            borderRectangle.Inflate(0, 0);
            ControlPaint.DrawBorder(e.Graphics, borderRectangle, Color.FromArgb(142, 142, 142), ButtonBorderStyle.Solid);
        }
>>>>>>> 1527d7b47c9cf77797478870176cc29b4a09206d
    }
}
