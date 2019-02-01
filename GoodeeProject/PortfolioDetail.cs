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

        protected override Point ScrollToControl(Control activeControl)
        {
            return this.AutoScrollPosition;
        }

        private void BigTextBox_TextChanged(object sender, EventArgs e)
        {
            AutoSizingTextBox_Big(sender);
        }

        private void SmallTextBox_TextChanged(object sender, EventArgs e)
        {
            AutoSizingTextBox_Small(sender);
        }

        private void AutoSizingTextBox_Big(object sender)
        {
            iTalk.iTalk_TextBox_Big textbox = sender as iTalk.iTalk_TextBox_Big;
            textbox.Height = (textbox.Font.Height + textbox.Padding.Vertical)
                            * (textbox.GetLineFromCharIndex(textbox) + 3);
        }

        private void AutoSizingTextBox_Small(object sender)
        {
            iTalk.iTalk_TextBox_Small textbox = sender as iTalk.iTalk_TextBox_Small;
            textbox.Height = (textbox.Font.Height + textbox.Padding.Vertical)
                            * (textbox.GetLineFromCharIndex(textbox) + 3);
        }

        internal void btnAddTextBox_Click(object sender, EventArgs e)
        {
            iTalk.iTalk_TextBox_Big textbox = new iTalk.iTalk_TextBox_Big();
            int i = this.introductionPanel.Controls.Count;
            textbox.Name = "textbox" + i;
            textbox.Width = introductionPanel.Width - 10;
            textbox.TextChanged += BigTextBox_TextChanged;
            textbox.MouseClick += Textbox_MouseClick;
            textbox.Multiline = true;
            PanelPortfolioBody.Controls.Add(textbox);
        }

        private void Textbox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                control = sender as iTalk.iTalk_TextBox_Big;
                contextMenuStrip1.Show(control, e.Location);
            }
        }

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
                PanelPortfolioBody.Controls.Add(picture); 
            }
        }

        private void Picture_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            PictureBox picture = sender as PictureBox;
            if (e.Button == MouseButtons.Right)
            {
                control = sender as PictureBox;
                contextMenuStrip1.Show(picture, e.Location);
            }
        }

        private void Picture_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox picture = sender as PictureBox;
            if (e.Button == MouseButtons.Left)
            {
                Point movePoint = e.Location;
                picture.Width += movePoint.X - point.X;
                picture.Height += movePoint.Y - point.Y;
            }
        }

        private void Picture_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                point = e.Location;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            control.Dispose();
        }
    }
}
