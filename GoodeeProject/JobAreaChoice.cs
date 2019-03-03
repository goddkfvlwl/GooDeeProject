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
        List<FirstSubArea> areas;
        List<string> list = new List<string>();
        CheckBoxAdd area;   // 사용자 폼; 동적으로 생성될 체크박스가 여기들어가게 됨
        iTalk.iTalk_CheckBox _CheckBox;
        FontFamily fm = new FontFamily("Microsoft Sans Serif"); // 폰트
        static List<FirstSubArea> lst = new List<FirstSubArea>();

        static List<FirstSubArea> checkResultlist = new List<FirstSubArea>();
        internal static List<FirstSubArea> CheckResultlist { get => checkResultlist; set => checkResultlist = value; }
        string code = "";

        public JobAreaChoice()
        {
            InitializeComponent();
            areas = new GoodeeDAO.GoodeeDAO().AreaAutomaticSearch();

        }

        /// <summary>
        /// 해당 폼이 로드될때 디비의 1차지역들이 화면에 추가된다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        }


        /// <summary>
        /// 한국2차지역버튼이 추가된다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KoreaArea_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(area);

            iTalk.iTalk_Button_1 button = (iTalk.iTalk_Button_1)sender; //현재 sender이 object이기 때문에 
            area = new CheckBoxAdd();

            area.Location = new Point(312,4);
            area.Size = new Size(514,394);
            this.Controls.Add(area);

            // code는 메인지역이름을 받아서 1차지역코드를 반환시켜준다.
            code = new GoodeeDAO.GoodeeDAO().SubAreaCount(button.Text);

            // 2차지역코드와 2차 지역 이름 1차 지역코드
            lst = new GoodeeDAO.GoodeeDAO().SubAreaName(code);
            foreach (FirstSubArea item in lst)
            {
                _CheckBox = new iTalk.iTalk_CheckBox();
                _CheckBox.Text = item.SubAreaName;
                _CheckBox.CheckedChanged += _CheckBox_CheckedChanged;
                area.flowLayoutPanel1.Controls.Add(_CheckBox);

            }

        }

        /// <summary>
        /// 체크박스를 눌렀을때 리스트에 추가하고 풀면 빼면서, 이 결과를 list에 저장해서 키워드로 넘긴다.
        /// </summary>
        /// <param name="sender"></param>
        private void _CheckBox_CheckedChanged(object sender)
        {
            iTalk.iTalk_CheckBox _CheckBox = (iTalk.iTalk_CheckBox)sender;


            if (_CheckBox.Checked) // 체크를 풀었을 경우 이미 checkResultlist에 들어간 부분을 삭제해주어야 하기 때문에
            {
                for (int i = 0; i < lst.Count; i++)
                {
                    if (lst[i].SubAreaName == _CheckBox.Text)
                    {
                        checkResultlist.Add(new FirstSubArea()
                        {
                            SubAreaCode = lst[i].SubAreaCode,
                            SubAreaName = lst[i].SubAreaName
                        });
                    }
                }
            }
            else
            {
                for (int j = 0; j < checkResultlist.Count; j++) // 체크를 풀었을시에 삭제부분
                {
                    if (checkResultlist[j].SubAreaName == _CheckBox.Text)
                    {
                        checkResultlist.RemoveAt(j);
                    }
                }
            }

        }

        /// <summary>
        /// 해당 폼에서의 컨트롤 초기화
        /// </summary>
        public void RemoveControl()
        {
            this.Controls.Remove(area);
        }
        

    }
}
