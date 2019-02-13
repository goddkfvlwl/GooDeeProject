namespace GoodeeProject
{
    partial class CreateSurvey
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
            this.btnAddMultiChoice = new System.Windows.Forms.Button();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.btnAddEssay = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.defaultSurvey1 = new GoodeeProject.DefaultSurvey();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSurveyTitle = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddMultiChoice
            // 
            this.btnAddMultiChoice.Location = new System.Drawing.Point(3, 3);
            this.btnAddMultiChoice.Name = "btnAddMultiChoice";
            this.btnAddMultiChoice.Size = new System.Drawing.Size(90, 23);
            this.btnAddMultiChoice.TabIndex = 0;
            this.btnAddMultiChoice.Text = "객관식 추가";
            this.btnAddMultiChoice.UseVisualStyleBackColor = true;
            this.btnAddMultiChoice.Click += new System.EventHandler(this.btnAddMultiChoice_Click);
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(191, 3);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(75, 23);
            this.btnAddQuestion.TabIndex = 1;
            this.btnAddQuestion.Text = "문항추가";
            this.btnAddQuestion.UseVisualStyleBackColor = true;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // btnAddEssay
            // 
            this.btnAddEssay.Location = new System.Drawing.Point(99, 3);
            this.btnAddEssay.Name = "btnAddEssay";
            this.btnAddEssay.Size = new System.Drawing.Size(86, 23);
            this.btnAddEssay.TabIndex = 2;
            this.btnAddEssay.Text = "주관식 추가";
            this.btnAddEssay.UseVisualStyleBackColor = true;
            this.btnAddEssay.Click += new System.EventHandler(this.btnAddEssay_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Controls.Add(this.defaultSurvey1);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 59);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(809, 395);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 57);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(100, 100);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // defaultSurvey1
            // 
            this.defaultSurvey1.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.defaultSurvey1.Location = new System.Drawing.Point(3, 3);
            this.defaultSurvey1.Name = "defaultSurvey1";
            this.defaultSurvey1.Size = new System.Drawing.Size(759, 48);
            this.defaultSurvey1.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(272, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSurveyTitle
            // 
            this.txtSurveyTitle.Location = new System.Drawing.Point(6, 32);
            this.txtSurveyTitle.Name = "txtSurveyTitle";
            this.txtSurveyTitle.Size = new System.Drawing.Size(806, 21);
            this.txtSurveyTitle.TabIndex = 7;
            // 
            // CreateSurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSurveyTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddEssay);
            this.Controls.Add(this.btnAddQuestion);
            this.Controls.Add(this.btnAddMultiChoice);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "CreateSurvey";
            this.Size = new System.Drawing.Size(815, 454);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddMultiChoice;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.Button btnAddEssay;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DefaultSurvey defaultSurvey1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSurveyTitle;
    }
}
