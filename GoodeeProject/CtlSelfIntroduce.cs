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
    public partial class CtlSelfIntroduce : UserControl
    {
        GoodeeDAO.GoodeeDAO goodee;
        internal int num;
        public CtlSelfIntroduce()
        {
            InitializeComponent();
            if (String.IsNullOrEmpty(tb_Body.Text) || tb_Body.Text == "자기소개서 내용")
            {
                tb_Body.ForeColor = Color.LightGray;
                tb_Body.Text = "자기소개서 내용";
            }
            if (String.IsNullOrEmpty(tb_Title.Text) || tb_Title.Text == "자기소개서 제목")
            {
                tb_Title.ForeColor = Color.LightGray;
                tb_Title.Text = "자기소개서 제목";
            }

            tb_Title.GotFocus += Tb_Title_GotFocus;
            tb_Body.GotFocus += Tb_Body_GotFocus;

            goodee = GoodeeDAO.GoodeeDAO.GetInstance();
        }

        public CtlSelfIntroduce(string title, string body, int num) : this()
        {
            tb_Title.Text = title;
            tb_Body.Text = body;
            this.num = num;
            tb_Title.ReadOnly = true;
            tb_Title.ForeColor = Color.Black;
            tb_Title.BackColor = Color.White;
            tb_Body.ReadOnly = true;
            tb_Body.BackColor = Color.White;
            tb_Body.ForeColor = Color.Black;
            btn_End.Text = "수정";
        }
        private void Tb_Body_GotFocus(object sender, EventArgs e)
        {
            tb_Body.ForeColor = Color.Black;
            if (String.IsNullOrEmpty(tb_Body.Text) || tb_Body.Text == "자기소개서 내용")
            {
                tb_Body.Text = String.Empty; 
            }
            if (String.IsNullOrEmpty(tb_Title.Text) || tb_Title.Text == "자기소개서 제목")
            {
                tb_Title.ForeColor = Color.LightGray;
                tb_Title.Text = "자기소개서 제목";
            }
    
        }

        private void Tb_Title_GotFocus(object sender, EventArgs e)
        {
            tb_Title.ForeColor = Color.Black;
            if (String.IsNullOrEmpty(tb_Title.Text) || tb_Title.Text == "자기소개서 제목")
            {
                tb_Title.Text = String.Empty;
            }
            if (String.IsNullOrEmpty(tb_Body.Text) || tb_Body.Text == "자기소개서 내용")
            {
                tb_Body.ForeColor = Color.LightGray;
                tb_Body.Text = "자기소개서 내용";
            }
        }

        private void btn_End_Click(object sender, EventArgs e)
        {
            if (btn_End.Text == "작성")
            {
                if (String.IsNullOrEmpty(tb_Title.Text) || tb_Title.Text == "자기소개서 제목")
                {
                    MessageBox.Show("제목을 입력해주세요");
                    return;
                }
                goodee.InsertSelfIntroduction(FrmMain.Ai.Id, tb_Title.Text, tb_Body.Text, DateTime.Today.ToShortDateString(), goodee.GetMax(FrmMain.Ai.Id)+1);
                btn_List_Click(null, null);
            }
            else if  (btn_End.Text == "수정")
            {
                this.tb_Title.ReadOnly = false;
                this.tb_Body.ReadOnly = false;
                this.btn_End.Text = "저장";
            }
            else if (btn_End.Text == "저장")
            {
                goodee.UpdateSelfIntroduction(FrmMain.Ai.Id, tb_Title.Text, tb_Body.Text, DateTime.Today.ToShortDateString(), num);
                btn_List_Click(null, null);
            }
        }

        private void btn_List_Click(object sender, EventArgs e)
        {
            CtlSelfIntroductionList ctlSelf = new CtlSelfIntroductionList();
            ctlSelf.Location = this.Location;
            this.Parent.Controls.Add(ctlSelf);
            this.Parent.Controls.Remove(this);
        }
    }
}
