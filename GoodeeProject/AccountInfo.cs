using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeProject
{
    class AccountInfo
    {
        private string id;
        private string pw;
        private char authority;

        public AccountInfo()
        {
        }

        public AccountInfo(string id, string pw, char authority)
        {
            this.Id = id;
            this.Pw = pw;
            this.Authority = authority;
        }

        public string Id { get => id; set => id = value; }
        public string Pw { get => pw; set => pw = value; }
        public char Authority { get => authority; set => authority = value; }
    }
}
