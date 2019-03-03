namespace GoodeeProject
{
    partial class UpdateAgreement
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
            this.save = new iTalk.iTalk_Button_1();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.iTalk_Label1 = new iTalk.iTalk_Label();
            this.iTalk_Label2 = new iTalk.iTalk_Label();
            this.iTalk_HeaderLabel1 = new iTalk.iTalk_HeaderLabel();
            this.Strikethrough = new System.Windows.Forms.PictureBox();
            this.FontUnderLine = new System.Windows.Forms.PictureBox();
            this.FontBold = new System.Windows.Forms.PictureBox();
            this.Fontsize = new System.Windows.Forms.ComboBox();
            this.comFontStyle = new System.Windows.Forms.ComboBox();
            this.pictureButton = new System.Windows.Forms.PictureBox();
            this.FontColor = new System.Windows.Forms.PictureBox();
            this.boardBoby = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Strikethrough)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FontUnderLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FontBold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FontColor)).BeginInit();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Transparent;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Image = null;
            this.save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save.Location = new System.Drawing.Point(839, 506);
            this.save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(64, 30);
            this.save.TabIndex = 44;
            this.save.Text = "글 수정";
            this.save.TextAlignment = System.Drawing.StringAlignment.Center;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(133, 63);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(259, 18);
            this.txtTitle.TabIndex = 42;
            // 
            // iTalk_Label1
            // 
            this.iTalk_Label1.AutoSize = true;
            this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label1.Location = new System.Drawing.Point(33, 94);
            this.iTalk_Label1.Name = "iTalk_Label1";
            this.iTalk_Label1.Size = new System.Drawing.Size(65, 19);
            this.iTalk_Label1.TabIndex = 39;
            this.iTalk_Label1.Text = "파일첨부";
            // 
            // iTalk_Label2
            // 
            this.iTalk_Label2.AutoSize = true;
            this.iTalk_Label2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label2.Location = new System.Drawing.Point(33, 64);
            this.iTalk_Label2.Name = "iTalk_Label2";
            this.iTalk_Label2.Size = new System.Drawing.Size(41, 19);
            this.iTalk_Label2.TabIndex = 35;
            this.iTalk_Label2.Text = "제 목";
            // 
            // iTalk_HeaderLabel1
            // 
            this.iTalk_HeaderLabel1.AutoSize = true;
            this.iTalk_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iTalk_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.iTalk_HeaderLabel1.Location = new System.Drawing.Point(25, 20);
            this.iTalk_HeaderLabel1.Name = "iTalk_HeaderLabel1";
            this.iTalk_HeaderLabel1.Size = new System.Drawing.Size(161, 31);
            this.iTalk_HeaderLabel1.TabIndex = 34;
            this.iTalk_HeaderLabel1.Text = "협약기업게시판";
            // 
            // Strikethrough
            // 
            this.Strikethrough.Image = global::GoodeeProject.Properties.Resources.strikethrough;
            this.Strikethrough.Location = new System.Drawing.Point(469, 132);
            this.Strikethrough.Name = "Strikethrough";
            this.Strikethrough.Size = new System.Drawing.Size(46, 32);
            this.Strikethrough.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Strikethrough.TabIndex = 52;
            this.Strikethrough.TabStop = false;
            this.Strikethrough.Click += new System.EventHandler(this.Strikethrough_Click);
            // 
            // FontUnderLine
            // 
            this.FontUnderLine.Image = global::GoodeeProject.Properties.Resources.font;
            this.FontUnderLine.Location = new System.Drawing.Point(413, 132);
            this.FontUnderLine.Name = "FontUnderLine";
            this.FontUnderLine.Size = new System.Drawing.Size(46, 32);
            this.FontUnderLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FontUnderLine.TabIndex = 51;
            this.FontUnderLine.TabStop = false;
            this.FontUnderLine.Click += new System.EventHandler(this.FontUnderLine_Click);
            // 
            // FontBold
            // 
            this.FontBold.Image = global::GoodeeProject.Properties.Resources.bold_text_option;
            this.FontBold.Location = new System.Drawing.Point(361, 132);
            this.FontBold.Name = "FontBold";
            this.FontBold.Size = new System.Drawing.Size(46, 32);
            this.FontBold.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FontBold.TabIndex = 50;
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
            this.Fontsize.Location = new System.Drawing.Point(289, 138);
            this.Fontsize.Name = "Fontsize";
            this.Fontsize.Size = new System.Drawing.Size(66, 23);
            this.Fontsize.TabIndex = 49;
            // 
            // comFontStyle
            // 
            this.comFontStyle.FormattingEnabled = true;
            this.comFontStyle.Location = new System.Drawing.Point(144, 138);
            this.comFontStyle.Name = "comFontStyle";
            this.comFontStyle.Size = new System.Drawing.Size(139, 23);
            this.comFontStyle.TabIndex = 48;
            // 
            // pictureButton
            // 
            this.pictureButton.Image = global::GoodeeProject.Properties.Resources.picture;
            this.pictureButton.Location = new System.Drawing.Point(91, 132);
            this.pictureButton.Name = "pictureButton";
            this.pictureButton.Size = new System.Drawing.Size(46, 32);
            this.pictureButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureButton.TabIndex = 47;
            this.pictureButton.TabStop = false;
            this.pictureButton.Click += new System.EventHandler(this.pictureButton_Click);
            // 
            // FontColor
            // 
            this.FontColor.Image = global::GoodeeProject.Properties.Resources.text__2_;
            this.FontColor.Location = new System.Drawing.Point(39, 132);
            this.FontColor.Name = "FontColor";
            this.FontColor.Size = new System.Drawing.Size(46, 32);
            this.FontColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FontColor.TabIndex = 46;
            this.FontColor.TabStop = false;
            this.FontColor.Click += new System.EventHandler(this.FontColor_Click);
            // 
            // boardBoby
            // 
            this.boardBoby.Location = new System.Drawing.Point(30, 171);
            this.boardBoby.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boardBoby.Name = "boardBoby";
            this.boardBoby.Size = new System.Drawing.Size(873, 302);
            this.boardBoby.TabIndex = 45;
            this.boardBoby.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UpdateAgreement
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
            this.Controls.Add(this.save);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.iTalk_Label1);
            this.Controls.Add(this.iTalk_Label2);
            this.Controls.Add(this.iTalk_HeaderLabel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UpdateAgreement";
            this.Size = new System.Drawing.Size(918, 556);
            this.Load += new System.EventHandler(this.UpdateAgreement_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.Strikethrough)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FontUnderLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FontBold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FontColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private iTalk.iTalk_Button_1 save;
        private System.Windows.Forms.TextBox txtTitle;
        private iTalk.iTalk_Label iTalk_Label1;
        private iTalk.iTalk_Label iTalk_Label2;
        private iTalk.iTalk_HeaderLabel iTalk_HeaderLabel1;
        private System.Windows.Forms.PictureBox Strikethrough;
        private System.Windows.Forms.PictureBox FontUnderLine;
        private System.Windows.Forms.PictureBox FontBold;
        private System.Windows.Forms.ComboBox Fontsize;
        private System.Windows.Forms.ComboBox comFontStyle;
        private System.Windows.Forms.PictureBox pictureButton;
        private System.Windows.Forms.PictureBox FontColor;
        private System.Windows.Forms.RichTextBox boardBoby;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
