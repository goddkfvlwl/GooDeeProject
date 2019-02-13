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
        public SurveyDetail()
        {
            InitializeComponent();
        }
        public SurveyDetail(Survey survey) : this()
        {
            this.survey = survey;
        }

        private void SurveyDetail_Load(object sender, EventArgs e)
        {
            GoodeeDAO.GoodeeDAO DAO = new GoodeeDAO.GoodeeDAO();
            bool check = DAO.CheckSurvey(FrmMain.Id, survey.SurveyNum);
            if (!check)
            {
                MessageBox.Show("이미 참여한 설문입니다.");
                this.Dispose();
                return;
            }
            this.panel1.Controls["lblNum"].Text = survey.SurveyNum.ToString();
            this.panel1.Controls["txtTitle"].Text = survey.SurveyName;
            this.panel1.Controls["lblWriter"].Text = survey.Writer;
            if (FrmMain.Authority == 'S')
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.SurveyDetailPanel.Controls)
            {
                Control c = item.Controls["flowLayoutPanel1"].Controls["QuestionPanel"];
                int surveyNum = survey.SurveyNum;
                string id = FrmMain.Id;
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
                GoodeeDAO.GoodeeDAO DAO = new GoodeeDAO.GoodeeDAO();
                DAO.InsertSurveyItem(items);
            }
            MessageBox.Show("설문이 완료되었습니다.");
            this.Dispose();
            return;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            GoodeeDAO.GoodeeDAO DAO = new GoodeeDAO.GoodeeDAO();
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
                                text.Width = c.Width - 20;
                                c.Controls.Add(text);
                            }
                        }
                    }
                }
            }
        }
    }
}
