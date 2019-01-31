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
            SqlParameter[] parameters = new SqlParameter[6];
            parameters[0] = new SqlParameter("id", member.Id);
            parameters[1] = new SqlParameter("name", member.Name);
            parameters[2] = new SqlParameter("gender", member.Gender);
            parameters[3] = new SqlParameter("birthDate", member.BirthDate);
            parameters[4] = new SqlParameter("mobile", member.Mobile);
            parameters[5] = new SqlParameter("address", member.Address);
            
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
                list.Add(new MemberDefault(item["Class_name"].ToString(), item["Name"].ToString(), DateTime.Parse(item["BirthDate"].ToString()), char.Parse(item["Gender"].ToString()), item["Mobile"].ToString(), item["Address"].ToString()));
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
                //mi = new MemberInfo
                //{
                //    Id = dt.Rows[0][0].ToString(),
                //    ClassNum = dt.Rows[0][1].ToString() == null? 0 : Int32.Parse(dt.Rows[0][1].ToString()),
                //    Name = dt.Rows[0][2].ToString() == null? " " : dt.Rows[0][2].ToString(),
                //    BirthDate = DateTime.Parse(dt.Rows[0][3].ToString()),
                //    Gender = char.Parse(dt.Rows[0][4].ToString()),
                //    Mobile = dt.Rows[0][5].ToString(),
                //    Address = dt.Rows[0][6].ToString(),
                //    HopePay = dt.Rows[0][7].ToString() == null? "0" : dt.Rows[0][7].ToString(),
                //    Army = dt.Rows[0][8].ToString() == null ? ' ' : char.Parse(dt.Rows[0][8].ToString()),
                //    Score = dt.Rows[0][9].ToString() == null ? 0 : float.Parse(dt.Rows[0][9].ToString())
                //};
                mi = new MemberInfo();

                mi.Id = dt.Rows[0][0].ToString();
                mi.ClassNum = dt.Rows[0][1].ToString() == null ? 0 : Int32.Parse(dt.Rows[0][1].ToString());
                mi.Name = dt.Rows[0][2].ToString() == null ? " " : dt.Rows[0][2].ToString();
                mi.BirthDate = DateTime.Parse(dt.Rows[0][3].ToString());
                mi.Gender = char.Parse(dt.Rows[0][4].ToString());
                mi.Mobile = dt.Rows[0][5].ToString();
                mi.Address = dt.Rows[0][6].ToString();
                mi.HopePay = dt.Rows[0][7].ToString() == null ? "0" : dt.Rows[0][7].ToString();
                mi.Army = dt.Rows[0][8].ToString() == null ? ' ' : char.Parse(dt.Rows[0][8].ToString());
                mi.Score = dt.Rows[0][9].ToString() == null ? 0 : float.Parse(dt.Rows[0][9].ToString());


            }

            return mi;
        }

        public bool InsetFirstAreaCode(string fa, string fn)
        {
            string proc = "InsertFistArea_Code";

            var dbCon = new DBConnection();

            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@areaCode", fa);
            sqlParameters[1] = new SqlParameter("@firstAreaName", fn);

            try
            {
                return dbCon.ExecuteInsert(proc, sqlParameters);
            }
            catch (Exception)
            {

                throw;
            }
        }

        

        internal bool InsetFirstAreaCode(string code, string name, string firstcode)
        {
            string proc = "AreaInsert";

            var dbCon = new DBConnection();

            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@secondAreaCode", code);
            sqlParameters[1] = new SqlParameter("@secondAreaName", name);
            sqlParameters[2] = new SqlParameter("@firstAreaCode", firstcode);

            try
            {
                return dbCon.ExecuteInsert(proc, sqlParameters);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool InsertJob(string jc, string jn)
        {
            string proc = "InsertFirstJob";

            var dbCon = new DBConnection();

            SqlParameter[] sqlParameters = new SqlParameter[2];
            sqlParameters[0] = new SqlParameter("@jobCode", jc);
            sqlParameters[1] = new SqlParameter("@jobName", jn);
           

            try
            {
                return dbCon.ExecuteInsert(proc, sqlParameters);
            }
            catch (Exception)
            {

                throw;
            }
        }

        internal bool InsertJob(string jobCode, string jobName, string firstJobCode)
        {
            string proc = "InsertSecondJob";

            var dbCon = new DBConnection();

            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@secondeJobCode", jobCode);
            sqlParameters[1] = new SqlParameter("@job_Name", jobName);
            sqlParameters[2] = new SqlParameter("@firstJobCode", firstJobCode);


            try
            {
                return dbCon.ExecuteInsert(proc, sqlParameters);
            }
            catch (Exception)
            {

                throw;
            }
        }

        internal bool InsertDetailJob(string jobCode, string jobName, string secondJobCode)
        {
            string proc = "InsertDetailJob";

            var dbCon = new DBConnection();

            SqlParameter[] sqlParameters = new SqlParameter[3];
            sqlParameters[0] = new SqlParameter("@detailJobCode", jobCode);
            sqlParameters[1] = new SqlParameter("@jobName", jobName);
            sqlParameters[2] = new SqlParameter("@secondJobCode", secondJobCode);


            try
            {
                return dbCon.ExecuteInsert(proc, sqlParameters);
            }
            catch (Exception)
            {

                throw;
            }
        }
        
    }
    }

