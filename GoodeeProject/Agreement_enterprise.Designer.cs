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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Fontsize = new System.Windows.Forms.ComboBox();
            this.comFontStyle = new System.Windows.Forms.ComboBox();
            this.boardBoby = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.attachments = new iTalk.iTalk_ComboBox();
            this.iTalk_Label3 = new iTalk.iTalk_Label();
            this.iTalk_Button_13 = new iTalk.iTalk_Button_1();
            this.iTalk_Label1 = new iTalk.iTalk_Label();
            this.iTalk_HeaderLabel1 = new iTalk.iTalk_HeaderLabel();
            this.save = new iTalk.iTalk_Button_1();
            this.Title = new iTalk.iTalk_TextBox_Small();
            this.iTalk_Label2 = new iTalk.iTalk_Label();
            this.Strikethrough = new System.Windows.Forms.PictureBox();
            this.FontUnderLine = new System.Windows.Forms.PictureBox();
            this.FontBold = new System.Windows.Forms.PictureBox();
            this.pictureButton = new System.Windows.Forms.PictureBox();
            this.FontColor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Strikethrough)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FontUnderLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FontBold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FontColor)).BeginInit();
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
            this.Fontsize.Location = new System.Drawing.Point(288, 129);
            this.Fontsize.Name = "Fontsize";
            this.Fontsize.Size = new System.Drawing.Size(66, 23);
            this.Fontsize.TabIndex = 37;
            this.Fontsize.SelectedIndexChanged += new System.EventHandler(this.Fontsize_SelectedIndexChanged);
            this.Fontsize.TextChanged += new System.EventHandler(this.Fontsize_TextChanged);
            // 
            // comFontStyle
            // 
            this.comFontStyle.FormattingEnabled = true;
            this.comFontStyle.Location = new System.Drawing.Point(143, 129);
            this.comFontStyle.Name = "comFontStyle";
            this.comFontStyle.Size = new System.Drawing.Size(139, 23);
            this.comFontStyle.TabIndex = 36;
            this.comFontStyle.SelectedIndexChanged += new System.EventHandler(this.comFontStyle_SelectedIndexChanged);
            // 
            // boardBoby
            // 
            this.boardBoby.Location = new System.Drawing.Point(29, 162);
            this.boardBoby.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boardBoby.Name = "boardBoby";
            this.boardBoby.Size = new System.Drawing.Size(873, 302);
            this.boardBoby.TabIndex = 33;
            this.boardBoby.Text = "";
            // 
            // attachments
            // 
            this.attachments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.attachments.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.attachments.DropDownHeight = 100;
            this.attachments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.attachments.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.attachments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.attachments.FormattingEnabled = true;
            this.attachments.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.attachments.IntegralHeight = false;
            this.attachments.ItemHeight = 20;
            this.attachments.Location = new System.Drawing.Point(90, 472);
            this.attachments.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.attachments.Name = "attachments";
            this.attachments.Size = new System.Drawing.Size(807, 26);
            this.attachments.StartIndex = 0;
            this.attachments.TabIndex = 27;
            // 
            // iTalk_Label3
            // 
            this.iTalk_Label3.AutoSize = true;
            this.iTalk_Label3.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label3.Location = new System.Drawing.Point(25, 480);
            this.iTalk_Label3.Name = "iTalk_Label3";
            this.iTalk_Label3.Size = new System.Drawing.Size(65, 19);
            this.iTalk_Label3.TabIndex = 24;
            this.iTalk_Label3.Text = "첨부파일";
            // 
            // iTalk_Button_13
            // 
            this.iTalk_Button_13.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Button_13.Image = null;
            this.iTalk_Button_13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_13.Location = new System.Drawing.Point(368, 75);
            this.iTalk_Button_13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iTalk_Button_13.Name = "iTalk_Button_13";
            this.iTalk_Button_13.Size = new System.Drawing.Size(64, 30);
            this.iTalk_Button_13.TabIndex = 22;
            this.iTalk_Button_13.Text = "파일";
            this.iTalk_Button_13.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // iTalk_Label1
            // 
            this.iTalk_Label1.AutoSize = true;
            this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label1.Location = new System.Drawing.Point(482, 69);
            this.iTalk_Label1.Name = "iTalk_Label1";
            this.iTalk_Label1.Size = new System.Drawing.Size(65, 19);
            this.iTalk_Label1.TabIndex = 19;
            this.iTalk_Label1.Text = "파일첨부";
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
            this.Title.Location = new System.Drawing.Point(101, 69);
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
            this.iTalk_Label2.Location = new System.Drawing.Point(25, 75);
            this.iTalk_Label2.Name = "iTalk_Label2";
            this.iTalk_Label2.Size = new System.Drawing.Size(41, 19);
            this.iTalk_Label2.TabIndex = 1;
            this.iTalk_Label2.Text = "제 목";
            // 
            // Strikethrough
            // 
            this.Strikethrough.Image = global::GoodeeProject.Properties.Resources.strikethrough;
            this.Strikethrough.Location = new System.Drawing.Point(468, 123);
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
            this.FontUnderLine.Location = new System.Drawing.Point(412, 123);
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
            this.FontBold.Location = new System.Drawing.Point(360, 123);
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
            this.pictureButton.Location = new System.Drawing.Point(90, 123);
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
            this.FontColor.Location = new System.Drawing.Point(38, 123);
            this.FontColor.Name = "FontColor";
            this.FontColor.Size = new System.Drawing.Size(46, 32);
            this.FontColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FontColor.TabIndex = 34;
            this.FontColor.TabStop = false;
            this.FontColor.Click += new System.EventHandler(this.FontColor_Click);
            // 
            // Agreement_enterprise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Strikethrough);
            this.Controls.Add(this.FontUnderLine);
            this.Controls.Add(this.FontBold);
            this.Controls.Add(this.Fontsize);
            this.Controls.Add(this.comFontStyle);
            this.Controls.Add(this.pictureButton);
            this.Controls.Add(this.FontColor);
            this.Controls.Add(this.boardBoby);
            this.Controls.Add(this.attachments);
            this.Controls.Add(this.iTalk_Label3);
            this.Controls.Add(this.iTalk_Button_13);
            this.Controls.Add(this.iTalk_Label1);
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
        private iTalk.iTalk_Label iTalk_Label1;
        private iTalk.iTalk_Button_1 iTalk_Button_13;
        private iTalk.iTalk_Label iTalk_Label3;
        private iTalk.iTalk_ComboBox attachments;
        private System.Windows.Forms.ComboBox Fontsize;
        private System.Windows.Forms.ComboBox comFontStyle;
        private System.Windows.Forms.PictureBox pictureButton;
        private System.Windows.Forms.PictureBox FontColor;
        private System.Windows.Forms.RichTextBox boardBoby;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox FontBold;
        private System.Windows.Forms.PictureBox FontUnderLine;
        private System.Windows.Forms.PictureBox Strikethrough;
    }
}
