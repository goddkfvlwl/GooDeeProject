using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeProject
{
    public class Survey
    {
        int surveyNum;
        string surveyName;
        string writer;
        bool isActivate;
        DateTime startDate;
        DateTime endDate;

        public Survey(int surveyNum, string surveyName, string writer, bool isActivate, DateTime startDate, DateTime endDate)
        {
            this.surveyNum = surveyNum;
            this.surveyName = surveyName;
            this.writer = writer;
            this.isActivate = isActivate;
            this.startDate = startDate;
            this.endDate = endDate;
        }

        public int SurveyNum { get => surveyNum; set => surveyNum = value; }
        public string SurveyName { get => surveyName; set => surveyName = value; }
        public string Writer { get => writer; set => writer = value; }
        public bool IsActivate { get => isActivate; set => isActivate = value; }
        public DateTime StartDate { get => startDate; set => startDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
    }
}
