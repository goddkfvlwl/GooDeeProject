namespace GoodeeProject
{
    partial class CtlSelfIntroduce
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
            this.tb_Body = new System.Windows.Forms.RichTextBox();
            this.tb_Title = new System.Windows.Forms.RichTextBox();
            this.btn_End = new iTalk.iTalk_Button_1();
            this.btn_List = new iTalk.iTalk_Button_1();
            this.SuspendLayout();
            // 
            // tb_Body
            // 
            this.tb_Body.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Body.Location = new System.Drawing.Point(15, 38);
            this.tb_Body.Name = "tb_Body";
            this.tb_Body.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.tb_Body.Size = new System.Drawing.Size(783, 372);
            this.tb_Body.TabIndex = 1;
            this.tb_Body.Text = "";
            // 
            // tb_Title
            // 
            this.tb_Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Title.Location = new System.Drawing.Point(15, 6);
            this.tb_Title.Multiline = false;
            this.tb_Title.Name = "tb_Title";
            this.tb_Title.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.tb_Title.Size = new System.Drawing.Size(783, 26);
            this.tb_Title.TabIndex = 0;
            this.tb_Title.Text = "";
            // 
            // btn_End
            // 
            this.btn_End.BackColor = System.Drawing.Color.Transparent;
            this.btn_End.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_End.Image = null;
            this.btn_End.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_End.Location = new System.Drawing.Point(665, 416);
            this.btn_End.Name = "btn_End";
            this.btn_End.Size = new System.Drawing.Size(133, 34);
            this.btn_End.TabIndex = 2;
            this.btn_End.Text = "작성";
            this.btn_End.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_End.Click += new System.EventHandler(this.btn_End_Click);
            // 
            // btn_List
            // 
            this.btn_List.BackColor = System.Drawing.Color.Transparent;
            this.btn_List.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_List.Image = null;
            this.btn_List.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_List.Location = new System.Drawing.Point(526, 416);
            this.btn_List.Name = "btn_List";
            this.btn_List.Size = new System.Drawing.Size(133, 34);
            this.btn_List.TabIndex = 3;
            this.btn_List.Text = "목록";
            this.btn_List.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_List.Click += new System.EventHandler(this.btn_List_Click);
            // 
            // CtlSelfIntroduce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.Controls.Add(this.btn_List);
            this.Controls.Add(this.btn_End);
            this.Controls.Add(this.tb_Title);
            this.Controls.Add(this.tb_Body);
            this.Name = "CtlSelfIntroduce";
            this.Size = new System.Drawing.Size(815, 454);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.RichTextBox tb_Body;
        internal System.Windows.Forms.RichTextBox tb_Title;
        internal iTalk.iTalk_Button_1 btn_End;
        internal iTalk.iTalk_Button_1 btn_List;
    }
}
