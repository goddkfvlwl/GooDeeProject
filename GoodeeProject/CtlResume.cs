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
    public partial class CtlResume : UserControl
    {
        iTalk.iTalk_Button_1 btnEdu;
        iTalk.iTalk_Button_1 btnLicense;

        public CtlResume()
        {
            InitializeComponent();
        }

        private void CtlResume_Load(object sender, EventArgs e)
        {
            //학력 패널
            CtlEdu ce = new CtlEdu();
            flowpanelEdu.Controls.Add(ce);
            btnEdu = new iTalk.iTalk_Button_1();
            flowpanelEdu.Controls.Add(btnEdu);
            btnEdu.Size = new Size(755, 20);
            btnEdu.Text = "학력  추가";

            //자격증 패널
            CtlLicense cl = new CtlLicense();
            flowpanelLicense.Controls.Add(cl);
            btnLicense = new iTalk.iTalk_Button_1();
            flowpanelLicense.Controls.Add(btnLicense);
            btnLicense.Size = new Size(755, 20);
            btnLicense.Text = "자격증 추가";


            btnEdu.Click += Btn_Click;
            btnLicense.Click += BtnLicense_Click;
        }

        private void BtnLicense_Click(object sender, EventArgs e)
        {
            CtlLicense cl = new CtlLicense();
            flowpanelLicense.Controls.Add(cl);
            flowpanelLicense.Controls.SetChildIndex(btnLicense, flowpanelLicense.Controls.Count);
            flowpanelLicense.AutoScroll = true;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            CtlEdu ce = new CtlEdu();
            flowpanelEdu.Controls.Add(ce);
            flowpanelEdu.Controls.SetChildIndex(btnEdu, flowpanelEdu.Controls.Count);
            flowpanelEdu.AutoScroll = true;
        }
    }
}
