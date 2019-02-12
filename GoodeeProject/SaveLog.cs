using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeProject
{
    internal class SaveLog
    {
        private string time;
        private string active;

        static List<SaveLog> logList = new List<SaveLog>();

        string filePath;

        public static List<SaveLog> LogList { get => logList; set => logList = value; }
        public string Time { get => time; set => time = value; }
        public string Active { get => active; set => active = value; }

        public void AddList(string active)
        {
            DateTime now = DateTime.Now;

            logList.Add(new SaveLog
            {
                Time = String.Format("{0:yyyy/MM/dd HH:mm:ss}", now),
                Active = active
            });
        }

        public void WriteLog()
        {
            //string dirPath = @"C:\Users\GDC1\Documents";
            string dirPath = Application.StartupPath;

            filePath = dirPath + @"\Log_" + DateTime.Now.ToShortDateString() + "_" + FrmMain.Ai.Id + ".log";

            FileInfo fi = new FileInfo(filePath);

            if (!fi.Exists)
            {
                StreamWriter sw = File.CreateText(filePath);
                foreach (var item in logList)
                {
                    sw.WriteLine("[{0}] {1}", item.time, item.active);
                }
                //sw.WriteLine("[{0}] {1}", DateTime.Now, active);
                sw.Flush();
                sw.Close();
            }
            else
            {
                StreamWriter sw = File.AppendText(filePath);
                foreach (var item in logList)
                {
                    sw.WriteLine("[{0}] {1}", item.time, item.active);
                }
                sw.Flush();
                sw.Close();
            }
        }


        public void SendLog(string id)
        {
            StreamReader sr;
            FtpWebResponse resp;
            
            
            string fileList = "";

            string ftpUrl = "ftp://52.165.176.111:3333/Log/" + @"\Log_" + DateTime.Now.ToShortDateString() + "_" + id + ".log";

            byte[] byteLog;

            //FileInfo fi = new FileInfo(ftpUrl);
            FtpWebRequest req = WebRequest.Create(ftpUrl) as FtpWebRequest;
            req.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

            //ftp 파일목록 가져오기

            try
            {
                resp = req.GetResponse() as FtpWebResponse;
                sr = new StreamReader(resp.GetResponseStream(), Encoding.UTF8);

                fileList = sr.ReadToEnd();   //목록
                sr.Close();
                resp.Close();
            }
            catch (WebException)
            {
                fileList = "";
            }

            FtpWebRequest req2 = WebRequest.Create(ftpUrl) as FtpWebRequest;
            if (!fileList.Contains(id))
            {
                //Console.WriteLine(WebRequestMethods.Ftp.ListDirectoryDetails);
                req2.Method = WebRequestMethods.Ftp.UploadFile;
            }
            else
            {
                req2.Method = WebRequestMethods.Ftp.AppendFile;
            }

            using (sr = new StreamReader(Application.StartupPath + @"\Log_" + DateTime.Now.ToShortDateString() + "_" + id + ".log"))
            {
                byteLog = Encoding.UTF8.GetBytes(sr.ReadToEnd());
            }

            req2.ContentLength = byteLog.Length;
            using (Stream reqStream = req2.GetRequestStream())
            {
                reqStream.Write(byteLog, 0, byteLog.Length);
                reqStream.Flush();
                reqStream.Close();
            }
        }

        public void DeleteLog()
        {
            File.Delete(filePath);
        }
    }
}
