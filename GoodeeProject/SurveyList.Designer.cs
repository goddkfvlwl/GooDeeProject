namespace GoodeeProject
{
    partial class SurveyList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoInclude = new System.Windows.Forms.RadioButton();
            this.rdoNotInclude = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(815, 429);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdoNotInclude);
            this.panel1.Controls.Add(this.rdoInclude);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 23);
            this.panel1.TabIndex = 1;
            // 
            // rdoInclude
            // 
            this.rdoInclude.AutoSize = true;
            this.rdoInclude.Location = new System.Drawing.Point(3, 3);
            this.rdoInclude.Name = "rdoInclude";
            this.rdoInclude.Size = new System.Drawing.Size(103, 16);
            this.rdoInclude.TabIndex = 0;
            this.rdoInclude.Text = "이전 설문 포함";
            this.rdoInclude.UseVisualStyleBackColor = true;
            this.rdoInclude.CheckedChanged += new System.EventHandler(this.SurveyList_Load);
            // 
            // rdoNotInclude
            // 
            this.rdoNotInclude.AutoSize = true;
            this.rdoNotInclude.Checked = true;
            this.rdoNotInclude.Location = new System.Drawing.Point(112, 3);
            this.rdoNotInclude.Name = "rdoNotInclude";
            this.rdoNotInclude.Size = new System.Drawing.Size(115, 16);
            this.rdoNotInclude.TabIndex = 1;
            this.rdoNotInclude.TabStop = true;
            this.rdoNotInclude.Text = "이전 설문 미포함";
            this.rdoNotInclude.UseVisualStyleBackColor = true;
            this.rdoNotInclude.CheckedChanged += new System.EventHandler(this.SurveyList_Load);
            // 
            // SurveyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SurveyList";
            this.Size = new System.Drawing.Size(815, 454);
            this.Load += new System.EventHandler(this.SurveyList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoNotInclude;
        private System.Windows.Forms.RadioButton rdoInclude;
    }
}
