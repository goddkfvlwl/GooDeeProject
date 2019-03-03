using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeProject
{
    public partial class CommantLsit : UserControl
    {
        private int boardNum;
        List<BoardListComment> blist = new List<BoardListComment>();
        string body;
        private static int num;

        public static int Num { get => num; set => num = value; }

        public CommantLsit()
        {
            InitializeComponent();
        }
    
        /// <summary>
        /// 댓글을 달기위해서 해당 게시물 번호가 필요하다. 해당 사용자 폼을 호출시
        /// 게시물번호를 전송해준다.
        /// </summary>
        /// <param name="boardNum"></param>
        public CommantLsit(int boardNum) : this()
        {
            this.boardNum = boardNum;
            blist = new GoodeeDAO.GoodeeDAO().OutBoard(boardNum);    // 게시물번호, 게시물제목, 작성자, 작성일, 조회
        }
        
        /// <summary>
        /// 버튼 클릭 메서드이다. 해당 댓글등록버튼을 누를시, 텍스트와 작성상자가 활성화된다
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iTalk_Button_11_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            InsertComm.Visible = true;
        }

        /// <summary>
        /// 해당 폼이 로드시 처음은 body가 널이다.
        /// 계속 각각의 글을 추가시 그때는 null 이 아니기에
        /// 폼을 갱신시키며 실시간으로 글이 달리는걸 본다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommantLsit_Load(object sender, EventArgs e)
        {
            
            if (body == null)
            {
                ListViewSelect();
            }
            else
            {
                ListView();
            }

        }

        /// <summary>
        /// null이 아닐경우의 리스트뷰
        /// </summary>
        private void ListView()
        {
            agreementList1.BeginUpdate();

            agreementList1.View = View.Details;

            ListViewItem lvi = new ListViewItem(boardNum.ToString());
            lvi.SubItems.Add(FrmMain.Ai.Id);
            lvi.SubItems.Add(richTextBox1.Text);
            lvi.SubItems.Add(DateTime.Now.ToString("yyyy.MM.dd"));

            agreementList1.Items.Add(lvi);

            agreementList1.Columns.Add("게시물번호", 80, HorizontalAlignment.Center);
            agreementList1.Columns.Add("작성자", 100, HorizontalAlignment.Center);
            agreementList1.Columns.Add("댓글내용", 200, HorizontalAlignment.Center);
            agreementList1.Columns.Add("작성일", 100, HorizontalAlignment.Center);

            agreementList1.EndUpdate();
        }

        /// <summary>
        /// null일 경우의 리스트 뷰
        /// </summary>
        private void ListViewSelect()
        {
            
            agreementList1.BeginUpdate();

            agreementList1.View = View.Details;

            foreach (BoardListComment ab in blist)
            {
                num = Int32.Parse(ab.BoardNum.ToString());
                ListViewItem lvi = new ListViewItem(ab.BoardNum.ToString());
                lvi.SubItems.Add(ab.Id);
                lvi.SubItems.Add(ab.Body.ToString());
                lvi.SubItems.Add(ab.WriteDate.ToString("yyyy.MM.dd"));

                agreementList1.Items.Add(lvi);
            }


            agreementList1.Columns.Add("게시물번호", 80, HorizontalAlignment.Center);
            agreementList1.Columns.Add("작성자", 100, HorizontalAlignment.Center);
            agreementList1.Columns.Add("댓글내용", 200, HorizontalAlignment.Center);
            agreementList1.Columns.Add("작성일", 100, HorizontalAlignment.Center);
            
            agreementList1.EndUpdate();
        }

        /// <summary>
        /// 해당 댓글의 내용을 DB에 저장시키는 것이다.
        /// 해당 게시물의 댓글이다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InsertComm_Click(object sender, EventArgs e)
        {
            BoardListComment board = new BoardListComment()
            {
                Id = FrmMain.Ai.Id,
                Body = richTextBox1.Text,
                BoardNum = boardNum,
                WriteDate = DateTime.Now
            };
            body = richTextBox1.Text;
            try
            {
                new GoodeeDAO.GoodeeDAO().InsertCommantBoard(board);
                MessageBox.Show("입력성공");
                CommantLsit_Load(null, null);
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 텍스트를 클릭시 텍스트가 초기화된다.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBox1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void iTalk_Button_12_Click(object sender, EventArgs e)
        {

        }
    }
}
