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
        //iTalk.iTalk_Label urlInput;
        //iTalk.iTalk_TextBox_Small urlText;
        //iTalk.iTalk_Button_1 urlAddButton;
        string url = "";

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
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string formats = "All Videos Files |*.dat; *.wmv; *.3g2; *.3gp; *.3gp2; *.3gpp; *.amv; *.asf;  *.avi; *.bin; *.cue; *.divx; *.dv; *.flv; *.gxf; *.iso; *.m1v; *.m2v; *.m2t; *.m2ts; *.m4v; " +
                      " *.mkv; *.mov; *.mp2; *.mp2v; *.mp4; *.mp4v; *.mpa; *.mpe; *.mpeg; *.mpeg1; *.mpeg2; *.mpeg4; *.mpg; *.mpv2; *.mts; *.nsv; *.nuv; *.ogg; *.ogm; *.ogv; *.ogx; *.ps; *.rec; *.rm; *.rmvb; *.tod; *.ts; *.tts; *.vob; *.vro; *.webm";

            openFileDialog.Filter = formats;

            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                mediaFileName.Text = "첨부파일 :" + openFileDialog.FileName;
                url = openFileDialog.FileName;
            }
        }

        private void LinkAddLabel_Click(object sender, EventArgs e)
        {
            //mediaLabel.ForeColor = Color.Gray;
            //LinkAddLabel.ForeColor = Color.Coral;

            //urlInput = new iTalk.iTalk_Label();
            //urlText = new iTalk.iTalk_TextBox_Small();
            //urlAddButton = new iTalk.iTalk_Button_1();
            //urlInput.Location = new Point(38, 74);
            //urlText.Location = new Point(42, 111);
            //urlText.Size = new Size(294, 28);
            //urlAddButton.Location = new Point(280, 177);
            //urlAddButton.Size = new Size(56, 24);

            //this.Controls.Add(urlInput);
            //this.Controls.Add(urlText);
            //this.Controls.Add(urlAddButton);

            //urlInput.Text = "URL입력";
            //urlAddButton.Text = "완료";

            //urlAddButton.Click += UrlAddButton_Click;

        }

        private void UrlAddButton_Click(object sender, EventArgs e)
        {
            //this.uri = new Uri("https://youtu.be/b73BI9eUkjM");
            //this.web.Url = uri; 
            //this.TxtUrl.Text = uri.ToString();
            
        }

        public void RemoveControl()
        {
            //myPcChoiceButton.Dispose();
            //urlInput.Dispose();
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            Agreement_enterprise.Attachments = url;
            this.Close();
        }
    }
}
