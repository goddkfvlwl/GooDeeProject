using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                mi = new MemberInfo();

                mi.Id = dt.Rows[0][0].ToString();
                mi.Name = dt.Rows[0][1].ToString() == null ? " " : dt.Rows[0][1].ToString();
                mi.BirthDate = DateTime.Parse(dt.Rows[0][2].ToString());
                mi.Gender = dt.Rows[0][3].ToString().Replace("109", "") == "\0" ? ' ' : char.Parse(dt.Rows[0][3].ToString());
                mi.Mobile = dt.Rows[0][4].ToString();
                mi.Address = dt.Rows[0][5].ToString();
                mi.HopePay = dt.Rows[0][6].ToString() == null ? "0" : dt.Rows[0][6].ToString();
                mi.Army = dt.Rows[0][7].ToString().Contains(Convert.DBNull.ToString()) ? 'N' : char.Parse(dt.Rows[0][7].ToString());
                //mi.Army = dt.Rows[0][7].ToString();
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
                pms[4] = new SqlParameter("picture", imageToByteArray(picture));
            }
            

            if (con.ExecuteUpdate(proc, pms))
            {
                result = true;
            }
            return result;
        }

        public byte[] imageToByteArray(Image imageIn)
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
    }
}
