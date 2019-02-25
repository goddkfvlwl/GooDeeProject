using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace GoodeeProject
{
    public partial class StudentManagement : UserControl
    {
        System.Data.DataTable table;
        public StudentManagement()
        {
            InitializeComponent();
        }

        private void StudentManagement_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            GoodeeDAO.GoodeeDAO goodeeDAO = GoodeeDAO.GoodeeDAO.getInstance();
            table = goodeeDAO.SelectMemberList();
            this.gViewStudentInfo.Columns.Add("Class", "분류");
            this.gViewStudentInfo.Columns.Add("Curriculum", "과정명");
            this.gViewStudentInfo.Columns.Add("Turn", "회차");
            this.gViewStudentInfo.Columns.Add("Name", "이름");
            this.gViewStudentInfo.Columns.Add("BirthDay", "생년월일");
            this.gViewStudentInfo.Columns.Add("Gender", "성별");
            this.gViewStudentInfo.Columns.Add("Mobile", "휴대폰");
            this.gViewStudentInfo.Columns.Add("Email", "이메일");
            this.gViewStudentInfo.Columns.Add("Address", "주소");
            this.gViewStudentInfo.Columns.Add("Regist", "학적");
            this.gViewStudentInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            gViewStudentInfo.Rows.Clear();
            
            foreach (DataRow item in table.Rows)
            {
                ViewRowInsert(item);
            }
            
        }

        private void btnReadExl_Click(object sender, EventArgs e)
        {
            string xlsPath = "";
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "xls file (*.xls)|*.xls";
            if (openFile.ShowDialog() != DialogResult.Cancel)
            {
                xlsPath = openFile.FileName;
                string conStr = "Provider=Microsoft.Jet.OLEDB.4.0;" + @"Data Source=" + xlsPath + ";"
                        + "Mode=ReadWrite|Share Deny None;" + "Extended Properties='Excel 8.0; HDR=YES; IMEX=1';" + "Persist Security Info=False";
                OleDbConnection con = new OleDbConnection(conStr);
                con.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM [sheet1$]", con);
                var xls = cmd.ExecuteReader();
                GoodeeDAO.GoodeeDAO goodeeDAO = GoodeeDAO.GoodeeDAO.getInstance();

                while (xls.Read())
                {
                    if (!string.IsNullOrEmpty(xls["이메일"].ToString()) && !string.IsNullOrEmpty(xls["이름"].ToString())
                        && !string.IsNullOrEmpty(xls["성별"].ToString()) && !string.IsNullOrEmpty(xls["생년월일"].ToString()) 
                        && !string.IsNullOrEmpty(xls["휴대폰"].ToString()) && !string.IsNullOrEmpty(xls["주소"].ToString()))
                    {
                        string[] member = new string[9];
                        member[0] = xls["이메일"].ToString();
                        member[1] = xls["이름"].ToString();
                        member[2] = xls["성별"].ToString() == "남자" ? "m" : "f";
                        member[3] = xls["생년월일"].ToString();
                        member[4] = xls["휴대폰"].ToString();
                        member[5] = xls["주소"].ToString();
                        member[6] = xls["분류"].ToString();
                        member[7] = xls["과정명"].ToString();
                        member[8] = xls["회차"].ToString();
                        goodeeDAO.InsertMember(member); 
                    }
                }
                con.Close();
            }
            this.StudentManagement_Load(null, null);
        }

        private void btnWriteExl_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "Excel File (*.xls) | *.xls";
            saveFile.AddExtension = true;
            saveFile.DefaultExt = ".xls";
            if (saveFile.ShowDialog() != DialogResult.Cancel)
            {

                GoodeeDAO.GoodeeDAO goodeeDAO = GoodeeDAO.GoodeeDAO.getInstance();

                var list = goodeeDAO.SelectMemberList();
                var missingValue = System.Reflection.Missing.Value;
                Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(missingValue);
                Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets.get_Item(1);
                worksheet.Cells[1][2] = "분류";
                worksheet.Cells[2][2] = "과정명";
                worksheet.Cells[3][2] = "회차";
                worksheet.Cells[4][2] = "이름";
                worksheet.Cells[5][2] = "생년월일";
                worksheet.Cells[6][2] = "성별";
                worksheet.Cells[7][2] = "휴대폰";
                worksheet.Cells[8][2] = "이메일";
                worksheet.Cells[9][2] = "주소";
                worksheet.Cells[10][2] = "학력";
                worksheet.Cells[11][2] = "최종학교";
                worksheet.Cells[12][2] = "전공";
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    worksheet.Cells[1][i + 3] = table.Rows[i]["class_Name"].ToString();
                    worksheet.Cells[2][i + 3] = table.Rows[i]["curriculum"].ToString();
                    worksheet.Cells[3][i + 3] = table.Rows[i]["turn"].ToString();
                    worksheet.Cells[4][i + 3] = table.Rows[i]["Name"].ToString();
                    worksheet.Cells[5][i + 3] = DateTime.Parse(table.Rows[i]["BirthDate"].ToString()).ToShortDateString();
                    worksheet.Cells[6][i + 3] = table.Rows[i]["Gender"].ToString() == "m" ? "남자" : "여자";
                    worksheet.Cells[7][i + 3] = table.Rows[i]["Mobile"].ToString();
                    worksheet.Cells[8][i + 3] = table.Rows[i]["Id"].ToString();
                    worksheet.Cells[9][i + 3] = table.Rows[i]["Address"].ToString();
                    worksheet.Cells[10][i + 3] = "학력";
                    worksheet.Cells[11][i + 3] = "최종학교";
                    worksheet.Cells[12][i + 3] = "전공";
                }
                workbook.SaveAs(saveFile.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, missingValue, missingValue, missingValue, missingValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, missingValue, missingValue, missingValue, missingValue, missingValue);
                workbook.Close(true, missingValue, missingValue);

                Marshal.ReleaseComObject(worksheet);
                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(app);
            }
        }

        private void gViewStudentInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = gViewStudentInfo.Rows[e.RowIndex].Cells[7].Value.ToString();
            FrmStudentRegist regist = new FrmStudentRegist(id);
            regist.ShowDialog();
            StudentManagement_Load(null, null);
        }

        private void mnubtnIndividualRegist_Click(object sender, EventArgs e)
        {
            FrmStudentRegist regist = new FrmStudentRegist();
            regist.ShowDialog();
            StudentManagement_Load(null, null);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            gViewStudentInfo.Rows.Clear();
            switch (comboBox1.SelectedItem)
            {
                case "이름":
                    foreach (DataRow item in table.Rows)
                    {
                        if (item["Name"].ToString().Contains(textBox1.Text))
                        {
                            ViewRowInsert(item);
                        }
                    }
                    break;
                case "분류":
                    foreach (DataRow item in table.Rows)
                    {
                        if (item["class_Name"].ToString().Contains(textBox1.Text))
                        {
                            ViewRowInsert(item);
                        }
                    }
                    break;
                case "과정명":
                    foreach (DataRow item in table.Rows)
                    {
                        if (item["curriculum"].ToString().Contains(textBox1.Text))
                        {
                            ViewRowInsert(item);
                        }
                    }
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// 그리드뷰에 StudentInfo정보를 체우는 메서드입니다.
        /// </summary>
        /// <param name="item">StudentInfo DataTable</param>
        private void ViewRowInsert(DataRow item)
        {
            string gender = "";
            if (item["Gender"].ToString() == "m" || item["Gender"].ToString() == "M")
            {
                gender = "남자";
            }
            else
            {
                gender = "여자";
            }
            gViewStudentInfo.Rows.Add(new string[] { item["class_Name"].ToString(), item["curriculum"].ToString(), item["turn"].ToString(), item["Name"].ToString(), DateTime.Parse(item["BirthDate"].ToString()).ToShortDateString(), gender, item["Mobile"].ToString(), item["Id"].ToString(), item["Address"].ToString(), item["Register"].ToString() });
        }
    }
}
