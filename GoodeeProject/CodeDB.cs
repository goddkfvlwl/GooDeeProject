using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;

namespace GoodeeProject
{
    public partial class CodeDB : Form
    {
        public CodeDB()
        {
            InitializeComponent();
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            string szConn = @"Provider=Microsoft.ACE.OLEDB.12.0.0;Data Source=C:\Users\1\Desktop\프로젝트 코드표\1차 지역 코드표.xlsx;Extended Properties='Excel 12.0;HDR=No'";
            OleDbConnection conn = new OleDbConnection(szConn);
            conn.Open();

            OleDbCommand cmd = new OleDbCommand("SELECT * FROM [Sheet1$]", conn);
            OleDbDataAdapter adpt = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            adpt.Fill(ds);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                string code = string.Format(dr[0].ToString());
                string name = string.Format(dr[1].ToString());
                try
                {
                    new GoodeeDAO.GoodeeDAO().InsetFirstAreaCode(code, name);
                }
                catch (SqlException se)
                {
                    MessageBox.Show(se.Message);
                }
            }
            conn.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string szConn = @"Provider=Microsoft.ACE.OLEDB.12.0.0;Data Source=C:\Users\1\Desktop\프로젝트 코드표\사람인 지역 코드 종합본.xlsx;Extended Properties='Excel 12.0;HDR=No'";
            OleDbConnection conn = new OleDbConnection(szConn);
            conn.Open();

            OleDbCommand cmd = new OleDbCommand("SELECT * FROM [Sheet1$]", conn);
            OleDbDataAdapter adpt = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            adpt.Fill(ds);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                string name = string.Format(dr[0].ToString());
                string secondCode = string.Format(dr[1].ToString());
                string firstcode = string.Format(dr[2].ToString());
                //MessageBox.Show(name + secondCode + firstcode);
                try
                {
                    new GoodeeDAO.GoodeeDAO().InsetFirstAreaCode(secondCode, name, firstcode);
                }
                catch (SqlException se)
                {
                    MessageBox.Show(se.Message);
                }
            }
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string szConn = @"Provider=Microsoft.ACE.OLEDB.12.0.0;Data Source=C:\Users\1\Desktop\프로젝트 코드표\상위 직업 직종 코드표.xlsx;Extended Properties='Excel 12.0;HDR=No'";
            OleDbConnection conn = new OleDbConnection(szConn);
            conn.Open();

            OleDbCommand cmd = new OleDbCommand("SELECT * FROM [Sheet1$]", conn);
            OleDbDataAdapter adpt = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            adpt.Fill(ds);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                string jobCode = string.Format(dr[0].ToString());
                string jobName = string.Format(dr[1].ToString());
                
                //MessageBox.Show(name + secondCode + firstcode);
                try
                {
                    new GoodeeDAO.GoodeeDAO().InsertJob(jobCode, jobName);
                }
                catch (SqlException se)
                {
                    MessageBox.Show(se.Message);
                }
            }
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string szConn = @"Provider=Microsoft.ACE.OLEDB.12.0.0;Data Source=C:\Users\1\Desktop\프로젝트 코드표\직업 직종 코드표.xlsx;Extended Properties='Excel 12.0;HDR=No'";
            OleDbConnection conn = new OleDbConnection(szConn);
            conn.Open();

            OleDbCommand cmd = new OleDbCommand("SELECT * FROM [Sheet1$]", conn);
            OleDbDataAdapter adpt = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            adpt.Fill(ds);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                string jobCode = string.Format(dr[0].ToString());
                string jobName = string.Format(dr[1].ToString());
                string firstJobCode = string.Format(dr[2].ToString());

                try
                {
                    new GoodeeDAO.GoodeeDAO().InsertJob(jobCode, jobName,firstJobCode);
                }
                catch (SqlException se)
                {
                    MessageBox.Show(se.Message);
                }
            }
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string szConn = @"Provider=Microsoft.ACE.OLEDB.12.0.0;Data Source=C:\Users\1\Desktop\프로젝트 코드표\직업 직종 키워드(상세분류) 코드표.xlsx;Extended Properties='Excel 12.0;HDR=No'";
            OleDbConnection conn = new OleDbConnection(szConn);
            conn.Open();

            OleDbCommand cmd = new OleDbCommand("SELECT * FROM [Sheet1$]", conn);
            OleDbDataAdapter adpt = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            adpt.Fill(ds);

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                string jobCode = string.Format(dr[0].ToString());
                string jobName = string.Format(dr[1].ToString());
                string secondJobCode = string.Format(dr[2].ToString());

                try
                {
                    new GoodeeDAO.GoodeeDAO().InsertDetailJob(jobCode, jobName, secondJobCode);
                }
                catch (SqlException se)
                {
                    MessageBox.Show(se.Message);
                }
            }
            conn.Close();
        }
    }
}
