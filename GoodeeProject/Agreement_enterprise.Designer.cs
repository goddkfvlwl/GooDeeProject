namespace GoodeeProject
{
    partial class Agreement_enterprise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agreement_enterprise));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Fontsize = new System.Windows.Forms.ComboBox();
            this.comFontStyle = new System.Windows.Forms.ComboBox();
            this.find = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Strikethrough = new System.Windows.Forms.PictureBox();
            this.FontUnderLine = new System.Windows.Forms.PictureBox();
            this.FontBold = new System.Windows.Forms.PictureBox();
            this.pictureButton = new System.Windows.Forms.PictureBox();
            this.FontColor = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.serchtxt = new iTalk.iTalk_TextBox_Small();
            this.iTalk_Button_11 = new iTalk.iTalk_Button_1();
            this.iTalk_Button_12 = new iTalk.iTalk_Button_1();
            this.serchPic = new System.Windows.Forms.PictureBox();
            this.iTalk_HeaderLabel1 = new iTalk.iTalk_HeaderLabel();
            this.save = new iTalk.iTalk_Button_1();
            this.Title = new iTalk.iTalk_TextBox_Small();
            this.iTalk_Label2 = new iTalk.iTalk_Label();
            ((System.ComponentModel.ISupportInitialize)(this.Strikethrough)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FontUnderLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FontBold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FontColor)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serchPic)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.Fontsize.Location = new System.Drawing.Point(285, 150);
            this.Fontsize.Name = "Fontsize";
            this.Fontsize.Size = new System.Drawing.Size(66, 23);
            this.Fontsize.TabIndex = 37;
            this.Fontsize.SelectedIndexChanged += new System.EventHandler(this.Fontsize_SelectedIndexChanged);
            this.Fontsize.TextChanged += new System.EventHandler(this.Fontsize_TextChanged);
            // 
            // comFontStyle
            // 
            this.comFontStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comFontStyle.FormattingEnabled = true;
            this.comFontStyle.Location = new System.Drawing.Point(140, 150);
            this.comFontStyle.Name = "comFontStyle";
            this.comFontStyle.Size = new System.Drawing.Size(139, 23);
            this.comFontStyle.TabIndex = 36;
            this.comFontStyle.SelectedIndexChanged += new System.EventHandler(this.comFontStyle_SelectedIndexChanged);
            // 
            // find
            // 
            this.find.Location = new System.Drawing.Point(29, 193);
            this.find.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(868, 311);
            this.find.TabIndex = 33;
            this.find.Text = "";
            // 
            // Strikethrough
            // 
            this.Strikethrough.Image = global::GoodeeProject.Properties.Resources.strikethrough;
            this.Strikethrough.Location = new System.Drawing.Point(465, 144);
            this.Strikethrough.Name = "Strikethrough";
            this.Strikethrough.Size = new System.Drawing.Size(46, 32);
            this.Strikethrough.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Strikethrough.TabIndex = 40;
            this.Strikethrough.TabStop = false;
            this.Strikethrough.Click += new System.EventHandler(this.Strikethrough_Click);
            // 
            // FontUnderLine
            // 
            this.FontUnderLine.Image = global::GoodeeProject.Properties.Resources.font;
            this.FontUnderLine.Location = new System.Drawing.Point(409, 144);
            this.FontUnderLine.Name = "FontUnderLine";
            this.FontUnderLine.Size = new System.Drawing.Size(46, 32);
            this.FontUnderLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FontUnderLine.TabIndex = 39;
            this.FontUnderLine.TabStop = false;
            this.FontUnderLine.Click += new System.EventHandler(this.FontUnderLine_Click);
            // 
            // FontBold
            // 
            this.FontBold.Image = global::GoodeeProject.Properties.Resources.bold_text_option;
            this.FontBold.Location = new System.Drawing.Point(357, 144);
            this.FontBold.Name = "FontBold";
            this.FontBold.Size = new System.Drawing.Size(46, 32);
            this.FontBold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FontBold.TabIndex = 38;
            this.FontBold.TabStop = false;
            this.FontBold.Click += new System.EventHandler(this.FontBold_Click);
            // 
            // pictureButton
            // 
            this.pictureButton.Image = global::GoodeeProject.Properties.Resources.picture;
            this.pictureButton.Location = new System.Drawing.Point(87, 144);
            this.pictureButton.Name = "pictureButton";
            this.pictureButton.Size = new System.Drawing.Size(46, 32);
            this.pictureButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureButton.TabIndex = 35;
            this.pictureButton.TabStop = false;
            this.pictureButton.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // FontColor
            // 
            this.FontColor.Image = global::GoodeeProject.Properties.Resources.text__2_;
            this.FontColor.Location = new System.Drawing.Point(35, 144);
            this.FontColor.Name = "FontColor";
            this.FontColor.Size = new System.Drawing.Size(46, 32);
            this.FontColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FontColor.TabIndex = 34;
            this.FontColor.TabStop = false;
            this.FontColor.Click += new System.EventHandler(this.FontColor_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.serchtxt);
            this.flowLayoutPanel1.Controls.Add(this.iTalk_Button_11);
            this.flowLayoutPanel1.Controls.Add(this.iTalk_Button_12);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(570, 144);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(327, 41);
            this.flowLayoutPanel1.TabIndex = 48;
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
            this.serchtxt.Size = new System.Drawing.Size(180, 33);
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
            this.iTalk_Button_11.Location = new System.Drawing.Point(189, 4);
            this.iTalk_Button_11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iTalk_Button_11.Name = "iTalk_Button_11";
            this.iTalk_Button_11.Size = new System.Drawing.Size(44, 30);
            this.iTalk_Button_11.TabIndex = 43;
            this.iTalk_Button_11.Text = "검색";
            this.iTalk_Button_11.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_11.Click += new System.EventHandler(this.iTalk_Button_11_Click_1);
            // 
            // iTalk_Button_12
            // 
            this.iTalk_Button_12.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Button_12.Image = null;
            this.iTalk_Button_12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_12.Location = new System.Drawing.Point(239, 4);
            this.iTalk_Button_12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iTalk_Button_12.Name = "iTalk_Button_12";
            this.iTalk_Button_12.Size = new System.Drawing.Size(74, 31);
            this.iTalk_Button_12.TabIndex = 45;
            this.iTalk_Button_12.Text = "지우기";
            this.iTalk_Button_12.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_12.Click += new System.EventHandler(this.iTalk_Button_12_Click);
            // 
            // serchPic
            // 
            this.serchPic.Image = ((System.Drawing.Image)(resources.GetObject("serchPic.Image")));
            this.serchPic.Location = new System.Drawing.Point(518, 147);
            this.serchPic.Name = "serchPic";
            this.serchPic.Size = new System.Drawing.Size(46, 32);
            this.serchPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.serchPic.TabIndex = 47;
            this.serchPic.TabStop = false;
            this.serchPic.Click += new System.EventHandler(this.serchPic_Click);
            // 
            // iTalk_HeaderLabel1
            // 
            this.iTalk_HeaderLabel1.AutoSize = true;
            this.iTalk_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iTalk_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.iTalk_HeaderLabel1.Location = new System.Drawing.Point(18, 15);
            this.iTalk_HeaderLabel1.Name = "iTalk_HeaderLabel1";
            this.iTalk_HeaderLabel1.Size = new System.Drawing.Size(161, 31);
            this.iTalk_HeaderLabel1.TabIndex = 18;
            this.iTalk_HeaderLabel1.Text = "협약기업게시판";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Transparent;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Image = null;
            this.save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save.Location = new System.Drawing.Point(834, 512);
            this.save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(64, 30);
            this.save.TabIndex = 9;
            this.save.Text = "글 저장";
            this.save.TextAlignment = System.Drawing.StringAlignment.Center;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Title.ForeColor = System.Drawing.Color.DimGray;
            this.Title.Location = new System.Drawing.Point(87, 75);
            this.Title.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Title.MaxLength = 32767;
            this.Title.Multiline = false;
            this.Title.Name = "Title";
            this.Title.ReadOnly = false;
            this.Title.Size = new System.Drawing.Size(200, 33);
            this.Title.TabIndex = 3;
            this.Title.Text = "게시글 제목을 입력하세요";
            this.Title.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.Title.UseSystemPasswordChar = false;
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // iTalk_Label2
            // 
            this.iTalk_Label2.AutoSize = true;
            this.iTalk_Label2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label2.Location = new System.Drawing.Point(25, 89);
            this.iTalk_Label2.Name = "iTalk_Label2";
            this.iTalk_Label2.Size = new System.Drawing.Size(41, 19);
            this.iTalk_Label2.TabIndex = 1;
            this.iTalk_Label2.Text = "제 목";
            // 
            // Agreement_enterprise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.serchPic);
            this.Controls.Add(this.Strikethrough);
            this.Controls.Add(this.FontUnderLine);
            this.Controls.Add(this.FontBold);
            this.Controls.Add(this.Fontsize);
            this.Controls.Add(this.comFontStyle);
            this.Controls.Add(this.pictureButton);
            this.Controls.Add(this.FontColor);
            this.Controls.Add(this.find);
            this.Controls.Add(this.iTalk_HeaderLabel1);
            this.Controls.Add(this.save);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.iTalk_Label2);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Agreement_enterprise";
            this.Size = new System.Drawing.Size(918, 556);
            this.Load += new System.EventHandler(this.Agreement_enterprise_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Strikethrough)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FontUnderLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FontBold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FontColor)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serchPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private iTalk.iTalk_Label iTalk_Label2;
        private iTalk.iTalk_TextBox_Small Title;
        private iTalk.iTalk_Button_1 save;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private iTalk.iTalk_HeaderLabel iTalk_HeaderLabel1;
        private System.Windows.Forms.ComboBox Fontsize;
        private System.Windows.Forms.ComboBox comFontStyle;
        private System.Windows.Forms.PictureBox pictureButton;
        private System.Windows.Forms.PictureBox FontColor;
        private System.Windows.Forms.RichTextBox find;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox FontBold;
        private System.Windows.Forms.PictureBox FontUnderLine;
        private System.Windows.Forms.PictureBox Strikethrough;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private iTalk.iTalk_TextBox_Small serchtxt;
        private iTalk.iTalk_Button_1 iTalk_Button_11;
        private System.Windows.Forms.PictureBox serchPic;
        private iTalk.iTalk_Button_1 iTalk_Button_12;
    }
}
