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

        private void Agreement_enterprise_list_Load(object sender, EventArgs e)
        {
            list = new GoodeeDAO.GoodeeDAO().OutBoard();    // 게시물번호, 게시물제목, 작성자, 작성일, 조회, (좋아요)

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
        Panel panel;
        FrmMain main;
        Agreement_enterprise agreement;
        private void iTalk_Button_12_Click(object sender, EventArgs e)
        {
            panel = (Panel)Parent;
            main = (FrmMain)panel.Parent;
            main.RemoveUserControl();

            agreement = new Agreement_enterprise();
            agreement.Location = new Point(190, 3);
            panel.Controls.Add(agreement);
        }

        private void agreementList1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            int boardNum = 0;   // 게시물 번호

            panel = (Panel)Parent;
            main = (FrmMain)panel.Parent;
            main.RemoveUserControl();

            if (e.IsSelected)
            {
                ListViewItem listViewItem = e.Item;
                boardNum = Int32.Parse(listViewItem.SubItems[0].Text);

                DetailView detail = new DetailView(boardNum);
                detail.Location = new Point(190, 3);
                detail.BringToFront();
                panel.Controls.Add(detail);
            }

        }
    }
}
