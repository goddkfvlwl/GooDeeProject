namespace GoodeeProject
{
    partial class KREDIT_JOB
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.JobSearch = new System.Windows.Forms.RichTextBox();
            this.iTalk_HeaderLabel1 = new iTalk.iTalk_HeaderLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GoodeeProject.Properties.Resources.company1;
            this.pictureBox1.Location = new System.Drawing.Point(15, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // JobSearch
            // 
            this.JobSearch.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.JobSearch.Location = new System.Drawing.Point(180, 174);
            this.JobSearch.Name = "JobSearch";
            this.JobSearch.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.JobSearch.Size = new System.Drawing.Size(437, 42);
            this.JobSearch.TabIndex = 2;
            this.JobSearch.Text = "기업을 검색해보세요";
            this.JobSearch.Click += new System.EventHandler(this.JobSearch_Click);
            this.JobSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.JobSearch_KeyDown);
            this.JobSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JobSearch_KeyPress);
            // 
            // iTalk_HeaderLabel1
            // 
            this.iTalk_HeaderLabel1.AutoSize = true;
            this.iTalk_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iTalk_HeaderLabel1.ForeColor = System.Drawing.Color.Peru;
            this.iTalk_HeaderLabel1.Location = new System.Drawing.Point(173, 107);
            this.iTalk_HeaderLabel1.Name = "iTalk_HeaderLabel1";
            this.iTalk_HeaderLabel1.Size = new System.Drawing.Size(442, 28);
            this.iTalk_HeaderLabel1.TabIndex = 0;
            this.iTalk_HeaderLabel1.Text = "이력서 쓰기 전에, 면접 가기 전에";
            // 
            // KREDIT_JOB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.JobSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.iTalk_HeaderLabel1);
            this.Name = "KREDIT_JOB";
            this.Size = new System.Drawing.Size(803, 445);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private iTalk.iTalk_HeaderLabel iTalk_HeaderLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox JobSearch;
    }
}
