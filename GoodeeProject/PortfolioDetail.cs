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

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            textbox.Height = textbox.Font.Height * (textbox.GetLineFromCharIndex(textbox.Text.Length) + 2);
        }

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

        private void Textbox_LostFocus(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            textbox.BorderStyle = BorderStyle.None;
        }

        private void Textbox_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                control = sender as TextBox;
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
                introductionPanel.Controls.Add(picture); 
            }
        }

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

        internal void Picture_MouseDown(object sender, MouseEventArgs e)
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
