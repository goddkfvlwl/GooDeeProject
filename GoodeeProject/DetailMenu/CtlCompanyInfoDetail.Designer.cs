﻿namespace GoodeeProject
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
            this.iTalk_ChatBubble_L1 = new iTalk.iTalk_ChatBubble_L();
            this.SuspendLayout();
            // 
            // iTalk_Separator1
            // 
            this.iTalk_Separator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.iTalk_Separator1.Location = new System.Drawing.Point(32, 55);
            this.iTalk_Separator1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iTalk_Separator1.Name = "iTalk_Separator1";
            this.iTalk_Separator1.Size = new System.Drawing.Size(137, 12);
            this.iTalk_Separator1.TabIndex = 33;
            this.iTalk_Separator1.Text = "iTalk_Separator1";
            // 
            // lblMenu1
            // 
            this.lblMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.lblMenu1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblMenu1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lblMenu1.Location = new System.Drawing.Point(19, 26);
            this.lblMenu1.Name = "lblMenu1";
            this.lblMenu1.Size = new System.Drawing.Size(160, 25);
            this.lblMenu1.TabIndex = 32;
            this.lblMenu1.Text = "구인정보";
            this.lblMenu1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMenu1.Click += new System.EventHandler(this.lblMenu1_Click_1);
            // 
            // iTalk_ChatBubble_L1
            // 
            this.iTalk_ChatBubble_L1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_ChatBubble_L1.BubbleColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.iTalk_ChatBubble_L1.DrawBubbleArrow = true;
            this.iTalk_ChatBubble_L1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iTalk_ChatBubble_L1.Location = new System.Drawing.Point(8, 12);
            this.iTalk_ChatBubble_L1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iTalk_ChatBubble_L1.Name = "iTalk_ChatBubble_L1";
            this.iTalk_ChatBubble_L1.Size = new System.Drawing.Size(174, 100);
            this.iTalk_ChatBubble_L1.TabIndex = 31;
            // 
            // CtlCompanyInfoDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iTalk_Separator1);
            this.Controls.Add(this.lblMenu1);
            this.Controls.Add(this.iTalk_ChatBubble_L1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CtlCompanyInfoDetail";
            this.Size = new System.Drawing.Size(192, 121);
            this.ResumeLayout(false);

        }

        #endregion
        internal iTalk.iTalk_Separator iTalk_Separator1;
        internal iTalk.iTalk_Label lblMenu1;
        internal iTalk.iTalk_ChatBubble_L iTalk_ChatBubble_L1;
    }
}
