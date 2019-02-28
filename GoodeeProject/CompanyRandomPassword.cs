using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeProject
{
    class CompanyRandomPassword
    {
        private string companyname; // 회사이름
        private string password;    // 비밀번호

        public string Companyname { get => companyname; set => companyname = value; }
        public string Password { get => password; set => password = value; }
    }
}
