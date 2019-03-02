using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GoodeeProject
{
    public partial class SurveyDetail : UserControl
    {
        Survey survey;
        /// <summary>
        /// 생성자
        /// </summary>
        public SurveyDetail()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="survey">Survey 객체</param>
        public SurveyDetail(Survey survey) : this()
        {
            this.survey = survey;
        }
        /// <summary>
        /// 설문의 상세내용을 표시합니다.
        /// 만약 이미 참여한 설문일경우 폼을 종료합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체입니다.</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void SurveyDetail_Load(object sender, EventArgs e)
        {
            GoodeeDAO.GoodeeDAO DAO = GoodeeDAO.GoodeeDAO.GetInstance();
            bool check = DAO.CheckSurvey(FrmMain.Mi.Id, survey.SurveyNum);
            if (!check)
            {
                MessageBox.Show("이미 참여한 설문입니다.");
                this.Dispose();
                return;
            }
            else if (FrmMain.Ai.Authority == 'S' && survey.EndDate < DateTime.Now)
            {
                MessageBox.Show("작성가능일이 지났습니다.");
                this.Dispose();
                return;
            }
            this.panel1.Controls["lblNum"].Text = survey.SurveyNum.ToString();
            this.panel1.Controls["txtTitle"].Text = survey.SurveyName;
            this.panel1.Controls["lblWriter"].Text = survey.Writer;
            if (FrmMain.Ai.Authority == 'S')
            {
                this.btnModify.Visible = false;
                this.btnResult.Visible = false;
            }
            else
            {
                this.btnSubmit.Visible = false;
            }

            XmlDocument doc = new XmlDocument();
            doc.Load("ftp://52.165.176.111:3333/Survey/" + survey.SurveyName + ".xml");
            foreach (XmlNode item in doc.SelectNodes("//question"))
            {
                DefaultSurvey survey = new DefaultSurvey();
                (survey.Controls["flowLayoutPanel1"].Controls["panel1"].Controls["txtQuestion"] as TextBox).ReadOnly = true;
                survey.Controls["flowLayoutPanel1"].Controls["panel1"].Controls["lblQuestionNum"].Text = item.Attributes["count"].Value;
                survey.Controls["flowLayoutPanel1"].Controls["panel1"].Controls["txtQuestion"].Text = item.InnerText;
                for (int i = 1; i < item.Attributes.Count; i++)
                {
                    if (item.Attributes[i].Name.Contains("multi"))
                    {
                        RadioButton radio = new RadioButton();
                        radio.Name = "multi" + (i + 1);
                        radio.Text = item.Attributes[i].Value;
                        survey.Controls["flowLayoutPanel1"].Controls["QuestionPanel"].Controls.Add(radio);
                    }
                    else
                    {
                        TextBox text = new TextBox();
                        text.Name = "essay" + (i + 1);
                        text.Width = survey.Controls["flowLayoutPanel1"].Width - 20;
                        survey.Controls["flowLayoutPanel1"].Controls["QuestionPanel"].Controls.Add(text);
                    }
                }
                this.SurveyDetailPanel.Controls.Add(survey);
            }
        }
        /// <summary>
        /// 작성한 설문을 저장합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체입니다.</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.SurveyDetailPanel.Controls)
            {
                Control c = item.Controls["flowLayoutPanel1"].Controls["QuestionPanel"];
                int surveyNum = survey.SurveyNum;
                string id = FrmMain.Mi.Id;
                int questionNum = int.Parse(item.Controls["flowLayoutPanel1"].Controls["panel1"].Controls["lblQuestionNum"].Text);
                string question = item.Controls["flowLayoutPanel1"].Controls["panel1"].Controls["txtQuestion"].Text;
                string answer = "";
                string division = "";
                DateTime survey_date = DateTime.Now;
                for (int i = 0; i < c.Controls.Count; i++)
                {
                    if (c.Controls[i].Name.Contains("multi"))
                    {
                        if ((c.Controls[i] as RadioButton).Checked)
                        {
                            answer = c.Controls[i].Text;
                            division = "multi";
                        }
                    }else
                    {
                        answer = c.Controls[i].Text;
                        division = "essay";
                    }
                }
                Survey_Items items = new Survey_Items(surveyNum, id, questionNum, question, answer, division, survey_date);
                GoodeeDAO.GoodeeDAO DAO = GoodeeDAO.GoodeeDAO.GetInstance();
                DAO.InsertSurveyItem(items);
            }
            MessageBox.Show("설문이 완료되었습니다.");
            this.Dispose();
            return;
        }
        /// <summary>
        /// 작성된 설문의 결과를 표시합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체입니다.</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void btnResult_Click(object sender, EventArgs e)
        {
            GoodeeDAO.GoodeeDAO DAO = GoodeeDAO.GoodeeDAO.GetInstance();
            var multi = DAO.SelectSurveyMulti(survey.SurveyNum);
            var essay = DAO.selectSurveyEssay(survey.SurveyNum);
            foreach (Control item in this.SurveyDetailPanel.Controls)
            {
                Control c = item.Controls["flowLayoutPanel1"].Controls["QuestionPanel"];
                foreach (DataRow rst in multi.Rows)
                {
                    if (rst[0].ToString() == item.Controls["flowLayoutPanel1"].Controls["panel1"].Controls["lblQuestionNum"].Text)
                    {
                        for (int i = 0; i < c.Controls.Count; i++)
                        {
                            if (c.Controls[i].Text == rst[2].ToString())
                            {
                                c.Controls[i].Text = c.Controls[i].Text + " 합 : " + rst[3].ToString();
                                c.Controls[i].Width = c.Controls[i].Text.Length * (c.Controls[i] as RadioButton).Font.Height;
                            }
                        }
                    }
                }

                foreach (DataRow rst in essay.Rows)
                {
                    if (rst[0].ToString() == item.Controls["flowLayoutPanel1"].Controls["panel1"].Controls["lblQuestionNum"].Text)
                    {
                        for (int i = 0; i < c.Controls.Count; i++)
                        {
                            if (c.Controls[i].Name.Contains("essay"))
                            {
                                c.Controls[i].Visible = false;
                                TextBox text = new TextBox();
                                text.ReadOnly = true;
                                text.Text = rst[1].ToString();
                                text.Width = 540;
                                text.Multiline = true;
                                c.Controls.Add(text);
                            }
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 설문을 수정하는 폼을 실행시킵니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체입니다.</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void btnModify_Click(object sender, EventArgs e)
        {
            CreateSurvey create = new CreateSurvey(survey.SurveyName, survey.SurveyNum);
            this.Parent.Controls.Add(create);
            create.BringToFront();
            create.Location = new Point(185, 0);
            this.Dispose();
        }
    }
}
