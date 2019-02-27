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
    public partial class CtlMBTIResult : UserControl
    {
        GoodeeDAO.GoodeeDAO gd;
        DataTable mbtiResult;
        iTalk.iTalk_TextBox_Small tbSearch;

        public CtlMBTIResult()
        {
            InitializeComponent();
            gd = GoodeeDAO.GoodeeDAO.GetInstance();
        }

        private void CtlMBTIResult_Load(object sender, EventArgs e)
        {
            
            if (FrmMain.Ai.Authority == 'S')
            {
                //학생일 때 본인 결과만
                mbtiResult = gd.SelectMBTI_Stats_Stu(FrmMain.Mi.Id);
                ListViewOutPut();
            }
            else
            {
                //나머지는 전체

                tbSearch = new iTalk.iTalk_TextBox_Small();
                tbSearch.Size = new Size(211, 28);
                tbSearch.Location = new Point(268, 21);
                tbSearch.Text = "";

                iTalk.iTalk_Button_1 btnSearch = new iTalk.iTalk_Button_1();
                btnSearch.Size = new Size(75, 30);
                btnSearch.Location = new Point(485, 21);
                btnSearch.Text = "이름검색";

                this.Controls.Add(tbSearch);
                this.Controls.Add(btnSearch);

                mbtiResult = gd.SelectMBTI_Stats();
                ListViewOutPut();
                btnSearch.Click += BtnSearch_Click;
            }

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbSearch.Text))
            {
                mbtiResult = new DataTable();
                mbtiResult = gd.SelectMBTI_StatsByName(tbSearch.Text);
                ListViewOutPut();
                tbSearch.Text = "";
            }
            else
            {
                MessageBox.Show("검색할 이름을 입력해주세요");
            }
        }

        private void ListViewOutPut()
        {
            lvResult.Clear();
            lvResult.BeginUpdate();
            lvResult.View = View.Details;
            lvResult.FullRowSelect = true;

            foreach (DataRow item in mbtiResult.DataSet.Tables[0].Rows)
            {
                lvResult.Items.Add(new ListViewItem(new string[] {
                        item["name"].ToString() ,item["ID"].ToString(), item["MBTIDate"].ToString().Substring(0, 10), item["Result"].ToString()
                    }));
            }
            lvResult.Columns.Add("이름", 200, HorizontalAlignment.Center);
            lvResult.Columns.Add("아이디", 200, HorizontalAlignment.Center);
            lvResult.Columns.Add("날짜", 200, HorizontalAlignment.Center);
            lvResult.Columns.Add("결과", 200, HorizontalAlignment.Center);

            lvResult.EndUpdate();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            CtlMBTIResult_Load(null, null);
        }

        private void lvResult_DoubleClick(object sender, EventArgs e)
        {
            if (lvResult.SelectedItems[0] != null)
            {
                DataTable result = gd.SelectMBTI_Stats_Stu(lvResult.SelectedItems[0].SubItems[1].Text);
                FrmMBTIResult mr = new FrmMBTIResult(result);
                mr.Show();
            }
        }
    }
}
