using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace GoodeeProject
{
    public partial class JobInformation : UserControl
    {
        static List<XmlSaraminNodeJobs> list;

        StringBuilder area = new StringBuilder();
        string areaAppend = "";

        StringBuilder job = new StringBuilder();
        string jobAppend = "";

        JobAreaChoice choice;
        JobChoice achoice;
        oneJobMatResult oneJobMat;

        string url = "http://api.saramin.co.kr/job-search?";

        string search = "";

        int total = 0;  // job개수
        int count = 10; // 한 페이지당 보여줄 개수
        int page = 0;  // 시작 페이지 번호
        int totalpage = 0;  // 마지막 페이지 번호

        internal static List<XmlSaraminNodeJobs> List { get => list; set => list = value; }

        public JobInformation()
        {
            InitializeComponent();
            list = new List<XmlSaraminNodeJobs>();

        }

        /// <summary>
        /// 지역선택을 눌렀울 경우, 아래의 패널에 지역선택의 사용자 정의 폼이 ADD된다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {
            RemoveControl();
            choice = new JobAreaChoice();
            choice.Location = new Point(38, 111);
            choice.Parent = this;

        }

        /// <summary>
        /// 직종선택을 눌렀을 경우 패널에 직종선택에 해당하는 사용자 정의폼을 띄운다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iTalk_Button_13_Click(object sender, EventArgs e)
        {
            RemoveControl();
            achoice = new JobChoice();
            achoice.Location = new Point(38, 111);
            achoice.Parent = this;

        }

        /// <summary>
        /// 해당폼의 컨트롤을 초기화
        /// </summary>
        public void RemoveControl()
        {
            this.Controls.Remove(choice);
            this.Controls.Remove(achoice);
            this.gbResultJob.Visible = false;
            this.resultPanel.Visible = false;
        }

        /// <summary>
        /// 모든키워드들이 정해지고 검색으로 넘기는 작업이다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            RemoveControl();    // 컨트롤 리무브
            iTalk_Button_12.Visible = true;
            iTalk_Button_13.Visible = true;
            labPage.Visible = true;

            area.Clear();
            job.Clear();

            Keyword();
            
        }

        /// <summary>
        /// 해당 키워드를 넘기면서 xml을 파싱한다.
        /// </summary>
        private void Keyword()
        {
            if (!String.IsNullOrEmpty(jobSearch.Text) && jobSearch.Text != "기업을 입력하세요") // 키워드가 있을 경우
            {
                search.JobKeyword(jobSearch.Text);
                url = listAddKey(url, page);  // 키워드도 있고, 지역 또는 직종이 선택되었을 경우
                //MessageBox.Show(url);
                XElement xml = url.XmlParsing(url);
                total = xml.XmlTotal(xml);  // 해당 jobs노드의 속성인 total값을 반환
                PageVisible();
                UrlXml(xml);
                JobResultAdd();
                
            }
            else if ((!String.IsNullOrEmpty(jobSearch.Text) && jobSearch.Text == "기업을 입력하세요") && (JobAreaChoice.CheckResultlist.Count == 0 && JobChoice.Jlistcheck.Count == 0))
            {
               MessageBox.Show("검색어가 없습니다.");
            }
            else
            {
                // 키워드만 없는 경우
                url = listAdd(url, page);
                //MessageBox.Show(url);
                XElement xml = url.XmlParsing(url);
                total = xml.XmlTotal(xml);  // 해당 jobs노드의 속성인 total값을 반환
                PageVisible();
                UrlXml(xml);
                JobResultAdd();
            }
        }

        /// <summary>
        /// 선택된 키워드들을 코드로 변환하여 사람인 API에 url로 넘긴다.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="page"></param>
        /// <returns></returns>
        private string listAddKey(string url, int page)
        {
            if (JobAreaChoice.CheckResultlist.Count != 0 || JobChoice.Jlistcheck.Count != 0)
            {
                string code = "";

                if (JobChoice.Jlistcheck.Count == 0)  // 직종이 선택된것이 없을 경우
                {
                    foreach (var item in JobAreaChoice.CheckResultlist) // 직종이 선택되지 않았으니 지역만 키워드에 저장
                    {
                        code = item.SubAreaCode;
                        area.Append(code + ",");
                    }
                    areaAppend = area.ToString().Substring(0, area.ToString().LastIndexOf(','));    // 마지막 , 지우기
                    areaButton.Text = "지역선택 (" + JobAreaChoice.CheckResultlist.Count + " 개 선택)";
                    url += "keywords=" + jobSearch.Text + "&loc_cd=" + areaAppend + "&start=" + page;

                }
                else if (JobAreaChoice.CheckResultlist.Count == 0)
                {
                    foreach (var item in JobChoice.Jlistcheck) //직종이 선택되지 않았으니 지역만 키워드에 저장
                    {
                        code = item.Detailjob_Code;
                        job.Append(code + ",");
                    }
                    JobButton.Text += "(" + JobChoice.Jlistcheck.Count + " 개 선택)";
                    jobAppend = job.ToString().Substring(0, job.ToString().LastIndexOf(','));
                    url += "keywords=" + jobSearch.Text + "&job_category=" + jobAppend + "&start=" + page;
                }
                else if (JobAreaChoice.CheckResultlist.Count != 0 && JobChoice.Jlistcheck.Count != 0)
                {
                    foreach (var item in JobAreaChoice.CheckResultlist)
                    {
                        code = item.SubAreaCode;
                        area.Append(code + ",");
                    }

                    foreach (var item in JobChoice.Jlistcheck)
                    {
                        code = item.Detailjob_Code;
                        job.Append(code + ",");
                    }
                    areaAppend = area.ToString().Substring(0, area.ToString().LastIndexOf(','));
                    jobAppend = job.ToString().Substring(0, job.ToString().LastIndexOf(','));
                    areaButton.Text = "지역선택 (" + JobAreaChoice.CheckResultlist.Count + " 개 선택)";
                    JobButton.Text = "직종선택 (" + JobChoice.Jlistcheck.Count + " 개 선택)";
                    url += "keywords=" + jobSearch.Text + "&loc_cd=" + areaAppend + "&job_category=" + jobAppend + "&start=" + page;
                }


            }
            else
            {
                url += "keywords=" + jobSearch.Text;
            }

            return url;
        }

        FontFamily fm = new FontFamily("굴림");
        /// <summary>
        /// 검색결과의 채용기업들의 정보를 사용자 정의폼으로 띄운다.
        /// </summary>
        private void JobResultAdd()
        {
            foreach (var item in list)
            {
                oneJobMat = new oneJobMatResult();
                oneJobMat.companyName.Name = item.Url;
                oneJobMat.companyName1.Text = item.Name;
                oneJobMat.companyName1.ForeColor = Color.DarkBlue;
                oneJobMat.title.Text = item.Title;
                oneJobMat.title.Font = new Font(fm, 11f, FontStyle.Bold);
                oneJobMat.companyIntroduce.Text = item.Experience_level + " | " + item.Required_education_level + " | " + item.Job_type;
                oneJobMat.companyIntroduce.Font = new Font(fm, 7.8f);
                oneJobMat.companyIntroduce.ForeColor = Color.LightSlateGray;
                oneJobMat.keyword.Text = item.Keyword;
                oneJobMat.keyword.Font = new Font(fm, 7.5f);

                oneJobMat.Click += OneJobMat_Click;
                resultPanel.Controls.Add(oneJobMat);


            }


        }

        /// <summary>
        /// 채용정보의 사용자정의폼 클릭시 해당 사이트로 접속한다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OneJobMat_Click(object sender, EventArgs e)
        {
            oneJobMatResult oneJob = (oneJobMatResult)sender;
            Process.Start("chrome.exe", oneJob.companyName.Name);
        }

        /// <summary>
        /// xml을 매개변수로 받으며, 파싱을 하고, 해당 노드를 분석하여 값을 출력한다.
        /// </summary>
        /// <param name="xml"></param>
        private void UrlXml(XElement xml)
        {
            list.Clear();
            IEnumerable<XElement> jobs = xml.Elements();


            var result = from xe in jobs.Elements()
                         select xe;
            foreach (var item in result)
            {
                list.Add(new XmlSaraminNodeJobs()
                {
                    Name = item.Element("company").Value,
                    Url = item.Element("url").Value,
                    Title = item.Element("position").Element("title").Value,
                    Location = (item.Element("position").Element("location").Value).Replace("&gt;", ","),
                    Job_type = item.Element("position").Element("job-type").Value,
                    Industry = item.Element("position").Element("industry").Value,
                    Job_category = item.Element("position").Element("job-category").Value,
                    Experience_level = item.Element("position").Element("experience-level").Value,
                    Required_education_level = item.Element("position").Element("required-education-level").Value,
                    Keyword = "#" + item.Element("keyword").Value
                });
            }


        }
        int spage;
        int t;
        private void PageVisible()
        {
            totalpage = Paging();
            spage = page + 1;
            t = totalpage - 1;
            if (t == -1)
            {
                t = 0;
            }
            labPage.Text = spage + " / " + t;

            this.gbResultJob.Visible = true;
            resultPanel.Visible = true;

        }

        /// <summary>
        /// 페이지정하기
        /// </summary>
        private int Paging()
        {
            if (total % count != 0) // 현재 한 페이지당 10개씩 보여주기로 하였슴; 딱 떨어지지 않음
            {
                totalpage = total / count + 1;

            }
            else if(total % count == 0)
            {
                totalpage = total / count;

            }
            return totalpage;
        }

        /// <summary>
        /// 직종, 지역 선택 여부
        /// </summary>
        /// <param name="url">키워드 선택여부에 따라 검색 url을 반환; 반환될 url</param>
        /// <returns></returns>
        private string listAdd(string url, int page)
        {
            if (JobAreaChoice.CheckResultlist.Count != 0 || JobChoice.Jlistcheck.Count != 0)
            {
                string code = "";

                if (JobChoice.Jlistcheck.Count == 0)  // 직종이 선택된것이 없을 경우
                {
                    foreach (var item in JobAreaChoice.CheckResultlist) // 직종이 선택되지 않았으니 지역만 키워드에 저장
                    {
                        code = item.SubAreaCode;
                        area.Append(code + ",");
                    }
                    areaAppend = area.ToString().Substring(0, area.ToString().LastIndexOf(','));    // 마지막 , 지우기
                    areaButton.Text = "지역선택 (" + JobAreaChoice.CheckResultlist.Count + " 개 선택)";
                    url += "loc_cd=" + areaAppend + "&start=" + page;

                }
                else if (JobAreaChoice.CheckResultlist.Count == 0)
                {
                    foreach (var item in JobChoice.Jlistcheck) //직종이 선택되지 않았으니 지역만 키워드에 저장
                    {
                        code = item.Detailjob_Code;
                        job.Append(code + ",");
                    }
                    JobButton.Text = "(" + JobChoice.Jlistcheck.Count + " 개 선택)";
                    jobAppend = job.ToString().Substring(0, job.ToString().LastIndexOf(','));
                    url += "job_category=" + jobAppend + "&start=" + page;
                }
                else if (JobAreaChoice.CheckResultlist.Count != 0 && JobChoice.Jlistcheck.Count != 0)
                {
                    foreach (var item in JobAreaChoice.CheckResultlist)
                    {
                        code = item.SubAreaCode;
                        area.Append(code + ",");
                    }

                    foreach (var item in JobChoice.Jlistcheck)
                    {
                        code = item.Detailjob_Code;
                        job.Append(code + ",");
                    }
                    areaAppend = area.ToString().Substring(0, area.ToString().LastIndexOf(','));
                    jobAppend = job.ToString().Substring(0, job.ToString().LastIndexOf(','));
                    areaButton.Text = "지역선택 (" + JobAreaChoice.CheckResultlist.Count + " 개 선택)";
                    JobButton.Text = "직종선택 (" + JobChoice.Jlistcheck.Count + " 개 선택)";
                    url += "loc_cd=" + areaAppend + "&job_category=" + jobAppend + "&start=" + page;
                }

            }

            return url;

        }

        /// <summary>
        /// 키워드 클릭시 텍스트가 초기화 된다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void jobSearch_Click(object sender, EventArgs e)
        {
            jobSearch.Text = " ";
        }

       /// <summary>
       /// 페이지 이동에 대한 페이징의 부분이다.
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void iTalk_Button_13_Click_1(object sender, EventArgs e)
        {
            if (page != totalpage)
            {
                resultPanel.Controls.Clear();
                page = page + 1;
                spage = page + 1;
                t = totalpage - 1;
                if (t==-1)
                {
                    t = 0;
                }
                labPage.Text = spage + " / " + t;
                url = listAdd(url, page);
                XElement xml = url.XmlParsing(url);
                UrlXml(xml);
                JobResultAdd();

            }
            else
            {
                MessageBox.Show("마지막페이지 입니다.");
            }
        }

        /// <summary>
        /// 페이징에 해당하는 부분이다
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iTalk_Button_12_Click(object sender, EventArgs e)
        {
            if (page != 0)
            {
                resultPanel.Controls.Clear();
                page = page - 1;
                spage = page + 1;
                t = totalpage - 1;
                if (t == -1)
                {
                    t = 0;
                }
                labPage.Text = spage + " / " + t;
                url = listAdd(url, page);
                XElement xml = url.XmlParsing(url);
                UrlXml(xml);
                JobResultAdd();

            }
            else
            {
                MessageBox.Show("첫 페이지 입니다.");
            }
        }

        /// <summary>
        /// 검색기록을 모두 초기화시키면서 키워드로 저장되어있던 모든 것들을 초기화 시킨다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picReset_Click(object sender, EventArgs e)
        {
            area.Clear();
            job.Clear();
            list.Clear();
            page = 0;
            iTalk_Button_12.Visible = false;
            iTalk_Button_13.Visible = false;
            labPage.Visible = false;
            url = "http://api.saramin.co.kr/job-search?";
            area.Remove(0, area.Length);
            job.Remove(0, job.Length);
            JobAreaChoice.CheckResultlist.Clear();
            JobChoice.Jlistcheck.Clear();
            areaButton.Text = "지역선택";
            JobButton.Text = "직업선택";
            resultPanel.Controls.Clear();
            labPage.Text = 0 + " / " + 0;
            jobSearch.Text = "기업을 입력하세요";
            search.JobKeyword("기업을 입력하세요");
        }

        /// <summary>
        /// 검색초기화의 툴팁이다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JobInformation_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(picReset, "검색 초기화");
        }

       
    }
}
