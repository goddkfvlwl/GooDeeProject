using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GoodeeProject
{
    public partial class CtlCreateCom : UserControl
    {
        GoodeeDAO.GoodeeDAO goodee;
        public CtlCreateCom()
        {
            InitializeComponent();
            goodee = GoodeeDAO.GoodeeDAO.GetInstance();
        }



        private void btn_Search_Click(object sender, EventArgs e)
        {
            FrmCreateID parent = (FrmCreateID)this.Parent.Parent;
            FrmSearchAddr frmSearch = new FrmSearchAddr(parent.GetType());
            frmSearch.Owner = parent;
            frmSearch.Show();
            frmSearch.FormClosed += FrmSearch_FormClosed;
        }

        private void FrmSearch_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmCreateID frm = (FrmCreateID)this.Parent.Parent;
            this.tb_Address.Text = frm.Addr;
        }

        private void btn_CreateID_Click(object sender, EventArgs e)
        {
            string mobilePattern = "^[0-9]{2,3}-[0-9]{3,4}-[0-9]{4}$";  //핸드폰 정규식

            if (!goodee.CheckID(tb_Email.Text))
            {
                MessageBox.Show("이메일이 중복되었습니다.");
                return;
            }

            if (String.IsNullOrEmpty(tb_Password.Text))
            {
                MessageBox.Show("비밀번호를 입력해주세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(tb_Name.Text))
            {
                MessageBox.Show("이름을 입력해주세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (!String.IsNullOrEmpty(tb_Phone.Text))
            {
                //if (!tb_Phone.Text.Contains('-'))
                //{
                //    tb_Phone.Text = tb_Phone.Text.Insert(6, "-");
                //    tb_Phone.Text = tb_Phone.Text.Insert(4, "-");
                //}
                //if (!Regex.IsMatch(tb_Phone.Text.Trim(), mobilePattern))
                //{
                //    MessageBox.Show("11자리의 핸드폰번호를 입력해주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    tb_Phone.Text = String.Empty;
                //    tb_Phone.Focus();
                //    return;
                //}
            }
            else
            {
                MessageBox.Show("전화번호를 입력해주세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Phone.Focus();
                return;
            }

            MemberInfo info;
            info = new MemberInfo()
            {
                Id = tb_Email.Text,
                Name = tb_Name.Text,
                Mobile = tb_Phone.Text,
                Address = tb_Address.Text + " " + tb_AddressDetail.Text,
                Gender = 'M'
            };
            if (goodee.InsertAdmin(info, tb_Password.Text, 'C'))
            {
                MessageBox.Show("저장성공");
            }
            else
            {
                MessageBox.Show("실패");
            }
        }
    }
}
