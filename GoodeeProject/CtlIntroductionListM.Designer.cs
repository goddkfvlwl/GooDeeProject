namespace GoodeeProject
{
    partial class CtlIntroductionListM
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
            this.flpIntroductionList = new System.Windows.Forms.FlowLayoutPanel();
            this.flpSList = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flpIntroductionList
            // 
            this.flpIntroductionList.BackColor = System.Drawing.Color.White;
            this.flpIntroductionList.Location = new System.Drawing.Point(285, 79);
            this.flpIntroductionList.Name = "flpIntroductionList";
            this.flpIntroductionList.Size = new System.Drawing.Size(510, 360);
            this.flpIntroductionList.TabIndex = 19;
            // 
            // flpSList
            // 
            this.flpSList.AutoScroll = true;
            this.flpSList.BackColor = System.Drawing.Color.White;
            this.flpSList.Location = new System.Drawing.Point(20, 80);
            this.flpSList.Margin = new System.Windows.Forms.Padding(1);
            this.flpSList.Name = "flpSList";
            this.flpSList.Size = new System.Drawing.Size(240, 360);
            this.flpSList.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "자기소개서 리스트";
            // 
            // CtlIntroductionListM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpSList);
            this.Controls.Add(this.flpIntroductionList);
            this.Name = "CtlIntroductionListM";
            this.Size = new System.Drawing.Size(815, 454);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpIntroductionList;
        private System.Windows.Forms.FlowLayoutPanel flpSList;
        private System.Windows.Forms.Label label1;
    }
}
