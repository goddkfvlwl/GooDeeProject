using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeProject.GoodeeDAO
{
    class GoodeeDAO : IGoodee
    {
        private DBConnection con;

        private static GoodeeDAO gd;

        public static GoodeeDAO GetInstance()
        {
            if (gd == null)
            {
                gd = new GoodeeDAO();
            }
            return gd;
        }

        public AccountInfo AccountLogin(string id, string pw)
        {
            AccountInfo ai = new AccountInfo();
            string proc = "AccountLogin";
            con = new DBConnection();

            SqlParameter[] pms = new SqlParameter[2];
            pms[0] = new SqlParameter("id", id);
            pms[1] = new SqlParameter("pw", pw);

            DataTable dt = con.SelectWithParams(proc, pms);

            if (dt.Rows.Count == 1)
            {
                ai = new AccountInfo(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), char.Parse(dt.Rows[0][2].ToString()));
            }

            return ai;
        }

        internal DataTable SelectChat(string id)
        {
            string proc = "SelectChat";
            con = new DBConnection();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("ID", id);
            return con.SelectWithParams(proc, parameters);
        }

        internal bool CheckID(string email)
        {
            bool result = false;
            string proc = "CheckID";
            con = new DBConnection();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("ID", email);
            int count = (int)con.ExecuteScalar(proc, parameters);
            if (count == 0)
            {
                result = true;
            }
            return result;
        }

        internal bool InsertAdmin(MemberInfo info, string password, char authority)
        {
            string proc = "InsertAdmin";
            con = new DBConnection();
            SqlParameter[] parameters = new SqlParameter[10];
            parameters[0] = new SqlParameter("ID", info.Id);
            parameters[1] = new SqlParameter("PW", password);
            parameters[2] = new SqlParameter("Name", info.Name);
            if (info.BirthDate < DateTime.Parse("0002.01.01"))
            {
                parameters[3] = new SqlParameter("BirthDate", DBNull.Value);
            }
            else
            {
                parameters[3] = new SqlParameter("BirthDate", info.BirthDate);
            }
            parameters[4] = new SqlParameter("Gender", info.Gender);
            parameters[5] = new SqlParameter("Mobile", info.Mobile);
            parameters[6] = new SqlParameter("Address", info.Address);
            if (info.Army == 'Y' || info.Army == 'N')
            {
                parameters[7] = new SqlParameter("Army", info.Army);
            }
            else
            {
                parameters[7] = new SqlParameter("Army", DBNull.Value);
            }

            SqlParameter imageParameter = new SqlParameter("picture", SqlDbType.Image);
            imageParameter.Value = DBNull.Value;

            if (info.Picture == null)
            {
                parameters[8] = imageParameter;
            }
            else
            {
                parameters[8] = new SqlParameter("picture", ImageToByteArray(info.Picture));
            }
            parameters[9] = new SqlParameter("Authority", authority);

            if (con.ExecuteInsert(proc, parameters))
            {
                return true;
            }
            else
            {

                return false;
            }
        }

        internal bool DeleteSelfIntroduction(string id, int num)
        {
            bool result = false;
            string proc = "DeleteSelfIntroduction";
            con = new DBConnection();
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("ID", id);
            parameters[1] = new SqlParameter("Num", num);

            if (con.ExecuteDelete(proc, parameters))
            {
                result = true;
            }
            return result;
        }

        internal int GetMax(string id)
        {
            string proc = "MaxNumSelfIntroduction";
            con = new DBConnection();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("ID", id);


            object temp = con.ExecuteScalar(proc, parameters);
            int result = temp == DBNull.Value ? 0 : (int)temp;

            return result;
        }

        internal void UpdateSelfIntroduction(string id, string text1, string text2, string v, int num)
        {
            string proc = "UpdateSelfIntroduction";
            con = new DBConnection();
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("ID", id);
            parameters[1] = new SqlParameter("Title", text1);
            parameters[2] = new SqlParameter("Body", text2);
            parameters[3] = new SqlParameter("Date", v);
            parameters[4] = new SqlParameter("Num", num);

            if (con.ExecuteUpdate(proc, parameters))
            {
                System.Windows.Forms.MessageBox.Show("저장성공");
            }
        }

        internal void InsertSelfIntroduction(string id, string text1, string text2, string v, int num)
        {
            string proc = "InsertSelfIntroduction";
            con = new DBConnection();
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("ID", id);
            parameters[1] = new SqlParameter("Title", text1);
            parameters[2] = new SqlParameter("Body", text2);
            parameters[3] = new SqlParameter("Date", v);
            parameters[4] = new SqlParameter("Num", num);

            if (con.ExecuteInsert(proc, parameters))
            {
                System.Windows.Forms.MessageBox.Show("저장성공");
            }
        }

        internal void InsertClass(string Class, string curriculm, TextBox turn, DateTime startDate, DateTime endDate, bool isActive)
        {
            string proc = "InsertClass";
            con = new DBConnection();
            SqlParameter[] parameters = new SqlParameter[6];
            parameters[0] = new SqlParameter("ClassName", Class);
            parameters[1] = new SqlParameter("curriculm", curriculm);
            parameters[2] = new SqlParameter("turn", turn);
            parameters[3] = new SqlParameter("startDate", startDate);
            parameters[4] = new SqlParameter("endDate", endDate);
            parameters[5] = new SqlParameter("isActive", isActive);
            if (con.ExecuteInsert(proc, parameters))
            {
                System.Windows.Forms.MessageBox.Show("저장성공");
            }
        }

        internal DataTable SelectChatContent(string Chat1, string Chat2)
        {
            string proc = "SelectChatContent";
            con = new DBConnection();
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("Chat1", Chat1);
            parameters[1] = new SqlParameter("Chat2", Chat2);
            return con.SelectWithParams(proc, parameters);

        }

        internal void InsertChat(string Title, string Chat1, string Chat2, string Chat1Name, string Chat2Name)
        {
            string proc = "InsertChat";
            con = new DBConnection();
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("Title", Title);
            parameters[1] = new SqlParameter("Chat1", Chat1);
            parameters[2] = new SqlParameter("Chat2", Chat2);
            parameters[3] = new SqlParameter("Chat1Name", Chat1Name);
            parameters[4] = new SqlParameter("Chat2Name", Chat2Name);
            con.ExecuteInsert(proc, parameters);
        }

        internal string GetCurriculum(int classNum)
        {
            string proc = "GetCurriculum";
            con = new DBConnection();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("ClassNum", classNum);
            var curriculm = con.SelectWithParams(proc, parameters);
            return curriculm.Rows[0][0].ToString();
        }

        internal DataTable selectClassList()
        {
            string proc = "SelectClassList";
            con = new DBConnection();
            return con.ExecuteSelect(proc);
        }

        internal void UpdateClass(int ID, string Class, string Curriculm, string Turn, DateTime StartDate, DateTime EndDate, bool isActive)
        {
            string proc = "UpdateClass";
            con = new DBConnection();
            SqlParameter[] parameters = new SqlParameter[7];
            parameters[0] = new SqlParameter("ClassNum", ID);
            parameters[1] = new SqlParameter("Class_Name", Class);
            parameters[2] = new SqlParameter("Curriculm", Curriculm);
            parameters[3] = new SqlParameter("Turn", Turn);
            parameters[4] = new SqlParameter("StartDate", StartDate);
            parameters[5] = new SqlParameter("EndDate", EndDate);
            parameters[6] = new SqlParameter("isActive", isActive);
            con.ExecuteInsert(proc, parameters);
        }

        internal void InsertChatContent(string Content, string Chat1, string Chat2)
        {
            string proc = "InsertChatContent";
            con = new DBConnection();
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("Content", Content);
            parameters[1] = new SqlParameter("Chat1", Chat1);
            parameters[2] = new SqlParameter("Chat2", Chat2);

            con.ExecuteInsert(proc, parameters);
        }

        internal DataTable SelectMemberInfo(string id)
        {
            string proc = "SelectMemberInfo";
            con = new DBConnection();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@ID", id);
            return con.SelectWithParams(proc, parameters);
        }

        internal void InsertMember(string[] str)
        {
            string proc = "InsertMember";
            con = new DBConnection();
            SqlParameter[] parameters = new SqlParameter[10];
            parameters[0] = new SqlParameter("id", str[0]);
            parameters[1] = new SqlParameter("name", str[1]);
            parameters[2] = new SqlParameter("gender", str[2]);
            parameters[3] = new SqlParameter("birthDate", DateTime.Parse(str[3]));
            parameters[4] = new SqlParameter("mobile", str[4]);
            parameters[5] = new SqlParameter("address", str[5]);
            parameters[6] = new SqlParameter("ClassName", str[6]);
            parameters[7] = new SqlParameter("Curriculum", str[7]);
            parameters[8] = new SqlParameter("Turn", str[8]);
            parameters[9] = new SqlParameter("Regist", str[9]);
            if (con.ExecuteInsert(proc, parameters))
            {
                System.Windows.Forms.MessageBox.Show("저장성공");
            }
        }

        public DataTable SelectMemberList()
        {
            string proc = "SelectMemberList";
            con = new DBConnection();
            List<MemberInfo> list = new List<MemberInfo>();
            return con.ExecuteSelect(proc);

        }

        public MemberInfo SelectMember(string id)
        {
            string proc = "SelectMember";


            con = new DBConnection();
            MemberInfo mi = new MemberInfo();
            SqlParameter[] pms = new SqlParameter[1];
            pms[0] = new SqlParameter("id", id);

            DataTable dt = con.SelectWithParams(proc, pms);
            if (dt.Rows.Count == 1)
            {
                mi = new MemberInfo();
                mi.Id = dt.Rows[0][0].ToString();
                mi.Name = dt.Rows[0][1].ToString() == null ? " " : dt.Rows[0][1].ToString();
                mi.BirthDate = DateTime.Parse(dt.Rows[0][2].ToString());
                mi.Gender = dt.Rows[0][3].ToString().Replace("109", "") == "\0" ? ' ' : char.Parse(dt.Rows[0][3].ToString());
                mi.Mobile = dt.Rows[0][4].ToString();
                mi.Address = dt.Rows[0][5].ToString();
                mi.HopePay = dt.Rows[0][6].ToString() == null ? "0" : dt.Rows[0][6].ToString();
                mi.Army = dt.Rows[0][7].ToString().Contains(Convert.DBNull.ToString()) ? 'N' : char.Parse(dt.Rows[0][7].ToString());
                mi.Score = dt.Rows[0][8].ToString() == Convert.DBNull.ToString() ? 0 : float.Parse(dt.Rows[0][8].ToString());
                if (String.IsNullOrEmpty(dt.Rows[0][9].ToString()))
                {
                    mi.Picture = Properties.Resources.profile2;

                }
                else
                {
                    var imgArr = (byte[])dt.Rows[0][9];
                    MemoryStream ms = new MemoryStream(imgArr, 0, imgArr.Length);
                    mi.Picture = Image.FromStream(ms);
                }
                mi.ClassNum = dt.Rows[0][10].ToString() == Convert.DBNull.ToString() ? 0 : Int32.Parse(dt.Rows[0][10].ToString());
            }
            return mi;
        }

        public Class SelectClass(int classNum)
        {
            string proc = "SelectClass";
            con = new DBConnection();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@ClassNum", classNum);

            DataTable dt = con.SelectWithParams(proc, parameters);
            Class c = new Class();
            if (dt.Rows.Count == 1)
            {
                c.ClassNum = int.Parse(dt.Rows[0][0].ToString());
                c.Class_Name = dt.Rows[0][1].ToString();
                c.Curriculum = dt.Rows[0][2].ToString();
                if (!string.IsNullOrEmpty(dt.Rows[0][3].ToString()) && !string.IsNullOrEmpty(dt.Rows[0][4].ToString()))
                {
                    c.Startdate = DateTime.Parse(dt.Rows[0][3].ToString());
                    c.Enddate = DateTime.Parse(dt.Rows[0][4].ToString());
                }
                c.Turn = dt.Rows[0][5].ToString();
            }
            return c;
        }

        public void InsertSurvey(string id, string name, DateTime startdate, DateTime enddate)
        {
            string proc = "InsertSurvey";
            con = new DBConnection();
            SqlParameter[] parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@Writer", id);
            parameters[1] = new SqlParameter("@SurveyName", name);
            parameters[2] = new SqlParameter("@StartDate", startdate);
            parameters[3] = new SqlParameter("@EndDate", enddate);
            if (con.ExecuteInsert(proc, parameters))
            {
                System.Windows.Forms.MessageBox.Show("저장성공");
            }
        }

        public List<Survey> SelectSurvey(bool isActivation)
        {
            string proc = "SelectSurvey";
            con = new DBConnection();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@isActivation", isActivation);
            var dt = con.SelectWithParams(proc, parameters);
            List<Survey> list = new List<Survey>();
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new Survey(int.Parse(item["SurveyNum"].ToString()), item["SurveyName"].ToString(), item["Writer"].ToString(), bool.Parse(item["isActivation"].ToString()), DateTime.Parse(item["StartDate"].ToString()), DateTime.Parse(item["EndDate"].ToString())));
            }
            return list;
        }

        public void InsertSurveyItem(Survey_Items item)
        {
            string proc = "InsertSurvey_Item";
            con = new DBConnection();
            SqlParameter[] parameters = new SqlParameter[7];
            parameters[0] = new SqlParameter("@SurveyNum", item.SurveyNum);
            parameters[1] = new SqlParameter("@Id", item.Id);
            parameters[2] = new SqlParameter("@QuestionNum", item.QuestionNum);
            parameters[3] = new SqlParameter("@Question", item.Question);
            parameters[4] = new SqlParameter("@Answer", item.Answer);
            parameters[5] = new SqlParameter("@Division", item.Division);
            parameters[6] = new SqlParameter("@Survey_Date", item.Survey_date);
            con.ExecuteInsert(proc, parameters);
        }

        public DataTable SelectSurveyMulti(int surveyNum)
        {
            string proc = "CountSurvey_Item";
            con = new DBConnection();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@SurveyNum", surveyNum);
            return con.SelectWithParams(proc, parameters);
        }

        public DataTable selectSurveyEssay(int surveyNum)
        {
            string proc = "SelectSurveyEssay";
            con = new DBConnection();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@SurveyNum", surveyNum);
            return con.SelectWithParams(proc, parameters);
        }

        public bool CheckSurvey(string id, int SurveyNum)
        {
            string proc = "CheckSurvey";
            con = new DBConnection();
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@id", id);
            parameters[1] = new SqlParameter("@SurveyNum", SurveyNum);
            var table = con.SelectWithParams(proc, parameters);
            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void DeleteSurvey(int surveyNum)
        {
            string proc = "ModifySurvey";
            con = new DBConnection();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@SurveyNum", surveyNum);
            con.ExecuteInsert(proc, parameters);
        }

        public bool CheckSurveyTitle(string surveyName)
        {
            string proc = "CheckSurveyTitle";
            con = new DBConnection();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@SurveyName", surveyName);
            var table = con.SelectWithParams(proc, parameters);
            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public DataTable SelectPortfolioList(string id)
        {
            string proc = "SelectPortfolioList";
            con = new DBConnection();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@ID", id);
            var table = con.SelectWithParams(proc, parameters);
            return table;
        }

        public bool InsertPortfolio(string id, string portfolioName, string beforeName)
        {
            string proc = "InsertPortfolio";
            con = new DBConnection();
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@id", id);
            parameters[1] = new SqlParameter("@portfolioName", portfolioName);
            parameters[2] = new SqlParameter("@beforeName", beforeName);
            return con.ExecuteInsert(proc, parameters);
        }

        public bool DeletePortfolio(string id, string portfolioName)
        {
            string proc = "DeletePortfolio";
            con = new DBConnection();
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@id", id);
            parameters[1] = new SqlParameter("@portfolioName", portfolioName);
            return con.ExecuteDelete(proc, parameters);
        }

        public bool UpdatePassWord(string id, string pw)
        {
            string proc = "UpdatePassWord";
            bool result = false;
            con = new DBConnection();
            SqlParameter[] pms = new SqlParameter[2];
            pms[0] = new SqlParameter("id", id);
            pms[1] = new SqlParameter("pw", pw);

            if (con.ExecuteUpdate(proc, pms))
            {
                result = true;
            }
            return result;
        }



        public bool UpdateMemberInfo(string id, string mobile, string address, string hopePay, Image picture)
        {
            string proc = "UpdateMemberInfo";
            bool result = false;
            con = new DBConnection();
            SqlParameter[] pms = new SqlParameter[5];
            pms[0] = new SqlParameter("id", id);
            pms[1] = new SqlParameter("mobile", mobile);
            pms[2] = new SqlParameter("addr", address);
            pms[3] = new SqlParameter("hopepay", hopePay);

            SqlParameter imageParameter = new SqlParameter("picture", SqlDbType.Image);
            imageParameter.Value = DBNull.Value;

            if (picture == null)
            {
                pms[4] = imageParameter;
            }
            else
            {
                pms[4] = new SqlParameter("picture", ImageToByteArray(picture));
            }


            if (con.ExecuteUpdate(proc, pms))
            {
                result = true;
            }
            return result;
        }

        public DataTable SelectSelfIntroduction(string id)
        {
            string proc = "SelectSelfIntroduction";


            con = new DBConnection();
            SqlParameter[] pms = new SqlParameter[1];
            pms[0] = new SqlParameter("id", id);

            DataTable dt = con.SelectWithParams(proc, pms);

            return dt;

        }

        public byte[] ImageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }

        public bool InsertLicense(string id, string name, DateTime date, string agency)
        {
            string proc = "InsertLicense";
            bool result = false;
            con = new DBConnection();
            SqlParameter[] pms = new SqlParameter[4];
            pms[0] = new SqlParameter("id", id);
            pms[1] = new SqlParameter("Name", name);
            pms[2] = new SqlParameter("Date", date);
            pms[3] = new SqlParameter("Agency", agency);

            if (con.ExecuteUpdate(proc, pms))
            {
                result = true;
            }
            return result;
        }

        public bool InsertEdu_History(string id, DateTime start, DateTime end, string eduAgency, string eduName, string skilName, string detail)
        {
            string proc = "InsertEdu_History";
            bool result = false;
            con = new DBConnection();
            SqlParameter[] pms = new SqlParameter[7];
            pms[0] = new SqlParameter("id", id);
            pms[1] = new SqlParameter("StartPeriod", start);
            pms[2] = new SqlParameter("EndPeriod", end);
            pms[3] = new SqlParameter("EduAgency", eduAgency);
            pms[4] = new SqlParameter("EduName", eduName);
            pms[5] = new SqlParameter("SkillName", skilName);
            pms[6] = new SqlParameter("Detail", detail);

            if (con.ExecuteUpdate(proc, pms))
            {
                result = true;
            }
            return result;
        }

        public bool InsertEducation(string id, DateTime enter, DateTime gradu, string school, string schoolType, string depart, string eduType)
        {
            string proc = "InsertEducation";
            bool result = false;
            con = new DBConnection();
            SqlParameter[] pms = new SqlParameter[7];
            pms[0] = new SqlParameter("id", id);
            pms[1] = new SqlParameter("EnterPeriod", enter);
            pms[2] = new SqlParameter("GraduPeriod", gradu);
            pms[3] = new SqlParameter("School", school);
            pms[4] = new SqlParameter("SchoolType", schoolType);
            pms[5] = new SqlParameter("Department", depart);
            pms[6] = new SqlParameter("EduType", eduType);

            if (con.ExecuteUpdate(proc, pms))
            {
                result = true;
            }
            return result;
        }

        public DataTable SelectLicense(string id)
        {
            string proc = "SelectLicense";
            con = new DBConnection();
            SqlParameter[] pms = new SqlParameter[1];
            pms[0] = new SqlParameter("id", id);

            return con.SelectWithParams(proc, pms);
        }

        public DataTable SelectEdu(string id)
        {
            string proc = "SelectEdu";
            con = new DBConnection();
            SqlParameter[] pms = new SqlParameter[1];
            pms[0] = new SqlParameter("id", id);

            return con.SelectWithParams(proc, pms);
        }

        public DataTable SelectEdu_History(string id)
        {
            string proc = "SelectEdu_History";
            con = new DBConnection();
            SqlParameter[] pms = new SqlParameter[1];
            pms[0] = new SqlParameter("id", id);

            return con.SelectWithParams(proc, pms);
        }

        public bool DeleteLiEduHis(string id)
        {
            string proc = "DeleteLiEduHis";
            con = new DBConnection();
            SqlParameter[] pms = new SqlParameter[1];
            pms[0] = new SqlParameter("id", id);

            return con.ExecuteDelete(proc, pms);
        }

        public DataTable SelectMBTI_Question()
        {
            string proc = "SelectMBTIQuestion";
            con = new DBConnection();

            return con.ExecuteSelect(proc);
        }

        public DataTable SelectMBTI_Choice()
        {
            string proc = "SelectMBTIChoice";
            con = new DBConnection();

            return con.ExecuteSelect(proc);
        }

        public bool InsertMBTI_Stats(string id, int ei, int sn, int tf, int jp, string result, DateTime mbtiDate)
        {
            string proc = "InsertMBTI_Stats";
            bool rs = false;
            con = new DBConnection();
            SqlParameter[] pms = new SqlParameter[7];
            pms[0] = new SqlParameter("ID", id);
            pms[1] = new SqlParameter("ei", ei);
            pms[2] = new SqlParameter("sn", sn);
            pms[3] = new SqlParameter("tf", tf);
            pms[4] = new SqlParameter("jp", jp);
            pms[5] = new SqlParameter("result", result);
            pms[6] = new SqlParameter("mbtidate", mbtiDate);

            if (con.ExecuteUpdate(proc, pms))
            {
                rs = true;
            }
            return rs;
        }

        public DataTable SelectMBTI_Stats_Stu(string id)
        {
            string proc = "SelectMbtiStats_Stu";
            con = new DBConnection();
            SqlParameter[] pms = new SqlParameter[1];
            pms[0] = new SqlParameter("id", id);

            return con.SelectWithParams(proc, pms);
        }

        public DataTable SelectMBTI_Stats()
        {
            string proc = "SelectMbtiStats";
            con = new DBConnection();

            return con.ExecuteSelect(proc);
        }

        public DataTable SelectAllClass()
        {
            string proc = "SelectAllClass";
            con = new DBConnection();

            return con.ExecuteSelect(proc);
        }

        public DataTable SelectMBTI_StatsByName(string name)
        {
            string proc = "SelectMBTIStatsByName";
            con = new DBConnection();
            SqlParameter[] pms = new SqlParameter[1];
            pms[0] = new SqlParameter("name", name);

            return con.SelectWithParams(proc, pms);
        }

        public DataTable SelectMBTI_Detail(string result)
        {
            string proc = "SelectMBTIDetail";
            con = new DBConnection();
            SqlParameter[] pms = new SqlParameter[1];
            pms[0] = new SqlParameter("result", result);
            return con.SelectWithParams(proc, pms);
        }

        internal DataTable SelectMemberInfoINClassNum(int tag)
        {
            string proc = "SelectMemberInfoINClassNum";
            con = new DBConnection();
            SqlParameter[] pms = new SqlParameter[1];
            pms[0] = new SqlParameter("ClassNum", tag);
            return con.SelectWithParams(proc, pms);
        }
    }
}
