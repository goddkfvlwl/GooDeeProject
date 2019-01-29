namespace GoodeeProject
{
    partial class Portfolio
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
            this.portfolioDetail1 = new GoodeeProject.PortfolioDetail();
            this.SuspendLayout();
            // 
            // portfolioDetail1
            // 
            this.portfolioDetail1.AutoSize = true;
            this.portfolioDetail1.Location = new System.Drawing.Point(0, 0);
            this.portfolioDetail1.Name = "portfolioDetail1";
            this.portfolioDetail1.Size = new System.Drawing.Size(798, 1500);
            this.portfolioDetail1.TabIndex = 0;
            this.portfolioDetail1.TabStop = false;
            // 
            // Portfolio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.portfolioDetail1);
            this.MinimumSize = new System.Drawing.Size(126, 39);
            this.Name = "Portfolio";
            this.Size = new System.Drawing.Size(815, 454);
            this.Load += new System.EventHandler(this.Portfolio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PortfolioDetail portfolioDetail1;
    }
}
