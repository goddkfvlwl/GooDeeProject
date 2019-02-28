namespace GoodeeProject
{
    partial class oneJobMatResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oneJobMatResult));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.keyword = new System.Windows.Forms.Label();
            this.companyName1 = new System.Windows.Forms.Label();
            this.companyIntroduce = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.companyName = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // keyword
            // 
            this.keyword.AutoSize = true;
            this.keyword.Location = new System.Drawing.Point(11, 108);
            this.keyword.Name = "keyword";
            this.keyword.Size = new System.Drawing.Size(38, 12);
            this.keyword.TabIndex = 14;
            this.keyword.Text = "label3";
            // 
            // companyName1
            // 
            this.companyName1.AutoSize = true;
            this.companyName1.Location = new System.Drawing.Point(56, 20);
            this.companyName1.Name = "companyName1";
            this.companyName1.Size = new System.Drawing.Size(38, 12);
            this.companyName1.TabIndex = 13;
            this.companyName1.Text = "label1";
            // 
            // companyIntroduce
            // 
            this.companyIntroduce.AutoSize = true;
            this.companyIntroduce.Location = new System.Drawing.Point(11, 83);
            this.companyIntroduce.Name = "companyIntroduce";
            this.companyIntroduce.Size = new System.Drawing.Size(38, 12);
            this.companyIntroduce.TabIndex = 12;
            this.companyIntroduce.Text = "label3";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(11, 57);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(53, 12);
            this.title.TabIndex = 11;
            this.title.Text = "채용공고";
            // 
            // companyName
            // 
            this.companyName.AutoSize = true;
            this.companyName.Location = new System.Drawing.Point(761, 20);
            this.companyName.Name = "companyName";
            this.companyName.Size = new System.Drawing.Size(0, 12);
            this.companyName.TabIndex = 16;
            // 
            // oneJobMatResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.companyName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.keyword);
            this.Controls.Add(this.companyName1);
            this.Controls.Add(this.companyIntroduce);
            this.Controls.Add(this.title);
            this.Name = "oneJobMatResult";
            this.Size = new System.Drawing.Size(781, 128);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label keyword;
        public System.Windows.Forms.Label companyName1;
        public System.Windows.Forms.Label companyIntroduce;
        public System.Windows.Forms.Label title;
        public System.Windows.Forms.LinkLabel companyName;
    }
}
