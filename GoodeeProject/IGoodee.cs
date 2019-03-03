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

        #region 사람인
        string SubAreaCount(string firstAreaName);
        List<FirstSubArea> SubAreaName(string fristCode);
        List<FirstSubArea> AreaAutomaticSearch();
        List<FirstSubJob> AllFirstJobName();
        List<FirstSubJob> selectSecondJob(string firstJobCode);
        List<FirstSubJob> selectDetailJob(string secondJocCode);
        #endregion

        
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
        bool InsertMBTI_Stats(string id, int ei, int sn, int tf, int jp, string result, DateTime mbtiDate);
        DataTable SelectMBTI_Stats_Stu(string id);
        DataTable SelectMBTI_Stats();
        DataTable SelectMBTI_StatsByName(string name);
        DataTable SelectMBTI_Detail(string result);

    }
}
