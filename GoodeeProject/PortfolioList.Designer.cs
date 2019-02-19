namespace GoodeeProject
{
    partial class PortfolioList
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddPortfolio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(677, 161);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 33);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "뒤로가기";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddPortfolio
            // 
            this.btnAddPortfolio.Location = new System.Drawing.Point(677, 58);
            this.btnAddPortfolio.Name = "btnAddPortfolio";
            this.btnAddPortfolio.Size = new System.Drawing.Size(123, 33);
            this.btnAddPortfolio.TabIndex = 2;
            this.btnAddPortfolio.Text = "추가";
            this.btnAddPortfolio.UseVisualStyleBackColor = true;
            this.btnAddPortfolio.Click += new System.EventHandler(this.btnAddPortfolio_Click);
            // 
            // PortfolioList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAddPortfolio);
            this.Controls.Add(this.btnBack);
            this.Name = "PortfolioList";
            this.Size = new System.Drawing.Size(815, 454);
            this.Load += new System.EventHandler(this.PortfolioList_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddPortfolio;
    }
}
