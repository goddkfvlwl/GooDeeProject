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
        SaveLog log = new SaveLog();
        string id;
        bool ismodify = false;
        /// <summary>
        /// 생성자
        /// </summary>
        public FrmStudentRegist()
        {
            InitializeComponent();
        }
        /// <summary>
        /// ID에 대항하는 수강생의 인적사항을 데이터베이스에서 읽어옵니다.
        /// </summary>
        /// <param name="id">수강생의 ID</param>
        public FrmStudentRegist(string id) : this()
        {
            ismodify = true;
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
            var edu = DAO.GetHighestEducation(id);
            txtGrade.Text = edu.Rows[0]["EduType"].ToString();
            txtSchool.Text = edu.Rows[0]["School"].ToString();
            txtMajor.Text = edu.Rows[0]["Department"].ToString();
            if (memberInfo.Rows[0]["Curriculum"].ToString() == "남자")
            {
                rdomale.Checked = true;
            }
            else
            {
                rdoFemale.Checked = true;
            }
        }

        /// <summary>
        /// 수강생의 인적사항을 저장하거나 수정합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
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
            if (ismodify)
            {
                log.AddList("수강생 정보 수정"); 
            }else
            {
                log.AddList("수강생 추가");
            }
            this.Dispose();
        }

        /// <summary>
        /// 현재 창을 종료합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        /// <summary>
        /// FrmStudentRegist 폼의 위치를 화면의 중앙으로 위치시킵니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void FrmStudentRegist_Load(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.Bounds.Size.Width / 2) - (this.Size.Width / 2), (Screen.PrimaryScreen.Bounds.Size.Height / 2) - (this.Size.Height / 2));
        }
    }
}
