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

        public MemberInfo SelectMember()
        {
            string proc = "SelectMember";
            con = new DBConnection();
            MemberInfo mi = new MemberInfo();

            DataTable dt = con.ExecuteSelect(proc);

            foreach (DataRow item in dt.Rows)
            {
                mi = new MemberInfo(item["id"].ToString(), Int32.Parse(item["ClassNum"].ToString()), item["Name"].ToString(), DateTime.Parse(item["BirthDate"].ToString()), char.Parse(item["Gender"].ToString()), item["Mobile"].ToString(), item["Address"].ToString(), item["HopePay"].ToString(), char.Parse(item["Army"].ToString()), float.Parse(item["Score"].ToString()));
            }

            return mi;
        }
    }
}
