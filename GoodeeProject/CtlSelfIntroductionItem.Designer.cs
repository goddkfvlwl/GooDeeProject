namespace GoodeeProject
{
    partial class CtlSelfIntroductionItem
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
            this.lbl_Title = new iTalk.iTalk_Label();
            this.lbl_Body = new iTalk.iTalk_Label();
            this.lbl_Date = new iTalk.iTalk_Label();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lbl_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lbl_Title.Location = new System.Drawing.Point(17, 10);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(150, 25);
            this.lbl_Title.TabIndex = 18;
            this.lbl_Title.Text = "자기소개서 제목";
            // 
            // lbl_Body
            // 
            this.lbl_Body.AutoSize = true;
            this.lbl_Body.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Body.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_Body.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lbl_Body.Location = new System.Drawing.Point(18, 43);
            this.lbl_Body.Name = "lbl_Body";
            this.lbl_Body.Size = new System.Drawing.Size(111, 19);
            this.lbl_Body.TabIndex = 19;
            this.lbl_Body.Text = "자기소개서 내용";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Date.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lbl_Date.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lbl_Date.Location = new System.Drawing.Point(453, 43);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(111, 19);
            this.lbl_Date.TabIndex = 20;
            this.lbl_Date.Text = "자기소개서 날짜";
            // 
            // CtlSelfIntroductionItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_Body);
            this.Controls.Add(this.lbl_Title);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "CtlSelfIntroductionItem";
            this.Size = new System.Drawing.Size(622, 72);
            this.Click += new System.EventHandler(this.CtlSelfIntroductionItem_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal iTalk.iTalk_Label lbl_Title;
        internal iTalk.iTalk_Label lbl_Body;
        internal iTalk.iTalk_Label lbl_Date;
    }
}
