using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeProject
{
    class MBTIChoice
    {
        private int questionNum;
        private char item;
        private string itemDetail;
        private int femaleSc;
        private int maleSc;
        private char detail_Tendency;

        public MBTIChoice(int questionNum, char item, string itemDetail, int femaleSc, int maleSc, char detail_Tendency)
        {
            this.questionNum = questionNum;
            this.item = item;
            this.itemDetail = itemDetail;
            this.femaleSc = femaleSc;
            this.maleSc = maleSc;
            this.detail_Tendency = detail_Tendency;
        }

        public int QuestionNum { get => questionNum; set => questionNum = value; }
        public char Item { get => item; set => item = value; }
        public string ItemDetail { get => itemDetail; set => itemDetail = value; }
        public int FemaleSc { get => femaleSc; set => femaleSc = value; }
        public int MaleSc { get => maleSc; set => maleSc = value; }
        public char Detail_Tendency { get => detail_Tendency; set => detail_Tendency = value; }
    }
}
