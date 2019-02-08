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
        List<AgreementBoard> list;
        public Agreement_enterprise_list()
        {
            InitializeComponent();
            list = new List<AgreementBoard>();
        }

        private void Agreement_enterprise_list_Load(object sender, EventArgs e)
        {
            list = new GoodeeDAO.GoodeeDAO().OutBoard();

            dataGridView1.DataSource = list;
        }

        private void iTalk_Button_12_Click(object sender, EventArgs e)
        {
            new Agreement_enterprise().Show();
                
        }
    }
}
