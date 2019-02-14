using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeProject.GoodeeDAO
{
    class GoodeeDAO : IGoodee
    {
        private DBConnection con;

        private static GoodeeDAO gd;

        public static GoodeeDAO getInstance()
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

        internal void InsertMember(MemberInfo member)
        {
            string proc = "InsertMember";
            con = new DBConnection();
            SqlParameter[] parameters = new SqlParameter[8];
            parameters[0] = new SqlParameter("id", member.Id);
            parameters[1] = new SqlParameter("name", member.Name);
            parameters[2] = new SqlParameter("gender", member.Gender);
            parameters[3] = new SqlParameter("birthDate", member.BirthDate);
            parameters[4] = new SqlParameter("mobile", member.Mobile);
            parameters[5] = new SqlParameter("address", member.Address);
            parameters[6] = new SqlParameter("curriculum", member.Curriculum);
            parameters[7] = new SqlParameter("class", member.ClassName);
            if (con.ExecuteInsert(proc, parameters))
            {
                System.Windows.Forms.MessageBox.Show("저장성공");
            }
        }

        public List<MemberDefault> SelectMemberList()
        {
            string proc = "SelectMemberList";
            con = new DBConnection();
            List<MemberDefault> list = new List<MemberDefault>();
            DataTable dt = con.ExecuteSelect(proc);
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new MemberDefault(item["Class"].ToString(), item["Curriculum"].ToString(), item["Name"].ToString(), DateTime.Parse(item["BirthDate"].ToString()), item["Gender"].ToString(), item["Mobile"].ToString(), item["Address"].ToString(), item["ID"].ToString()));
            }
            return list;
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
                mi.Curriculum = dt.Rows[0][9].ToString();
                mi.ClassName = dt.Rows[0][10].ToString();
            }
            return mi;
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
            }else
            {
                return true;
            }
        }
    }
}
