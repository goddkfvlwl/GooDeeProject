namespace GoodeeProject
{
    partial class DetailView
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
            this.butDelete = new iTalk.iTalk_Button_1();
            this.butUpdate = new iTalk.iTalk_Button_1();
            this.boardBoby = new System.Windows.Forms.RichTextBox();
            this.title = new iTalk.iTalk_Label();
            this.SuspendLayout();
            // 
            // butDelete
            // 
            this.butDelete.BackColor = System.Drawing.Color.Transparent;
            this.butDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDelete.Image = null;
            this.butDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butDelete.Location = new System.Drawing.Point(751, 494);
            this.butDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(64, 30);
            this.butDelete.TabIndex = 41;
            this.butDelete.Text = "삭제";
            this.butDelete.TextAlignment = System.Drawing.StringAlignment.Center;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butUpdate
            // 
            this.butUpdate.BackColor = System.Drawing.Color.Transparent;
            this.butUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butUpdate.Image = null;
            this.butUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butUpdate.Location = new System.Drawing.Point(833, 494);
            this.butUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(64, 30);
            this.butUpdate.TabIndex = 40;
            this.butUpdate.Text = "수정";
            this.butUpdate.TextAlignment = System.Drawing.StringAlignment.Center;
            this.butUpdate.Click += new System.EventHandler(this.butUpdate_Click);
            // 
            // boardBoby
            // 
            this.boardBoby.Location = new System.Drawing.Point(24, 72);
            this.boardBoby.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boardBoby.Name = "boardBoby";
            this.boardBoby.Size = new System.Drawing.Size(873, 413);
            this.boardBoby.TabIndex = 39;
            this.boardBoby.Text = "";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.title.Location = new System.Drawing.Point(19, 32);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(38, 20);
            this.title.TabIndex = 38;
            this.title.Text = "제 목";
            // 
            // DetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butUpdate);
            this.Controls.Add(this.boardBoby);
            this.Controls.Add(this.title);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DetailView";
            this.Size = new System.Drawing.Size(918, 556);
            this.Load += new System.EventHandler(this.DetailView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private iTalk.iTalk_Button_1 butDelete;
        private iTalk.iTalk_Button_1 butUpdate;
        private System.Windows.Forms.RichTextBox boardBoby;
        private iTalk.iTalk_Label title;
    }
}
