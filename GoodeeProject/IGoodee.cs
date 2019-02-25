using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeProject
{
    interface IGoodee
    {
        AccountInfo AccountLogin(string id, string pw);
        MemberInfo SelectMember(string id);
        bool UpdatePassWord(string id, string pw);
        bool UpdateMemberInfo(string id, string mobile, string address, string hopePay, Image picture);
        bool InsertLicense(string id, string name, DateTime date, string agency);
        bool InsertEdu_History(string id, DateTime start, DateTime end, string eduAgency, string eduName, string skilName, string detail);
        bool InsertEducation(string id, DateTime enter, DateTime gradu, string school, string schoolType, string depart, string eduType);
        DataTable SelectLicense(string id);
        DataTable SelectEdu(string id);
        DataTable SelectEdu_History(string id);
        bool DeleteLiEduHis(string id);
        DataTable SelectMBTI_Question();
        DataTable SelectMBTI_Choice();

    }
}
