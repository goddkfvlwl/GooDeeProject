using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
                //mi.ClassNum = int.Parse(dt.Rows[0][9].ToString());
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
            }else
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
    }
}
