namespace GoodeeProject
{
    partial class JobAreaChoice
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
            this.foreginAreaName = new System.Windows.Forms.FlowLayoutPanel();
            this.koreaAreaPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.iTalk_RichTextBox1 = new iTalk.iTalk_RichTextBox();
            this.iTalk_Label1 = new iTalk.iTalk_Label();
            this.SuspendLayout();
            // 
            // foreginAreaName
            // 
            this.foreginAreaName.Location = new System.Drawing.Point(21, 195);
            this.foreginAreaName.Name = "foreginAreaName";
            this.foreginAreaName.Size = new System.Drawing.Size(237, 113);
            this.foreginAreaName.TabIndex = 6;
            // 
            // koreaAreaPanel
            // 
            this.koreaAreaPanel.Location = new System.Drawing.Point(10, 68);
            this.koreaAreaPanel.Name = "koreaAreaPanel";
            this.koreaAreaPanel.Size = new System.Drawing.Size(258, 102);
            this.koreaAreaPanel.TabIndex = 7;
            // 
            // iTalk_RichTextBox1
            // 
            this.iTalk_RichTextBox1.AutoWordSelection = false;
            this.iTalk_RichTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_RichTextBox1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.iTalk_RichTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.iTalk_RichTextBox1.Location = new System.Drawing.Point(10, 14);
            this.iTalk_RichTextBox1.Name = "iTalk_RichTextBox1";
            this.iTalk_RichTextBox1.ReadOnly = false;
            this.iTalk_RichTextBox1.Size = new System.Drawing.Size(707, 35);
            this.iTalk_RichTextBox1.TabIndex = 4;
            this.iTalk_RichTextBox1.Text = "지역명 입력";
            this.iTalk_RichTextBox1.WordWrap = true;
            // 
            // iTalk_Label1
            // 
            this.iTalk_Label1.AutoSize = true;
            this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label1.Location = new System.Drawing.Point(11, 174);
            this.iTalk_Label1.Name = "iTalk_Label1";
            this.iTalk_Label1.Size = new System.Drawing.Size(255, 26);
            this.iTalk_Label1.TabIndex = 3;
            this.iTalk_Label1.Text = "--------------------------------------------------------------\r\n\r\n";
            // 
            // JobAreaChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.koreaAreaPanel);
            this.Controls.Add(this.foreginAreaName);
            this.Controls.Add(this.iTalk_RichTextBox1);
            this.Controls.Add(this.iTalk_Label1);
            this.Name = "JobAreaChoice";
            this.Size = new System.Drawing.Size(725, 327);
            this.Load += new System.EventHandler(this.JobAreaChoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private iTalk.iTalk_Label iTalk_Label1;
        private iTalk.iTalk_RichTextBox iTalk_RichTextBox1;
        private System.Windows.Forms.FlowLayoutPanel foreginAreaName;
        private System.Windows.Forms.FlowLayoutPanel koreaAreaPanel;
    }
}
