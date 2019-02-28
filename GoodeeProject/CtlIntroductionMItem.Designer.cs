namespace GoodeeProject
{
    partial class CtlIntroductionMItem
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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_Body = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_Title.Location = new System.Drawing.Point(15, 10);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(45, 19);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "label1";
            // 
            // lbl_Body
            // 
            this.lbl_Body.AutoSize = true;
            this.lbl_Body.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_Body.Location = new System.Drawing.Point(15, 35);
            this.lbl_Body.Name = "lbl_Body";
            this.lbl_Body.Size = new System.Drawing.Size(38, 15);
            this.lbl_Body.TabIndex = 1;
            this.lbl_Body.Text = "label2";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_Date.Location = new System.Drawing.Point(360, 35);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(38, 15);
            this.lbl_Date.TabIndex = 2;
            this.lbl_Date.Text = "label3";
            // 
            // CtlIntroductionMItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_Body);
            this.Controls.Add(this.lbl_Title);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "CtlIntroductionMItem";
            this.Size = new System.Drawing.Size(508, 60);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CtlIntroductionMItem_Paint);
            this.DoubleClick += new System.EventHandler(this.CtlSelfIntroductionItem_DoubleClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lbl_Title;
        internal System.Windows.Forms.Label lbl_Body;
        internal System.Windows.Forms.Label lbl_Date;
    }
}
