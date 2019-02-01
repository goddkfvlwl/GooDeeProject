using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodeeProject
{
    public partial class MedioButton : Form
    {
        public MedioButton()
        {
            InitializeComponent();
        }
        iTalk.iTalk_Button_1 myPcChoiceButton;
        iTalk.iTalk_Label urlInput;
        iTalk.iTalk_TextBox_Small urlText;
        iTalk.iTalk_Button_1 urlAddButton;
        private void iTalk_HeaderLabel1_Click(object sender, EventArgs e)
        {
            LinkAddLabel.ForeColor = Color.Gray;
            mediaLabel.ForeColor = Color.Coral;
            
            myPcChoiceButton = new iTalk.iTalk_Button_1();
            myPcChoiceButton.Location = new Point(112, 107);
            
            this.Controls.Add(myPcChoiceButton);
            myPcChoiceButton.Text = "내PC에서 선택";

            myPcChoiceButton.Click += MyPcChoiceButton_Click;

        }

        private void MyPcChoiceButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                MessageBox.Show(openFileDialog1.FileName);

            }
        }

        private void LinkAddLabel_Click(object sender, EventArgs e)
        {
            mediaLabel.ForeColor = Color.Gray;
            LinkAddLabel.ForeColor = Color.Coral;

            urlInput = new iTalk.iTalk_Label();
            urlText = new iTalk.iTalk_TextBox_Small();
            urlAddButton = new iTalk.iTalk_Button_1();
            urlInput.Location = new Point(38, 74);
            urlText.Location = new Point(42, 111);
            urlText.Size = new Size(294, 28);
            urlAddButton.Location = new Point(280, 177);
            urlAddButton.Size = new Size(56, 24);

            this.Controls.Add(urlInput);
            this.Controls.Add(urlText);
            this.Controls.Add(urlAddButton);

            urlInput.Text = "URL입력";
            urlAddButton.Text = "완료";

            urlAddButton.Click += UrlAddButton_Click;

        }

        private void UrlAddButton_Click(object sender, EventArgs e)
        {
            //this.uri = new Uri("https://youtu.be/b73BI9eUkjM");
            //this.web.Url = uri; 
            //this.TxtUrl.Text = uri.ToString();
            
        }

        public void RemoveControl()
        {
            myPcChoiceButton.Dispose();
            urlInput.Dispose();
        }

        
    }
}
