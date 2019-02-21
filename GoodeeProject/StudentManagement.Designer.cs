namespace GoodeeProject
{
    partial class StudentManagement
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
            this.gViewStudentInfo = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnubtnStudentRegist = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubtnExcelRegist = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubtnIndividualRegist = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubtnStudentPrint = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gViewStudentInfo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gViewStudentInfo
            // 
            this.gViewStudentInfo.AllowUserToAddRows = false;
            this.gViewStudentInfo.AllowUserToDeleteRows = false;
            this.gViewStudentInfo.AllowUserToResizeColumns = false;
            this.gViewStudentInfo.AllowUserToResizeRows = false;
            this.gViewStudentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gViewStudentInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gViewStudentInfo.Location = new System.Drawing.Point(0, 28);
            this.gViewStudentInfo.Name = "gViewStudentInfo";
            this.gViewStudentInfo.ReadOnly = true;
            this.gViewStudentInfo.RowHeadersVisible = false;
            this.gViewStudentInfo.RowTemplate.Height = 23;
            this.gViewStudentInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gViewStudentInfo.Size = new System.Drawing.Size(815, 426);
            this.gViewStudentInfo.TabIndex = 1;
            this.gViewStudentInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gViewStudentInfo_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnubtnStudentRegist,
            this.mnubtnStudentPrint});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(815, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnubtnStudentRegist
            // 
            this.mnubtnStudentRegist.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnubtnExcelRegist,
            this.mnubtnIndividualRegist});
            this.mnubtnStudentRegist.Name = "mnubtnStudentRegist";
            this.mnubtnStudentRegist.Size = new System.Drawing.Size(83, 20);
            this.mnubtnStudentRegist.Text = "수강생 등록";
            // 
            // mnubtnExcelRegist
            // 
            this.mnubtnExcelRegist.Name = "mnubtnExcelRegist";
            this.mnubtnExcelRegist.Size = new System.Drawing.Size(170, 22);
            this.mnubtnExcelRegist.Text = "수강생 Excel 등록";
            this.mnubtnExcelRegist.Click += new System.EventHandler(this.btnReadExl_Click);
            // 
            // mnubtnIndividualRegist
            // 
            this.mnubtnIndividualRegist.Name = "mnubtnIndividualRegist";
            this.mnubtnIndividualRegist.Size = new System.Drawing.Size(170, 22);
            this.mnubtnIndividualRegist.Text = "수강생 개별  등록";
            this.mnubtnIndividualRegist.Click += new System.EventHandler(this.mnubtnIndividualRegist_Click);
            // 
            // mnubtnStudentPrint
            // 
            this.mnubtnStudentPrint.Name = "mnubtnStudentPrint";
            this.mnubtnStudentPrint.Size = new System.Drawing.Size(83, 20);
            this.mnubtnStudentPrint.Text = "수강생 출력";
            this.mnubtnStudentPrint.Click += new System.EventHandler(this.btnWriteExl_Click);
            // 
            // StudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gViewStudentInfo);
            this.Controls.Add(this.menuStrip1);
            this.Name = "StudentManagement";
            this.Size = new System.Drawing.Size(815, 454);
            this.Load += new System.EventHandler(this.StudentManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gViewStudentInfo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.DataGridView gViewStudentInfo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnubtnStudentRegist;
        private System.Windows.Forms.ToolStripMenuItem mnubtnExcelRegist;
        private System.Windows.Forms.ToolStripMenuItem mnubtnIndividualRegist;
        private System.Windows.Forms.ToolStripMenuItem mnubtnStudentPrint;
    }
}
