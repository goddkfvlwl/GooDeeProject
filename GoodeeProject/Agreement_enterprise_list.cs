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

        /// <summary>
        /// 해당 폼이 로드될 경우이다.
        /// 게시판에 작성된 목록들이 리스트 박스에 표시된다
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Agreement_enterprise_list_Load(object sender, EventArgs e)
        {
            list = new GoodeeDAO.GoodeeDAO().OutBoard();    // 게시물번호, 게시물제목, 작성자, 작성일, 조회

            agreementList1.BeginUpdate();

            agreementList1.View = View.Details;

            foreach (AgreementBoard ab in list)
            {
                ListViewItem lvi = new ListViewItem(ab.BoardNum.ToString());
                lvi.SubItems.Add(ab.Title);
                lvi.SubItems.Add(ab.Id);
                lvi.SubItems.Add(ab.WriteDate.ToString("yyyy.MM.dd"));
                lvi.SubItems.Add(ab.Hits.ToString());

                agreementList1.Items.Add(lvi);
            }


            agreementList1.Columns.Add("게시물번호", 80, HorizontalAlignment.Left);
            agreementList1.Columns.Add("제목", 250, HorizontalAlignment.Left);
            agreementList1.Columns.Add("작성자", 100, HorizontalAlignment.Left);
            agreementList1.Columns.Add("작성일", 100, HorizontalAlignment.Left);
            agreementList1.Columns.Add("조회", 50, HorizontalAlignment.Left);
            agreementList1.EndUpdate();
        }
        
    }
}
