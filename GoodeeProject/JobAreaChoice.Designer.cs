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
            this.koreaAreaPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.areaNameSearch = new iTalk.iTalk_RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // koreaAreaPanel
            // 
            this.koreaAreaPanel.Location = new System.Drawing.Point(10, 62);
            this.koreaAreaPanel.Name = "koreaAreaPanel";
            this.koreaAreaPanel.Size = new System.Drawing.Size(258, 256);
            this.koreaAreaPanel.TabIndex = 7;
            // 
            // areaNameSearch
            // 
            this.areaNameSearch.AutoWordSelection = false;
            this.areaNameSearch.BackColor = System.Drawing.Color.Transparent;
            this.areaNameSearch.Font = new System.Drawing.Font("Tahoma", 10F);
            this.areaNameSearch.ForeColor = System.Drawing.Color.DimGray;
            this.areaNameSearch.Location = new System.Drawing.Point(10, 29);
            this.areaNameSearch.Name = "areaNameSearch";
            this.areaNameSearch.ReadOnly = false;
            this.areaNameSearch.Size = new System.Drawing.Size(707, 27);
            this.areaNameSearch.TabIndex = 4;
            this.areaNameSearch.Text = "지역명 입력";
            this.areaNameSearch.WordWrap = true;
            this.areaNameSearch.Click += new System.EventHandler(this.iTalk_RichTextBox1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(725, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toolStripComboBox1_KeyDown);
            // 
            // JobAreaChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.koreaAreaPanel);
            this.Controls.Add(this.areaNameSearch);
            this.Name = "JobAreaChoice";
            this.Size = new System.Drawing.Size(725, 327);
            this.Load += new System.EventHandler(this.JobAreaChoice_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private iTalk.iTalk_RichTextBox areaNameSearch;
        private System.Windows.Forms.FlowLayoutPanel koreaAreaPanel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
    }
}
