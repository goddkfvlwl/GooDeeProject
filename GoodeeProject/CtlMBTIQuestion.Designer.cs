namespace GoodeeProject
{
    partial class CtlMBTIQuestion
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
            this.lblQuestion = new iTalk.iTalk_Label();
            this.lblNum = new iTalk.iTalk_Label();
            this.iTalk_Separator1 = new iTalk.iTalk_Separator();
            this.flowpanelChoice = new System.Windows.Forms.FlowLayoutPanel();
            this.rdoA = new System.Windows.Forms.RadioButton();
            this.rdoB = new System.Windows.Forms.RadioButton();
            this.flowpanelChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.White;
            this.lblQuestion.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lblQuestion.Location = new System.Drawing.Point(37, 15);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(78, 21);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Question";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.BackColor = System.Drawing.Color.White;
            this.lblNum.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lblNum.Location = new System.Drawing.Point(12, 15);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(23, 21);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "N";
            // 
            // iTalk_Separator1
            // 
            this.iTalk_Separator1.Location = new System.Drawing.Point(3, 2);
            this.iTalk_Separator1.Name = "iTalk_Separator1";
            this.iTalk_Separator1.Size = new System.Drawing.Size(762, 10);
            this.iTalk_Separator1.TabIndex = 5;
            this.iTalk_Separator1.Text = "iTalk_Separator1";
            // 
            // flowpanelChoice
            // 
            this.flowpanelChoice.Controls.Add(this.rdoA);
            this.flowpanelChoice.Controls.Add(this.rdoB);
            this.flowpanelChoice.Location = new System.Drawing.Point(16, 42);
            this.flowpanelChoice.Name = "flowpanelChoice";
            this.flowpanelChoice.Size = new System.Drawing.Size(750, 20);
            this.flowpanelChoice.TabIndex = 6;
            // 
            // rdoA
            // 
            this.rdoA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdoA.AutoSize = true;
            this.rdoA.Location = new System.Drawing.Point(3, 3);
            this.rdoA.Name = "rdoA";
            this.rdoA.Size = new System.Drawing.Size(31, 16);
            this.rdoA.TabIndex = 0;
            this.rdoA.TabStop = true;
            this.rdoA.Text = "A";
            this.rdoA.UseVisualStyleBackColor = true;
            // 
            // rdoB
            // 
            this.rdoB.AutoSize = true;
            this.rdoB.Dock = System.Windows.Forms.DockStyle.Left;
            this.rdoB.Location = new System.Drawing.Point(40, 3);
            this.rdoB.Name = "rdoB";
            this.rdoB.Size = new System.Drawing.Size(31, 16);
            this.rdoB.TabIndex = 1;
            this.rdoB.TabStop = true;
            this.rdoB.Text = "B";
            this.rdoB.UseVisualStyleBackColor = true;
            // 
            // CtlMBTIQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowpanelChoice);
            this.Controls.Add(this.iTalk_Separator1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.lblNum);
            this.Name = "CtlMBTIQuestion";
            this.Size = new System.Drawing.Size(771, 62);
            this.flowpanelChoice.ResumeLayout(false);
            this.flowpanelChoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private iTalk.iTalk_Separator iTalk_Separator1;
        internal iTalk.iTalk_Label lblNum;
        internal iTalk.iTalk_Label lblQuestion;
        internal System.Windows.Forms.RadioButton rdoA;
        internal System.Windows.Forms.RadioButton rdoB;
        internal System.Windows.Forms.FlowLayoutPanel flowpanelChoice;
    }
}
