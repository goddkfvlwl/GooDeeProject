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
using System.Net;
using System.IO;

namespace GoodeeProject
{
    public partial class CreateSurvey : UserControl
    {
        public CreateSurvey()
        {
            InitializeComponent();
        }

        private void btnAddMultiChoice_Click(object sender, EventArgs e)
        {
            TextBox text = new TextBox();

            text.Text = this.defaultSurvey1.Controls["flowLayoutPanel1"].Controls["QuestionPanel"].Controls.Count + 1 + "번답";
            this.defaultSurvey1.Controls["flowLayoutPanel1"].Controls["QuestionPanel"].Controls.Add(text);
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            DefaultSurvey survey = new DefaultSurvey();
            survey.Controls["flowLayoutPanel1"].Controls["panel1"].Controls["button1"].Visible = true;
            survey.Controls["flowLayoutPanel1"].Controls["panel1"].Controls["button1"].Click += DeleteButton_Click;
            (survey.Controls["flowLayoutPanel1"].Controls["panel1"].Controls["txtQuestion"] as TextBox).ReadOnly = true;
            survey.Controls["flowLayoutPanel1"].Controls["panel1"].Controls["lblQuestionNum"].Text = (this.flowLayoutPanel1.Controls.Count + 1).ToString();
            survey.Controls["flowLayoutPanel1"].Controls["panel1"].Controls["txtQuestion"].Text = defaultSurvey1.Controls["flowLayoutPanel1"].Controls["panel1"].Controls["txtQuestion"].Text;
            for (int i = 0; i < defaultSurvey1.Controls["flowLayoutPanel1"].Controls["QuestionPanel"].Controls.Count; i++)
            {
                if (!defaultSurvey1.Controls["flowLayoutPanel1"].Controls["QuestionPanel"].Controls[i].Name.Contains("essay"))
                {
                    RadioButton radio = new RadioButton();
                    radio.Text = defaultSurvey1.Controls["flowLayoutPanel1"].Controls["QuestionPanel"].Controls[i].Text;
                    survey.Controls["flowLayoutPanel1"].Controls["QuestionPanel"].Controls.Add(radio);
                }
                else
                {
                    TextBox text = new TextBox();
                    text.Name = "essay";
                    text.Width = survey.Controls["flowLayoutPanel1"].Width - 20;
                    survey.Controls["flowLayoutPanel1"].Controls["QuestionPanel"].Controls.Add(text);
                }
            }
            this.flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(survey);
            defaultSurvey1.Controls["flowLayoutPanel1"].Controls["panel1"].Controls["txtQuestion"].Text = string.Empty;
            defaultSurvey1.Controls["flowLayoutPanel1"].Controls["QuestionPanel"].Controls.Clear();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Control control = sender as Control;
            control.Parent.Parent.Parent.Dispose();
            for (int i = 0; i < this.flowLayoutPanel1.Controls.Count; i++)
            {
                this.flowLayoutPanel1.Controls[i].Controls["flowLayoutPanel1"].Controls["panel1"].Controls["lblQuestionNum"].Text = (i + 1).ToString();
            }
        }

        private void btnAddEssay_Click(object sender, EventArgs e)
        {
            bool check = true;
            foreach (Control item in this.defaultSurvey1.Controls["flowLayoutPanel1"].Controls["QuestionPanel"].Controls)
            {
                if (item.Name.Contains("essay"))
                {
                    check = false;
                }
            }
            
            if (check)
            {
                TextBox text = new TextBox();
                text.Name = "essay";
                text.Width = this.defaultSurvey1.Controls["flowLayoutPanel1"].Width - 20;
                this.defaultSurvey1.Controls["flowLayoutPanel1"].Controls["QuestionPanel"].Controls.Add(text); 
            }else
            {
                MessageBox.Show("주관식 답안은 한 문항당 하나만 등록할 수 있습니다.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            xml.CreateXmlDeclaration("1.0", "utf-8", null);
            XmlNode root = xml.CreateElement("survey");
            
            XmlElement title = xml.CreateElement("title");
            title.InnerText = this.txtSurveyTitle.Text;
            root.AppendChild(title);
            foreach (Control item in this.flowLayoutPanel1.Controls)
            {
                XmlElement question = xml.CreateElement("question");
                question.InnerText = item.Controls["flowLayoutPanel1"].Controls["panel1"].Controls["txtQuestion"].Text;
                question.SetAttribute("count", item.Controls["flowLayoutPanel1"].Controls["panel1"].Controls["lblQuestionNum"].Text);
                for (int i = 0; i < item.Controls["flowLayoutPanel1"].Controls["QuestionPanel"].Controls.Count; i++)
                {
                    if (item.Controls["flowLayoutPanel1"].Controls["QuestionPanel"].Controls[i].Name != "essay")
                    {
                        question.SetAttribute("multi" + (i + 1), item.Controls["flowLayoutPanel1"].Controls["QuestionPanel"].Controls[i].Text); 

                    }else
                    {
                        question.SetAttribute("essay" + (i + 1), item.Controls["flowLayoutPanel1"].Controls["QuestionPanel"].Controls[i].Text);
                    }
                }
                title.AppendChild(question);
            }
            xml.AppendChild(root);
            XmlTextWriter writer = new XmlTextWriter(Application.StartupPath + "/" + this.txtSurveyTitle.Text + ".xml", Encoding.UTF8);
            writer.Formatting = Formatting.Indented;
            xml.WriteContentTo(writer);
            writer.Flush();
            writer.Close();

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://52.165.176.111:3333/Survey/" + this.txtSurveyTitle.Text + ".xml");
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.UseBinary = true;
            using (Stream fileStream = File.OpenRead(Application.StartupPath + "/" + this.txtSurveyTitle.Text + ".xml"))
            using (Stream ftpStream = request.GetRequestStream())
            {
                fileStream.CopyTo(ftpStream);
                fileStream.Close();
            }
            File.Delete(Application.StartupPath + "/" + this.txtSurveyTitle.Text + ".xml");

            GoodeeDAO.GoodeeDAO DAO = new GoodeeDAO.GoodeeDAO();
            dtpStartDate.Value = new DateTime(dtpStartDate.Value.Year, dtpStartDate.Value.Month, dtpStartDate.Value.Day - 1, 23, 59, 59);
            dtpEndDate.Value = new DateTime(dtpEndDate.Value.Year, dtpEndDate.Value.Month, dtpEndDate.Value.Day, 23, 59, 59);
            DateTime start = default(DateTime);
            DateTime end = default(DateTime);
            if (dtpStartDate.Value > dtpEndDate.Value)
            {
                start = dtpEndDate.Value;
                end = dtpStartDate.Value;
            }else if(dtpStartDate.Value < dtpEndDate.Value)
            {
                start = dtpStartDate.Value;
                end = dtpEndDate.Value;
            }
            DAO.InsertSurvey(FrmMain.Id, this.txtSurveyTitle.Text, start, end);

            this.Dispose();
            return;
        }
    }
}
