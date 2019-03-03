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
    public partial class Commant : UserControl
    {
        private int boardNum;

        public Commant()
        {
            InitializeComponent();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                new GoodeeDAO.GoodeeDAO().InsertCommantBoard(boardNum, body.Text, DateTime.Now, FrmMain.Ai.Id);
                MessageBox.Show("댓글이 정상적으로 달렸습니다");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Commant_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(boardNum.ToString());
        }
    }
}
