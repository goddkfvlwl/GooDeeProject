using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeProject
{
    public class AgreementBoard
    {
        private int boardNum;   // 게시판 번호
        private string title;   // 제목
        private string body;    // ftp경로
        private DateTime writeDate; // 작성날짜
        private int hits;   // 조회수
        private string id;  // 작성자(현재 로그인이된)의 ID

        public int BoardNum { get => boardNum; set => boardNum = value; }
        public string Title { get => title; set => title = value; }
        public string Body { get => body; set => body = value; }
        public DateTime WriteDate { get => writeDate; set => writeDate = value; }
        public int Hits { get => hits; set => hits = value; }
        public string Id { get => id; set => id = value; }
    }
}
