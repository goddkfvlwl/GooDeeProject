using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodeeProject
{
    class DBConnection
    {
        private SqlConnection con;

        public DBConnection()
        {
            string conStr = ConfigurationManager.ConnectionStrings["conStr"].ConnectionString;
            con = new SqlConnection(conStr);
        }

        private SqlConnection OpenConnection()
        {
            if (con.State == System.Data.ConnectionState.Closed || con.State == System.Data.ConnectionState.Broken)
            {
                con.Open();
            }
            return con;
        }

        internal DataTable ExecuteSelect(string proc)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            var ds = new DataSet();

            SqlCommand cmd = new SqlCommand();
            da.SelectCommand = cmd;
            da.SelectCommand.Connection = con;
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.CommandText = proc;

            da.Fill(ds);

            return ds.Tables[0];
        }

        internal bool ExecuteInsert(string proc, SqlParameter[] pm)
        {
            bool result = false;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = proc;

            OpenConnection();

            if (pm != null)
            {
                cmd.Parameters.AddRange(pm);
            }

            int r = cmd.ExecuteNonQuery();


            if (r == 1)
            {
                result = true;
            }

            con.Close();
            return result;
        }

        internal bool ExecuteDelete(string proc, SqlParameter pm)
        {
            bool result = false;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = proc;

            OpenConnection();

            if (pm != null)
            {
                cmd.Parameters.Add(pm);
            }

            int r = cmd.ExecuteNonQuery();

            if (r == 1)
            {
                result = true;
            }
            con.Close();
            return result;
        }
    }
}
