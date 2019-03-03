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
using System.IO;

namespace GoodeeProject
{
    public partial class CtlModifyMemberInfo : UserControl
    {
        SaveLog s = new SaveLog();

        Image profileImg;
        GoodeeDAO.GoodeeDAO gd;

        public CtlModifyMemberInfo()
        {
            InitializeComponent();
            tboxMobile.Text = FrmMain.Mi.Mobile;
            tboxDetailAddr.Text = FrmMain.Mi.Address;
            tboxHopePay.Text = FrmMain.Mi.HopePay;
            gd = GoodeeDAO.GoodeeDAO.GetInstance();
            pboxPic.Image = FrmMain.Mi.Picture;

            s.AddList("회원정보수정 클릭");
        }
        /// <summary>
        /// 주소검색API 폼을 띄우는 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearhAddr_Click(object sender, EventArgs e)
        {
            FrmSearchAddr sa = new FrmSearchAddr();
            sa.Owner = (FrmModify)this.Parent.Parent;
            sa.FormClosed += Sa_FormClosed;
            sa.Show();


        }
        /// <summary>
        /// 선택한 주소를 가져오는 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Sa_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmModify parent = (FrmModify)this.Parent.Parent;
            this.tboxAddr.Text = parent.Addr;
        }

        private void CtlModifyMemberInfo_Paint(object sender, PaintEventArgs e)
        {
            Rectangle borderRectangle = this.ClientRectangle;
            borderRectangle.Inflate(0, 0);
            ControlPaint.DrawBorder(e.Graphics, borderRectangle, Color.DimGray, ButtonBorderStyle.Solid);
        }
        /// <summary>
        /// 유효성검사를 마친 데이터를 Update 시켜주는 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModify_Click(object sender, EventArgs e)
        {
            string mobilePattern = "^[0-9]{2,3}-[0-9]{3,4}-[0-9]{4}$";  //핸드폰 정규식

            if (pboxPic.Image == null)
            {
                profileImg = null;
            }
            else
            {
                profileImg = pboxPic.Image;
            }

            if (!(String.IsNullOrEmpty(tboxDetailAddr.Text) && String.IsNullOrEmpty(tboxMobile.Text)))
            {
                if (Regex.IsMatch(tboxMobile.Text.Trim(), mobilePattern))
                {
                    //업데이트
                    gd.UpdateMemberInfo(FrmMain.Mi.Id, tboxMobile.Text, tboxAddr.Text + tboxDetailAddr.Text, tboxHopePay.Text, profileImg);
                    MessageBox.Show("수정 성공");
                    this.ParentForm.Close();
                    s.AddList("정보수정 버튼 클릭");
                    Invalidate();
                }
                else
                {
                    MessageBox.Show("000-0000-0000 형식의 핸드폰번호를 작성해주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("필수 기재사항을 입력해주세요", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// 프로필사진을 설정하는 메서드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPicture_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pboxPic.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        
    }
}
