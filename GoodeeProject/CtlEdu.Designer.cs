namespace GoodeeProject
{
    partial class CtlEdu
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
            this.mTboxEnterPeriod = new System.Windows.Forms.MaskedTextBox();
            this.mTboxGraduPeriod = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxSchoolName = new System.Windows.Forms.TextBox();
            this.cboxSchoolType = new System.Windows.Forms.ComboBox();
            this.cboxGraduType = new System.Windows.Forms.ComboBox();
            this.tboxDepart = new System.Windows.Forms.TextBox();
            this.iTalk_Separator1 = new iTalk.iTalk_Separator();
            this.SuspendLayout();
            // 
            // mTboxEnterPeriod
            // 
            this.mTboxEnterPeriod.Location = new System.Drawing.Point(6, 7);
            this.mTboxEnterPeriod.Mask = "0000-00-00";
            this.mTboxEnterPeriod.Name = "mTboxEnterPeriod";
            this.mTboxEnterPeriod.Size = new System.Drawing.Size(100, 21);
            this.mTboxEnterPeriod.TabIndex = 0;
            this.mTboxEnterPeriod.ValidatingType = typeof(System.DateTime);
            // 
            // mTboxGraduPeriod
            // 
            this.mTboxGraduPeriod.Location = new System.Drawing.Point(126, 7);
            this.mTboxGraduPeriod.Mask = "0000-00-00";
            this.mTboxGraduPeriod.Name = "mTboxGraduPeriod";
            this.mTboxGraduPeriod.Size = new System.Drawing.Size(100, 21);
            this.mTboxGraduPeriod.TabIndex = 1;
            this.mTboxGraduPeriod.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "~";
            // 
            // tboxSchoolName
            // 
            this.tboxSchoolName.Location = new System.Drawing.Point(246, 7);
            this.tboxSchoolName.Name = "tboxSchoolName";
            this.tboxSchoolName.Size = new System.Drawing.Size(158, 21);
            this.tboxSchoolName.TabIndex = 3;
            // 
            // cboxSchoolType
            // 
            this.cboxSchoolType.FormattingEnabled = true;
            this.cboxSchoolType.Items.AddRange(new object[] {
            "고등학교",
            "대학교",
            "대학원"});
            this.cboxSchoolType.Location = new System.Drawing.Point(410, 7);
            this.cboxSchoolType.Name = "cboxSchoolType";
            this.cboxSchoolType.Size = new System.Drawing.Size(72, 20);
            this.cboxSchoolType.TabIndex = 4;
            // 
            // cboxGraduType
            // 
            this.cboxGraduType.FormattingEnabled = true;
            this.cboxGraduType.Items.AddRange(new object[] {
            "졸업",
            "재학",
            "자퇴",
            "퇴학"});
            this.cboxGraduType.Location = new System.Drawing.Point(681, 7);
            this.cboxGraduType.Name = "cboxGraduType";
            this.cboxGraduType.Size = new System.Drawing.Size(72, 20);
            this.cboxGraduType.TabIndex = 5;
            // 
            // tboxDepart
            // 
            this.tboxDepart.Location = new System.Drawing.Point(503, 7);
            this.tboxDepart.Name = "tboxDepart";
            this.tboxDepart.Size = new System.Drawing.Size(170, 21);
            this.tboxDepart.TabIndex = 6;
            // 
            // iTalk_Separator1
            // 
            this.iTalk_Separator1.Location = new System.Drawing.Point(6, 30);
            this.iTalk_Separator1.Name = "iTalk_Separator1";
            this.iTalk_Separator1.Size = new System.Drawing.Size(747, 10);
            this.iTalk_Separator1.TabIndex = 7;
            this.iTalk_Separator1.Text = "iTalk_Separator1";
            // 
            // CtlEdu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iTalk_Separator1);
            this.Controls.Add(this.tboxDepart);
            this.Controls.Add(this.cboxGraduType);
            this.Controls.Add(this.cboxSchoolType);
            this.Controls.Add(this.tboxSchoolName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mTboxGraduPeriod);
            this.Controls.Add(this.mTboxEnterPeriod);
            this.Name = "CtlEdu";
            this.Size = new System.Drawing.Size(753, 36);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private iTalk.iTalk_Separator iTalk_Separator1;
        internal System.Windows.Forms.MaskedTextBox mTboxEnterPeriod;
        internal System.Windows.Forms.MaskedTextBox mTboxGraduPeriod;
        internal System.Windows.Forms.TextBox tboxSchoolName;
        internal System.Windows.Forms.ComboBox cboxSchoolType;
        internal System.Windows.Forms.ComboBox cboxGraduType;
        internal System.Windows.Forms.TextBox tboxDepart;
    }
}
