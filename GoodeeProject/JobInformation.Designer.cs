namespace GoodeeProject
{
    partial class JobInformation
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
            this.iTalk_RichTextBox1 = new iTalk.iTalk_RichTextBox();
            this.iTalk_RichTextBox3 = new iTalk.iTalk_RichTextBox();
            this.iTalk_Button_11 = new iTalk.iTalk_Button_1();
            this.SuspendLayout();
            // 
            // iTalk_RichTextBox1
            // 
            this.iTalk_RichTextBox1.AutoWordSelection = false;
            this.iTalk_RichTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_RichTextBox1.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_RichTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.iTalk_RichTextBox1.Location = new System.Drawing.Point(36, 14);
            this.iTalk_RichTextBox1.Name = "iTalk_RichTextBox1";
            this.iTalk_RichTextBox1.ReadOnly = false;
            this.iTalk_RichTextBox1.Size = new System.Drawing.Size(199, 42);
            this.iTalk_RichTextBox1.TabIndex = 0;
            this.iTalk_RichTextBox1.Text = "검색어 입력";
            this.iTalk_RichTextBox1.WordWrap = true;
            // 
            // iTalk_RichTextBox3
            // 
            this.iTalk_RichTextBox3.AutoWordSelection = false;
            this.iTalk_RichTextBox3.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_RichTextBox3.Enabled = false;
            this.iTalk_RichTextBox3.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_RichTextBox3.ForeColor = System.Drawing.Color.DimGray;
            this.iTalk_RichTextBox3.Location = new System.Drawing.Point(570, 14);
            this.iTalk_RichTextBox3.Name = "iTalk_RichTextBox3";
            this.iTalk_RichTextBox3.ReadOnly = false;
            this.iTalk_RichTextBox3.Size = new System.Drawing.Size(199, 42);
            this.iTalk_RichTextBox3.TabIndex = 2;
            this.iTalk_RichTextBox3.Text = "직업 선택";
            this.iTalk_RichTextBox3.WordWrap = true;
            // 
            // iTalk_Button_11
            // 
            this.iTalk_Button_11.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.iTalk_Button_11.Image = null;
            this.iTalk_Button_11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_11.Location = new System.Drawing.Point(301, 14);
            this.iTalk_Button_11.Name = "iTalk_Button_11";
            this.iTalk_Button_11.Size = new System.Drawing.Size(211, 42);
            this.iTalk_Button_11.TabIndex = 3;
            this.iTalk_Button_11.Text = "지역선택";
            this.iTalk_Button_11.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_11.Click += new System.EventHandler(this.iTalk_Button_11_Click);
            // 
            // JobInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iTalk_Button_11);
            this.Controls.Add(this.iTalk_RichTextBox3);
            this.Controls.Add(this.iTalk_RichTextBox1);
            this.Name = "JobInformation";
            this.Size = new System.Drawing.Size(815, 454);
            this.ResumeLayout(false);

        }

        #endregion

        private iTalk.iTalk_RichTextBox iTalk_RichTextBox1;
        private iTalk.iTalk_RichTextBox iTalk_RichTextBox3;
        private iTalk.iTalk_Button_1 iTalk_Button_11;
    }
}
