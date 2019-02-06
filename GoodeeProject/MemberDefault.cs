using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeProject
{
    class MemberDefault
    {
        string curriculum;
        string class_name;
        string name;
        DateTime birthDate;
        string gender;
        string mobile;
        string address;
        string id;

        public MemberDefault(string curriculum, string class_name, string name, DateTime birthDate, string gender, string mobile, string address, string id)
        {
            this.curriculum = curriculum;
            this.class_name = class_name;
            this.name = name;
            this.birthDate = birthDate;
            this.gender = gender;
            this.mobile = mobile;
            this.address = address;
            this.id = id;
        }

        public string Curriculum { get => curriculum; set => curriculum = value; }
        public string Class_name { get => class_name; set => class_name = value; }
        public string Name { get => name; set => name = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Mobile { get => mobile; set => mobile = value; }
        public string Address { get => address; set => address = value; }
        public string Id { get => id; set => id = value; }
    }
}
