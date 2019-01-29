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
        public PortfolioDetail()
        {
            InitializeComponent();
            txtProjectPart.MinimumSize = txtProjectPart.Size;
            size = panel1.Height;
        }

        private void txtProjectPart_TextChanged(object sender, EventArgs e)
        {
            AutoSizingTextBox(sender);
            (this.Parent as Portfolio).VerticalScroll.Value = (sender as iTalk.iTalk_TextBox_Big).Location.Y - 100;
        }

        private void AutoSizingTextBox(object sender)
        {
            iTalk.iTalk_TextBox_Big textbox = sender as iTalk.iTalk_TextBox_Big;
            textbox.Height = (textbox.Font.Height + textbox.Padding.Vertical)
                            * (textbox.GetLineFromCharIndex(textbox) + 3);
        }

        private void btnAddTextBox_Click(object sender, EventArgs e)
        {
            iTalk.iTalk_TextBox_Big textbox = new iTalk.iTalk_TextBox_Big();
            textbox.Width = PanelPortfolioBody.Width - 10;
            textbox.TextChanged += txtProjectPart_TextChanged;
            textbox.Multiline = true;
            PanelPortfolioBody.Controls.Add(textbox);
            //(this.Parent as Portfolio).VerticalScroll.Value = textbox.Location.Y - 100;
        }

        private void btnAddPictureBox_Click(object sender, EventArgs e)
        {
            PictureBox picture = new PictureBox();
            picture.BorderStyle = BorderStyle.FixedSingle;
            picture.Size = new Size(200, 200);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.Click += Picture_Click;
            picture.MouseDown += Picture_MouseDown;
            picture.MouseUp += Picture_MouseUp;
            PanelPortfolioBody.Controls.Add(picture);
            //(this.Parent as Portfolio).VerticalScroll.Value = picture.Location.Y - 100;
        }

        private void Picture_MouseUp(object sender, MouseEventArgs e)
        {
            PictureBox picture = sender as PictureBox;
            Point movePoint = e.Location;
            picture.Width += movePoint.X - point.X;
            picture.Height += movePoint.Y - point.Y;
            //(this.Parent as Portfolio).VerticalScroll.Value = (sender as PictureBox).Location.Y;
        }

        private void Picture_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
        }

        private void Picture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            PictureBox picture = sender as PictureBox;
            if (openfile.ShowDialog() != DialogResult.Cancel)
            {
                picture.ImageLocation = openfile.FileName;
            }
        }
    }
}
