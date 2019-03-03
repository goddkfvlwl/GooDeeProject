namespace GoodeeProject
{
    partial class CtlSurveyAdminDetail
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
            this.btnNewSurvey = new iTalk.iTalk_Label();
            this.iTalk_Separator1 = new iTalk.iTalk_Separator();
            this.btnSurveyList = new iTalk.iTalk_Label();
            this.SuspendLayout();
            // 
            // btnNewSurvey
            // 
            this.btnNewSurvey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.btnNewSurvey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewSurvey.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnNewSurvey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.btnNewSurvey.Location = new System.Drawing.Point(11, 49);
            this.btnNewSurvey.Name = "btnNewSurvey";
            this.btnNewSurvey.Size = new System.Drawing.Size(137, 20);
            this.btnNewSurvey.TabIndex = 36;
            this.btnNewSurvey.Text = "새 설문";
            this.btnNewSurvey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iTalk_Separator1
            // 
            this.iTalk_Separator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.iTalk_Separator1.Location = new System.Drawing.Point(21, 34);
            this.iTalk_Separator1.Name = "iTalk_Separator1";
            this.iTalk_Separator1.Size = new System.Drawing.Size(120, 10);
            this.iTalk_Separator1.TabIndex = 35;
            this.iTalk_Separator1.Text = "iTalk_Separator1";
            // 
            // btnSurveyList
            // 
            this.btnSurveyList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.btnSurveyList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSurveyList.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btnSurveyList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.btnSurveyList.Location = new System.Drawing.Point(10, 11);
            this.btnSurveyList.Name = "btnSurveyList";
            this.btnSurveyList.Size = new System.Drawing.Size(140, 20);
            this.btnSurveyList.TabIndex = 34;
            this.btnSurveyList.Text = "설문목록";
            this.btnSurveyList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CtlSurveyAdminDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.Controls.Add(this.btnNewSurvey);
            this.Controls.Add(this.iTalk_Separator1);
            this.Controls.Add(this.btnSurveyList);
            this.Name = "CtlSurveyAdminDetail";
            this.Size = new System.Drawing.Size(160, 80);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Frm_BorderPaint);
            this.ResumeLayout(false);

        }

        #endregion

        internal iTalk.iTalk_Label btnNewSurvey;
        internal iTalk.iTalk_Separator iTalk_Separator1;
        internal iTalk.iTalk_Label btnSurveyList;
    }
}
