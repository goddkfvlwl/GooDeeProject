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
            SqlParameter[] parameters = new SqlParameter[9];
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
            int result = temp == DBNull.Value? 0 : (int)temp;

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
    }
}
