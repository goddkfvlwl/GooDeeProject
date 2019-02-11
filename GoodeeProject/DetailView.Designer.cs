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
            this.iTalk_HeaderLabel1 = new iTalk.iTalk_HeaderLabel();
            this.boardBoby = new System.Windows.Forms.RichTextBox();
            this.Title = new iTalk.iTalk_TextBox_Small();
            this.iTalk_Label2 = new iTalk.iTalk_Label();
            this.butUpdate = new iTalk.iTalk_Button_1();
            this.butDelete = new iTalk.iTalk_Button_1();
            this.SuspendLayout();
            // 
            // iTalk_HeaderLabel1
            // 
            this.iTalk_HeaderLabel1.AutoSize = true;
            this.iTalk_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel1.Font = new System.Drawing.Font("함초롬돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iTalk_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.iTalk_HeaderLabel1.Location = new System.Drawing.Point(16, 11);
            this.iTalk_HeaderLabel1.Name = "iTalk_HeaderLabel1";
            this.iTalk_HeaderLabel1.Size = new System.Drawing.Size(152, 27);
            this.iTalk_HeaderLabel1.TabIndex = 35;
            this.iTalk_HeaderLabel1.Text = "협약기업게시판";
            // 
            // boardBoby
            // 
            this.boardBoby.Location = new System.Drawing.Point(22, 128);
            this.boardBoby.Name = "boardBoby";
            this.boardBoby.Size = new System.Drawing.Size(764, 239);
            this.boardBoby.TabIndex = 32;
            this.boardBoby.Text = "";
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Title.ForeColor = System.Drawing.Color.DimGray;
            this.Title.Location = new System.Drawing.Point(79, 81);
            this.Title.MaxLength = 32767;
            this.Title.Multiline = true;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Size = new System.Drawing.Size(175, 28);
            this.Title.TabIndex = 29;
            this.Title.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.Title.UseSystemPasswordChar = false;
            this.Title.Visible = false;
            // 
            // iTalk_Label2
            // 
            this.iTalk_Label2.AutoSize = true;
            this.iTalk_Label2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label2.Location = new System.Drawing.Point(32, 88);
            this.iTalk_Label2.Name = "iTalk_Label2";
            this.iTalk_Label2.Size = new System.Drawing.Size(32, 13);
            this.iTalk_Label2.TabIndex = 28;
            this.iTalk_Label2.Text = "제 목";
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
            // 
            // DetailView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.butDelete);
            this.Controls.Add(this.butUpdate);
            this.Controls.Add(this.iTalk_HeaderLabel1);
            this.Controls.Add(this.boardBoby);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.iTalk_Label2);
            this.Name = "DetailView";
            this.Size = new System.Drawing.Size(803, 445);
            this.Load += new System.EventHandler(this.DetailView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private iTalk.iTalk_HeaderLabel iTalk_HeaderLabel1;
        private System.Windows.Forms.RichTextBox boardBoby;
        private iTalk.iTalk_TextBox_Small Title;
        private iTalk.iTalk_Label iTalk_Label2;
        private iTalk.iTalk_Button_1 butUpdate;
        private iTalk.iTalk_Button_1 butDelete;
    }
}
