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
using System.Net;
using System.IO;
using System.Runtime.InteropServices;
using Word = Microsoft.Office.Interop.Word;
using System.Resources;

namespace GoodeeProject
{
    public partial class Portfolio : UserControl
    {
        string beforeName;
        public Portfolio()
        {
            InitializeComponent();
            beforeName = "";
        }
        public Portfolio(string id, string portfolioName) : this()
        {
            LoadPortfolio(id, portfolioName);
        }
        protected override Point ScrollToControl(Control activeControl)
        {
            return this.AutoScrollPosition;
        }

        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {
            bool isDirectoryExist = false;
            string id = FrmMain.Id;
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://52.165.176.111:3333/Portfolio");
            request.Method = WebRequestMethods.Ftp.ListDirectory;
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());

            Control projectInfo = this.portfolioDetail1.Controls["PanelPortfolioBody"].Controls["projectInfoPanel"];
            Control useTechnologyInfo = this.portfolioDetail1.Controls["PanelPortfolioBody"].Controls["useTechnologyPanel"];
            Control introductionInfo = this.portfolioDetail1.Controls["PanelPortfolioBody"].Controls["introductionPanel"];

            while (!reader.EndOfStream)
            {
                string strr = reader.ReadLine();
                if (id == strr)
                {
                    isDirectoryExist = true;
                    break;
                }
            }

            reader.Close();
            if (!isDirectoryExist)
            {
                request = (FtpWebRequest)WebRequest.Create("ftp://52.165.176.111:3333/Portfolio/" + id);
                request.Method = WebRequestMethods.Ftp.MakeDirectory;
                response = (FtpWebResponse)request.GetResponse();
            }

            request = (FtpWebRequest)WebRequest.Create("ftp://52.165.176.111:3333/Portfolio/" + id);
            request.Method = WebRequestMethods.Ftp.ListDirectory;
            response = (FtpWebResponse)request.GetResponse();
            reader = new StreamReader(response.GetResponseStream());
            isDirectoryExist = false;
            while (!reader.EndOfStream)
            {
                string strr = reader.ReadLine();
                if (projectInfo.Controls["txtProjectTitle"].Text == strr)
                {
                    isDirectoryExist = true;
                    break;
                }
            }

            if (!isDirectoryExist)
            {
                request = (FtpWebRequest)WebRequest.Create("ftp://52.165.176.111:3333/Portfolio/" + id + "/" + projectInfo.Controls["txtProjectTitle"].Text);
                request.Method = WebRequestMethods.Ftp.MakeDirectory;
                response = (FtpWebResponse)request.GetResponse();
            }

            
            XmlDocument xml = new XmlDocument();
            xml.CreateXmlDeclaration("1.0", "utf-8-", null);
            XmlNode root = xml.CreateElement("Portfolio");
            xml.AppendChild(root);
            XmlElement info = xml.CreateElement("Info");
            root.AppendChild(info);
            XmlElement projectName = xml.CreateElement("projectName");
            projectName.InnerText = projectInfo.Controls["txtProjectTitle"].Text;
            info.AppendChild(projectName);
            XmlElement startDate = xml.CreateElement("StartDate");
            startDate.InnerText = projectInfo.Controls["dpProjectStartDate"].Text;
            info.AppendChild(startDate);
            XmlElement endDate = xml.CreateElement("EndDate");
            endDate.InnerText = projectInfo.Controls["dpProjectEndDate"].Text;
            info.AppendChild(endDate);
            XmlElement memberCount = xml.CreateElement("MemberCount");
            memberCount.InnerText = (projectInfo.Controls["MemberCount"] as NumericUpDown).Value.ToString();
            info.AppendChild(memberCount);
            XmlElement part = xml.CreateElement("ProjectPart");
            part.InnerText = projectInfo.Controls["txtProjectPart"].Text;
            info.AppendChild(part);
            XmlElement useTechnology = xml.CreateElement("UseTechnology");
            root.AppendChild(useTechnology);
            XmlElement devEnvironment = xml.CreateElement("DevelopEnvironment");
            devEnvironment.InnerText = useTechnologyInfo.Controls["panel4"].Controls["txtDevEnvironment"].Text;
            useTechnology.AppendChild(devEnvironment);
            XmlElement tools = xml.CreateElement("UseTools");
            tools.InnerText = useTechnologyInfo.Controls["panel5"].Controls["txtUseTools"].Text;
            useTechnology.AppendChild(tools);
            XmlElement technique = xml.CreateElement("UseTechnique");
            technique.InnerText = useTechnologyInfo.Controls["panel6"].Controls["txtUseTechnique"].Text;
            useTechnology.AppendChild(technique);
            XmlElement introduction = xml.CreateElement("Introduction");
            root.AppendChild(introduction);
            int i = 0;

            foreach (Control item in introductionInfo.Controls)
            {
                XmlElement temp = xml.CreateElement(item.Name);
                if (item.Name.Contains("textbox"))
                {
                    temp.InnerText = "text" + i;
                    temp.SetAttribute("value", item.Text);
                }
                else
                {
                    request = (FtpWebRequest)WebRequest.Create("ftp://52.165.176.111:3333/Portfolio/" + id + "/" + projectInfo.Controls["txtProjectTitle"].Text + "/" + projectInfo.Controls["txtProjectTitle"].Text + i + ".jpg");
                    request.Method = WebRequestMethods.Ftp.UploadFile;

                    using (Stream fileStream = File.OpenRead((item as PictureBox).ImageLocation))
                    {
                        using (Stream ftpStream = request.GetRequestStream())
                        {
                            fileStream.CopyTo(ftpStream);
                        }
                    }
                    
                    temp.InnerText = "image" + i;
                    temp.SetAttribute("Width", item.Size.Width.ToString());
                    temp.SetAttribute("Height", item.Size.Height.ToString());
                    temp.SetAttribute("location", "ftp://52.165.176.111:3333/Portfolio/" + id + "/" + projectInfo.Controls["txtProjectTitle"].Text + "/" + projectInfo.Controls["txtProjectTitle"].Text + i + ".jpg");
                }
                i++;
                introduction.AppendChild(temp);
            }

            XmlTextWriter writer = new XmlTextWriter(Application.StartupPath + "/" + "xml.xml", Encoding.UTF8);
            writer.Formatting = Formatting.Indented;
            xml.WriteContentTo(writer);
            writer.Flush();
            writer.Close();

            request = (FtpWebRequest)WebRequest.Create("ftp://52.165.176.111:3333/Portfolio/" + id + "/" + projectInfo.Controls["txtProjectTitle"].Text + "/" + projectInfo.Controls["txtProjectTitle"].Text + ".xml");
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.UseBinary = true;
            using (Stream fileStream = File.OpenRead(Application.StartupPath + "/" + "xml.xml"))
            using (Stream ftpStream = request.GetRequestStream())
            {
                fileStream.CopyTo(ftpStream);
                fileStream.Close();
            }
            File.Delete(Application.StartupPath + "/" + "xml.xml");

            GoodeeDAO.GoodeeDAO DAO = new GoodeeDAO.GoodeeDAO();
            var check = DAO.InsertPortfolio(FrmMain.Id, projectInfo.Controls["txtProjectTitle"].Text, beforeName);
            if (check)
            {
                MessageBox.Show("저장성공");
            }else
            {
                MessageBox.Show("저장실패");
            }
        }

        private void LoadPortfolio(string id, string portfolioName)
        {
            Control projectInfo = this.portfolioDetail1.Controls["PanelPortfolioBody"].Controls["projectInfoPanel"];
            Control useTechnologyInfo = this.portfolioDetail1.Controls["PanelPortfolioBody"].Controls["useTechnologyPanel"];
            Control introductionInfo = this.portfolioDetail1.Controls["PanelPortfolioBody"].Controls["introductionPanel"];
            
            for (int i = introductionInfo.Controls.Count; i > 1; i--)
            {
                introductionInfo.Controls.RemoveAt(i - 1);
            }

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("ftp://52.165.176.111:3333/Portfolio/" + id + "/" + portfolioName + "/" + portfolioName + ".xml");
                projectInfo.Controls["txtProjectTitle"].Text = doc.SelectSingleNode("//projectName").InnerText;
                
                projectInfo.Controls["dpProjectStartDate"].Text = doc.SelectSingleNode("//StartDate").InnerText;
                projectInfo.Controls["dpProjectEndDate"].Text = doc.SelectSingleNode("//EndDate").InnerText;
                (projectInfo.Controls["MemberCount"] as NumericUpDown).Value = long.Parse(doc.SelectSingleNode("//MemberCount").InnerText);
                projectInfo.Controls["txtProjectPart"].Text = doc.SelectSingleNode("//ProjectPart").InnerText;
                
                useTechnologyInfo.Controls["panel4"].Controls["txtDevEnvironment"].Text = doc.SelectSingleNode("//DevelopEnvironment").InnerText;
                
                useTechnologyInfo.Controls["panel5"].Controls["txtUseTools"].Text = doc.SelectSingleNode("//UseTools").InnerText;
                
                useTechnologyInfo.Controls["panel6"].Controls["txtUseTechnique"].Text = doc.SelectSingleNode("//UseTechnique").InnerText;

                if (FrmMain.Authority != 'S')
                {
                    projectInfo.Controls["dpProjectStartDate"].Enabled = false;
                    projectInfo.Controls["dpProjectEndDate"].Enabled = false;
                    (projectInfo.Controls["MemberCount"] as NumericUpDown).ReadOnly = true;
                    (projectInfo.Controls["MemberCount"] as NumericUpDown).Enabled = false;
                    (projectInfo.Controls["txtProjectTitle"] as TextBox).ReadOnly = true;
                    (projectInfo.Controls["txtProjectPart"] as TextBox).ReadOnly = true;
                    (useTechnologyInfo.Controls["panel4"].Controls["txtDevEnvironment"] as TextBox).ReadOnly = true;
                    (useTechnologyInfo.Controls["panel5"].Controls["txtUseTools"] as TextBox).ReadOnly = true;
                    (useTechnologyInfo.Controls["panel6"].Controls["txtUseTechnique"] as TextBox).ReadOnly = true;
                    this.portfolioDetail1.Controls["PanelPortfolioBody"].Controls["AddButtonPanel"].Visible = false;
                }
                int i = 0;

                foreach (XmlNode item in doc.SelectSingleNode("//Introduction").ChildNodes)
                {
                    if (item.Name.Contains("Title"))
                    {
                        introductionInfo.Controls["textBoxTitle"].Text = item.Attributes["value"].Value.ToString();
                        if (FrmMain.Authority != 'S')
                        {
                            (introductionInfo.Controls["textBoxTitle"] as TextBox).ReadOnly = true; 
                        }
                    }
                    else if (item.Name.Contains("textbox"))
                    {
                        portfolioDetail1.btnAddTextBox_Click(null, null);
                        introductionInfo.Controls["textbox" + i].Text = item.Attributes["value"].Value.ToString();
                        if (FrmMain.Authority != 'S')
                        {
                            (introductionInfo.Controls["textbox" + i] as TextBox).ReadOnly = true;
                        }
                    }
                    else if (item.Name.Contains("picture"))
                    {
                        PictureBox p = new PictureBox();
                        int count = introductionInfo.Controls.Count;
                        p.Name = "picture" + i;
                        p.MinimumSize = new Size(200, 200);
                        p.MaximumSize = new Size(580, 580);
                        p.SizeMode = PictureBoxSizeMode.StretchImage;
                        if (FrmMain.Authority == 'S')
                        {
                            p.MouseClick += this.portfolioDetail1.Picture_MouseClick;
                            p.MouseDown += this.portfolioDetail1.Picture_MouseDown;
                            p.MouseUp += this.portfolioDetail1.Picture_MouseUp; 
                        }
                        introductionInfo.Controls.Add(p);
                        (introductionInfo.Controls[introductionInfo.Controls.Count - 1] as PictureBox).Size = new Size(int.Parse(item.Attributes["Width"].Value), int.Parse(item.Attributes["Height"].Value));
                        WebClient web = new WebClient();
                        web.DownloadFile(item.Attributes["location"].Value, Application.StartupPath + "/" + item.Name + ".jpg");
                        (introductionInfo.Controls[introductionInfo.Controls.Count - 1] as PictureBox).ImageLocation = Application.StartupPath + "/" + item.Name + ".jpg";
                    }
                    i++;
                }
            }
            catch (WebException)
            {
                MessageBox.Show("저장된 포트폴리오가 없습니다.");
                return;
            }

            beforeName = projectInfo.Controls["txtProjectTitle"].Text;
        }

        private void btnSaveToPDF_Click(object sender, EventArgs e)
        {
            var missingValue = System.Reflection.Missing.Value;
            Word.Application app = new Word.Application();
            Word.Document doc = app.Documents.Open(Application.StartupPath + "/Resources/Project Portfolio.docx");
            Control projectInfo = this.portfolioDetail1.Controls["PanelPortfolioBody"].Controls["projectInfoPanel"];
            Control useTechnologyInfo = this.portfolioDetail1.Controls["PanelPortfolioBody"].Controls["useTechnologyPanel"];
            Control introductionInfo = this.portfolioDetail1.Controls["PanelPortfolioBody"].Controls["introductionPanel"];
            doc.Tables[1].Cell(3, 2).Range.Text = projectInfo.Controls["txtProjectTitle"].Text;
            if (DateTime.Parse(projectInfo.Controls["dpProjectStartDate"].ToString()) < DateTime.Parse(projectInfo.Controls["dpProjectEndDate"].ToString()))
            {
                doc.Tables[1].Cell(4, 2).Range.Text = projectInfo.Controls["dpProjectStartDate"].Text + " ~ " + projectInfo.Controls["dpProjectEndDate"].Text;
            }else
            {
                doc.Tables[1].Cell(4, 2).Range.Text = projectInfo.Controls["dpProjectEndDate"].Text + " ~ " + projectInfo.Controls["dpProjectStartDate"].Text;
            }
            doc.Tables[1].Cell(5, 2).Range.Text = projectInfo.Controls["MemberCount"].Text;
            doc.Tables[1].Cell(6, 2).Range.Text = projectInfo.Controls["txtProjectPart"].Text;
            doc.Tables[1].Cell(8, 2).Range.Text = useTechnologyInfo.Controls["panel4"].Controls["txtDevEnvironment"].Text;
            doc.Tables[1].Cell(9, 2).Range.Text = useTechnologyInfo.Controls["panel5"].Controls["txtUseTools"].Text; 
            doc.Tables[1].Cell(10, 2).Range.Text = useTechnologyInfo.Controls["panel6"].Controls["txtUseTechnique"].Text; 
            doc.Tables[1].Cell(12, 1).Range.Text = introductionInfo.Controls["textboxTitle"].Text;
            for (int i = 1; i < introductionInfo.Controls.Count; i++)
            {
                doc.Tables[1].Cell(doc.Tables[1].Rows.Count, 1).HeightRule = Word.WdRowHeightRule.wdRowHeightAuto;
                if (introductionInfo.Controls[i].Name.Contains("text"))
                {
                    doc.Tables[1].Cell(doc.Tables[1].Rows.Count, 1).Range.Text = introductionInfo.Controls[i].Text;
                }else
                {
                    doc.Tables[1].Rows.Add();
                    Bitmap bit = new Bitmap((introductionInfo.Controls[i] as PictureBox).Image, (introductionInfo.Controls[i] as PictureBox).Size);
                    bit.Save(Application.StartupPath + "/" + introductionInfo.Controls[i].Name + ".jpg");
                    doc.Tables[1].Cell(doc.Tables[1].Rows.Count, 1).Range.InlineShapes.AddPicture(Application.StartupPath + "/" + introductionInfo.Controls[i].Name + ".jpg");
                    if (i < introductionInfo.Controls.Count)
                    {
                        doc.Tables[1].Rows.Add();
                    }
                    File.Delete(Application.StartupPath + "/" + introductionInfo.Controls[i].Name + ".jpg");
                }
            }
            doc.SaveAs2(Application.StartupPath + "/DocTo.doc");
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PDF File (*.pdf) *.pdf|";
            save.DefaultExt = ".pdf";
            save.OverwritePrompt = false;
            if (save.ShowDialog() != DialogResult.Cancel)
            {
                doc.ExportAsFixedFormat(save.FileName, Word.WdExportFormat.wdExportFormatPDF);
            }
            
            doc.Close();
            app.Quit();
            Marshal.FinalReleaseComObject(doc);
            Marshal.FinalReleaseComObject(app);
            File.Delete(Application.StartupPath + "/DocTo.doc");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            
        }
    }
}
