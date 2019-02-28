using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeProject
{
    class XmlSaramin
    {
        private string name; // 회사 이름
        private string title; // 회사채용내용
        private string working_style; // 근무 형태; 예)정규직
        private string area; // 간단지역
        private string sectors; //업종
        private int pay; // 급여
        private string career; // 경력
        private string education; // 학력
        private string keword; // 키워드

        public string Name { get => name; set => name = value; }
        public string Title { get => title; set => title = value; }
        public string Working_style { get => working_style; set => working_style = value; }
        public string Sectors { get => sectors; set => sectors = value; }
        public int Pay { get => pay; set => pay = value; }
        public string Career { get => career; set => career = value; }
        public string Education { get => education; set => education = value; }
        public string Keword { get => keword; set => keword = value; }
        public string Area { get => area; set => area = value; }
    }
}
