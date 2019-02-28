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
    public partial class FrmStudentRegist : Form
    {
        string id;
        public FrmStudentRegist()
        {
            InitializeComponent();
        }
        public FrmStudentRegist(string id) : this()
        {
            this.panel1.Visible = true;
            this.id = id;
            GoodeeDAO.GoodeeDAO DAO = new GoodeeDAO.GoodeeDAO();
            var memberInfo = DAO.SelectMemberInfo(id);
            txtName.Text = memberInfo.Rows[0]["name"].ToString();
            txtEmail.Text = memberInfo.Rows[0]["ID"].ToString();
            txtBirthDay.Text = memberInfo.Rows[0]["BirthDate"].ToString();
            txtMobile.Text = memberInfo.Rows[0]["Mobile"].ToString();
            txtAddress.Text = memberInfo.Rows[0]["Address"].ToString();
            txtClass.Text = memberInfo.Rows[0]["Class_Name"].ToString();
            txtCurriculm.Text = memberInfo.Rows[0]["Curriculum"].ToString();
            txtTurn.Text = memberInfo.Rows[0]["Turn"].ToString();
            Regist.SelectedItem = memberInfo.Rows[0]["Register"];
            if (memberInfo.Rows[0]["Curriculum"].ToString() == "남자")
            {
                rdomale.Checked = true;
            }
            else
            {
                rdoFemale.Checked = true;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtEmail.Text) && !String.IsNullOrEmpty(txtName.Text) && !String.IsNullOrEmpty(txtBirthDay.Text) && !String.IsNullOrEmpty(txtMobile.Text) && !String.IsNullOrEmpty(txtAddress.Text) && !String.IsNullOrEmpty(txtClass.Text) && !String.IsNullOrEmpty(txtCurriculm.Text) && !String.IsNullOrEmpty(txtTurn.Text) && !string.IsNullOrEmpty(Regist.SelectedItem.ToString()))
            {
                GoodeeDAO.GoodeeDAO goodeeDAO = new GoodeeDAO.GoodeeDAO();
                string[] member = new string[10];
                member[0] = txtEmail.Text;
                member[1] = txtName.Text;
                if ((this.groupBox1.Controls["rdoMale"] as RadioButton).Checked)
                {
                    member[2] = "m";
                }
                else
                {
                    member[2] = "f";
                }
                member[3] = txtBirthDay.Text;
                member[4] = txtMobile.Text;
                member[5] = txtAddress.Text;
                member[6] = txtClass.Text;
                member[7] = txtCurriculm.Text;
                member[8] = txtTurn.Text;
                member[9] = Regist.SelectedItem.ToString();
                goodeeDAO.InsertMember(member);
            }
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmStudentRegist_Load(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Size.Width / 2) - (this.Size.Width / 2), (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (this.Size.Height / 2));
        }
    }
}
