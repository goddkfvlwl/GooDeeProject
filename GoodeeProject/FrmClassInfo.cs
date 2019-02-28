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
    public partial class FrmClassInfo : Form
    {
        private string classNum;

        public FrmClassInfo()
        {
            InitializeComponent();
        }

        public FrmClassInfo(string classNum)
        {
            this.classNum = classNum;
            GoodeeDAO.GoodeeDAO DAO = new GoodeeDAO.GoodeeDAO();
            var c = DAO.SelectClass(int.Parse(classNum));
            txtClass.Text = c.Class_Name;
            txtCurriculm.Text = c.Curriculum;
            txtTurn.Text = c.Turn;
            dtpStartDate.Value = c.Startdate;
            dtpEndDate.Value = c.Enddate;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GoodeeDAO.GoodeeDAO DAO = new GoodeeDAO.GoodeeDAO();
            DAO.InsertClass(txtClass.Text, txtCurriculm.Text, txtTurn, dtpStartDate.Value, dtpEndDate.Value, true);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
