using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeProject
{
    interface IGoodee
    {
        AccountInfo AccountLogin(string id, string pw);
        #region 사람인 코드 DB저장용 (일회성)
        bool InsetFirstAreaCode(string fa, string fn);
        bool InsertJob(string jc, string jn); 
        #endregion

        MemberInfo SelectMember(string id);

        bool UpdatePassWord(string id, string pw);


        #region 게시판
        bool InsertBoard(AgreementBoard b);
        List<AgreementBoard> OutBoard();
        bool DeleteBoard(int num);
        #endregion


        bool UpdateMemberInfo(string id, string mobile, string address, string hopePay, Image picture);

    }
}
