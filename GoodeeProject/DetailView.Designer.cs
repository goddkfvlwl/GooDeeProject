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
            this.boardBoby = new System.Windows.Forms.RichTextBox();
            this.butDelete = new iTalk.iTalk_Button_1();
            this.butUpdate = new iTalk.iTalk_Button_1();
            this.title = new iTalk.iTalk_Label();
            this.SuspendLayout();
            // 
            // boardBoby
            // 
            this.boardBoby.Location = new System.Drawing.Point(22, 119);
            this.boardBoby.Name = "boardBoby";
            this.boardBoby.Size = new System.Drawing.Size(764, 239);
            this.boardBoby.TabIndex = 32;
            this.boardBoby.Text = "";
            // 
            // butDelete
            // 
            this.butDelete.BackColor = System.Drawing.Color.Transparent;
            this.butDelete.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDelete.Image = null;
            this.butDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butDelete.Location = new System.Drawing.Point(658, 382);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(56, 24);
            this.butDelete.TabIndex = 37;
            this.butDelete.Text = "삭제";
            this.butDelete.TextAlignment = System.Drawing.StringAlignment.Center;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // butUpdate
            // 
            this.butUpdate.BackColor = System.Drawing.Color.Transparent;
            this.butUpdate.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butUpdate.Image = null;
            this.butUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.butUpdate.Location = new System.Drawing.Point(730, 382);
            this.butUpdate.Name = "butUpdate";
            this.butUpdate.Size = new System.Drawing.Size(56, 24);
            this.butUpdate.TabIndex = 36;
            this.butUpdate.Text = "수정";
            this.butUpdate.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("함초롬돋움", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.title.Location = new System.Drawing.Point(19, 47);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(38, 17);
            this.title.TabIndex = 28;
            this.title.Text = "제 목";
            // 
            // DetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butUpdate);
            this.Controls.Add(this.boardBoby);
            this.Controls.Add(this.title);
            this.Name = "DetailView";
            this.Size = new System.Drawing.Size(803, 445);
            this.Load += new System.EventHandler(this.DetailView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox boardBoby;
        private iTalk.iTalk_Label title;
        private iTalk.iTalk_Button_1 butUpdate;
        private iTalk.iTalk_Button_1 butDelete;
    }
}
