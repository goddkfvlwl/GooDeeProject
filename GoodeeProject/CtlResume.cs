using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
using System.Resources;
using GoodeeProject.Properties;
using System.IO;

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
            ReloadResume();
        }

        private void CtlResume_Load(object sender, EventArgs e)
        {
            flowPanelEduHistory.AutoScroll = true;
            flowpanelLicense.AutoScroll = true;
            flowpanelEdu.AutoScroll = true;

            //학력 패널
            ce = new CtlEdu();
            //flowpanelEdu.Controls.Add(ce);

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
            //flowpanelLicense.Controls.Add(cl);
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
            //flowPanelEduHistory.Controls.Add(ch);
            btnEduHistory = new iTalk.iTalk_Button_1();
            flowPanelEduHistory.Controls.Add(btnEduHistory);
            btnEduHistory.Size = new Size(755, 20);
            btnEduHistory.Text = "교육 이력 추가";

            btnDelEduHistory = new iTalk.iTalk_Button_1();
            flowPanelEduHistory.Controls.Add(btnDelEduHistory);
            btnDelEduHistory.Size = new Size(755, 20);
            btnDelEduHistory.Text = "교육 이력 제거";


            btnEdu.Click += BtnEdu_Click;
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
            
        }

        private void BtnLicense_Click(object sender, EventArgs e)
        {
            cl = new CtlLicense();
            flowpanelLicense.Controls.Add(cl);
            flowpanelLicense.Controls.SetChildIndex(btnLicense, flowpanelLicense.Controls.Count - 1);
            flowpanelLicense.Controls.SetChildIndex(btnDelLicense, flowpanelLicense.Controls.Count);
            
        }

        private void BtnEdu_Click(object sender, EventArgs e)
        {
            ce = new CtlEdu();
            flowpanelEdu.Controls.Add(ce);
            flowpanelEdu.Controls.SetChildIndex(btnEdu, flowpanelEdu.Controls.Count - 1);
            flowpanelEdu.Controls.SetChildIndex(btnDelEdu, flowpanelEdu.Controls.Count);
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            gd.DeleteLiEduHis(FrmMain.Mi.Id);
            // 자격증 추가
            if (flowpanelLicense.Controls.Count >= 3)
            {
                for (int i = 0; i < flowpanelLicense.Controls.Count - 2; i++)
                {
                    CtlLicense cl = (CtlLicense)flowpanelLicense.Controls[i];
                    gd.InsertLicense(FrmMain.Mi.Id, cl.tboxLiName.Text, DateTime.Parse(cl.mTboxDate.Text), cl.tboxAgency.Text);
                } 
            }
            // 학력  추가
            if (flowpanelEdu.Controls.Count >= 3)
            {
                for (int i = 0; i < flowpanelEdu.Controls.Count - 2; i++)
                {
                    CtlEdu ce = (CtlEdu)flowpanelEdu.Controls[i];
                    gd.InsertEducation(FrmMain.Mi.Id, DateTime.Parse(ce.mTboxEnterPeriod.Text), DateTime.Parse(ce.mTboxGraduPeriod.Text), ce.tboxSchoolName.Text, ce.cboxSchoolType.Text, ce.tboxDepart.Text, ce.cboxGraduType.Text);
                } 
            }
            // 교육 이력 추가
            if (flowPanelEduHistory.Controls.Count >= 3)
            {
                CtlEduHistory eh;
                for (int i = 0; i < flowPanelEduHistory.Controls.Count; i++)
                {
                    try
                    {
                       eh = (CtlEduHistory)flowPanelEduHistory.Controls[i];
                    }
                    catch (InvalidCastException)
                    {
                        continue;
                    }
                    gd.InsertEdu_History(FrmMain.Mi.Id, DateTime.Parse(eh.mtboxStartPeriod.Text), DateTime.Parse(eh.mtboxEndPeriod.Text), eh.tboxEduAgency.Text, eh.tboxEduName.Text, eh.tboxSkill.Text, eh.tboxDetail.Text);
                } 
            }
            MessageBox.Show("저장 완료");
        }

        //로드 시 저장되어있는 데이터 불러올 메서드
        private void ReloadResume()
        {
            DataTable license = gd.SelectLicense(FrmMain.Mi.Id);
            DataTable edu = gd.SelectEdu(FrmMain.Mi.Id);
            DataTable edu_His = gd.SelectEdu_History(FrmMain.Mi.Id);

            CtlLicense[] cl = new CtlLicense[license.DataSet.Tables[0].Rows.Count];
            CtlEdu[] ce = new CtlEdu[edu.DataSet.Tables[0].Rows.Count];
            CtlEduHistory[] ch = new CtlEduHistory[edu_His.DataSet.Tables[0].Rows.Count];


            //라이센스
            if (license.DataSet.Tables[0].Rows.Count != 0)
            {
                for (int i = 0; i < license.DataSet.Tables[0].Rows.Count; i++)
                {
                    cl[i] = new CtlLicense();
                    flowpanelLicense.Controls.Add(cl[i]);
                    cl[i].tboxLiName.Text = license.DataSet.Tables[0].Rows[i]["Name"].ToString();
                    cl[i].mTboxDate.Text = license.DataSet.Tables[0].Rows[i]["Date"].ToString();
                    cl[i].tboxAgency.Text = license.DataSet.Tables[0].Rows[i]["Agency"].ToString();
                } 
            }

            //학력
            if (edu.DataSet.Tables[0].Rows.Count != 0)
            {
                for (int i = 0; i < edu.DataSet.Tables[0].Rows.Count; i++)
                {
                    ce[i] = new CtlEdu();
                    flowpanelEdu.Controls.Add(ce[i]);
                    ce[i].mTboxEnterPeriod.Text = edu.DataSet.Tables[0].Rows[i]["EnterPeriod"].ToString();
                    ce[i].mTboxGraduPeriod.Text = edu.DataSet.Tables[0].Rows[i]["GraduPeriod"].ToString();
                    ce[i].tboxSchoolName.Text = edu.DataSet.Tables[0].Rows[i]["School"].ToString();
                    ce[i].cboxSchoolType.Text = edu.DataSet.Tables[0].Rows[i]["SchoolType"].ToString();
                    ce[i].tboxDepart.Text = edu.DataSet.Tables[0].Rows[i]["Department"].ToString();
                    ce[i].cboxGraduType.Text = edu.DataSet.Tables[0].Rows[i]["EduType"].ToString();
                } 
            }

            //교육이력
            if (edu_His.DataSet.Tables[0].Rows.Count != 0)
            {
                for (int i = 0; i < edu_His.DataSet.Tables[0].Rows.Count; i++)
                {
                    ch[i] = new CtlEduHistory();
                    flowPanelEduHistory.Controls.Add(ch[i]);
                    ch[i].mtboxStartPeriod.Text = edu_His.DataSet.Tables[0].Rows[i]["StartPeriod"].ToString();
                    ch[i].mtboxEndPeriod.Text = edu_His.DataSet.Tables[0].Rows[i]["EndPeriod"].ToString();
                    ch[i].tboxEduAgency.Text = edu_His.DataSet.Tables[0].Rows[i]["EduAgency"].ToString();
                    ch[i].tboxEduName.Text = edu_His.DataSet.Tables[0].Rows[i]["EduName"].ToString();
                    ch[i].tboxSkill.Text = edu_His.DataSet.Tables[0].Rows[i]["SkillName"].ToString();
                    ch[i].tboxDetail.Text = edu_His.DataSet.Tables[0].Rows[i]["Detail"].ToString();
                } 
            }
        }

        private void btnFileSave_Click(object sender, EventArgs e)
        {
            object missingValue = System.Reflection.Missing.Value;
            Excel.Workbook workBook;

            SaveFileDialog sf = new SaveFileDialog();
            sf.Title = "이력서 저장";
            sf.Filter = "PDF 문서(*.pdf)|*.pdf";
            sf.DefaultExt = "pdf";
            
            DialogResult result = sf.ShowDialog();

            if (result == DialogResult.OK)
            {
                Excel.Application excelApp = new Excel.Application();
                if (excelApp == null)
                {
                    MessageBox.Show("Excel이 설치되지 않았습니다.");
                    return;
                }
                workBook = excelApp.Workbooks.Open(Filename: Application.StartupPath + "/Resources/Resume.xlsx");
                Excel.Worksheet workSheet = workBook.Worksheets.Item[1];

                workSheet.Cells[11, 1] = tboxName.Text;
                Excel.Range picRange = workSheet.Cells[1, 3];

                Bitmap img = new Bitmap(FrmMain.Mi.Picture, new Size(125, 22 * 8));

                Clipboard.SetDataObject(img, true);
                workSheet.Paste(picRange, img);

                //기본정보
                workSheet.Cells[17, 2] = "생년월일 : " + tboxBirthDate.Text;
                workSheet.Cells[18, 2] = "주소 : " + tboxAddr.Text;
                workSheet.Cells[19, 2] = "이메일 : " + FrmMain.Mi.Id;
                workSheet.Cells[20, 2] = "연락처 : " + tboxMobile.Text;

                int i = 0;
                int lastEdu = 0;
                //학력
                if (flowpanelEdu.Controls.Count >= 3)
                {
                    for (i = 0; i < flowpanelEdu.Controls.Count - 2; i++)
                    {
                        CtlEdu ce = (CtlEdu)flowpanelEdu.Controls[i];
                        workSheet.Cells[24 + (4 * i), 2] = "기간 : " + ce.mTboxEnterPeriod.Text + " ~ " + ce.mTboxGraduPeriod.Text;
                        workSheet.Cells[25 + (4 * i), 2] = "학교명 : " + ce.tboxSchoolName.Text + ce.cboxSchoolType.Text + " " + ce.cboxGraduType.Text;
                        workSheet.Cells[26 + (4 * i), 2] = ce.tboxDepart.Text;
                        lastEdu = 26 + (4 * i) + 3;
                    }
                    workSheet.get_Range("A24", "A" + (lastEdu - 3)).Merge(false);

                    workSheet.Range["A" + (lastEdu - 1) + ":C" + (lastEdu - 1)].Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = 1;
                    workSheet.Range["A" + (lastEdu - 1) + ":C" + (lastEdu - 1)].Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = Excel.XlBorderWeight.xlThick;
                }

                //교육이력
                workSheet.get_Range("A" + lastEdu, "A" + (lastEdu + 3)).Merge(false);
                workSheet.Cells[lastEdu, 1] = "교육이력";
                workSheet.Cells[lastEdu, 1].Font.Bold = true;
                workSheet.Cells[lastEdu, 1].Font.Size = 10;

                int lastEduHis = 0;
                if (flowPanelEduHistory.Controls.Count >= 3)
                {
                    for (i = 0; i < flowPanelEduHistory.Controls.Count - 2; i++)
                    {
                        CtlEduHistory eh = (CtlEduHistory)flowPanelEduHistory.Controls[i];
                        workSheet.Cells[lastEdu + (6 * i), 2] = "기간 : " + eh.mtboxStartPeriod.Text + " ~ " + eh.mtboxEndPeriod.Text;
                        workSheet.Cells[lastEdu + 1 + (6 * i), 2] = "기관명 : " + eh.tboxEduAgency.Text;
                        workSheet.Cells[lastEdu + 2 + (6 * i), 2] = "과정명 : " + eh.tboxEduName.Text;
                        workSheet.Cells[lastEdu + 3 + (6 * i), 2] = "보유능력 : " + eh.tboxSkill.Text;
                        workSheet.Cells[lastEdu + 4 + (6 * i), 2] = "상세내용 : " + eh.tboxDetail.Text;
                        lastEduHis = lastEdu + 4 + (6 * i) + 3;
                    }
                    workSheet.get_Range("A" + lastEdu, "A" + (lastEduHis - 3)).Merge(false);
                    workSheet.Range["A" + (lastEduHis - 1) + ":C" + (lastEduHis - 1)].Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = 1;
                    workSheet.Range["A" + (lastEduHis - 1) + ":C" + (lastEduHis - 1)].Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = Excel.XlBorderWeight.xlThick;
                }

                // 자격증
                workSheet.get_Range("A" + lastEduHis, "A" + (lastEduHis + 2)).Merge(false);
                workSheet.Cells[lastEduHis, 1] = "자격증";
                workSheet.Cells[lastEduHis, 1].Font.Bold = true;
                workSheet.Cells[lastEduHis, 1].Font.Size = 10;

                int lastLicense = 0;
                if (flowpanelLicense.Controls.Count >= 3)
                {
                    for (i = 0; i < flowpanelLicense.Controls.Count - 2; i++)
                    {
                        CtlLicense cl = (CtlLicense)flowpanelLicense.Controls[i];
                        workSheet.Cells[lastEduHis + (4 * i), 2] = "이름 : " + cl.tboxLiName.Text;
                        workSheet.Cells[lastEduHis + 1 + (4 * i), 2] = "취득날짜 : " + cl.mTboxDate.Text;
                        workSheet.Cells[lastEduHis + 2 + (4 * i), 2] = "발급기관 : " + cl.tboxAgency.Text;
                        lastLicense = lastEduHis + 2 + (4 * i) + 3;
                    }
                    workSheet.get_Range("A" + lastEduHis, "A" + (lastLicense - 3)).Merge(false);
                    workSheet.Range["A" + (lastLicense - 1) + ":C" + (lastLicense - 1)].Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = 1;
                    workSheet.Range["A" + (lastLicense - 1) + ":C" + (lastLicense - 1)].Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = Excel.XlBorderWeight.xlThick;
                }

                //기타 사항
                workSheet.get_Range("A" + lastLicense, "A" + (lastLicense + 1)).Merge(false);
                workSheet.Cells[lastLicense, 1] = "기타사항";
                workSheet.Cells[lastLicense, 1].Font.Bold = true;
                workSheet.Cells[lastLicense, 1].Font.Size = 10;

                if (this.radioArmyY.Checked)
                {
                    workSheet.Cells[lastLicense, 2] = "병역여부 : 군필";
                }
                else
                {
                    workSheet.Cells[lastLicense, 2] = "병역여부 : 미필";
                }
                workSheet.Cells[lastLicense + 1, 2] = "고용촉진지원금 대상자 (청년취업프로그램 이수)";

                workSheet.Range["A" + (lastLicense + 3) + ":C" + (lastLicense + 3)].Borders[Excel.XlBordersIndex.xlEdgeTop].LineStyle = 1;
                workSheet.Range["A" + (lastLicense + 3) + ":C" + (lastLicense + 3)].Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = Excel.XlBorderWeight.xlThick;


                //저장
                try
                {
                    workBook.SaveAs(Application.StartupPath + "/Resources/userResume.xls", Excel.XlFileFormat.xlWorkbookNormal, null, null, null, null, Excel.XlSaveAsAccessMode.xlExclusive, Excel.XlSaveConflictResolution.xlLocalSessionChanges, missingValue, missingValue, missingValue, missingValue);
                }
                catch (Exception)
                {
                    return;
                }

                try
                {
                    workBook.ExportAsFixedFormat(Excel.XlFixedFormatType.xlTypePDF, sf.FileName, Excel.XlFixedFormatQuality.xlQualityStandard, true, true, Type.Missing, Type.Missing, false, Type.Missing);
                    MessageBox.Show("저장 완료");
                }
                catch (Exception)
                {
                    MessageBox.Show("저장 실패");
                }

                excelApp.Quit();
                Marshal.ReleaseComObject(workSheet);
                Marshal.ReleaseComObject(workBook);
                Marshal.ReleaseComObject(excelApp);
                File.Delete(Application.StartupPath + "/Resources/userResume.xls");
            }
        }
    }
}
