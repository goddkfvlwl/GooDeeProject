using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GoodeeProject
{
    public partial class StudentManagement : UserControl
    {
        public StudentManagement()
        {
            InitializeComponent();
        }

        private void StudentManagement_Load(object sender, EventArgs e)
        {
        }

        private void btnReadExl_Click(object sender, EventArgs e)
        {
            string conStr = "Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source= C:\C#\C#\C#WinForm\TeamProject\TeamProject\student.xls;"
                + "Mode=ReadWrite|Share Deny None;" +"Extended Properties='Excel 8.0; HDR=YES; IMEX=1';" +"Persist Security Info=False";
            OleDbConnection con = new OleDbConnection(conStr);
            con.Open();
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM [sheet1$]", con);
            var xls = cmd.ExecuteReader();
            GoodeeDAO.GoodeeDAO goodeeDAO = new GoodeeDAO.GoodeeDAO();
           
            while (xls.Read())
            {
                MemberInfo member = new MemberInfo()
                {
                    Id = xls["이메일"].ToString(),
                    Name = xls["이름"].ToString(),
                    Gender = xls["성별"].ToString() == "남자"? 'm':'f' ,
                    BirthDate = DateTime.Parse(xls["생년월일"].ToString()),
                    Mobile = xls["휴대폰"].ToString(),
                    Address = xls["주소"].ToString()
                };
                goodeeDAO.InsertMember(member);
            }

        }
    }
}
