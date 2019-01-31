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
    public partial class MediaButton : UserControl
    {
        private int movePointX;
        private int movePointY;
        Agreement_enterprise main;
        public MediaButton()
        {
            InitializeComponent();
            main = (Agreement_enterprise)Parent;

        }
     


        private void MedeioButton_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + (e.X - movePointX), this.Location.Y + (e.Y - movePointY));
            }
        }

        private void MedeioButton_MouseDown_1(object sender, MouseEventArgs e)
        {
            movePointX = e.X;
            movePointY = e.Y;
        }

       

        private void 동영상올리기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iTalk.iTalk_Button_1 fileSelect = new iTalk.iTalk_Button_1();
            //fileSelect.Parent = this;
            fileSelect.Size = new Size(131, 32);
            fileSelect.Location = new Point(25, 66);
            fileSelect.Text = "내PC파일추가";
            this.Controls.Add(fileSelect);

            fileSelect.Click += FileSelect_Click;
            this.Click += MedeioButton_Click;
        }

        private void FileSelect_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                
            }
        }

        

        private void MedeioButton_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyValue == 27)
            {
                //MessageBox.Show(e.KeyCode.ToString());
                foreach (Control item in this.Controls)
                {
                    item.Dispose();
                }
                main = (Agreement_enterprise)this.Parent;
                main.RemoveControl();
            }
        }

        private void MedeioButton_Click(object sender, EventArgs e)
        {
            this.Select();
        }
    }
}
