﻿namespace GoodeeProject
{
    partial class CtlMBTIDivide
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
            this.lblDivide = new iTalk.iTalk_Label();
            this.SuspendLayout();
            // 
            // lblDivide
            // 
            this.lblDivide.AutoSize = true;
            this.lblDivide.BackColor = System.Drawing.Color.Transparent;
            this.lblDivide.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDivide.ForeColor = System.Drawing.Color.DimGray;
            this.lblDivide.Location = new System.Drawing.Point(15, 25);
            this.lblDivide.Name = "lblDivide";
            this.lblDivide.Size = new System.Drawing.Size(0, 25);
            this.lblDivide.TabIndex = 1;
            this.lblDivide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CtlMBTIDivde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.lblDivide);
            this.Name = "CtlMBTIDivde";
            this.Size = new System.Drawing.Size(771, 97);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal iTalk.iTalk_Label lblDivide;
    }
}