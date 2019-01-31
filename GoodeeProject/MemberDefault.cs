using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeProject
{
    class MemberDefault
    {
        string Curriculum;
        string class_name;
        string name;
        DateTime birthDate;
        char gender;
        string mobile;
        string address;

        public MemberDefault(string curriculum, string class_name, string name, DateTime birthDate, char gender, string mobile, string address)
        {
            Curriculum = curriculum;
            this.class_name = class_name;
            this.name = name;
            this.birthDate = birthDate;
            this.gender = gender;
            this.mobile = mobile;
            this.address = address;
        }

        public string Curriculum1 { get => Curriculum; set => Curriculum = value; }
        public string Class_name { get => class_name; set => class_name = value; }
        public string Name { get => name; set => name = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public char Gender { get => gender; set => gender = value; }
        public string Mobile { get => mobile; set => mobile = value; }
        public string Address { get => address; set => address = value; }
    }
}
