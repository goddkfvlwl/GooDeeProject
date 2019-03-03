namespace GoodeeProject
{
    partial class ChatList
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
            this.lblChatTitle = new System.Windows.Forms.Label();
            this.lblLastChatContent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblChatTitle
            // 
            this.lblChatTitle.AutoSize = true;
            this.lblChatTitle.Location = new System.Drawing.Point(3, 9);
            this.lblChatTitle.Name = "lblChatTitle";
            this.lblChatTitle.Size = new System.Drawing.Size(53, 12);
            this.lblChatTitle.TabIndex = 0;
            this.lblChatTitle.Text = "채팅제목";
            this.lblChatTitle.Click += new System.EventHandler(this.ChatList_Click);
            // 
            // lblLastChatContent
            // 
            this.lblLastChatContent.AutoSize = true;
            this.lblLastChatContent.Location = new System.Drawing.Point(3, 24);
            this.lblLastChatContent.Name = "lblLastChatContent";
            this.lblLastChatContent.Size = new System.Drawing.Size(97, 12);
            this.lblLastChatContent.TabIndex = 1;
            this.lblLastChatContent.Text = "마지막 채팅 기록";
            this.lblLastChatContent.Click += new System.EventHandler(this.ChatList_Click);
            // 
            // ChatList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblLastChatContent);
            this.Controls.Add(this.lblChatTitle);
            this.Name = "ChatList";
            this.Size = new System.Drawing.Size(465, 45);
            this.Click += new System.EventHandler(this.ChatList_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblChatTitle;
        private System.Windows.Forms.Label lblLastChatContent;
    }
}
