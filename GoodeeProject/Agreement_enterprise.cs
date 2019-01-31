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
    public partial class Agreement_enterprise : UserControl
    {
        public Agreement_enterprise()
        {
            InitializeComponent();
            
        }
        string fileName = "";
        
        private void picAdd_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                fileName = openFileDialog1.FileName;

                Bitmap myBitmap = new Bitmap(Image.FromFile(fileName));


                Clipboard.SetDataObject(myBitmap);
                DataFormats.Format myFormat = DataFormats.GetFormat(DataFormats.Bitmap);
                if (boardBoby.CanPaste(myFormat))
                {

                    boardBoby.Paste(myFormat);
                }
                else
                {
                    MessageBox.Show("시도한 데이터 형식은 해당 컨트롤이 지원되지 않습니다.");
                }

            }
          
        }


        private void iTalk_Button_15_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                boardBoby.SelectionFont = fontDialog1.Font;
            }
        }

        private void iTalk_Button_16_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                boardBoby.SelectionColor = colorDialog1.Color;
            }
        }
        MediaButton medeioButton;
        private void MedioButton_Click(object sender, EventArgs e)
        {
            medeioButton = new MediaButton();

            medeioButton.Location = new Point(62,80);
            medeioButton.Parent = this;
          
            this.Controls.Add(medeioButton);

            medeioButton.BringToFront();
        }

        public void RemoveControl()
        {
            //medeioButton.Parent.Controls.Remove(medeioButton);
            //medeioButton.Dispose();
            this.Controls.Remove(medeioButton);
        }

        
    }
}
