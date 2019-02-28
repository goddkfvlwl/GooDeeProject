using System;
using System.Collections.Generic;
using System.Drawing;
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
        private string regist;
        private Image picture;
        public MemberInfo()
        {
        }

        public MemberInfo(string id, string name, DateTime birthDate, char gender, string mobile, string address, int classNum, string regist)
        {
            this.id = id;
            this.name = name;
            this.birthDate = birthDate;
            this.gender = gender;
            this.mobile = mobile;
            this.address = address;
            this.classNum = classNum;
            this.regist = regist;
        }
        public MemberInfo(string id, string name, DateTime birthDate, char gender, string mobile, string address, string hopePay, char army, float score, int classNum, Image picture)
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
            this.ClassNum = classNum;
            this.Picture = picture;
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
        public string Regist { get => regist; set => regist = value; }
        public Image Picture { get => picture; set => picture = value; }
    }
}