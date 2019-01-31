using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeProject
{
    interface IFormControl
    {
        void Frm_MouseDown(object sender, MouseEventArgs e);

        void Frm_MouseMove(object sender, MouseEventArgs e);

        void BtnExit_Click(object sender, EventArgs e);

        void BtnMinimum_Click(object sender, EventArgs e);
    }
}
