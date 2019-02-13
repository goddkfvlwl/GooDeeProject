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

        public Survey(int surveyNum, string surveyName, string writer, bool isActivate)
        {
            this.surveyNum = surveyNum;
            this.surveyName = surveyName;
            this.writer = writer;
            this.isActivate = isActivate;
        }

        public int SurveyNum { get => surveyNum; set => surveyNum = value; }
        public string SurveyName { get => surveyName; set => surveyName = value; }
        public string Writer { get => writer; set => writer = value; }
        public bool IsActivate { get => isActivate; set => isActivate = value; }
    }
}
