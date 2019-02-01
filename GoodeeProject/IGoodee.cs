using System;
using System.Collections.Generic;
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

    }
}
