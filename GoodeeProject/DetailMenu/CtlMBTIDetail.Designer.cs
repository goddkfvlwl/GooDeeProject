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
            this.iTalk_ChatBubble_L1 = new iTalk.iTalk_ChatBubble_L();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lblResult.Location = new System.Drawing.Point(14, 42);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(137, 20);
            this.lblResult.TabIndex = 19;
            this.lblResult.Text = "MBTI 결과";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iTalk_Separator1
            // 
            this.iTalk_Separator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.iTalk_Separator1.Location = new System.Drawing.Point(24, 30);
            this.iTalk_Separator1.Name = "iTalk_Separator1";
            this.iTalk_Separator1.Size = new System.Drawing.Size(120, 10);
            this.iTalk_Separator1.TabIndex = 17;
            this.iTalk_Separator1.Text = "iTalk_Separator1";
            // 
            // lblWrite
            // 
            this.lblWrite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lblWrite.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblWrite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lblWrite.Location = new System.Drawing.Point(12, 11);
            this.lblWrite.Name = "lblWrite";
            this.lblWrite.Size = new System.Drawing.Size(140, 20);
            this.lblWrite.TabIndex = 16;
            this.lblWrite.Text = "MBTI 작성";
            this.lblWrite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iTalk_ChatBubble_L1
            // 
            this.iTalk_ChatBubble_L1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_ChatBubble_L1.BubbleColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.iTalk_ChatBubble_L1.DrawBubbleArrow = true;
            this.iTalk_ChatBubble_L1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iTalk_ChatBubble_L1.Location = new System.Drawing.Point(3, 7);
            this.iTalk_ChatBubble_L1.Name = "iTalk_ChatBubble_L1";
            this.iTalk_ChatBubble_L1.Size = new System.Drawing.Size(152, 66);
            this.iTalk_ChatBubble_L1.TabIndex = 15;
            // 
            // CtlMBTIDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.iTalk_Separator1);
            this.Controls.Add(this.lblWrite);
            this.Controls.Add(this.iTalk_ChatBubble_L1);
            this.Name = "CtlMBTIDetail";
            this.Size = new System.Drawing.Size(163, 80);
            this.ResumeLayout(false);

        }

        #endregion

        internal iTalk.iTalk_Label lblResult;
        internal iTalk.iTalk_Separator iTalk_Separator1;
        internal iTalk.iTalk_Label lblWrite;
        internal iTalk.iTalk_ChatBubble_L iTalk_ChatBubble_L1;
    }
}
