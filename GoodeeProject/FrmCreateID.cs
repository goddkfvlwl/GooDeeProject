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
    public partial class FrmCreateID : Form
    {
        GoodeeDAO.GoodeeDAO goodee;
        public FrmCreateID()
        {
            InitializeComponent();
            goodee = GoodeeDAO.GoodeeDAO.GetInstance();
        }

        private void btn_CreateID_Click(object sender, EventArgs e)
        {
            MemberInfo info;
            info = new MemberInfo()
            {
                Id = tb_Email,

            }
            string password;
            if (goodee.InsertAdmin(info, password))
            {

            }

           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }
    }
}
