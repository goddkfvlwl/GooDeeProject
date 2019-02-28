using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeProject
{
    class FirstSubJob
    {
        private string firstJob_Code;
        private string firstJob_Name;
        private string secondJob_Code;
        private string secondJob_Name;
        private string detailjob_Code;
        private string detailjob_Name;

        public string FirstJob_Code { get => firstJob_Code; set => firstJob_Code = value; }
        public string FirstJob_Name { get => firstJob_Name; set => firstJob_Name = value; }
        public string SecondJob_Code { get => secondJob_Code; set => secondJob_Code = value; }
        public string SecondJob_Name { get => secondJob_Name; set => secondJob_Name = value; }
        public string Detailjob_Code { get => detailjob_Code; set => detailjob_Code = value; }
        public string Detailjob_Name { get => detailjob_Name; set => detailjob_Name = value; }
        
    }
}
