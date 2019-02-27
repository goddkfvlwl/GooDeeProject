﻿using System;
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
            //lst.Clear();
            //lst = new GoodeeDAO.GoodeeDAO().ForeginAllFirstAreaName();

            //foreach (FirstSubArea item in lst)
            //{
            //    iTalk.iTalk_Button_1 foreginArea = new iTalk.iTalk_Button_1();
            //    foreginArea.Size = new Size(63, 19);
            //    foreginArea.Font = new Font(fm, 8f);
            //    foreginArea.Text = item.FirstAreaName1;
            //    foreginArea.Click += ForeginArea_Click;
            //    foreginAreaName.Controls.Add(foreginArea);

            //} 
            #endregion

        }

        /// <summary>
        /// 외국지역버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ForeginArea_Click(object sender, EventArgs e)
        {
            //iTalk.iTalk_Button_1 button = (iTalk.iTalk_Button_1)sender;
            //MessageBox.Show(button.Text);
        }

        /// <summary>
        /// 한국지역버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KoreaArea_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(area);

            iTalk.iTalk_Button_1 button = (iTalk.iTalk_Button_1)sender; //현재 sender이 object이기 때문에 
            area = new CheckBoxAdd();

            area.Location = new Point(282, 77);
            area.Size = new Size(435, 237);
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

        public void RemoveControl()
        {
            this.Controls.Remove(area);
        }

        private void iTalk_RichTextBox1_Click(object sender, EventArgs e)
        {
            areaNameSearch.Text = " ";
        }

        
        private void toolStripComboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.toolStripComboBox1.Items.Clear();
                list.Clear();
                foreach (var item in areas)
                {
                    if (item.FirstAreaName1.Contains(this.toolStripComboBox1.Text) || item.SubAreaName.Contains(this.toolStripComboBox1.Text))
                    {
                        list.Add(item.FirstAreaName1 + " > " + item.SubAreaName);
                    }
                }
                this.toolStripComboBox1.Items.AddRange(list.ToArray());
                this.toolStripComboBox1.SelectionStart = this.toolStripComboBox1.Text.Length;
                this.toolStripComboBox1.DroppedDown = true;
            }
        }
    }
}
