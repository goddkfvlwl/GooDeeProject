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
    public partial class PortfolioDetail : UserControl
    {
        int size;
        Point point;
        Control control;
        
        public PortfolioDetail()
        {
            InitializeComponent();
            txtProjectPart.MinimumSize = txtProjectPart.Size;
            size = txtUseTools.Height;
        }
        /// <summary>
        /// 스크롤바의 자동이동을 막는 메서드입니다.
        /// </summary>
        /// <param name="activeControl">스크롤바의 이동을 호출한 컨트롤입니다.</param>
        /// <returns></returns>
        protected override Point ScrollToControl(Control activeControl)
        {
            return this.AutoScrollPosition;
        }

        /// <summary>
        /// 텍스트 박스의 높이를 자동으로 조정합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            textbox.Height = textbox.Font.Height * (textbox.GetLineFromCharIndex(textbox.Text.Length) + 2);
        }
        /// <summary>
        /// 텍스트박스를 동적으로 생성하여 추가합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        internal void btnAddTextBox_Click(object sender, EventArgs e)
        {
            TextBox textbox = new TextBox();
            int i = this.introductionPanel.Controls.Count;
            textbox.Name = "textbox" + i;
            textbox.Width = PanelPortfolioBody.Width - 10;
            textbox.TextChanged += TextBox_TextChanged;
            textbox.MouseClick += Textbox_MouseClick;
            textbox.LostFocus += Textbox_LostFocus;
            textbox.Multiline = true;
            introductionPanel.Controls.Add(textbox);
        }
        /// <summary>
        /// 텍스트박스가 포커스를 잃을경우 텍스트박스의 테두리를 지웁니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void Textbox_LostFocus(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            textbox.BorderStyle = BorderStyle.None;
        }

        /// <summary>
        /// 텍스트박스에 마우스 오른쪽 버튼을 클릭하면 ContextMenuStrip을  Show합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">Control.MouseUp, Control.MouseDown 및 Control.MouseMove 이벤트에 대한 데이터를 제공합니다. </param>
        private void Textbox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                control = sender as TextBox;
                contextMenuStrip1.Show(control, e.Location);
            }
        }

        /// <summary>
        /// PictureBox를 동적으로 생성하며 OpenFileDialog를 실행시켜 이미지를 선택해 PictureBox의 Image로 설정합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        internal void btnAddPictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image files(*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (open.ShowDialog() != DialogResult.Cancel)
            {
                PictureBox picture = new PictureBox();
                int i = this.introductionPanel.Controls.Count;
                picture.Name = "picture" + i;
                picture.BorderStyle = BorderStyle.FixedSingle;
                picture.Size = new Size(200, 200);
                picture.MinimumSize = new Size(200, 200);
                picture.MaximumSize = new Size(580, 580);
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                picture.MouseClick += Picture_MouseClick;
                picture.MouseDown += Picture_MouseDown;
                picture.MouseUp += Picture_MouseUp;
                picture.ImageLocation = open.FileName;
                introductionPanel.Controls.Add(picture); 
            }
        }

        /// <summary>
        /// PictureBox에 마우스 오른쪽 버튼을 클릭하면 ContextMenuStrip을  Show합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">Control.MouseUp, Control.MouseDown 및 Control.MouseMove 이벤트에 대한 데이터를 제공합니다. </param>
        internal void Picture_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            PictureBox picture = sender as PictureBox;
            if (e.Button == MouseButtons.Right)
            {
                control = sender as PictureBox;
                contextMenuStrip1.Show(picture, e.Location);
            }
        }

        /// <summary>
        /// 텍스트박스에 마우스 왼쪽 버튼이 MouseUp 될때 현재 마우스의 위치와  저장된 PictureBox의 위치값을 비교하여 PictureBox의 크기를 조정합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">Control.MouseUp, Control.MouseDown 및 Control.MouseMove 이벤트에 대한 데이터를 제공합니다. </param>
        internal void Picture_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox picture = sender as PictureBox;
            if (e.Button == MouseButtons.Left)
            {
                Point movePoint = e.Location;
                picture.Width += movePoint.X - point.X;
                picture.Height += movePoint.Y - point.Y;
            }
        }

        /// <summary>
        /// 텍스트박스에 마우스 왼쪽 버튼이 클릭될때 현제 PictureBox의 위치값을 저장합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">Control.MouseUp, Control.MouseDown 및 Control.MouseMove 이벤트에 대한 데이터를 제공합니다. </param>
        internal void Picture_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                point = e.Location;
            }
        }
        /// <summary>
        /// 현재 폼을 종료합니다.
        /// </summary>
        /// <param name="sender">이벤트를 호출한 컨트롤 객체</param>
        /// <param name="e">이벤트 데이터를 포함하는 클래스의 기본 클래스를 나타내며 이벤트 데이터를 포함하지 않는 이벤트에 사용할 값을 제공합니다.</param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            control.Dispose();
        }
    }
}
