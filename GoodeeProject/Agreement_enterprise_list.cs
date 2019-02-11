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
    public partial class Agreement_enterprise_list : UserControl
    {
        //List<AgreementBoard> list;
        public Agreement_enterprise_list()
        {
            InitializeComponent();
            //list = new List<AgreementBoard>();
        }

        private void Agreement_enterprise_list_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = new GoodeeDAO.GoodeeDAO().OutBoard();
        }
        Panel panel;
        FrmMain main;
        Agreement_enterprise agreement;
        private void iTalk_Button_12_Click(object sender, EventArgs e)
        {
            panel = (Panel)Parent;
            main = (FrmMain)panel.Parent;
            main.RemoveUserControl();

            agreement = new Agreement_enterprise();
            agreement.Location = new Point(190, 3);
            panel.Controls.Add(agreement);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            panel = (Panel)Parent;
            main = (FrmMain)panel.Parent;
            main.RemoveUserControl();

            int postNum = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            DetailView detail = new DetailView(postNum);
            detail.Location = new Point(190, 3);
            detail.BringToFront();
            panel.Controls.Add(detail);

        }
    }
}
