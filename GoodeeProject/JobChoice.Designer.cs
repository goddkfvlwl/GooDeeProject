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
            this.secondJobName = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // firstJobName
            // 
            this.firstJobName.FormattingEnabled = true;
            this.firstJobName.ItemHeight = 15;
            this.firstJobName.Location = new System.Drawing.Point(23, 84);
            this.firstJobName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.firstJobName.Name = "firstJobName";
            this.firstJobName.Size = new System.Drawing.Size(145, 274);
            this.firstJobName.TabIndex = 0;
            this.firstJobName.SelectedIndexChanged += new System.EventHandler(this.firstJobName_SelectedIndexChanged);
            // 
            // secondJobName
            // 
            this.secondJobName.FormattingEnabled = true;
            this.secondJobName.ItemHeight = 15;
            this.secondJobName.Location = new System.Drawing.Point(177, 84);
            this.secondJobName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.secondJobName.Name = "secondJobName";
            this.secondJobName.Size = new System.Drawing.Size(171, 274);
            this.secondJobName.TabIndex = 3;
            this.secondJobName.SelectedIndexChanged += new System.EventHandler(this.secondJobName_SelectedIndexChanged);
            // 
            // JobChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.secondJobName);
            this.Controls.Add(this.firstJobName);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "JobChoice";
            this.Size = new System.Drawing.Size(829, 409);
            this.Load += new System.EventHandler(this.AreaChoice_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox firstJobName;
        private System.Windows.Forms.ListBox secondJobName;
    }
}
