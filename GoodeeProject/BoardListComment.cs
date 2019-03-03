using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeProject
{
    class BoardListComment
    {
        private int boardNum;
        private string body;
        private DateTime writeDate;
        private string id;

        public int BoardNum { get => boardNum; set => boardNum = value; }
        public string Body { get => body; set => body = value; }
        public DateTime WriteDate { get => writeDate; set => writeDate = value; }
        public string Id { get => id; set => id = value; }
    }
}
