namespace GoodeeProject
{
    partial class DetailView
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailView));
            this.butDelete = new iTalk.iTalk_Button_1();
            this.butUpdate = new iTalk.iTalk_Button_1();
            this.boardBoby = new System.Windows.Forms.RichTextBox();
            this.title = new iTalk.iTalk_Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.serchtxt = new iTalk.iTalk_TextBox_Small();
            this.iTalk_Button_11 = new iTalk.iTalk_Button_1();
            this.iTalk_Button_12 = new iTalk.iTalk_Button_1();
            this.serchPic = new System.Windows.Forms.PictureBox();
            this.Strikethrough = new System.Windows.Forms.PictureBox();
            this.FontUnderLine = new System.Windows.Forms.PictureBox();
            this.FontBold = new System.Windows.Forms.PictureBox();
            this.Fontsize = new System.Windows.Forms.ComboBox();
            this.comFontStyle = new System.Windows.Forms.ComboBox();
            this.pictureButton = new System.Windows.Forms.PictureBox();
            this.FontColor = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnComment = new iTalk.iTalk_Button_1();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serchPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Strikethrough)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FontUnderLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FontBold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FontColor)).BeginInit();
            this.SuspendLayout();
            // 
            // butDelete
            // 
            this.butDelete.BackColor = System.Drawing.Color.Transparent;
            this.butDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDelete.Image = null;
            this.butDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butDelete.Location = new System.Drawing.Point(751, 494);
            this.butDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(64, 30);
            this.butDelete.TabIndex = 41;
            this.butDelete.Text = "삭제";
            this.butDelete.TextAlignment = System.Drawing.StringAlignment.Center;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butUpdate
            // 
            this.butUpdate.BackColor = System.Drawing.Color.Transparent;
            this.butUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butUpdate.Image = null;
            this.butUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butUpdate.Location = new System.Drawing.Point(833, 494);
            this.butUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(64, 30);
            this.butUpdate.TabIndex = 40;
            this.butUpdate.Text = "수정";
            this.butUpdate.TextAlignment = System.Drawing.StringAlignment.Center;
            this.butUpdate.Click += new System.EventHandler(this.butUpdate_Click);
            // 
            // boardBoby
            // 
            this.boardBoby.Location = new System.Drawing.Point(24, 130);
            this.boardBoby.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boardBoby.Name = "boardBoby";
            this.boardBoby.Size = new System.Drawing.Size(873, 355);
            this.boardBoby.TabIndex = 39;
            this.boardBoby.Text = "";
            this.boardBoby.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.boardBoby_LinkClicked_1);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.title.Location = new System.Drawing.Point(19, 32);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(38, 20);
            this.title.TabIndex = 38;
            this.title.Text = "제 목";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.serchtxt);
            this.flowLayoutPanel1.Controls.Add(this.iTalk_Button_11);
            this.flowLayoutPanel1.Controls.Add(this.iTalk_Button_12);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(560, 82);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(337, 41);
            this.flowLayoutPanel1.TabIndex = 46;
            this.flowLayoutPanel1.Visible = false;
            // 
            // serchtxt
            // 
            this.serchtxt.BackColor = System.Drawing.Color.Transparent;
            this.serchtxt.Font = new System.Drawing.Font("Tahoma", 11F);
            this.serchtxt.ForeColor = System.Drawing.Color.DimGray;
            this.serchtxt.Location = new System.Drawing.Point(3, 3);
            this.serchtxt.MaxLength = 32767;
            this.serchtxt.Multiline = false;
            this.serchtxt.Name = "serchtxt";
            this.serchtxt.ReadOnly = false;
            this.serchtxt.Size = new System.Drawing.Size(197, 33);
            this.serchtxt.TabIndex = 42;
            this.serchtxt.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.serchtxt.UseSystemPasswordChar = false;
            // 
            // iTalk_Button_11
            // 
            this.iTalk_Button_11.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Button_11.Image = null;
            this.iTalk_Button_11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_11.Location = new System.Drawing.Point(206, 4);
            this.iTalk_Button_11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iTalk_Button_11.Name = "iTalk_Button_11";
            this.iTalk_Button_11.Size = new System.Drawing.Size(47, 32);
            this.iTalk_Button_11.TabIndex = 43;
            this.iTalk_Button_11.Text = "검색";
            this.iTalk_Button_11.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_11.Click += new System.EventHandler(this.iTalk_Button_11_Click);
            // 
            // iTalk_Button_12
            // 
            this.iTalk_Button_12.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Button_12.Image = null;
            this.iTalk_Button_12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_12.Location = new System.Drawing.Point(259, 4);
            this.iTalk_Button_12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iTalk_Button_12.Name = "iTalk_Button_12";
            this.iTalk_Button_12.Size = new System.Drawing.Size(66, 31);
            this.iTalk_Button_12.TabIndex = 44;
            this.iTalk_Button_12.Text = "지우기";
            this.iTalk_Button_12.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_12.Click += new System.EventHandler(this.iTalk_Button_12_Click);
            // 
            // serchPic
            // 
            this.serchPic.Image = ((System.Drawing.Image)(resources.GetObject("serchPic.Image")));
            this.serchPic.Location = new System.Drawing.Point(508, 85);
            this.serchPic.Name = "serchPic";
            this.serchPic.Size = new System.Drawing.Size(46, 32);
            this.serchPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.serchPic.TabIndex = 45;
            this.serchPic.TabStop = false;
            this.serchPic.Click += new System.EventHandler(this.serchPic_Click);
            // 
            // Strikethrough
            // 
            this.Strikethrough.Image = global::GoodeeProject.Properties.Resources.strikethrough;
            this.Strikethrough.Location = new System.Drawing.Point(456, 85);
            this.Strikethrough.Name = "Strikethrough";
            this.Strikethrough.Size = new System.Drawing.Size(46, 32);
            this.Strikethrough.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Strikethrough.TabIndex = 53;
            this.Strikethrough.TabStop = false;
            this.Strikethrough.Click += new System.EventHandler(this.Strikethrough_Click);
            // 
            // FontUnderLine
            // 
            this.FontUnderLine.Image = global::GoodeeProject.Properties.Resources.font;
            this.FontUnderLine.Location = new System.Drawing.Point(400, 85);
            this.FontUnderLine.Name = "FontUnderLine";
            this.FontUnderLine.Size = new System.Drawing.Size(46, 32);
            this.FontUnderLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FontUnderLine.TabIndex = 52;
            this.FontUnderLine.TabStop = false;
            this.FontUnderLine.Click += new System.EventHandler(this.FontUnderLine_Click);
            // 
            // FontBold
            // 
            this.FontBold.Image = global::GoodeeProject.Properties.Resources.bold_text_option;
            this.FontBold.Location = new System.Drawing.Point(348, 85);
            this.FontBold.Name = "FontBold";
            this.FontBold.Size = new System.Drawing.Size(46, 32);
            this.FontBold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FontBold.TabIndex = 51;
            this.FontBold.TabStop = false;
            this.FontBold.Click += new System.EventHandler(this.FontBold_Click);
            // 
            // Fontsize
            // 
            this.Fontsize.FormattingEnabled = true;
            this.Fontsize.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "38",
            "98",
            "72"});
            this.Fontsize.Location = new System.Drawing.Point(276, 91);
            this.Fontsize.Name = "Fontsize";
            this.Fontsize.Size = new System.Drawing.Size(66, 23);
            this.Fontsize.TabIndex = 50;
            this.Fontsize.SelectedIndexChanged += new System.EventHandler(this.Fontsize_SelectedIndexChanged);
            // 
            // comFontStyle
            // 
            this.comFontStyle.FormattingEnabled = true;
            this.comFontStyle.Location = new System.Drawing.Point(131, 91);
            this.comFontStyle.Name = "comFontStyle";
            this.comFontStyle.Size = new System.Drawing.Size(139, 23);
            this.comFontStyle.TabIndex = 49;
            this.comFontStyle.SelectedIndexChanged += new System.EventHandler(this.comFontStyle_SelectedIndexChanged);
            // 
            // pictureButton
            // 
            this.pictureButton.Image = global::GoodeeProject.Properties.Resources.picture;
            this.pictureButton.Location = new System.Drawing.Point(78, 85);
            this.pictureButton.Name = "pictureButton";
            this.pictureButton.Size = new System.Drawing.Size(46, 32);
            this.pictureButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureButton.TabIndex = 48;
            this.pictureButton.TabStop = false;
            this.pictureButton.Click += new System.EventHandler(this.pictureButton_Click);
            // 
            // FontColor
            // 
            this.FontColor.Image = global::GoodeeProject.Properties.Resources.text__2_;
            this.FontColor.Location = new System.Drawing.Point(26, 85);
            this.FontColor.Name = "FontColor";
            this.FontColor.Size = new System.Drawing.Size(46, 32);
            this.FontColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FontColor.TabIndex = 47;
            this.FontColor.TabStop = false;
            this.FontColor.Click += new System.EventHandler(this.FontColor_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnComment
            // 
            this.btnComment.BackColor = System.Drawing.Color.Transparent;
            this.btnComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComment.Image = null;
            this.btnComment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComment.Location = new System.Drawing.Point(24, 503);
            this.btnComment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnComment.Name = "btnComment";
            this.btnComment.Size = new System.Drawing.Size(181, 30);
            this.btnComment.TabIndex = 54;
            this.btnComment.Text = "댓글달기";
            this.btnComment.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnComment.Click += new System.EventHandler(this.btnComment_Click);
            // 
            // DetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnComment);
            this.Controls.Add(this.Strikethrough);
            this.Controls.Add(this.FontUnderLine);
            this.Controls.Add(this.FontBold);
            this.Controls.Add(this.Fontsize);
            this.Controls.Add(this.comFontStyle);
            this.Controls.Add(this.pictureButton);
            this.Controls.Add(this.FontColor);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.serchPic);
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butUpdate);
            this.Controls.Add(this.boardBoby);
            this.Controls.Add(this.title);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DetailView";
            this.Size = new System.Drawing.Size(918, 556);
            this.Load += new System.EventHandler(this.DetailView_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serchPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Strikethrough)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FontUnderLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FontBold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FontColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox boardBoby;
        private iTalk.iTalk_Label title;
        internal iTalk.iTalk_Button_1 butDelete;
        internal iTalk.iTalk_Button_1 butUpdate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private iTalk.iTalk_TextBox_Small serchtxt;
        private iTalk.iTalk_Button_1 iTalk_Button_11;
        private System.Windows.Forms.PictureBox serchPic;
        private System.Windows.Forms.PictureBox Strikethrough;
        private System.Windows.Forms.PictureBox FontUnderLine;
        private System.Windows.Forms.PictureBox FontBold;
        private System.Windows.Forms.ComboBox Fontsize;
        private System.Windows.Forms.ComboBox comFontStyle;
        private System.Windows.Forms.PictureBox pictureButton;
        private System.Windows.Forms.PictureBox FontColor;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private iTalk.iTalk_Button_1 iTalk_Button_12;
        internal iTalk.iTalk_Button_1 btnComment;
    }
}
