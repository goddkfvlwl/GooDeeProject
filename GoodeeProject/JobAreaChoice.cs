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
    public partial class JobAreaChoice : UserControl
    {
        GoodeeDAO.GoodeeDAO gd;
        static List<FirstSubArea> lst;
        FontFamily fm = new FontFamily("함초롬돋움");

        internal static List<FirstSubArea> Lst { get => lst; set => lst = value; }

        public JobAreaChoice()
        {
            InitializeComponent();
            
        }

        
        private void iTalk_Button_12_Click(object sender, EventArgs e)
        {
            Area seoul = new Area();
            seoul.Location = new Point(254, 58);
            seoul.Parent = this;
            
        }

        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {
            #region 지역버튼을 누르면 해당 서브지역이 생성
            //Area seoul = new Area();
            //seoul.Location = new Point(254, 58);
            //seoul.Parent = this;
            #endregion

            #region 2개의 프로시저를 사용하여 지역의 서브와 합친 경우
            //string code = new GoodeeDAO.GoodeeDAO().SubAreaCount("서울");
            //lst = new GoodeeDAO.GoodeeDAO().SubAreaName(code);
            //foreach (FirstSubArea item in lst)
            //{
            //    MessageBox.Show(item.SubAreaName);

            //} 
            #endregion

            
        }

        private void JobAreaChoice_Load(object sender, EventArgs e)
        {
            #region 한국대표지역추가
            lst = new GoodeeDAO.GoodeeDAO().AllFirstAreaName();
            
            foreach (FirstSubArea item in lst)
            {
                iTalk.iTalk_Button_1 koreaArea = new iTalk.iTalk_Button_1();
                koreaArea.Size = new Size(45, 19);
                koreaArea.Font = new Font(fm, 8f);
                //koreaArea.Font = new Font(koreaArea.Text, 8.9f, FontStyle.Regular);
                koreaArea.Text = item.FirstAreaName1;
                koreaArea.Click += KoreaArea_Click;
                koreaAreaPanel.Controls.Add(koreaArea);
                
            }
            #endregion

            #region 외국지역추가
            lst.Clear();
            lst = new GoodeeDAO.GoodeeDAO().ForeginAllFirstAreaName();

            foreach (FirstSubArea item in lst)
            {
                iTalk.iTalk_Button_1 foreginArea = new iTalk.iTalk_Button_1();
                foreginArea.Size = new Size(63, 19);
                foreginArea.Font = new Font(fm, 8f);
                foreginArea.Text = item.FirstAreaName1;
                foreginArea.Click += ForeginArea_Click;
                foreginAreaName.Controls.Add(foreginArea);

            } 
            #endregion

        }

        /// <summary>
        /// 외국지역버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ForeginArea_Click(object sender, EventArgs e)
        {
            iTalk.iTalk_Button_1 button = (iTalk.iTalk_Button_1)sender;
            MessageBox.Show(button.Text);
        }

        /// <summary>
        /// 한국지역버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KoreaArea_Click(object sender, EventArgs e)
        {
            iTalk.iTalk_Button_1 button = (iTalk.iTalk_Button_1)sender;
            Area area = new Area();
            
            area.Location = new Point(282, 77);
            area.Size = new Size(435, 237);
            this.Controls.Add(area);

            string code = new GoodeeDAO.GoodeeDAO().SubAreaCount(button.Text);
            iTalk.iTalk_CheckBox _CheckBox;
            lst = new GoodeeDAO.GoodeeDAO().SubAreaName(code);
            foreach (FirstSubArea item in lst)
            {
                _CheckBox = new iTalk.iTalk_CheckBox();
                _CheckBox.Text = item.SubAreaName;
                _CheckBox.Click += _CheckBox_Click;
                area.flowLayoutPanel1.Controls.Add(_CheckBox);

            }

            
        }


        private void _CheckBox_Click(object sender, EventArgs e)
        {
            // 현재 강서구 두개임
            iTalk.iTalk_CheckBox _CheckBox = (iTalk.iTalk_CheckBox)sender;

            foreach (FirstSubArea item in new GoodeeDAO.GoodeeDAO().AllDetailArea(_CheckBox.Text))
            {
                lst.Add(new FirstSubArea()
                {
                    SubAreaCode = item.SubAreaCode
                });
            }


        }


    }
}
