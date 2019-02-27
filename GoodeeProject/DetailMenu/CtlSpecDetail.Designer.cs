namespace GoodeeProject
{
    partial class CtlSpecDetail
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
            this.iTalk_ChatBubble_L1 = new iTalk.iTalk_ChatBubble_L();
            this.lblMenu1 = new iTalk.iTalk_Label();
            this.iTalk_Separator1 = new iTalk.iTalk_Separator();
            this.separator2 = new iTalk.iTalk_Separator();
            this.lbl_SelfIntroduction = new iTalk.iTalk_Label();
            this.iTalk_Label2 = new iTalk.iTalk_Label();
            this.SuspendLayout();
            // 
            // iTalk_ChatBubble_L1
            // 
            this.iTalk_ChatBubble_L1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_ChatBubble_L1.BubbleColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.iTalk_ChatBubble_L1.DrawBubbleArrow = true;
            this.iTalk_ChatBubble_L1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iTalk_ChatBubble_L1.Location = new System.Drawing.Point(3, 3);
            this.iTalk_ChatBubble_L1.Name = "iTalk_ChatBubble_L1";
            this.iTalk_ChatBubble_L1.Size = new System.Drawing.Size(152, 90);
            this.iTalk_ChatBubble_L1.TabIndex = 8;
            // 
            // lblMenu1
            // 
            this.lblMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lblMenu1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblMenu1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lblMenu1.Location = new System.Drawing.Point(12, 7);
            this.lblMenu1.Name = "lblMenu1";
            this.lblMenu1.Size = new System.Drawing.Size(140, 20);
            this.lblMenu1.TabIndex = 9;
            this.lblMenu1.Text = "이력서";
            this.lblMenu1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iTalk_Separator1
            // 
            this.iTalk_Separator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.iTalk_Separator1.Location = new System.Drawing.Point(24, 26);
            this.iTalk_Separator1.Name = "iTalk_Separator1";
            this.iTalk_Separator1.Size = new System.Drawing.Size(120, 10);
            this.iTalk_Separator1.TabIndex = 10;
            this.iTalk_Separator1.Text = "iTalk_Separator1";
            // 
            // separator2
            // 
            this.separator2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.separator2.Location = new System.Drawing.Point(21, 57);
            this.separator2.Name = "separator2";
            this.separator2.Size = new System.Drawing.Size(120, 10);
            this.separator2.TabIndex = 12;
            this.separator2.Text = "iTalk_Separator2";
            // 
            // lbl_SelfIntroduction
            // 
            this.lbl_SelfIntroduction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lbl_SelfIntroduction.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbl_SelfIntroduction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lbl_SelfIntroduction.Location = new System.Drawing.Point(14, 38);
            this.lbl_SelfIntroduction.Name = "lbl_SelfIntroduction";
            this.lbl_SelfIntroduction.Size = new System.Drawing.Size(137, 20);
            this.lbl_SelfIntroduction.TabIndex = 13;
            this.lbl_SelfIntroduction.Text = "자기소개서";
            this.lbl_SelfIntroduction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iTalk_Label2
            // 
            this.iTalk_Label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.iTalk_Label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label2.Location = new System.Drawing.Point(15, 68);
            this.iTalk_Label2.Name = "iTalk_Label2";
            this.iTalk_Label2.Size = new System.Drawing.Size(136, 20);
            this.iTalk_Label2.TabIndex = 14;
            this.iTalk_Label2.Text = "포트폴리오";
            this.iTalk_Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CtlSpecDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iTalk_Label2);
            this.Controls.Add(this.lbl_SelfIntroduction);
            this.Controls.Add(this.separator2);
            this.Controls.Add(this.iTalk_Separator1);
            this.Controls.Add(this.lblMenu1);
            this.Controls.Add(this.iTalk_ChatBubble_L1);
            this.Name = "CtlSpecDetail";
            this.Size = new System.Drawing.Size(162, 96);
            this.ResumeLayout(false);

        }

        #endregion
        internal iTalk.iTalk_Label lblMenu1;
        internal iTalk.iTalk_Separator iTalk_Separator1;
        internal iTalk.iTalk_Separator separator2;
        internal iTalk.iTalk_ChatBubble_L iTalk_ChatBubble_L1;
        internal iTalk.iTalk_Label lbl_SelfIntroduction;
        internal iTalk.iTalk_Label iTalk_Label2;
    }
}
