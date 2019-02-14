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

namespace GoodeeProject
{
    public partial class PortfolioManager : UserControl
    {
        public PortfolioManager()
        {
            InitializeComponent();
        }

        private void PortfolioManager_Load(object sender, EventArgs e)
        {
            GoodeeDAO.GoodeeDAO dao = new GoodeeDAO.GoodeeDAO();
            dataGridView1.DataSource = dao.SelectMemberList();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Columns[0].HeaderText = "분류";
            dataGridView1.Columns[1].HeaderText = "과정명";
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView1.Columns[2].HeaderText = "이름";
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                PortfolioDetail portfolio = new PortfolioDetail();
                panel1.Controls.Add(portfolio);
                portfolio.Location = new Point(0, 0);
                portfolio.Size = new Size(815, 410);
                portfolio.BringToFront();
                string id = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                Control projectInfo = portfolio.Controls["PanelPortfolioBody"].Controls["projectInfoPanel"];
                Control useTechnologyInfo = portfolio.Controls["PanelPortfolioBody"].Controls["useTechnologyPanel"];
                Control introductionInfo = portfolio.Controls["PanelPortfolioBody"].Controls["introductionPanel"];
                //for (int i = introductionInfo.Controls.Count; i > 1; i--)
                //{
                //    introductionInfo.Controls.RemoveAt(i - 1);
                //}
                try
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load("ftp://52.165.176.111:3333/" + id + "/" + id + ".xml");
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
                            portfolio.btnAddTextBox_Click(null, null);
                            introductionInfo.Controls["textbox" + i].Text = item.Attributes["value"].Value.ToString();
                        }
                        else if (item.Name.Contains("picture"))
                        {
                            PictureBox p = new PictureBox();
                            introductionInfo.Controls.Add(p);
                            (introductionInfo.Controls[introductionInfo.Controls.Count - 1] as PictureBox).Size = new Size(int.Parse(item.Attributes["Width"].Value), int.Parse(item.Attributes["Height"].Value));
                            WebClient web = new WebClient();
                            web.DownloadFile(item.Attributes["location"].Value, Application.StartupPath + "/" + item.Name + "jpg");
                            (introductionInfo.Controls[introductionInfo.Controls.Count - 1] as PictureBox).ImageLocation = Application.StartupPath + "/" + item.Name + "jpg";
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls[0].Dispose();
        }
    }
}
