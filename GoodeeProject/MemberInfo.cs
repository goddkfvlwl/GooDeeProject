using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeProject
{
    class MemberInfo
    {
        private string id;
        private string name;
        private DateTime birthDate;
        private char gender;
        private string mobile;
        private string address;
        private string hopePay;
        private char army;
        private float score;
        private string curriculum;
        private string className;

        public MemberInfo()
        {
        }

        public MemberInfo(string id, string name, DateTime birthDate, char gender, string mobile, string address, string hopePay, char army, float score, string curriculum, string className)
        {
            this.Id = id;
            this.Name = name;
            this.BirthDate = birthDate;
            this.Gender = gender;
            this.Mobile = mobile;
            this.Address = address;
            this.HopePay = hopePay;
            this.Army = army;
            this.Score = score;
            this.Curriculum = curriculum;
            this.className = className;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime BirthDate { get => birthDate; set => birthDate = value; }
        public char Gender { get => gender; set => gender = value; }
        public string Mobile { get => mobile; set => mobile = value; }
        public string Address { get => address; set => address = value; }
        public string HopePay { get => hopePay; set => hopePay = value; }
        public char Army { get => army; set => army = value; }
        public float Score { get => score; set => score = value; }
        public string Curriculum { get => curriculum; set => curriculum = value; }
        public string ClassName { get => className; set => className = value; }
    }
}
