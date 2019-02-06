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
            this.btnReadExl = new iTalk.iTalk_Button_1();
            this.gViewStudentInfo = new System.Windows.Forms.DataGridView();
            this.btnWriteExl = new iTalk.iTalk_Button_1();
            ((System.ComponentModel.ISupportInitialize)(this.gViewStudentInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReadExl
            // 
            this.btnReadExl.BackColor = System.Drawing.Color.Transparent;
            this.btnReadExl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnReadExl.Image = null;
            this.btnReadExl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReadExl.Location = new System.Drawing.Point(3, 3);
            this.btnReadExl.Name = "btnReadExl";
            this.btnReadExl.Size = new System.Drawing.Size(172, 40);
            this.btnReadExl.TabIndex = 0;
            this.btnReadExl.Text = "수강생 명단 엑셀 입력";
            this.btnReadExl.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnReadExl.Click += new System.EventHandler(this.btnReadExl_Click);
            // 
            // gViewStudentInfo
            // 
            this.gViewStudentInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gViewStudentInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gViewStudentInfo.Location = new System.Drawing.Point(0, 52);
            this.gViewStudentInfo.Name = "gViewStudentInfo";
            this.gViewStudentInfo.RowTemplate.Height = 23;
            this.gViewStudentInfo.Size = new System.Drawing.Size(815, 402);
            this.gViewStudentInfo.TabIndex = 1;
            // 
            // btnWriteExl
            // 
            this.btnWriteExl.BackColor = System.Drawing.Color.Transparent;
            this.btnWriteExl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnWriteExl.Image = null;
            this.btnWriteExl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWriteExl.Location = new System.Drawing.Point(181, 3);
            this.btnWriteExl.Name = "btnWriteExl";
            this.btnWriteExl.Size = new System.Drawing.Size(172, 40);
            this.btnWriteExl.TabIndex = 2;
            this.btnWriteExl.Text = "수강생 명단 엑셀 출력";
            this.btnWriteExl.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnWriteExl.Click += new System.EventHandler(this.btnWriteExl_Click);
            // 
            // StudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnWriteExl);
            this.Controls.Add(this.gViewStudentInfo);
            this.Controls.Add(this.btnReadExl);
            this.Name = "StudentManagement";
            this.Size = new System.Drawing.Size(815, 454);
            ((System.ComponentModel.ISupportInitialize)(this.gViewStudentInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private iTalk.iTalk_Button_1 btnReadExl;
        private iTalk.iTalk_Button_1 btnWriteExl;
        internal System.Windows.Forms.DataGridView gViewStudentInfo;
    }
}
