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
<<<<<<< HEAD

=======
        bool UpdatePassWord(string id, string pw);
>>>>>>> 0abd41c8e3530463e0c9361d9844163cb3b2d6b4
    }
}
