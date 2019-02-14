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

        public GoodeeDAO()
        {
        }

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

        public AgreementBoard ReadCountUP(int postNum)
        {
            string proc = "ReadBoard";

            SqlParameter sqlparameters = new SqlParameter();
            sqlparameters = new SqlParameter("BoardNum", postNum);
            AgreementBoard ab =new AgreementBoard();

            try
            {
                SqlDataReader reader = new DBConnection().GetPost(proc, sqlparameters);
                while (reader.Read())
                {
                    if (!string.IsNullOrEmpty(reader["Body"].ToString()))
                    {
                        ab = new AgreementBoard()
                        {
                            BoardNum = Int32.Parse(reader["BoardNum"].ToString()),
                            Title = reader["Title"].ToString(),
                            Body = reader["Body"].ToString(),
                            WriteDate = DateTime.Parse(reader["WriteDate"].ToString()),
                            Hits = Int32.Parse(reader["hits"].ToString()),
                            Id = reader["ID"].ToString()

                        };
                        
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            return ab;
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
                mi.Name = dt.Rows[0][1].ToString() == null ? " " : dt.Rows[0][1].ToString();
                mi.BirthDate = DateTime.Parse(dt.Rows[0][2].ToString());
                mi.Gender = dt.Rows[0][3].ToString().Replace("109", "") == "\0" ? ' ' : char.Parse(dt.Rows[0][3].ToString());
                mi.Mobile = dt.Rows[0][4].ToString();
                mi.Address = dt.Rows[0][5].ToString();
                mi.HopePay = dt.Rows[0][6].ToString() == null ? "0" : dt.Rows[0][6].ToString();
                mi.Army = dt.Rows[0][7].ToString().Contains(Convert.DBNull.ToString()) ? 'N' : char.Parse(dt.Rows[0][7].ToString());
                //mi.Army = dt.Rows[0][7].ToString();
                mi.Score = dt.Rows[0][8].ToString() == Convert.DBNull.ToString() ? 0 : float.Parse(dt.Rows[0][8].ToString());
                mi.Curriculum = dt.Rows[0][9].ToString();
                mi.ClassName = dt.Rows[0][10].ToString();

                if (String.IsNullOrEmpty(dt.Rows[0][11].ToString()))
                {
                    mi.Picture = Properties.Resources.profile2;

                }
                else
                {
                    var imgArr = (byte[])dt.Rows[0][11];
                    MemoryStream ms = new MemoryStream(imgArr, 0, imgArr.Length);
                    mi.Picture = Image.FromStream(ms);
                }

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


        public bool InsertBoard(AgreementBoard b)
        {
            string proc = "BoardInsert";

            con = new DBConnection();
            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@title", b.Title);
            sqlParameters[1] = new SqlParameter("@body", b.Body);
            sqlParameters[2] = new SqlParameter("@writeDate", b.WriteDate);
            sqlParameters[3] = new SqlParameter("@id", b.Id);

            try
            {
                return con.ExecuteInsert(proc, sqlParameters);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<AgreementBoard> OutBoard()
        {
            List<AgreementBoard> lst = new List<AgreementBoard>();
            string sp = "SelectListBoard";

            try
            {
                SqlDataReader reader = new DBConnection().GetEntryBoard(sp);
                while (reader.Read())
                {
                    lst.Add(new AgreementBoard()
                    {
                        BoardNum = Int32.Parse(reader["BoardNum"].ToString()),
                        Title = reader["Title"].ToString(),
                        WriteDate = DateTime.Parse(reader["WriteDate"].ToString()),
                        Id = reader["ID"].ToString(),
                        Hits = Int32.Parse(reader["hits"].ToString())

                    });
                }
            }
            catch (SqlException)
            {

                throw;
            }
            return lst;
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

        public bool DeleteBoard(int num)
        {
            string proc = "DeleteBoard";

            var dbCon = new DBConnection();

            SqlParameter sqlparameters = new SqlParameter();
            sqlparameters = new SqlParameter("@BoardNum", num);

            try
            {
                return dbCon.ExecuteDelete(proc, sqlparameters);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string SubAreaCount(string firstAreaName)
        {
            string sp = "FirstAreaCode";

            string firstCode = "";
            SqlParameter sqlparameters = new SqlParameter();
            sqlparameters = new SqlParameter("firstAreaName", firstAreaName);
            
            try
            {
                SqlDataReader reader = new DBConnection().GetPost(sp, sqlparameters);
                //System.Windows.Forms.MessageBox.Show(firstCode = reader["FirstArea_Code"].ToString());
                while (reader.Read())
                {
                    firstCode = reader["FirstArea_Code"].ToString();
                }
            }
            catch
            {
                throw;
            }
            return firstCode;
            
        }

        public List<FirstSubArea> SubAreaName(string fristCode)
        {
            string sp = "subAreaCodeName";
            List<FirstSubArea> list = new List<FirstSubArea>();

            SqlParameter sqlParameter = new SqlParameter();
            sqlParameter = new SqlParameter("@firstAreaCode", fristCode);

            try
            {
                SqlDataReader reader = new DBConnection().GetPost(sp, sqlParameter);
                while (reader.Read())
                {
                    list.Add(new FirstSubArea()
                    {
                        SubAreaName = reader["secondArea_Name"].ToString(),
                        SubAreaCode = reader["secondArea_Code"].ToString()
                    });
                }
            }
            catch (Exception)
            {

                throw;
            }

            return list;
        }

        public List<FirstSubArea> AllFirstAreaName()
        {
            string proc = "KoreaFirstAreaName";
            List<FirstSubArea> list = new List<FirstSubArea>();

            try
            {
                SqlDataReader reader = new DBConnection().Select(proc);
                while (reader.Read())
                {
                    list.Add(new FirstSubArea()
                    {
                        FirstAreaName1 = reader["FirstArea_Name"].ToString()
                    });
                        
                }
                
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }

        public List<FirstSubArea> ForeginAllFirstAreaName()
        {
            string proc = "ForeignAreaName";
            List<FirstSubArea> list = new List<FirstSubArea>();

            try
            {
                SqlDataReader reader = new DBConnection().Select(proc);
                while (reader.Read())
                {
                    list.Add(new FirstSubArea()
                    {
                        FirstAreaName1 = reader["FirstArea_Name"].ToString()
                    });

                }

            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }

        public List<FirstSubJob> AllFirstJobName()
        {
            string proc = "AllFirstJob";
            List<FirstSubJob> list = new List<FirstSubJob>();
            try
            {
                SqlDataReader reader = new DBConnection().Select(proc);
                while (reader.Read())
                {
                    list.Add(new FirstSubJob()
                    {
                        FirstJob_Code = reader["Job_Code"].ToString(),
                        FirstJob_Name = reader["Job_Name"].ToString()
                    });
                }
            }
            catch (Exception)
            {

                throw;
            }

            return list;
        }

        public List<FirstSubArea> AllDetailArea(string area)
        {
            string proc = "AllDetailArea";
            List<FirstSubArea> list = new List<FirstSubArea>();
            SqlParameter sqlParameter = new SqlParameter();
            sqlParameter = new SqlParameter("secondAreaName", area);
            try
            {
                SqlDataReader reader = new DBConnection().GetPost(proc, sqlParameter);
                while (reader.Read())
                {
                    list.Add(new FirstSubArea()
                    {
                        FirstAreaCode = reader["FirstArea_Code"].ToString(),
                        SubAreaName = reader["secondArea_Name"].ToString(),
                        SubAreaCode = reader["secondArea_Code"].ToString()
                    });

                }

            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }

        public string AllFirstAreaName(string firstJobName)
        {
            string proc = "selectJobCode";
            string code = "";
            SqlParameter sqlParameter = new SqlParameter();
            sqlParameter = new SqlParameter("@jobName", firstJobName);

            try
            {
                SqlDataReader reader = new DBConnection().GetPost(proc, sqlParameter);
                while (reader.Read())
                {
                    code = reader["Job_Code"].ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }

            return code;
        }

        public List<FirstSubJob> selectSecondJob(string firstJobCode)
        {
            string proc = "selectSecondJob";
            List<FirstSubJob> list = new List<FirstSubJob>();
            SqlParameter sqlParameter = new SqlParameter();
            sqlParameter = new SqlParameter("@firstJobCode", firstJobCode);
            try
            {
                SqlDataReader reader = new DBConnection().GetPost(proc, sqlParameter);
                while (reader.Read())
                {
                    list.Add(new FirstSubJob()
                    {
                        SecondJob_Code = reader["SecondJob_Code"].ToString(),
                        SecondJob_Name = reader["job_Name"].ToString(),
                        FirstJob_Code = reader["FirstJob_Code"].ToString()
                    });

                }

            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }

        public List<FirstSubJob> selectDetailJob(string secondJocCode)
        {
            string proc = "DetailJob";
            List<FirstSubJob> list = new List<FirstSubJob>();
            SqlParameter sqlParameter = new SqlParameter();
            sqlParameter = new SqlParameter("@secondJobCode", secondJocCode);
            try
            {
                SqlDataReader reader = new DBConnection().GetPost(proc, sqlParameter);
                while (reader.Read())
                {
                    list.Add(new FirstSubJob()
                    {
                        Detailjob_Code = reader["DetailJob_Code"].ToString(),
                        Detailjob_Name = reader["Job_Name"].ToString(),
                        SecondJob_Code = reader["SecondJob_Code"].ToString()
                    });

                }

            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }
    }
}

