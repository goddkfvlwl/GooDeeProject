namespace GoodeeProject
{
    partial class JobChoice
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
            this.firstJobName = new System.Windows.Forms.ListBox();
            this.iTalk_RichTextBox1 = new iTalk.iTalk_RichTextBox();
            this.secondJobName = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // firstJobName
            // 
            this.firstJobName.FormattingEnabled = true;
            this.firstJobName.ItemHeight = 12;
            this.firstJobName.Location = new System.Drawing.Point(20, 67);
            this.firstJobName.Name = "firstJobName";
            this.firstJobName.Size = new System.Drawing.Size(127, 220);
            this.firstJobName.TabIndex = 0;
            this.firstJobName.SelectedIndexChanged += new System.EventHandler(this.firstJobName_SelectedIndexChanged);
            // 
            // iTalk_RichTextBox1
            // 
            this.iTalk_RichTextBox1.AutoWordSelection = false;
            this.iTalk_RichTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_RichTextBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.iTalk_RichTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.iTalk_RichTextBox1.Location = new System.Drawing.Point(16, 18);
            this.iTalk_RichTextBox1.Name = "iTalk_RichTextBox1";
            this.iTalk_RichTextBox1.ReadOnly = false;
            this.iTalk_RichTextBox1.Size = new System.Drawing.Size(696, 32);
            this.iTalk_RichTextBox1.TabIndex = 2;
            this.iTalk_RichTextBox1.Text = "직업(직종)명 입력";
            this.iTalk_RichTextBox1.WordWrap = true;
            // 
            // secondJobName
            // 
            this.secondJobName.FormattingEnabled = true;
            this.secondJobName.ItemHeight = 12;
            this.secondJobName.Location = new System.Drawing.Point(155, 67);
            this.secondJobName.Name = "secondJobName";
            this.secondJobName.Size = new System.Drawing.Size(150, 220);
            this.secondJobName.TabIndex = 3;
            this.secondJobName.SelectedIndexChanged += new System.EventHandler(this.secondJobName_SelectedIndexChanged);
            // 
            // JobChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.secondJobName);
            this.Controls.Add(this.iTalk_RichTextBox1);
            this.Controls.Add(this.firstJobName);
            this.Name = "JobChoice";
            this.Size = new System.Drawing.Size(725, 327);
            this.Load += new System.EventHandler(this.AreaChoice_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox firstJobName;
        private iTalk.iTalk_RichTextBox iTalk_RichTextBox1;
        private System.Windows.Forms.ListBox secondJobName;
    }
}
