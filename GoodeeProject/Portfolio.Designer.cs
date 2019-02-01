﻿namespace GoodeeProject
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
            this.btnSaveToPDF = new iTalk.iTalk_Button_1();
            this.btnSave = new iTalk.iTalk_Button_1();
            this.portfolioDetail1 = new GoodeeProject.PortfolioDetail();
            this.SuspendLayout();
            // 
            // btnSaveToPDF
            // 
            this.btnSaveToPDF.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveToPDF.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSaveToPDF.Image = null;
            this.btnSaveToPDF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveToPDF.Location = new System.Drawing.Point(172, 0);
            this.btnSaveToPDF.Name = "btnSaveToPDF";
            this.btnSaveToPDF.Size = new System.Drawing.Size(166, 40);
            this.btnSaveToPDF.TabIndex = 2;
            this.btnSaveToPDF.Text = "PDF저장";
            this.btnSaveToPDF.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSave.Image = null;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(166, 40);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "저장";
            this.btnSave.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.iTalk_Button_11_Click);
            // 
            // portfolioDetail1
            // 
            this.portfolioDetail1.AutoScroll = true;
            this.portfolioDetail1.Location = new System.Drawing.Point(0, 46);
            this.portfolioDetail1.Name = "portfolioDetail1";
            this.portfolioDetail1.Size = new System.Drawing.Size(815, 400);
            this.portfolioDetail1.TabIndex = 0;
            // 
            // Portfolio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.Controls.Add(this.btnSaveToPDF);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.portfolioDetail1);
            this.Name = "Portfolio";
            this.Size = new System.Drawing.Size(815, 454);
            this.Load += new System.EventHandler(this.Portfolio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PortfolioDetail portfolioDetail1;
        private iTalk.iTalk_Button_1 btnSave;
        private iTalk.iTalk_Button_1 btnSaveToPDF;
    }
}