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
    public partial class CtlCreateManager : UserControl
    {
        char gender;
        char army;
        GoodeeDAO.GoodeeDAO goodee;

        public CtlCreateManager()
        {
            InitializeComponent();
            goodee = GoodeeDAO.GoodeeDAO.GetInstance();
        }
        private void btn_CreateID_Click(object sender, EventArgs e)
        {

            string mobilePattern = "^[0-9]{2,3}-[0-9]{3,4}-[0-9]{4}$";  //핸드폰 정규식
            string datePattern = @"^\d{4}-(0[0-9]|1[0,1,2])-([0,1,2][0-9]|3[0,1])$";

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

            if (!String.IsNullOrEmpty(tb_BirthDate.Text))
            {
                if (!tb_BirthDate.Text.Contains('-'))
                {
                    tb_BirthDate.Text = tb_BirthDate.Text.Insert(6, "-");
                    tb_BirthDate.Text = tb_BirthDate.Text.Insert(4, "-");
                }
                if (!Regex.IsMatch(tb_BirthDate.Text.Trim(), datePattern))
                {
                    MessageBox.Show("0000-00-00 형식의 생년월일을 입력해주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_BirthDate.Text = String.Empty;
                    tb_BirthDate.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("생년월일을 입력해주세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_BirthDate.Focus();
                return;
            }

            if (!String.IsNullOrEmpty(tb_Phone.Text))
            {
                if (!tb_Phone.Text.Contains('-'))
                {
                    tb_Phone.Text = tb_Phone.Text.Insert(6, "-");
                    tb_Phone.Text = tb_Phone.Text.Insert(4, "-");
                }
                if (!Regex.IsMatch(tb_Phone.Text.Trim(), mobilePattern))
                {
                    MessageBox.Show("11자리의 핸드폰번호를 입력해주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_Phone.Text = String.Empty;
                    tb_Phone.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("전화번호를 입력해주세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Phone.Focus();
                return;
            }

            if (!chk_Male.Checked && !chk_Female.Checked)
            {
                MessageBox.Show("성별을 선택해주세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(tb_Address.Text))
            {
                MessageBox.Show("주소를 입력해주세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MemberInfo info;
            info = new MemberInfo()
            {
                Id = tb_Email.Text,
                Name = tb_Name.Text,
                BirthDate = DateTime.Parse(tb_BirthDate.Text),
                Gender = gender,
                Mobile = tb_Phone.Text,
                Address = tb_Address.Text + " " + tb_AddressDetail.Text,
                Army = army,
                Picture = pictureBox1.Image
            };
            if (goodee.InsertAdmin(info, tb_Password.Text, 'A'))
            {
                MessageBox.Show("저장성공");
            }
            else
            {
                MessageBox.Show("실패");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void chk_Female_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Female.Checked)
            {
                chk_Male.Checked = false;
                CheckBox checkBox = (CheckBox)sender;
                gender = Char.Parse(checkBox.Tag.ToString());
            }
        }

        private void chk_Male_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Male.Checked)
            {
                chk_Female.Checked = false;
                CheckBox checkBox = (CheckBox)sender;
                gender = Char.Parse(checkBox.Tag.ToString());
            }
        }

        private void chk_ArmyY_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ArmyY.Checked)
            {
                chk_ArmyN.Checked = false;
                CheckBox checkBox = (CheckBox)sender;
                army = Char.Parse(checkBox.Tag.ToString());
            }
        }

        private void chk_ArmyN_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_ArmyN.Checked)
            {
                chk_ArmyY.Checked = false;
                CheckBox checkBox = (CheckBox)sender;
                army = Char.Parse(checkBox.Tag.ToString());
            }
        }

        public void Frm_BorderPaint(object sender, PaintEventArgs e)
        {
            Rectangle borderRectangle = this.ClientRectangle;
            borderRectangle.Inflate(0, 0);
            ControlPaint.DrawBorder(e.Graphics, borderRectangle, Color.DimGray, ButtonBorderStyle.Solid);
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

        private void tb_BirthDate_TextChanged(object sender, EventArgs e)
        {
            if (tb_BirthDate.Text.Length > 8)
            {
                return;
            }
        }
    }
}

