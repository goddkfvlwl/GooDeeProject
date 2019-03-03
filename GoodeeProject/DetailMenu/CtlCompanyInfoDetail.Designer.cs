namespace GoodeeProject
{
    partial class CtlCompanyInfoDetail
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
            this.iTalk_Separator1 = new iTalk.iTalk_Separator();
            this.lblMenu1 = new iTalk.iTalk_Label();
            this.SuspendLayout();
            // 
            // iTalk_Label1
            // 
            this.lblMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.lblMenu1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMenu1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblMenu1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lblMenu1.Location = new System.Drawing.Point(12, 49);
            this.lblMenu1.Name = "iTalk_Label1";
            this.lblMenu1.Size = new System.Drawing.Size(137, 20);
            this.lblMenu1.TabIndex = 34;
            this.lblMenu1.Text = "기업정보";
            this.lblMenu1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iTalk_Separator1
            // 
            this.iTalk_Separator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.iTalk_Separator1.Cursor = System.Windows.Forms.Cursors.Default;
            this.iTalk_Separator1.Location = new System.Drawing.Point(23, 33);
            this.iTalk_Separator1.Name = "iTalk_Separator1";
            this.iTalk_Separator1.Size = new System.Drawing.Size(137, 12);
            this.iTalk_Separator1.TabIndex = 33;
            this.iTalk_Separator1.Text = "iTalk_Separator1";
            // 
            // lblMenu1
            // 
            this.lblMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.lblMenu1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMenu1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblMenu1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lblMenu1.Location = new System.Drawing.Point(11, 10);
            this.lblMenu1.Name = "lblMenu1";
            this.lblMenu1.Size = new System.Drawing.Size(160, 25);
            this.lblMenu1.TabIndex = 32;
            this.lblMenu1.Text = "구인정보";
            this.lblMenu1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMenu1.Click += new System.EventHandler(this.lblMenu1_Click_1);
            // 
            // 
            // CtlCompanyInfoDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.Controls.Add(this.lblMenu1);
            this.Controls.Add(this.iTalk_Separator1);
            this.Controls.Add(this.lblMenu1);
            this.Name = "CtlCompanyInfoDetail";
            this.Size = new System.Drawing.Size(160, 80);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Frm_BorderPaint);
            this.ResumeLayout(false);

        }

        #endregion
        internal iTalk.iTalk_Separator iTalk_Separator1;
        internal iTalk.iTalk_Label lblMenu1;
    }
}
