using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeProject
{
    public partial class CompanyForm : Form, IFormControl
    {
        private int movePointX;
        private int movePointY;
        private TcpClient client;
        private NetworkStream ns;

        PortfolioManager portfolioManager;
        CtlIntroductionListM introductionList;
        CtlResume rs;
        FlowLayoutPanel flowLayout;
        FlowLayoutPanel namefloaw;
        List<Class> list = new List<Class>();
        DataTable table;
        Button nameButton;

        private static string ID;

        public static string ID1 { get => ID; set => ID = value; }
        internal static List<MemberInfo> Mlist { get => mlist; set => mlist = value; }

        static List<MemberInfo> mlist = new List<MemberInfo>();
        

        

        public CompanyForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 기업의 학생들의 열람요청이 되며, TcpClient,NetworkStream객체를 넘겨 받는다.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="ns"></param>
        public CompanyForm(TcpClient client, NetworkStream ns) : this()
        {
            this.client = client;
            this.ns = ns;
        }



        #region 인터페이스
        public void BtnExit_Click(object sender, EventArgs e)
        {
            string logout = "$DisConnect$";
            byte[] a = Encoding.UTF8.GetBytes(logout);
            ns.Write(a, 0, a.Length);
            ns.Flush();
            Environment.Exit(0);
        }

        public void BtnMinimum_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public void Frm_BorderPaint(object sender, PaintEventArgs e)
        {
            Rectangle borderRectangle = this.ClientRectangle;
            borderRectangle.Inflate(0, 0);
            ControlPaint.DrawBorder(e.Graphics, borderRectangle, Color.DimGray, ButtonBorderStyle.Solid);
        }

        public void Frm_MouseDown(object sender, MouseEventArgs e)
        {
            movePointX = e.X;
            movePointY = e.Y;
        }

        public void Frm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + (e.X - movePointX), this.Location.Y + (e.Y - movePointY));
            }
        }


        #endregion

        /// <summary>
        /// 기업은 다른 사용자들의 메인과는 다르게 비활성화 되는 부분들이 있다.
        /// 해당 폼을 로드하면서 각기능의 비활을 해주어야 할것을 false 처리를 해준다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompanyForm_Load(object sender, EventArgs e)
        {
            ctlProfile1.btnStudent.Visible = false;
            ctlProfile1.btnLog.Visible = false;
            ctlProfile1.btnModify.Visible = false;
            ctlProfile1.btnCreateID.Visible = false;
            
            ctlProfile1.lblName.Text = CompanyMainForm.Mi.Name;
            ctlProfile1.lblEmailID.Text = CompanyMainForm.Mi.Id;
        }

        /// <summary>
        /// 자기소개서에 해당하는 버튼의 이벤트이다.
        /// 해당 버튼을 누를경우 모든 학생들의 자기소개서를 들고온다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSpec_Click(object sender, EventArgs e)
        {
            RemoveControl();
            introductionList = new CtlIntroductionListM();
            introductionList.Location = new Point(6, 7);
            panel2.Controls.Add(introductionList);
        }
        
        /// <summary>
        /// 이력서에 해당하는 버튼이다.
        /// 모든 학생들의 이력서를 들고온다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            RemoveControl();
            flowLayout = new FlowLayoutPanel();
            flowLayout.Location = new Point(6, 3);
            flowLayout.Size = new Size(530, 579);
            panel2.Controls.Add(flowLayout);

            
            table = new DataTable();
            table = new GoodeeDAO.GoodeeDAO().SelectAllClass();
            foreach (DataRow item in table.Rows)
            {
                if (item["Class_Name"].ToString().Contains("Manager"))
                {
                    continue;
                }

                {
                    Button button = new Button();
                    button.Font = new Font("굴림", 8f);
                    button.Text = item["Curriculum"].ToString() + " ( " + item["Turn"].ToString() + " ) ";
                    button.Name = item["ClassNum"].ToString();
                    button.Size = new Size(522, 47);
                    
                    flowLayout.Controls.Add(button);
                    button.Click += Button_Click;
                    
                }
                
            }
            

        }

        /// <summary>
        /// 이력서를 받을때 각 반이 먼저 출력이 되며
        /// 각 반을 선택시 각 반에 해당하는 학생들이 나온다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, EventArgs e)
        {
            panel2.Controls.Remove(namefloaw);

            namefloaw = new FlowLayoutPanel();
            namefloaw.Size = new Size(422, 575);
            namefloaw.Location = new Point(540, 3);
            panel2.Controls.Add(namefloaw);

            Button button = (Button)sender;
            DataTable table1 = new DataTable();
            table1 = new GoodeeDAO.GoodeeDAO().SelectMemberList();

            foreach (DataRow item2 in table1.Rows)
            {
                if (Int32.Parse(item2["ClassNum"].ToString()) == Int32.Parse(button.Name))
                {
                    nameButton = new Button();
                    nameButton.Size = new Size(135, 27);
                    nameButton.Font = new Font("굴림", 8f);
                    
                    mlist.Add(new MemberInfo()
                    {
                        Id = item2["ID"].ToString(),
                        Name = item2["Name"].ToString(),
                        BirthDate = DateTime.Parse(item2["BirthDate"].ToString()),
                        Gender = Char.Parse(item2["Gender"].ToString()),
                        Address = item2["Address"].ToString(),
                        Mobile = item2["Mobile"].ToString(),
                        Picture = Properties.Resources.profile2,
                      });
                     
                    nameButton.Text = item2["Name"].ToString();
                    nameButton.Name = item2["ID"].ToString();
                    namefloaw.Controls.Add(nameButton);

                    nameButton.Click += NameButton_Click;
                   
                    
                }
            }
        }

        /// <summary>
        /// 학생으름을 선택시 이력서가 출력된다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NameButton_Click(object sender, EventArgs e)
        {
            RemoveControl();

            Button button = (Button)sender;
            ID = button.Name;
            rs = new CtlResume();
            panel2.Controls.Add(rs);
            
        }

        /// <summary>
        /// 등록이된 모든 학생들의 포토폴리오가 나온다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            RemoveControl();
            portfolioManager = new PortfolioManager();
            panel2.Controls.Add(portfolioManager);
            portfolioManager.Location = new Point(6, 7);
            portfolioManager.BringToFront();
        }

        /// <summary>
        /// 각 기능을 실행시 해당 패널의 컨트롤들을 초기화
        /// </summary>
        public void RemoveControl()
        {
            panel2.Controls.Clear();
            panel2.Controls.Remove(portfolioManager);
            panel2.Controls.Remove(introductionList);
            panel2.Controls.Remove(rs);
            panel2.Controls.Remove(flowLayout);
            panel2.Controls.Remove(namefloaw);
            panel2.Controls.Remove(nameButton);
        }
    }
}
