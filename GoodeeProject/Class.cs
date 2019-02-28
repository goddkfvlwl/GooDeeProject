using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeProject
{
    class Class
    {
        private int classNum;
        private string class_Name;
        private string curriculum;
        private DateTime startdate;
        private DateTime enddate;
        private string turn;

        public Class()
        {
        }

        public Class(int classNum, string class_Name, string curriculum, DateTime startdate, DateTime enddate, string turn)
        {
            this.classNum = classNum;
            this.class_Name = class_Name;
            this.curriculum = curriculum;
            this.startdate = startdate;
            this.enddate = enddate;
            this.turn = turn;
        }

        public int ClassNum { get => classNum; set => classNum = value; }
        public string Class_Name { get => class_Name; set => class_Name = value; }
        public string Curriculum { get => curriculum; set => curriculum = value; }
        public DateTime Startdate { get => startdate; set => startdate = value; }
        public DateTime Enddate { get => enddate; set => enddate = value; }
        public string Turn { get => turn; set => turn = value; }
    }
}
