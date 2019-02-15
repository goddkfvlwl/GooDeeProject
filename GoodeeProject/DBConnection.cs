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

        internal DataTable SelectWithParams(string proc, SqlParameter[] pm)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            var ds = new DataSet();

            OpenConnection();

            SqlCommand cmd = new SqlCommand();
            da.SelectCommand = cmd;
            da.SelectCommand.Connection = con;
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.CommandText = proc;

            if (pm != null)
            {
                da.SelectCommand.Parameters.AddRange(pm); 
            }

            da.Fill(ds);
            con.Close();
            return ds.Tables[0];
        }

        internal DataTable ExecuteSelect(string proc)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            var ds = new DataSet();

            OpenConnection();

            SqlCommand cmd = new SqlCommand();
            da.SelectCommand = cmd;
            da.SelectCommand.Connection = con;
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.CommandText = proc;

            da.Fill(ds);
            con.Close();
            return ds.Tables[0];
        }

        internal bool ExecuteScalar(string proc, SqlParameter[] parameters)
        {
            bool result = false;
         
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = OpenConnection();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = proc;

            if (parameters != null)
            {
                cmd.Parameters.AddRange(parameters);
            }

            int id = (int)cmd.ExecuteScalar();
            if (id == 0)
            {
                result = true;
            }

            con.Close();
            return result;
        }

        internal bool ExecuteInsert(string proc, SqlParameter[] pm)
        {
            bool result = false;
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = proc;

      

            if (pm != null)
            {
                cmd.Parameters.AddRange(pm);
            }

            int r = cmd.ExecuteNonQuery();


            if (r >= 1)
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

        internal bool ExecuteUpdate(string proc, SqlParameter[] pms)
        {
            bool result = false;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = proc;

            OpenConnection();

            if (pms != null)
            {
                cmd.Parameters.AddRange(pms);
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
