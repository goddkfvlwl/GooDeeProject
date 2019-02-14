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
        private static List<FirstSubJob> jlist = new List<FirstSubJob>();
        private static List<FirstSubJob> jlist2 = new List<FirstSubJob>();
        private static List<FirstSubJob> jlistcheck = new List<FirstSubJob>();

        internal static List<FirstSubJob> Jlist { get => jlist; set => jlist = value; }
        internal static List<FirstSubJob> Jlist2 { get => jlist2; set => jlist2 = value; }
        internal static List<FirstSubJob> Jlistcheck { get => jlistcheck; set => jlistcheck = value; }

        string code ="";
        FontFamily fm = new FontFamily("함초롬돋움");
        public JobChoice()
        {
            InitializeComponent();
        }

        private void AreaChoice_Load(object sender, EventArgs e)
        {
            jlist = new GoodeeDAO.GoodeeDAO().AllFirstJobName();
            foreach (FirstSubJob item in jlist)
            {
                firstJobName.Font = new Font(fm, 10f);
                firstJobName.Items.Add(item.FirstJob_Name);
            }
            
        }

        private void firstJobName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(firstJobName.SelectedItem.ToString());
            Jlistcheck.Clear();
            secondJobName.Items.Clear();
            code = new GoodeeDAO.GoodeeDAO().AllFirstAreaName(firstJobName.SelectedItem.ToString());   // 해당 직업으로 코드를 받아냄
            jlist = new GoodeeDAO.GoodeeDAO().selectSecondJob(code);

            foreach (FirstSubJob item in jlist)
            {
                secondJobName.Font = new Font(fm, 10f);
                secondJobName.Items.Add(item.SecondJob_Name);
                //MessageBox.Show(item.SecondJob_Code);
            }
            
        }

        CheckBoxAdd add = new CheckBoxAdd();
        iTalk.iTalk_CheckBox _CheckBox;

        private void secondJobName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Jlistcheck.Clear();
            this.Controls.Remove(add);
            panelChechkBoxAdd();
        }

        private void panelChechkBoxAdd()
        {
            string secondJobCode = "";
            for (int i = 0; i < jlist.Count; i++)
            {
                if (jlist[i].SecondJob_Name == secondJobName.SelectedItem.ToString())
                {
                    secondJobCode = jlist[i].SecondJob_Code;
                }
            }

            add = new CheckBoxAdd();
            add.Location = new Point(312, 67);
            add.Size = new Size(400, 220);
            this.Controls.Add(add);

            jlist2 = new GoodeeDAO.GoodeeDAO().selectDetailJob(secondJobCode);

            foreach (FirstSubJob item in jlist2)
            {
                _CheckBox = new iTalk.iTalk_CheckBox();
                _CheckBox.Text = item.Detailjob_Name;
                _CheckBox.Font = new Font(fm, 9f);
                _CheckBox.CheckedChanged += _CheckBox_CheckedChanged;
                add.flowLayoutPanel1.Controls.Add(_CheckBox);
            }

            
        }

        private void _CheckBox_CheckedChanged(object sender)
        {
            iTalk.iTalk_CheckBox _CheckBox = (iTalk.iTalk_CheckBox)sender;
            //MessageBox.Show(_CheckBox.Text);

            for (int i = 0; i < jlist2.Count; i++)
            {
                if (jlist2[i].Detailjob_Name == _CheckBox.Text)
                {
                    Jlistcheck.Add(new FirstSubJob()
                    {
                        Detailjob_Code = jlist2[i].Detailjob_Code
                    });
                }
            }

            foreach (FirstSubJob item in Jlistcheck)
            {
                MessageBox.Show(item.Detailjob_Code);
            }
        }

    }
}
