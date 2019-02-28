namespace GoodeeProject
{
    partial class KREDITPanel
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
            this.companyName = new System.Windows.Forms.Label();
            this.companyArea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // companyName
            // 
            this.companyName.AutoSize = true;
            this.companyName.Location = new System.Drawing.Point(94, 30);
            this.companyName.Name = "companyName";
            this.companyName.Size = new System.Drawing.Size(53, 12);
            this.companyName.TabIndex = 0;
            this.companyName.Text = "회사이름";
            // 
            // companyArea
            // 
            this.companyArea.AutoSize = true;
            this.companyArea.Location = new System.Drawing.Point(406, 30);
            this.companyArea.Name = "companyArea";
            this.companyArea.Size = new System.Drawing.Size(29, 12);
            this.companyArea.TabIndex = 1;
            this.companyArea.Text = "지역";
            // 
            // KREDITPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.companyArea);
            this.Controls.Add(this.companyName);
            this.Name = "KREDITPanel";
            this.Size = new System.Drawing.Size(607, 79);
            this.Load += new System.EventHandler(this.KREDITPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label companyName;
        private System.Windows.Forms.Label companyArea;
    }
}
