﻿using System;
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
            FtpWebRequest request = null;
            foreach (Control item in introductionInfo.Controls)
            {
                XmlElement temp = xml.CreateElement(item.Name);
                if (item.Name.Contains("textbox"))
                {
                    temp.InnerText = "text" + i;
                    temp.SetAttribute("value", item.Text);
                }else
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

            request = (FtpWebRequest)WebRequest.Create("ftp://52.231.66.167:3333/" + "aaa.xml");
            request.Method = WebRequestMethods.Ftp.UploadFile;

            using (Stream fileStream = File.OpenRead(@"C:\C#\GoodeeProject\CreateXmlEx2.xml"))
            using (Stream ftpStream = request.GetRequestStream())
            {
                fileStream.CopyTo(ftpStream);
            }
            
        }

        private void Portfolio_Load(object sender, EventArgs e)
        {
            try
            {
                Control projectInfo = this.portfolioDetail1.Controls["PanelPortfolioBody"].Controls["projectInfoPanel"];
                Control useTechnologyInfo = this.portfolioDetail1.Controls["PanelPortfolioBody"].Controls["useTechnologyPanel"];
                Control introductionInfo = this.portfolioDetail1.Controls["PanelPortfolioBody"].Controls["introductionPanel"];

                XmlDocument doc = new XmlDocument();
                doc.Load("ftp://52.231.66.167:3333/" + "aaa.xml");
                projectInfo.Controls["txtProjectTitle"].Text = doc.SelectSingleNode("//projectName").InnerText;
                projectInfo.Controls["dpProjectStartDate"].Text = doc.SelectSingleNode("//StartDate").InnerText;
                projectInfo.Controls["dpProjectEndDate"].Text = doc.SelectSingleNode("//EndDate").InnerText;
                projectInfo.Controls["MemberCount"].Text = doc.SelectSingleNode("//MemberCount").InnerText;
                projectInfo.Controls["txtProjectPart"].Text = doc.SelectSingleNode("//ProjectPart").InnerText;
                useTechnologyInfo.Controls["panel4"].Controls["txtDevEnvironment"].Text = doc.SelectSingleNode("//DevelopEnvironment").InnerText;
                useTechnologyInfo.Controls["panel5"].Controls["txtUseTools"].Text = doc.SelectSingleNode("//UseTools").InnerText;
                useTechnologyInfo.Controls["panel6"].Controls["txtUseTechnique"].Text = doc.SelectSingleNode("//UseTechnique").InnerText;
                int i = 1;
                foreach (XmlNode item in doc.SelectSingleNode("//Introduction").ChildNodes)
                {
                    if (item.Name.Contains("Title"))
                    {
                        introductionInfo.Controls["textBoxTitle"].Text = item.InnerText;
                    }
                    else if (item.Name.Contains("textBox") && !item.Name.Contains("Title"))
                    {
                        portfolioDetail1.btnAddTextBox_Click(null, null);
                        introductionInfo.Controls["textbox" + i].Text = item.InnerText;
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
                return;
            }
        }
    }
}
