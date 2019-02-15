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
        public CtlSelfIntroductionList()
        {
            InitializeComponent();
            goodee = GoodeeDAO.GoodeeDAO.GetInstance();
            GetBoard();
     
        }

        private void GetBoard()
        {
            DataTable introductionList = goodee.SelectSelfIntroduction(FrmMain.Ai.Id);
            if (introductionList.Rows.Count != 0)
            {
                foreach (DataRow item in introductionList.Rows)
                {
                    CtlSelfIntroductionItem introductionitem = new CtlSelfIntroductionItem();
                    introductionitem.lbl_Title.Text = item["ID"].ToString();
                    introductionitem.lbl_Body.Text = item["body"].ToString();
                    introductionitem.lbl_Date.Text = item["WriteDate"].ToString();

                    flowLayoutPanel1.Controls.Add(introductionitem);
                }
            }
        }
    }
}
