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
        private int classNum;

        public MemberInfo()
        {
        }

        public MemberInfo(string id, string name, DateTime birthDate, char gender, string mobile, string address, string hopePay, char army, float score, int classNum)
        {
            this.id = id;
            this.name = name;
            this.birthDate = birthDate;
            this.gender = gender;
            this.mobile = mobile;
            this.address = address;
            this.hopePay = hopePay;
            this.army = army;
            this.score = score;
            this.classNum = classNum;
        }
        public MemberInfo(string id, string name, DateTime birthDate, char gender, string mobile, string address, int classNum)
        {
            this.id = id;
            this.name = name;
            this.birthDate = birthDate;
            this.gender = gender;
            this.mobile = mobile;
            this.address = address;
            this.classNum = classNum;
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
        public int ClassNum { get => classNum; set => classNum = value; }
    }
}
