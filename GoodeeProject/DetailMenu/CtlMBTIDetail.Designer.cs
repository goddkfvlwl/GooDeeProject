namespace GoodeeProject
{
    partial class CtlMBTIDetail
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
            this.lblResult = new iTalk.iTalk_Label();
            this.iTalk_Separator1 = new iTalk.iTalk_Separator();
            this.lblWrite = new iTalk.iTalk_Label();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.lblResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lblResult.Location = new System.Drawing.Point(13, 49);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(137, 20);
            this.lblResult.TabIndex = 19;
            this.lblResult.Text = "MBTI 결과";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iTalk_Separator1
            // 
            this.iTalk_Separator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.iTalk_Separator1.Location = new System.Drawing.Point(23, 36);
            this.iTalk_Separator1.Name = "iTalk_Separator1";
            this.iTalk_Separator1.Size = new System.Drawing.Size(120, 10);
            this.iTalk_Separator1.TabIndex = 17;
            this.iTalk_Separator1.Text = "iTalk_Separator1";
            // 
            // lblWrite
            // 
            this.lblWrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.lblWrite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblWrite.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblWrite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lblWrite.Location = new System.Drawing.Point(11, 11);
            this.lblWrite.Name = "lblWrite";
            this.lblWrite.Size = new System.Drawing.Size(140, 20);
            this.lblWrite.TabIndex = 16;
            this.lblWrite.Text = "MBTI 작성";
            this.lblWrite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CtlMBTIDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.iTalk_Separator1);
            this.Controls.Add(this.lblWrite);
            this.Name = "CtlMBTIDetail";
            this.Size = new System.Drawing.Size(163, 80);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Frm_BorderPaint);
            this.ResumeLayout(false);

        }

        #endregion

        internal iTalk.iTalk_Label lblResult;
        internal iTalk.iTalk_Separator iTalk_Separator1;
        internal iTalk.iTalk_Label lblWrite;
    }
}
