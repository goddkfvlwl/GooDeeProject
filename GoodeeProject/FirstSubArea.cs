using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeProject
{
    class FirstSubArea
    {
        private string firstAreaCode;  // 대표지역코드
        private string FirstAreaName;   // 대표지역코드이름
        private string subAreaCode;    // 서브지역코드   
        private string subAreaName; // 서브지역코드이름

        public string FirstAreaCode { get => firstAreaCode; set => firstAreaCode = value; }
        public string FirstAreaName1 { get => FirstAreaName; set => FirstAreaName = value; }
        public string SubAreaCode { get => subAreaCode; set => subAreaCode = value; }
        public string SubAreaName { get => subAreaName; set => subAreaName = value; }
    }
}
