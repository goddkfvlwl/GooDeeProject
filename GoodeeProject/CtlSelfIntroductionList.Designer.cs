namespace GoodeeProject
{
    partial class CtlSelfIntroductionList
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_Write = new iTalk.iTalk_Button_1();
            this.btn_Delete = new iTalk.iTalk_Button_1();
            this.iTalk_Label1 = new iTalk.iTalk_Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 77);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(774, 360);
            this.flowLayoutPanel1.TabIndex = 18;
            // 
            // btn_Write
            // 
            this.btn_Write.BackColor = System.Drawing.Color.Transparent;
            this.btn_Write.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Write.Image = null;
            this.btn_Write.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Write.Location = new System.Drawing.Point(641, 22);
            this.btn_Write.Name = "btn_Write";
            this.btn_Write.Size = new System.Drawing.Size(153, 41);
            this.btn_Write.TabIndex = 21;
            this.btn_Write.Text = "자기소개서 작성";
            this.btn_Write.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_Write.Click += new System.EventHandler(this.btn_Write_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Transparent;
            this.btn_Delete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Delete.Image = null;
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.Location = new System.Drawing.Point(495, 22);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(140, 41);
            this.btn_Delete.TabIndex = 19;
            this.btn_Delete.Text = "삭제";
            this.btn_Delete.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // iTalk_Label1
            // 
            this.iTalk_Label1.AutoSize = true;
            this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label1.Font = new System.Drawing.Font("Segoe UI", 22F);
            this.iTalk_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label1.Location = new System.Drawing.Point(13, 19);
            this.iTalk_Label1.Name = "iTalk_Label1";
            this.iTalk_Label1.Size = new System.Drawing.Size(236, 41);
            this.iTalk_Label1.TabIndex = 17;
            this.iTalk_Label1.Text = "자기소개서 목록";
            // 
            // CtlSelfIntroductionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.Controls.Add(this.btn_Write);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.iTalk_Label1);
            this.Name = "CtlSelfIntroductionList";
            this.Size = new System.Drawing.Size(815, 454);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private iTalk.iTalk_Label iTalk_Label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private iTalk.iTalk_Button_1 btn_Delete;
        private iTalk.iTalk_Button_1 btn_Write;
    }
}
