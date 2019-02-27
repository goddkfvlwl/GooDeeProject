using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeProject
{
    class KREDIT
    {
        private DateTime dataCrtYm;
        private string seq;
        private string wkplNm;
        private string wkplRoadNmDtlAddr;

        public DateTime DataCrtYm { get => dataCrtYm; set => dataCrtYm = value; }
        public string Seq { get => seq; set => seq = value; }
        public string WkplNm { get => wkplNm; set => wkplNm = value; }
        public string WkplRoadNmDtlAddr { get => wkplRoadNmDtlAddr; set => wkplRoadNmDtlAddr = value; }
    }
}
