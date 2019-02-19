namespace GoodeeProject
{
    partial class JobInformation
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
            this.iTalk_Button_13 = new iTalk.iTalk_Button_1();
            this.iTalk_Label1 = new iTalk.iTalk_Label();
            this.iTalk_Button_11 = new iTalk.iTalk_Button_1();
            this.jobSearch = new iTalk.iTalk_RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // iTalk_Button_13
            // 
            this.iTalk_Button_13.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_13.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.iTalk_Button_13.Image = null;
            this.iTalk_Button_13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_13.Location = new System.Drawing.Point(473, 42);
            this.iTalk_Button_13.Name = "iTalk_Button_13";
            this.iTalk_Button_13.Size = new System.Drawing.Size(211, 42);
            this.iTalk_Button_13.TabIndex = 6;
            this.iTalk_Button_13.Text = "직업선택";
            this.iTalk_Button_13.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_13.Click += new System.EventHandler(this.iTalk_Button_13_Click);
            // 
            // iTalk_Label1
            // 
            this.iTalk_Label1.AutoSize = true;
            this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label1.Font = new System.Drawing.Font("함초롬돋움", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.iTalk_Label1.Location = new System.Drawing.Point(18, 16);
            this.iTalk_Label1.Name = "iTalk_Label1";
            this.iTalk_Label1.Size = new System.Drawing.Size(200, 17);
            this.iTalk_Label1.TabIndex = 4;
            this.iTalk_Label1.Text = "어떤 채용 정보를 찾고 싶으세요?";
            // 
            // iTalk_Button_11
            // 
            this.iTalk_Button_11.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.iTalk_Button_11.Image = null;
            this.iTalk_Button_11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_11.Location = new System.Drawing.Point(252, 42);
            this.iTalk_Button_11.Name = "iTalk_Button_11";
            this.iTalk_Button_11.Size = new System.Drawing.Size(211, 42);
            this.iTalk_Button_11.TabIndex = 3;
            this.iTalk_Button_11.Text = "지역선택";
            this.iTalk_Button_11.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_11.Click += new System.EventHandler(this.iTalk_Button_11_Click);
            // 
            // jobSearch
            // 
            this.jobSearch.AutoWordSelection = false;
            this.jobSearch.BackColor = System.Drawing.Color.Transparent;
            this.jobSearch.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobSearch.ForeColor = System.Drawing.Color.DimGray;
            this.jobSearch.Location = new System.Drawing.Point(43, 42);
            this.jobSearch.Name = "jobSearch";
            this.jobSearch.ReadOnly = false;
            this.jobSearch.Size = new System.Drawing.Size(199, 42);
            this.jobSearch.TabIndex = 0;
            this.jobSearch.Text = "검색어 입력";
            this.jobSearch.WordWrap = true;
            this.jobSearch.Click += new System.EventHandler(this.jobSearch_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GoodeeProject.Properties.Resources.loupe;
            this.pictureBox1.Location = new System.Drawing.Point(698, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // JobInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.iTalk_Button_13);
            this.Controls.Add(this.iTalk_Label1);
            this.Controls.Add(this.iTalk_Button_11);
            this.Controls.Add(this.jobSearch);
            this.Name = "JobInformation";
            this.Size = new System.Drawing.Size(815, 454);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private iTalk.iTalk_Button_1 iTalk_Button_11;
        private iTalk.iTalk_RichTextBox jobSearch;
        private iTalk.iTalk_Label iTalk_Label1;
        private iTalk.iTalk_Button_1 iTalk_Button_13;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
