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
        GoodeeDAO.GoodeeDAO gd;

        iTalk.iTalk_Button_1 btnEdu;
        iTalk.iTalk_Button_1 btnDelEdu;
        iTalk.iTalk_Button_1 btnLicense;
        iTalk.iTalk_Button_1 btnDelLicense;
        iTalk.iTalk_Button_1 btnEduHistory;
        iTalk.iTalk_Button_1 btnDelEduHistory;

        CtlEduHistory ch;
        CtlEdu ce;
        CtlLicense cl;

        public CtlResume()
        {
            InitializeComponent();
            gd = GoodeeDAO.GoodeeDAO.GetInstance();
            this.Size = new Size(818, 454);
        }

        private void CtlResume_Load(object sender, EventArgs e)
        {
            //학력 패널
            ce = new CtlEdu();
            flowpanelEdu.Controls.Add(ce);

            btnEdu = new iTalk.iTalk_Button_1();
            flowpanelEdu.Controls.Add(btnEdu);
            btnEdu.Size = new Size(755, 20);
            btnEdu.Text = "학력  추가";

            btnDelEdu = new iTalk.iTalk_Button_1();
            flowpanelEdu.Controls.Add(btnDelEdu);
            btnDelEdu.Size = new Size(755, 20);
            btnDelEdu.Text = "학력  제거";

            //자격증 패널
            cl = new CtlLicense();
            flowpanelLicense.Controls.Add(cl);
            btnLicense = new iTalk.iTalk_Button_1();
            flowpanelLicense.Controls.Add(btnLicense);
            btnLicense.Size = new Size(755, 20);
            btnLicense.Text = "자격증 추가";

            btnDelLicense = new iTalk.iTalk_Button_1();
            flowpanelLicense.Controls.Add(btnDelLicense);
            btnDelLicense.Size = new Size(755, 20);
            btnDelLicense.Text = "자격증 제거";

            //교육 이력 패널
            ch = new CtlEduHistory();
            flowPanelEduHistory.Controls.Add(ch);
            btnEduHistory = new iTalk.iTalk_Button_1();
            flowPanelEduHistory.Controls.Add(btnEduHistory);
            btnEduHistory.Size = new Size(755, 20);
            btnEduHistory.Text = "교육 이력 추가";

            btnDelEduHistory = new iTalk.iTalk_Button_1();
            flowPanelEduHistory.Controls.Add(btnDelEduHistory);
            btnDelEduHistory.Size = new Size(755, 20);
            btnDelEduHistory.Text = "교육 이력 제거";


            btnEdu.Click += Btn_Click;
            btnLicense.Click += BtnLicense_Click;
            btnEduHistory.Click += BtnEduHistory_Click;

            btnDelEdu.Click += BtnDelEdu_Click;
            btnDelLicense.Click += BtnDelLicense_Click;
            btnDelEduHistory.Click += BtnDelEduHistory_Click;

            ReceiveInfo();
        }

        private void ReceiveInfo()
        {
            tboxName.Text = FrmMain.Mi.Name;
            if (!String.IsNullOrEmpty(FrmMain.Mi.BirthDate.ToString()))
            {
                tboxBirthDate.Text = FrmMain.Mi.BirthDate.ToShortDateString();
            }
            else
            {
                tboxBirthDate.Text = "";
            }
            if (FrmMain.Mi.Gender == 'M')
            {
                radioGenderM.Checked = true;
            }
            else
            {
                radioGenderW.Checked = true;
            }
            tboxAddr.Text = FrmMain.Mi.Address;
            tboxMobile.Text = FrmMain.Mi.Mobile;
            tboxEmail.Text = FrmMain.Mi.Id;
            if (FrmMain.Mi.Army == 'Y')
            {
                radioArmyY.Checked = true;
            }
            else
            {
                radioArmyN.Checked = true;
            }
            pboxProfile.Image = FrmMain.Mi.Picture;
            pboxProfile.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void BtnDelEduHistory_Click(object sender, EventArgs e)
        {
            try
            {
                flowPanelEduHistory.Controls.RemoveAt(flowPanelEduHistory.Controls.Count - 3);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("삭제 할 자격증이 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelLicense_Click(object sender, EventArgs e)
        {
            try
            {
                flowpanelLicense.Controls.RemoveAt(flowpanelLicense.Controls.Count - 3);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("삭제 할 자격증이 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelEdu_Click(object sender, EventArgs e)
        {
            try
            {
                flowpanelEdu.Controls.RemoveAt(flowpanelEdu.Controls.Count - 3);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("삭제 할 학력이 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEduHistory_Click(object sender, EventArgs e)
        {
            ch = new CtlEduHistory();
            flowPanelEduHistory.Controls.Add(ch);
            flowPanelEduHistory.Controls.SetChildIndex(btnEduHistory, flowPanelEduHistory.Controls.Count - 1);
            flowPanelEduHistory.Controls.SetChildIndex(btnDelEduHistory, flowPanelEduHistory.Controls.Count);
            flowPanelEduHistory.AutoScroll = true;
        }

        private void BtnLicense_Click(object sender, EventArgs e)
        {
            cl = new CtlLicense();
            flowpanelLicense.Controls.Add(cl);
            flowpanelLicense.Controls.SetChildIndex(btnLicense, flowpanelLicense.Controls.Count - 1);
            flowpanelLicense.Controls.SetChildIndex(btnDelLicense, flowpanelLicense.Controls.Count);
            flowpanelLicense.AutoScroll = true;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            ce = new CtlEdu();
            flowpanelEdu.Controls.Add(ce);
            flowpanelEdu.Controls.SetChildIndex(btnEdu, flowpanelEdu.Controls.Count - 1);
            flowpanelEdu.Controls.SetChildIndex(btnDelEdu, flowpanelEdu.Controls.Count);
            flowpanelEdu.AutoScroll = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 자격증 추가
            for (int i = 0; i < flowpanelLicense.Controls.Count - 2; i++)
            {
                CtlLicense ad = (CtlLicense)flowpanelLicense.Controls[i];
                gd.InsertLicense(FrmMain.Mi.Id, ad.tboxLiName.Text, DateTime.Parse(ad.mTboxDate.Text), ad.tboxAgency.Text);
            }
            // 학력  추가
            for (int i = 0; i < flowpanelEdu.Controls.Count - 2; i++)
            {
                CtlEdu ce = (CtlEdu)flowpanelEdu.Controls[i];
                gd.InsertEducation(FrmMain.Mi.Id, DateTime.Parse(ce.mTboxEnterPeriod.Text), DateTime.Parse(ce.mTboxGraduPeriod.Text), ce.tboxSchoolName.Text, ce.cboxSchoolType.Text, ce.tboxDepart.Text, ce.cboxGraduType.Text);
            }
            // 교육 이력 추가
            for (int i = 0; i < flowPanelEduHistory.Controls.Count; i++)
            {
                CtlEduHistory eh = (CtlEduHistory)flowPanelEduHistory.Controls[i];
                gd.InsertEdu_History(FrmMain.Mi.Id, DateTime.Parse(eh.mtboxStartPeriod.Text), DateTime.Parse(eh.mtboxEndPeriod.Text), eh.tboxEduAgency.Text, eh.tboxEduName.Text, eh.tboxSkill.Text, eh.tboxDetail.Text);
            }

        }

        //로드 시 저장되어있는 데이터 불러올 메서드
        private void ReloadResume()
        {

        }
    }
}
