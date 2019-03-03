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
    public partial class JobChoice : UserControl
    {
        private List<FirstSubJob> jlist = new List<FirstSubJob>(); // 1차지역코드 1차 지역이름
        private List<FirstSubJob> jlist2 = new List<FirstSubJob>(); // 1차지역코드 2차지역이름 2차지역코드
        private List<FirstSubJob> jlist3 = new List<FirstSubJob>(); // 


        private static List<FirstSubJob> jlistcheck = new List<FirstSubJob>();
        internal static List<FirstSubJob> Jlistcheck { get => jlistcheck; set => jlistcheck = value; }

        string code = "";
        FontFamily fm = new FontFamily("Microsoft Sans Serif");
        public JobChoice()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 해당 폼이 로드시, 1차 직종이 리스트박스에 추가된다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AreaChoice_Load(object sender, EventArgs e)
        {
            jlist = new GoodeeDAO.GoodeeDAO().AllFirstJobName();  // 전체 1차 직종코드랑 1차 직종 이름을 반환한다.

            foreach (FirstSubJob item in jlist)
            {
                firstJobName.Font = new Font(fm, 10f);
                firstJobName.Items.Add(item.FirstJob_Name);
            }

        }

        /// <summary>
        /// 1차 직종코드를 선택시 해당하는 2차 직종코드가 리스트박스에 추가가된다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void firstJobName_SelectedIndexChanged(object sender, EventArgs e)
        {
            secondJobName.Items.Clear();
            for (int i = 0; i < jlist.Count; i++)
            {
                if (jlist[i].FirstJob_Name == firstJobName.SelectedItem.ToString())
                {
                    code = jlist[i].FirstJob_Code;
                    jlist2 = new GoodeeDAO.GoodeeDAO().selectSecondJob(code);   
                    // 1차 지역코드를 넘겨서 1차지역코드, 2차지역이름, 2차지역코드
                }
            }
            foreach (FirstSubJob item in jlist2)
            {
                secondJobName.Font = new Font(fm, 10f);
                secondJobName.Items.Add(item.SecondJob_Name);

            }
        }

        CheckBoxAdd add = new CheckBoxAdd();
        iTalk.iTalk_CheckBox _CheckBox;
        
        /// <summary>
        /// 3차 직종을 띄운다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void secondJobName_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Controls.Remove(add);
            panelChechkBoxAdd();    // 3차 직종을 띄우는 메서드
        }

        /// <summary>
        /// 해당 체크할 것을 넘긴다.
        /// 키워드로 넘길 list의 메서드
        /// </summary>
        private void panelChechkBoxAdd()
        {
            string secondJobCode = "";

            for (int i = 0; i < jlist2.Count; i++)
            {
                if (jlist2[i].SecondJob_Name == secondJobName.SelectedItem.ToString())
                {
                    secondJobCode = jlist2[i].SecondJob_Code;
                    jlist3 = new GoodeeDAO.GoodeeDAO().selectDetailJob(secondJobCode);  // 3차지역코드 3차지역이름 2차지역코드
                }
            }

            add = new CheckBoxAdd();
            add.Location = new Point(348, 53);
            add.Size = new Size(507, 520);
            this.Controls.Add(add);

            foreach (FirstSubJob item in jlist3)
            {
                _CheckBox = new iTalk.iTalk_CheckBox();
                _CheckBox.Text = item.Detailjob_Name;
                _CheckBox.Font = new Font(fm, 9f);
                _CheckBox.CheckedChanged += _CheckBox_CheckedChanged;
                //add.flowLayoutPanel.
                add.flowLayoutPanel1.Controls.Add(_CheckBox);
            }


        }

        /// <summary>
        /// 키워드의 리스트를 넘길경우 체크박스도 생각해야 하는데
        /// 체크가 풀릴경우, 유지될경우를 인식해 키워드를 넘긴다.
        /// </summary>
        /// <param name="sender"></param>
        private void _CheckBox_CheckedChanged(object sender)
        {
            iTalk.iTalk_CheckBox _CheckBox = (iTalk.iTalk_CheckBox)sender;

            if (_CheckBox.Checked)
            {
                for (int i = 0; i < jlist3.Count; i++)
                {
                    if (jlist3[i].Detailjob_Name == _CheckBox.Text)
                    {
                        jlistcheck.Add(new FirstSubJob()
                        {
                            Detailjob_Code = jlist3[i].Detailjob_Code,
                            Detailjob_Name = jlist3[i].Detailjob_Name
                        });
                    }
                }
            }
            else
            {
                for (int j = 0; j < jlistcheck.Count; j++)
                {
                    if (jlistcheck[j].Detailjob_Name == _CheckBox.Text)
                    {
                        jlistcheck.RemoveAt(j);
                    }
                }
            }
        }

    }
}
