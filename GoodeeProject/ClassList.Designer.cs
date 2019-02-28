namespace GoodeeProject
{
    partial class ClassList
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
            this.btnClassAdd = new System.Windows.Forms.Button();
            this.btnClassDelete = new System.Windows.Forms.Button();
            this.btnClassModify = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(815, 414);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnClassAdd
            // 
            this.btnClassAdd.Location = new System.Drawing.Point(4, 4);
            this.btnClassAdd.Name = "btnClassAdd";
            this.btnClassAdd.Size = new System.Drawing.Size(75, 23);
            this.btnClassAdd.TabIndex = 1;
            this.btnClassAdd.Text = "과정 추가";
            this.btnClassAdd.UseVisualStyleBackColor = true;
            this.btnClassAdd.Click += new System.EventHandler(this.btnClassAdd_Click);
            // 
            // btnClassDelete
            // 
            this.btnClassDelete.Location = new System.Drawing.Point(85, 4);
            this.btnClassDelete.Name = "btnClassDelete";
            this.btnClassDelete.Size = new System.Drawing.Size(75, 23);
            this.btnClassDelete.TabIndex = 2;
            this.btnClassDelete.Text = "과정 삭제";
            this.btnClassDelete.UseVisualStyleBackColor = true;
            this.btnClassDelete.Click += new System.EventHandler(this.btnClassDelete_Click);
            // 
            // btnClassModify
            // 
            this.btnClassModify.Location = new System.Drawing.Point(166, 4);
            this.btnClassModify.Name = "btnClassModify";
            this.btnClassModify.Size = new System.Drawing.Size(75, 23);
            this.btnClassModify.TabIndex = 3;
            this.btnClassModify.Text = "과정 수정";
            this.btnClassModify.UseVisualStyleBackColor = true;
            this.btnClassModify.Click += new System.EventHandler(this.btnClassModify_Click);
            // 
            // ClassList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClassModify);
            this.Controls.Add(this.btnClassDelete);
            this.Controls.Add(this.btnClassAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ClassList";
            this.Size = new System.Drawing.Size(815, 454);
            this.Load += new System.EventHandler(this.ClassList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnClassAdd;
        private System.Windows.Forms.Button btnClassDelete;
        private System.Windows.Forms.Button btnClassModify;
    }
}
