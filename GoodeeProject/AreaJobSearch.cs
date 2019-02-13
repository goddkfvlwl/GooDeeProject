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
    public partial class AreaJobSearch : UserControl
    {
        List<FirstSubArea> lst = new List<FirstSubArea>();  // 지역
        List<FirstSubJob> list = new List<FirstSubJob>();
        FontFamily fm = new FontFamily("함초롬돋움");    // 폰트 이름
        public AreaJobSearch()
        {
            InitializeComponent();
        }

        private void AreaJobSearch_Load(object sender, EventArgs e)
        {
            #region 첫 번째 지역 콤보박스 추가
            lst = new GoodeeDAO.GoodeeDAO().AllFirstAreaName();
            foreach (FirstSubArea item in lst)
            {
                firstAreaComb.Items.Add(item.FirstAreaName1);
                
            }
            #endregion


            #region 첫 번째 직종 콤보박스 추가
            list = new GoodeeDAO.GoodeeDAO().AllFirstJobName();
            foreach (FirstSubJob item in list)
            {
                firstJobComb.Items.Add(item.FirstJob_Name);
            } 
            #endregion
        }

        private void firstAreaComb_SelectedIndexChanged(object sender, EventArgs e)
        {
            lst.Clear();
            //MessageBox.Show(firstAreaComb.SelectedItem.ToString());
            string code = new GoodeeDAO.GoodeeDAO().SubAreaCount(firstAreaComb.SelectedItem.ToString());
            lst = new GoodeeDAO.GoodeeDAO().SubAreaName(code);

            secondAreaComb.Items.Clear();
            foreach (FirstSubArea item in lst)
            {
                secondAreaComb.Items.Add(item.SubAreaName);
            }
        }

        private void firstJobComb_SelectedIndexChanged(object sender, EventArgs e)
        {
            list.Clear();
            //string code = new GoodeeDAO.GoodeeDAO().SubJobCount(firstJobComb.SelectedItem.ToString());
        }
    }
}
