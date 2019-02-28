using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeProject
{
    public class Survey_Items
    {
        int surveyNum;
        string id;
        int questionNum;
        string question;
        string answer;
        string division;
        DateTime survey_date;

        public Survey_Items(int surveyNum, string id, int questionNum, string question, string answer, string division, DateTime survey_date)
        {
            this.surveyNum = surveyNum;
            this.id = id;
            this.questionNum = questionNum;
            this.question = question;
            this.answer = answer;
            this.division = division;
            this.survey_date = survey_date;
        }

        public int SurveyNum { get => surveyNum; set => surveyNum = value; }
        public string Id { get => id; set => id = value; }
        public int QuestionNum { get => questionNum; set => questionNum = value; }
        public string Question { get => question; set => question = value; }
        public string Answer { get => answer; set => answer = value; }
        public string Division { get => division; set => division = value; }
        public DateTime Survey_date { get => survey_date; set => survey_date = value; }
    }
}
