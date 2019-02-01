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
using PdfSharp.Pdf;
using PdfSharp.Drawing;

namespace GoodeeProject
{
    public partial class Portfolio : UserControl
    {
        public Portfolio()
        {
            InitializeComponent();
        }

        protected override Point ScrollToControl(Control activeControl)
        {
            return this.AutoScrollPosition;
        }

        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {
            bool isDirectoryExist = false;
            string id = FrmMain.Id;
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://52.231.66.167:3333/");
            request.Method = WebRequestMethods.Ftp.ListDirectory;
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream());

            while (!reader.EndOfStream)
            {
                string strr = reader.ReadLine();
                if (id.Contains(strr))
                {
                    isDirectoryExist = true;
                    break;
                }
            }
            reader.Close();
            if (!isDirectoryExist)
            {
                request = (FtpWebRequest)WebRequest.Create("ftp://52.231.66.167:3333/" + id);
                request.Method = WebRequestMethods.Ftp.MakeDirectory;
                response = (FtpWebResponse)request.GetResponse();
            }
            Control projectInfo = this.portfolioDetail1.Controls["PanelPortfolioBody"].Controls["projectInfoPanel"];
            Control useTechnologyInfo = this.portfolioDetail1.Controls["PanelPortfolioBody"].Controls["useTechnologyPanel"];
            Control introductionInfo = this.portfolioDetail1.Controls["PanelPortfolioBody"].Controls["introductionPanel"];
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
            memberCount.InnerText = (projectInfo.Controls["MemberCount"] as iTalk.iTalk_NumericUpDown).Value.ToString();
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
                    request = (FtpWebRequest)WebRequest.Create("ftp://52.231.66.167:3333/image" + i + ".jpg");
                    request.Method = WebRequestMethods.Ftp.UploadFile;

                    using (Stream fileStream = File.OpenRead((item as PictureBox).ImageLocation))
                    using (Stream ftpStream = request.GetRequestStream())
                    {
                        fileStream.CopyTo(ftpStream);
                    }
                    temp.InnerText = "image" + i;
                    temp.SetAttribute("Width", item.Size.Width.ToString());
                    temp.SetAttribute("Height", item.Size.Height.ToString());
                    temp.SetAttribute("location", "ftp://52.231.66.167:3333/image" + i + ".jpg");
                }
                i++;
                introduction.AppendChild(temp);
            }
            XmlTextWriter writer = new XmlTextWriter(@"C:\C#\GoodeeProject\CreateXmlEx2.xml", Encoding.UTF8);
            writer.Formatting = Formatting.Indented;
            xml.WriteContentTo(writer);
            writer.Flush();
            writer.Close();

            request = (FtpWebRequest)WebRequest.Create("ftp://52.231.66.167:3333/" + id + "/" + id + ".xml");
            request.Method = WebRequestMethods.Ftp.UploadFile;
            using (Stream fileStream = File.OpenRead(@"C:\C#\GoodeeProject\CreateXmlEx2.xml"))
            using (Stream ftpStream = request.GetRequestStream())
            {
                fileStream.CopyTo(ftpStream);
                fileStream.Close();
            }
        }

        private void iTalk_Button_11_Click_1(object sender, EventArgs e)
        {
            string id = FrmMain.Id;
            Control projectInfo = this.portfolioDetail1.Controls["PanelPortfolioBody"].Controls["portfolio"].Controls["projectInfoPanel"];
            Control useTechnologyInfo = this.portfolioDetail1.Controls["PanelPortfolioBody"].Controls["portfolio"].Controls["useTechnologyPanel"];
            Control introductionInfo = this.portfolioDetail1.Controls["PanelPortfolioBody"].Controls["portfolio"].Controls["introductionPanel"];
            for (int i = introductionInfo.Controls.Count; i > 1; i--)
            {
                introductionInfo.Controls.RemoveAt(i - 1);
            }
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("ftp://52.231.66.167:3333/" + id + "/" + id + ".xml");
                projectInfo.Controls["txtProjectTitle"].Text = doc.SelectSingleNode("//projectName").InnerText;
                projectInfo.Controls["dpProjectStartDate"].Text = doc.SelectSingleNode("//StartDate").InnerText;
                projectInfo.Controls["dpProjectEndDate"].Text = doc.SelectSingleNode("//EndDate").InnerText;
                (projectInfo.Controls["MemberCount"] as iTalk.iTalk_NumericUpDown).Value = long.Parse(doc.SelectSingleNode("//MemberCount").InnerText);
                projectInfo.Controls["txtProjectPart"].Text = doc.SelectSingleNode("//ProjectPart").InnerText;
                useTechnologyInfo.Controls["panel4"].Controls["txtDevEnvironment"].Text = doc.SelectSingleNode("//DevelopEnvironment").InnerText;
                useTechnologyInfo.Controls["panel5"].Controls["txtUseTools"].Text = doc.SelectSingleNode("//UseTools").InnerText;
                useTechnologyInfo.Controls["panel6"].Controls["txtUseTechnique"].Text = doc.SelectSingleNode("//UseTechnique").InnerText;
                int i = 0;

                foreach (XmlNode item in doc.SelectSingleNode("//Introduction").ChildNodes)
                {
                    if (item.Name.Contains("Title"))
                    {
                        introductionInfo.Controls["textBoxTitle"].Text = item.Attributes["value"].Value.ToString();
                    }
                    else if (item.Name.Contains("textbox"))
                    {
                        portfolioDetail1.btnAddTextBox_Click(null, null);
                        introductionInfo.Controls["textbox" + i].Text = item.Attributes["value"].Value.ToString();
                    }
                    else if (item.Name.Contains("picture"))
                    {
                        portfolioDetail1.btnAddPictureBox_Click(null, null);
                        (introductionInfo.Controls["picture" + i] as PictureBox).Size = new Size(int.Parse(item.Attributes["Width"].Value), int.Parse(item.Attributes["Height"].Value));
                        WebClient web = new WebClient();
                        web.DownloadFile(item.Attributes["location"].Value, @"C:\C#\GoodeeProject\" + item.Name + "jpg");
                        (introductionInfo.Controls["picture" + i] as PictureBox).ImageLocation = @"C:\C#\GoodeeProject\" + item.Name + "jpg";
                    }
                    i++;
                }
            }
            catch (WebException)
            {
                MessageBox.Show("저장된 포트폴리오가 없습니다.");
                return;
            }
        }

        private void btnSaveToPDF_Click(object sender, EventArgs e)
        {
            PdfDocument doc = new PdfDocument();
            Control body = this.Controls["portfolioDetail1"].Controls["PanelPortfolioBody"];
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PDF File (*.pdf) *.pdf |";
            save.AddExtension = true;
            save.DefaultExt = ".pdf";
            if (save.ShowDialog() != DialogResult.Cancel)
            {
                string path = save.FileName;

                using (Graphics gfx = this.Controls["portfolioDetail1"].CreateGraphics())
                {
                    using (Bitmap bmp = new Bitmap(body.Width, body.Height, gfx))
                    {
                        body.Focus();
                        if (body.Height > 840)
                        {
                            body.DrawToBitmap(bmp,new Rectangle(0, 0, body.Width, body.Height));
                            for (int i = 0; i < Math.Ceiling(body.Height / 840.0); i++)
                            {
                                //Rectangle r = new Rectangle(0, i * 840, body.Width, 840);
                                Bitmap bit = new Bitmap(585, 840);
                                Graphics g = Graphics.FromImage(bit);
                                g.DrawImage(bmp, new Rectangle(0, 0, 585, 840), new Rectangle(0, i * 840, 585, 840), GraphicsUnit.Pixel);
                                g.Dispose();
                                bit.Save(@"C:\Users\goodee.DESKTOP-V47D6IG\Documents\GJHFTP\" + i + ".bmp");
                                PdfPage page = doc.AddPage();
                                page.Size = PdfSharp.PageSize.A4;
                                XGraphics gf = XGraphics.FromPdfPage(page);
                                XImage image = bit;
                                gf.DrawImage(image, 0, 0, image.PixelWidth, image.PixelHeight);
                            }
                        }else
                        {
                            body.DrawToBitmap(bmp, new Rectangle(0, 0, body.Width, body.Height));
                            Bitmap bit = new Bitmap(bmp, new Size(585, body.Height));
                            PdfPage page = doc.AddPage();
                            page.Size = PdfSharp.PageSize.A4;
                            XGraphics gf = XGraphics.FromPdfPage(page);
                            XImage image = bit;
                            gf.DrawImage(image, 0, 0, image.PixelWidth, image.PixelHeight);
                        }
                        doc.Save(path);
                        doc.Close();
                    }
                }
            }
        }
    }
}
