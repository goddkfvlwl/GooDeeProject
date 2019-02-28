using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeProject
{
    class XmlSaraminNodeJobs
    {
        private string name; // 회사 이름
        private string url;
        private string title;// 기업채용공고
        private string location; // 기업 위치
        private string job_type;    // 정규직,비정규직,프리랜서 등
        private string industry;    // 업종
        private string job_category; //직종
        private string experience_level;    // 경력
        private string required_education_level; // 학력
        private string keyword; // 키워드

        public string Name { get => name; set => name = value; }
        public string Url { get => url; set => url = value; }
        public string Title { get => title; set => title = value; }
        public string Location { get => location; set => location = value; }
        public string Job_type { get => job_type; set => job_type = value; }
        public string Industry { get => industry; set => industry = value; }
        public string Job_category { get => job_category; set => job_category = value; }
        public string Experience_level { get => experience_level; set => experience_level = value; }
        public string Required_education_level { get => required_education_level; set => required_education_level = value; }
        public string Keyword { get => keyword; set => keyword = value; }
    }
}
