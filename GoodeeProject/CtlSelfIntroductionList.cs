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
    public partial class CtlSelfIntroductionList : UserControl
    {
        GoodeeDAO.GoodeeDAO goodee;
        internal DataTable introductionList;
        public CtlSelfIntroductionList()
        {
            InitializeComponent();
            goodee = GoodeeDAO.GoodeeDAO.GetInstance();
            GetBoard();
     
        }

        private void GetBoard()
        {
            flowLayoutPanel1.Controls.Clear();
            introductionList = goodee.SelectSelfIntroduction(FrmMain.Ai.Id);
            if (introductionList.Rows.Count != 0)
            {
                foreach (DataRow item in introductionList.Rows)
                {
                    CtlSelfIntroductionItem introductionitem = new CtlSelfIntroductionItem();
                    introductionitem.lbl_Title.Text = item["Title"].ToString();
                    //introductionitem.lbl_Body.Text = item["Body"].ToString();
                    introductionitem.lbl_Body.Text = item["Body"].ToString().Length > 35 ? item["Body"].ToString().Remove(35) : item["Body"].ToString();
                    DateTime dt = (DateTime)item["WriteDate"];
                    introductionitem.lbl_Date.Text = dt.ToLongDateString();
                    introductionitem.num = (int)item["Num"];
                    flowLayoutPanel1.Controls.Add(introductionitem);
                }
            }
            else
            {
                CtlSelfIntroductionItem introductionitem = new CtlSelfIntroductionItem();
                introductionitem.lbl_Title.Text = "등록된 자기소개서가 없습니다.";
                introductionitem.lbl_Body.Text = "새로운 자기소개서를 등록해주세요.";
                introductionitem.lbl_Date.Text = "";
                introductionitem.DoubleClick -= introductionitem.CtlSelfIntroductionItem_DoubleClick;
                introductionitem.Click -= introductionitem.CtlSelfIntroductionItem_Click;
                flowLayoutPanel1.Controls.Add(introductionitem);
            }
        }

        private void btn_Write_Click(object sender, EventArgs e)
        {
            CtlSelfIntroduce ctlSelf = new CtlSelfIntroduce();
            ctlSelf.Location = this.Location;
            this.Parent.Controls.Add(ctlSelf);
            this.Parent.Controls.Remove(this);
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            bool check = false;
            if (MessageBox.Show("선택된 자기소개서를 삭제하시겠습니까?", "확인", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                foreach (CtlSelfIntroductionItem item in flowLayoutPanel1.Controls)
                {
                    if (item.selected == true)
                    {
                        if (goodee.DeleteSelfIntroduction(FrmMain.Ai.Id, item.num))
                        {
                            check = true;
                        }
                        else
                        {
                            MessageBox.Show("삭제 실패");
                            check = true;
                        }
                    }
                }
            }
          
            if (check)
            {
                MessageBox.Show("삭제 성공", "삭제 완료");
                GetBoard();
            }
            else
            {
                MessageBox.Show("선택된 자기소개서가 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
