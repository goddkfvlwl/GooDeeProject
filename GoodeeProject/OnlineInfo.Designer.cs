﻿namespace GoodeeProject
{
    partial class OnlineInfo
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblCurriculum = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(29, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "이름";
            this.lblName.Click += new System.EventHandler(this.OnlineInfo_Click);
            // 
            // lblCurriculum
            // 
            this.lblCurriculum.AutoSize = true;
            this.lblCurriculum.Location = new System.Drawing.Point(3, 39);
            this.lblCurriculum.Name = "lblCurriculum";
            this.lblCurriculum.Size = new System.Drawing.Size(41, 12);
            this.lblCurriculum.TabIndex = 1;
            this.lblCurriculum.Text = "과정명";
            this.lblCurriculum.Click += new System.EventHandler(this.OnlineInfo_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(3, 5);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 12);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "이메일";
            // 
            // OnlineInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCurriculum);
            this.Controls.Add(this.lblName);
            this.Name = "OnlineInfo";
            this.Size = new System.Drawing.Size(310, 57);
            this.Click += new System.EventHandler(this.OnlineInfo_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCurriculum;
        private System.Windows.Forms.Label lblEmail;
    }
}
