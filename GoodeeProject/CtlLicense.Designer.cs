﻿namespace GoodeeProject
{
    partial class CtlLicense
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
            this.tboxLiName = new System.Windows.Forms.TextBox();
            this.mTboxDate = new System.Windows.Forms.MaskedTextBox();
            this.tboxAgency = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // iTalk_Separator1
            // 
            this.iTalk_Separator1.Location = new System.Drawing.Point(3, 29);
            this.iTalk_Separator1.Name = "iTalk_Separator1";
            this.iTalk_Separator1.Size = new System.Drawing.Size(747, 10);
            this.iTalk_Separator1.TabIndex = 15;
            this.iTalk_Separator1.Text = "iTalk_Separator1";
            // 
            // tboxLiName
            // 
            this.tboxLiName.Location = new System.Drawing.Point(4, 7);
            this.tboxLiName.Name = "tboxLiName";
            this.tboxLiName.Size = new System.Drawing.Size(250, 21);
            this.tboxLiName.TabIndex = 16;
            // 
            // mTboxDate
            // 
            this.mTboxDate.Location = new System.Drawing.Point(292, 7);
            this.mTboxDate.Mask = "0000-00-00";
            this.mTboxDate.Name = "mTboxDate";
            this.mTboxDate.Size = new System.Drawing.Size(210, 21);
            this.mTboxDate.TabIndex = 17;
            this.mTboxDate.ValidatingType = typeof(System.DateTime);
            // 
            // tboxAgency
            // 
            this.tboxAgency.Location = new System.Drawing.Point(537, 7);
            this.tboxAgency.Name = "tboxAgency";
            this.tboxAgency.Size = new System.Drawing.Size(192, 21);
            this.tboxAgency.TabIndex = 18;
            // 
            // CtlLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tboxAgency);
            this.Controls.Add(this.mTboxDate);
            this.Controls.Add(this.tboxLiName);
            this.Controls.Add(this.iTalk_Separator1);
            this.Name = "CtlLicense";
            this.Size = new System.Drawing.Size(753, 36);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private iTalk.iTalk_Separator iTalk_Separator1;
        internal System.Windows.Forms.TextBox tboxLiName;
        internal System.Windows.Forms.MaskedTextBox mTboxDate;
        internal System.Windows.Forms.TextBox tboxAgency;
    }
}
