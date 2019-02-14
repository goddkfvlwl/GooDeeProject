namespace GoodeeProject
{
    partial class SurveyDetail
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.lblWriter = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.SurveyDetailPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnResult);
            this.panel1.Controls.Add(this.btnModify);
            this.panel1.Controls.Add(this.lblWriter);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblNum);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 79);
            this.panel1.TabIndex = 1;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(737, 47);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 23);
            this.btnResult.TabIndex = 7;
            this.btnResult.Text = "결과보기";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(737, 9);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 6;
            this.btnModify.Text = "수정";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // lblWriter
            // 
            this.lblWriter.AutoSize = true;
            this.lblWriter.Location = new System.Drawing.Point(607, 58);
            this.lblWriter.Name = "lblWriter";
            this.lblWriter.Size = new System.Drawing.Size(0, 12);
            this.lblWriter.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(599, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "작성자";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "제목";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(9, 56);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(0, 12);
            this.lblNum.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "번호";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(45, 50);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(541, 21);
            this.txtTitle.TabIndex = 0;
            // 
            // SurveyDetailPanel
            // 
            this.SurveyDetailPanel.AutoSize = true;
            this.SurveyDetailPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SurveyDetailPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SurveyDetailPanel.Location = new System.Drawing.Point(0, 79);
            this.SurveyDetailPanel.Name = "SurveyDetailPanel";
            this.SurveyDetailPanel.Size = new System.Drawing.Size(815, 4);
            this.SurveyDetailPanel.TabIndex = 3;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubmit.Location = new System.Drawing.Point(0, 83);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(815, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "설문 작성";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // SurveyDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.SurveyDetailPanel);
            this.Controls.Add(this.panel1);
            this.Name = "SurveyDetail";
            this.Size = new System.Drawing.Size(815, 454);
            this.Load += new System.EventHandler(this.SurveyDetail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWriter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.FlowLayoutPanel SurveyDetailPanel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnResult;
    }
}
