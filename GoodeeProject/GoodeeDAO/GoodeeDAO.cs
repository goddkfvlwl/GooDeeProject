using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GoodeeProject.GoodeeDAO
{
    class GoodeeDAO : IGoodee
    {
        private DBConnection con;

        private static GoodeeDAO gd;
        /// <summary>
        /// DAO단 싱글톤
        /// </summary>
        /// <returns></returns>
        public static GoodeeDAO GetInstance()
        {
            if (gd == null)
            {
                gd = new GoodeeDAO();
            }
            return gd;
        }
        /// <summary>
        /// 매개변수를 통한 프로시저의 값이 있을 경우 AccountInfo 객체에 넣어준다.
        /// </summary>
        /// <param name="id">사용자가 입력한 id</param>
        /// <param name="pw">사용자가 입력한 pw</param>
        /// <returns></returns>
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

        /// <summary>
        /// 채팅목록을 불러옵니다.
        /// </summary>
        /// <param name="id">불러오려는 채팅방의 대상자의 아이디입니다.</param>
        /// <returns></returns>
        internal DataTable SelectChat(string id)
        {
            string proc = "SelectChat";
            con = new DBConnection();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("ID", id);
            return con.SelectWithParams(proc, parameters);
        }

        public AgreementBoard ReadCountUP(int postNum)
        {
            string proc = "ReadBoard";

            SqlParameter sqlparameters = new SqlParameter();
            sqlparameters = new SqlParameter("BoardNum", postNum);
            AgreementBoard ab = new AgreementBoard();

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

        /// <summary>
        /// ID의 중복을 체크하는 메서드입니다.
        /// </summary>
        /// <param name="email">체크하려는 ID입니다.</param>
        /// <returns></returns>
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
            SqlParameter[] parameters = new SqlParameter[10];
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
            int result = temp == DBNull.Value ? 0 : (int)temp;

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

        /// <summary>
        /// 훈련 과정을 등록하는 메서드입니다.
        /// </summary>
        /// <param name="Class">과정 분류</param>
        /// <param name="curriculm">과정명</param>
        /// <param name="turn">과정 회차</param>
        /// <param name="startDate">과정 시작일</param>
        /// <param name="endDate">과정 종료일</param>
        /// <param name="isActive">종료여부</param>
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

        /// <summary>
        /// 이전 채팅 이력을 읽어오는 메서드입니다.
        /// </summary>
        /// <param name="Chat1">채팅 참여자1입니다.</param>
        /// <param name="Chat2">채팅 참여자2입니다.</param>
        /// <returns></returns>
        internal DataTable SelectChatContent(string Chat1, string Chat2)
        {
            string proc = "SelectChatContent";
            con = new DBConnection();
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("Chat1", Chat1);
            parameters[1] = new SqlParameter("Chat2", Chat2);
            return con.SelectWithParams(proc, parameters);

        }

        /// <summary>
        /// 채팅방을 저장하는 메서드입니다.
        /// </summary>
        /// <param name="Title">채팅방의 제목입니다.</param>
        /// <param name="Chat1">채팅 참여자1입니다.</param>
        /// <param name="Chat2">채팅 참여자2입니다.</param>
        /// <param name="Chat1Name">채팅 참여자1의 이름입니다.</param>
        /// <param name="Chat2Name">채팅 참여자2의 이름입니다.</param>
        internal void InsertChat(string Title, string Chat1, string Chat2, string Chat1Name, string Chat2Name)
        {
            string proc = "InsertChat";
            con = new DBConnection();
            SqlParameter[] parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("Title", Title);
            parameters[1] = new SqlParameter("Chat1", Chat1);
            parameters[2] = new SqlParameter("Chat2", Chat2);
            parameters[3] = new SqlParameter("Chat1Name", Chat1Name);
            parameters[4] = new SqlParameter("Chat2Name", Chat2Name);
            con.ExecuteInsert(proc, parameters);
        }

        /// <summary>
        /// ClassNum을 매개변수로 받아 해당하는 과정명을 읽어오는 메서드입니다.
        /// </summary>
        /// <param name="classNum">과정번호</param>
        /// <returns></returns>
        internal string GetCurriculum(int classNum)
        {
            string proc = "GetCurriculum";
            con = new DBConnection();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("ClassNum", classNum);
            var curriculm = con.SelectWithParams(proc, parameters);
            return curriculm.Rows[0][0].ToString();
        }

        /// <summary>
        /// 훈련과정목록을 모두 읽어오는 메서드입니다.
        /// </summary>
        /// <returns></returns>
        internal DataTable selectClassList()
        {
            string proc = "SelectClassList";
            con = new DBConnection();
            return con.ExecuteSelect(proc);
        }

        /// <summary>
        /// 훈련과정을 Update하는 메서드입니다.
        /// </summary>
        /// <param name="ID">아이디</param>
        /// <param name="Class">과정 분류</param>
        /// <param name="Curriculm">과정명</param>
        /// <param name="Turn">과정 회차</param>
        /// <param name="StartDate">과정 시작일</param>
        /// <param name="EndDate">과정 종료일</param>
        /// <param name="isActive">종료 여부</param>
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

        /// <summary>
        /// 채팅방의 채팅내용을 저장하는 메서드입니다.
        /// </summary>
        /// <param name="Content">내용</param>
        /// <param name="Chat1">채팅 참여자1</param>
        /// <param name="Chat2">채팅 참여자2</param>
        internal void InsertChatContent(string Content, string Chat1, string Chat2)
        {
            string proc = "InsertChatContent";
            con = new DBConnection();
            SqlParameter[] parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("Content", Content);
            parameters[1] = new SqlParameter("Chat1", Chat1);
            parameters[2] = new SqlParameter("Chat2", Chat2);

            con.ExecuteInsert(proc, parameters);
        }

        /// <summary>
        /// 해당 ID의 MemberInfo의 데이터를 DataTable형식으로 return 시킨다.
        /// </summary>
        /// <param name="id">사용자 id</param>
        /// <returns></returns>
        internal DataTable SelectMemberInfo(string id)
        {
            string proc = "SelectMemberInfo";
            con = new DBConnection();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@ID", id);
            return con.SelectWithParams(proc, parameters);
        }

        /// <summary>
        /// 수강생의 정보를 Insert하는 메서드입니다.
        /// </summary>
        /// <param name="str">수강생의 정보가 들어있는 string 배열입니다. 아이디, 이름, 성별, 생년월일, 휴대폰, 주소, 과정번호, 과정명, 회차, 수강여부</param>
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
            parameters[9] = new SqlParameter("Regist", "수강");
            con.ExecuteInsert(proc, parameters);
        }

        /// <summary>
        /// 수강생의 목록을 Select하는 메서드입니다.
        /// </summary>
        /// <returns></returns>
        public DataTable SelectMemberList()
        {
            string proc = "SelectMemberList";
            con = new DBConnection();
            List<MemberInfo> list = new List<MemberInfo>();
            return con.ExecuteSelect(proc);

        }
        /// <summary>
        /// 데이터가 있을 경우 MemberInfo 테이블의 데이터를 MemberInfo 객체에 각각 저장시켜준다. 
        /// </summary>
        /// <param name="id">사용자 id</param>
        /// <returns></returns>
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

        /// <summary>
        /// 1차 지역에 대한 코드와 이름을 디비에 저장
        /// </summary>
        /// <param name="fa">1차지역코드</param>
        /// <param name="fn">1차지역이름</param>
        /// <returns></returns>
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


        /// <summary>
        /// 2차지역을인서트한다.
        /// </summary>
        /// <param name="code">2차지역코드</param>
        /// <param name="name">2차지역이름</param>
        /// <param name="firstcode">1차지역코드</param>
        /// <returns></returns>
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

        /// <summary>
        /// 잡에 대한 정보를 저장
        /// </summary>
        /// <param name="jc">직종코드</param>
        /// <param name="jn">직종이름</param>
        /// <returns></returns>
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

        /// <summary>
        /// 두번째 2차 직종
        /// </summary>
        /// <param name="jobCode">2차직종코드</param>
        /// <param name="jobName">2차직종이름</param>
        /// <param name="firstJobCode">1차직종코드</param>
        /// <returns></returns>
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

        /// <summary>
        /// ClassNum을 매개변수로 받아서 해당하는 훈련과정의 정보를 Select하는 메서드입니다.
        /// </summary>
        /// <param name="classNum">훈련 과정 번호</param>
        /// <returns></returns>
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

        /// <summary>
        /// 설문을 저장하는 메서드입니다.
        /// </summary>
        /// <param name="id">작성자 아이디</param>
        /// <param name="name">설문 제목</param>
        /// <param name="startdate">설문 시작일</param>
        /// <param name="enddate">설문 종료일</param>
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

        /// <summary>
        /// 설문 목록을 Select하는 메서드입니다.
        /// </summary>
        /// <param name="isActivation">설문 종료 여부</param>
        /// <returns></returns>
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

        /// <summary>
        /// 설문 답안을 Insert하는 메서드입니다.
        /// </summary>
        /// <param name="item">설문 답안 객체</param>
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

        /// <summary>
        /// 설문 객관식 문항의 답안 갯수를 읽어오는 메서드입니다.
        /// </summary>
        /// <param name="surveyNum">설문 문항 번호</param>
        /// <returns></returns>
        public DataTable SelectSurveyMulti(int surveyNum)
        {
            string proc = "CountSurvey_Item";
            con = new DBConnection();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@SurveyNum", surveyNum);
            return con.SelectWithParams(proc, parameters);
        }

        /// <summary>
        /// 설문 주관식 문항의 답안을 읽어오는 메서드입니다.
        /// </summary>
        /// <param name="surveyNum">설문 번호</param>
        /// <returns></returns>
        public DataTable selectSurveyEssay(int surveyNum)
        {
            string proc = "SelectSurveyEssay";
            con = new DBConnection();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@SurveyNum", surveyNum);
            return con.SelectWithParams(proc, parameters);
        }

        /// <summary>
        /// ID와 SurveyNum을 매개변수로 받아서 설문의 답변을 작성하였는지 체크하는 메서드입니다.
        /// </summary>
        /// <param name="id">아이디</param>
        /// <param name="SurveyNum">설문 번호</param>
        /// <returns></returns>
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
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 설문을 삭제하는 메서드입니다.
        /// </summary>
        /// <param name="surveyNum">설문 번호</param>
        public void DeleteSurvey(int surveyNum)
        {
            string proc = "ModifySurvey";
            con = new DBConnection();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@SurveyNum", surveyNum);
            con.ExecuteInsert(proc, parameters);
        }

        /// <summary>
        /// 설문 제목의 중복을 체크하는 메서드입니다.
        /// </summary>
        /// <param name="surveyName">설문 제목</param>
        /// <returns></returns>
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

        /// <summary>
        /// 포트폴리오의 목록을 읽어오는 메서드입니다.
        /// </summary>
        /// <param name="id">아이디</param>
        /// <returns></returns>
        public DataTable SelectPortfolioList(string id)
        {
            string proc = "SelectPortfolioList";
            con = new DBConnection();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@ID", id);
            var table = con.SelectWithParams(proc, parameters);
            return table;
        }

        /// <summary>
        /// 포트폴리오를 저장하는 메서드입니다.
        /// </summary>
        /// <param name="id">아이디</param>
        /// <param name="portfolioName">포트폴리오 경로</param>
        /// <param name="beforeName">포트폴리오 제목 변경전 제목</param>
        /// <returns></returns>
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

        /// <summary>
        /// 포트폴리오를 삭제하는 메서드입니다.
        /// </summary>
        /// <param name="id">아이디</param>
        /// <param name="portfolioName">포트폴리오 경로</param>
        /// <returns></returns>
        public bool DeletePortfolio(string id, string portfolioName)
        {
            string proc = "DeletePortfolio";
            con = new DBConnection();
            SqlParameter[] parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@id", id);
            parameters[1] = new SqlParameter("@portfolioName", portfolioName);
            return con.ExecuteDelete(proc, parameters);
        }

        /// <summary>
        /// 3차직종코드 insert
        /// </summary>
        /// <param name="jobCode">3차직종코드</param>
        /// <param name="jobName">3차직종이름</param>
        /// <param name="secondJobCode">2차직종코드</param>
        /// <returns></returns>
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

        /// <summary>
        /// 해당 id의 PW를 Update시켜준다.
        /// </summary>
        /// <param name="id">사용자 id</param>
        /// <param name="pw">Update하려 하는 pw</param>
        /// <returns></returns>
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

        /// <summary>
        /// 게시판에 작성된 내용을 insert한다
        /// </summary>
        /// <param name="b">작성된 내을 insert할때 필요한 파라미터</param>
        /// <returns></returns>
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

        /// <summary>
        /// 해당 보드넘버의 댓글을 읽어온다.
        /// </summary>
        /// <param name="board">게시판번호</param>
        /// <returns></returns>
        public List<BoardListComment> OutBoard(int board)
        {
            //GetPost
            List<BoardListComment> list = new List<BoardListComment>();
            SqlParameter prm = new SqlParameter();
            prm = new SqlParameter("@boardNum", board);
            string sp = "SelectCommentBoard";
            try
            {
                SqlDataReader reader = new DBConnection().GetPost(sp, prm);
                while (reader.Read())
                {
                    list.Add(new BoardListComment()
                    {
                        BoardNum = Int32.Parse(reader["BoardNum"].ToString()),
                        Body = reader["Body"].ToString(),
                        WriteDate = DateTime.Parse(reader["WriteDate"].ToString()),
                        Id = reader["ID"].ToString()

                    });
                }
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }

        /// <summary>
        /// 게시판에 등록이된 내용을 select한다.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// 해당 id의 mobile, address, hopepay, picture을 Update 한다.
        /// </summary>
        /// <param name="id">사용자 id</param>
        /// <param name="mobile">바꾸려하는 핸드폰 번호</param>
        /// <param name="address">바꾸려하는 주소</param>
        /// <param name="hopePay">바꾸려하는 희망연봉</param>
        /// <param name="picture">바꾸려하는 프로필사진</param>
        /// <returns></returns>
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


        /// <summary>
        /// 이미지를 Byte배열로 바꿔준다.
        /// </summary>
        /// <param name="imageIn">byte 배열로 바꿀 이미지</param>
        /// <returns></returns>
        public byte[] ImageToByteArray(Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            return ms.ToArray();
        }


        /// <summary>
        /// 게시판의 내용을 삭제
        /// </summary>
        /// <param name="num">샂제할 게시판번호</param>
        /// <returns></returns>
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

        /// <summary>
        /// 1차지역코드 반환
        /// </summary>
        /// <param name="firstAreaName"></param>
        /// <returns></returns>
        public string SubAreaCount(string firstAreaName)
        {
            string sp = "FirstAreaCode";

            string firstCode = "";
            SqlParameter sqlparameters = new SqlParameter();
            sqlparameters = new SqlParameter("firstAreaName", firstAreaName);
            
            try
            {
                SqlDataReader reader = new DBConnection().GetPost(sp, sqlparameters);
                
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

        /// <summary>
        /// 2차지역알아내기
        /// </summary>
        /// <param name="fristCode"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 한국1차 지역검색
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        ///  전체 1차 직종코드랑 1차 직종 이름을 반환한다.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// // 1차 지역코드를 넘겨서 1차지역코드, 2차지역이름, 2차지역코드
        /// </summary>
        /// <param name="firstJobCode"></param>
        /// <returns></returns>
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

        /// <summary>
        /// // 3차지역코드 3차지역이름 2차지역코드
        /// </summary>
        /// <param name="secondJocCode"></param>
        /// <returns></returns>
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

        /// <summary>
        /// 지역검색
        /// </summary>
        /// <returns></returns>
        public List<FirstSubArea> AreaAutomaticSearch()
        {
            string proc = "AreaAutomaticSearch";
            List<FirstSubArea> list = new List<FirstSubArea>();

            con = new DBConnection();

            DataTable dt = con.ExecuteSelect(proc);
            foreach (DataRow item in dt.Rows)
            {
                list.Add(new FirstSubArea()
                {
                    FirstAreaCode = item["FirstArea_Code"].ToString(),
                    FirstAreaName1 = item["FirstArea_Name"].ToString(),
                    SubAreaCode = item["secondArea_Code"].ToString(),
                    SubAreaName = item["secondArea_Name"].ToString()
                });
            }
            return list;

        }

        /// <summary>
        /// License테이블에 매개변수의 데이터를 Insert 시킨다.
        /// </summary>
        /// <param name="id">사용자 id</param>
        /// <param name="name">자격증 명</param>
        /// <param name="date">발급날짜</param>
        /// <param name="agency">발급기관</param>
        /// <returns></returns>
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

        /// <summary>
        /// Edu_History 테이블에 매개변수의 데이터를 Insert 시킨다.
        /// </summary>
        /// <param name="id">사용자 id</param>
        /// <param name="start">시작 날짜</param>
        /// <param name="end">종료 날짜</param>
        /// <param name="eduAgency">교육기관</param>
        /// <param name="eduName">교육명</param>
        /// <param name="skilName">기술명</param>
        /// <param name="detail">상세내용</param>
        /// <returns></returns>
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

        /// <summary>
        /// Education테이블에 매개변수의 데이터를 Insert 시킨다.
        /// </summary>
        /// <param name="id">사용자id</param>
        /// <param name="enter">입학날짜</param>
        /// <param name="gradu">졸업날짜</param>
        /// <param name="school">학교명</param>
        /// <param name="schoolType">학교구분</param>
        /// <param name="depart">과</param>
        /// <param name="eduType">졸업구분</param>
        /// <returns></returns>
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

        /// <summary>
        /// 수강생의 최종 학력 데이터를 가져오는 메서드입니다.
        /// </summary>
        /// <param name="id">아이디</param>
        /// <returns></returns>
        public DataTable GetHighestEducation(string id)
        {
            string proc = "GetHighestEducation";
            con = new DBConnection();
            SqlParameter[] pms = new SqlParameter[1];
            pms[0] = new SqlParameter("id", id);
            return con.SelectWithParams(proc, pms);
        }

        /// <summary>
        /// License테이블에 해당 id의 데이터를 return 시켜준다.
        /// </summary>
        /// <param name="id">사용자 id</param>
        /// <returns></returns>
        public DataTable SelectLicense(string id)
        {
            string proc = "SelectLicense";
            con = new DBConnection();
            SqlParameter[] pms = new SqlParameter[1];
            pms[0] = new SqlParameter("id", id);

            return con.SelectWithParams(proc, pms);
        }

        /// <summary>
        /// Education테이블에 해당 id의 데이터를 return 시켜준다.
        /// </summary>
        /// <param name="id">사용자 id</param>
        /// <returns></returns>
        public DataTable SelectEdu(string id)
        {
            string proc = "SelectEdu";
            con = new DBConnection();
            SqlParameter[] pms = new SqlParameter[1];
            pms[0] = new SqlParameter("id", id);

            return con.SelectWithParams(proc, pms);
        }

        /// <summary>
        /// Edu_History테이블에 해당 id의 데이터를 return시켜준다.
        /// </summary>
        /// <param name="id">사용자 id</param>
        /// <returns></returns>
        public DataTable SelectEdu_History(string id)
        {
            string proc = "SelectEdu_History";
            con = new DBConnection();
            SqlParameter[] pms = new SqlParameter[1];
            pms[0] = new SqlParameter("id", id);

            return con.SelectWithParams(proc, pms);
        }

        /// <summary>
        /// License, Education, Edu_History 테이블에 해당 id의 데이터를 삭제시킨다.
        /// </summary>
        /// <param name="id">사용자 id</param>
        /// <returns></returns>
        public bool DeleteLiEduHis(string id)
        {
            string proc = "DeleteLiEduHis";
            con = new DBConnection();
            SqlParameter[] pms = new SqlParameter[1];
            pms[0] = new SqlParameter("id", id);

            return con.ExecuteDelete(proc, pms);
        }

        /// <summary>
        /// MBTI_Question테이블의 데이터를 return 시켜준다.
        /// </summary>
        /// <returns></returns>
        public DataTable SelectMBTI_Question()
        {
            string proc = "SelectMBTIQuestion";
            con = new DBConnection();

            return con.ExecuteSelect(proc);
        }

        /// <summary>
        /// MBTI_Choice테이블의 데이터를 return 시켜준다.
        /// </summary>
        /// <returns></returns>
        public DataTable SelectMBTI_Choice()
        {
            string proc = "SelectMBTIChoice";
            con = new DBConnection();

            return con.ExecuteSelect(proc);
        }

        /// <summary>
        /// MBTI_Stats테이블에 해당 id를 기준으로 매개변수의 데이터를 Insert 시켜준다.
        /// </summary>
        /// <param name="id">사용자 ID</param>
        /// <param name="ei">E, I 환산점수</param>
        /// <param name="sn">S, N 환산점수</param>
        /// <param name="tf">T, F 환산점수</param>
        /// <param name="jp">J, P 환산점수</param>
        /// <param name="result">결과</param>
        /// <param name="mbtiDate">설문제출날짜</param>
        /// <returns></returns>
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

        /// <summary>
        /// 해당 id가 제출한 MBTI 제출 목록을 return 시켜준다.
        /// </summary>
        /// <param name="id">사용자ID</param>
        /// <returns></returns>
        public DataTable SelectMBTI_Stats_Stu(string id)
        {
            string proc = "SelectMbtiStats_Stu";
            con = new DBConnection();
            SqlParameter[] pms = new SqlParameter[1];
            pms[0] = new SqlParameter("id", id);

            return con.SelectWithParams(proc, pms);
        }
        
        /// <summary>
        /// 모든 MBTI 제출 목록을 return 시켜준다.
        /// </summary>
        /// <returns></returns>
        public DataTable SelectMBTI_Stats()
        {
            string proc = "SelectMbtiStats";
            con = new DBConnection();

            return con.ExecuteSelect(proc);
        }

        public DataTable SelectAllClass()
        {
            string proc = "SelectAllClass";
            con = new DBConnection();

            return con.ExecuteSelect(proc);
        }

        /// <summary>
        /// 사용자 이름이 매개변수가 포함된 MBTI 제출 목록을 return 시켜준다.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public DataTable SelectMBTI_StatsByName(string name)
        {
            string proc = "SelectMBTIStatsByName";
            con = new DBConnection();
            SqlParameter[] pms = new SqlParameter[1];
            pms[0] = new SqlParameter("name", name);

            return con.SelectWithParams(proc, pms);
        }

        /// <summary>
        /// 매개변수를 통해 해당하는 MBTI_Detail의 데이터를 return 시켜준다.
        /// </summary>
        /// <param name="result">MBTI 설문 결과</param>
        /// <returns></returns>
        public DataTable SelectMBTI_Detail(string result)
        {
            string proc = "SelectMBTIDetail";
            con = new DBConnection();
            SqlParameter[] pms = new SqlParameter[1];
            pms[0] = new SqlParameter("result", result);
            return con.SelectWithParams(proc, pms);
        }

        internal DataTable SelectMemberInfoINClassNum(int tag)
        {
            string proc = "SelectMemberInfoINClassNum";
            con = new DBConnection();
            SqlParameter[] pms = new SqlParameter[1];
            pms[0] = new SqlParameter("ClassNum", tag);
            return con.SelectWithParams(proc, pms);
        }

        internal bool UpdateBoard(int boardNum, AgreementBoard board)
        {
            string proc = "UpdateBoard";
            bool result = false;
            con = new DBConnection();
            SqlParameter[] pms = new SqlParameter[3];
            pms[0] = new SqlParameter("@boardNum", board.BoardNum);
            pms[1] = new SqlParameter("@body", board.Body);
            pms[2] = new SqlParameter("@date", board.WriteDate);

            if (con.ExecuteUpdate(proc, pms))
            {
                result = true;
            }
            
            return result;
        }

        /// <summary>
        /// 댓글등록
        /// </summary>
        /// <param name="b">댓글로 넘기기 위한 객체</param>
        /// <returns></returns>
        public bool InsertCommantBoard(BoardListComment b)
        {
            string proc = "InsertCommantBoard";

            var dbCon = new DBConnection();

            SqlParameter[] sqlParameters = new SqlParameter[4];
            sqlParameters[0] = new SqlParameter("@boardNum",b.BoardNum);
            sqlParameters[1] = new SqlParameter("@body", b.Body);
            sqlParameters[2] = new SqlParameter("@writeDate",b.WriteDate);
            sqlParameters[3] = new SqlParameter("@Id", b.Id);

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

