namespace GoodeeProject
{
    partial class CtlEduHistory
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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.iTalk_Label5 = new iTalk.iTalk_Label();
            this.iTalk_Label6 = new iTalk.iTalk_Label();
            this.iTalk_Label4 = new iTalk.iTalk_Label();
            this.iTalk_Label3 = new iTalk.iTalk_Label();
            this.iTalk_Label2 = new iTalk.iTalk_Label();
            this.iTalk_Label1 = new iTalk.iTalk_Label();
            this.iTalk_Separator1 = new iTalk.iTalk_Separator();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(119, 17);
            this.maskedTextBox1.Mask = "0000-00-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 21);
            this.maskedTextBox1.TabIndex = 0;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(252, 17);
            this.maskedTextBox2.Mask = "0000-00-00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 21);
            this.maskedTextBox2.TabIndex = 1;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(233, 21);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(233, 21);
            this.textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(119, 140);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(518, 21);
            this.textBox3.TabIndex = 19;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(119, 168);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(518, 141);
            this.textBox4.TabIndex = 16;
            // 
            // iTalk_Label5
            // 
            this.iTalk_Label5.AutoSize = true;
            this.iTalk_Label5.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iTalk_Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label5.Location = new System.Drawing.Point(16, 136);
            this.iTalk_Label5.Name = "iTalk_Label5";
            this.iTalk_Label5.Size = new System.Drawing.Size(80, 21);
            this.iTalk_Label5.TabIndex = 18;
            this.iTalk_Label5.Text = "보유 능력";
            // 
            // iTalk_Label6
            // 
            this.iTalk_Label6.AutoSize = true;
            this.iTalk_Label6.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iTalk_Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label6.Location = new System.Drawing.Point(16, 164);
            this.iTalk_Label6.Name = "iTalk_Label6";
            this.iTalk_Label6.Size = new System.Drawing.Size(80, 21);
            this.iTalk_Label6.TabIndex = 17;
            this.iTalk_Label6.Text = "상세 내용";
            // 
            // iTalk_Label4
            // 
            this.iTalk_Label4.AutoSize = true;
            this.iTalk_Label4.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iTalk_Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label4.Location = new System.Drawing.Point(26, 93);
            this.iTalk_Label4.Name = "iTalk_Label4";
            this.iTalk_Label4.Size = new System.Drawing.Size(70, 21);
            this.iTalk_Label4.TabIndex = 6;
            this.iTalk_Label4.Text = "과 정 명";
            // 
            // iTalk_Label3
            // 
            this.iTalk_Label3.AutoSize = true;
            this.iTalk_Label3.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iTalk_Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label3.Location = new System.Drawing.Point(26, 55);
            this.iTalk_Label3.Name = "iTalk_Label3";
            this.iTalk_Label3.Size = new System.Drawing.Size(70, 21);
            this.iTalk_Label3.TabIndex = 5;
            this.iTalk_Label3.Text = "기 관 명";
            // 
            // iTalk_Label2
            // 
            this.iTalk_Label2.AutoSize = true;
            this.iTalk_Label2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iTalk_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label2.Location = new System.Drawing.Point(26, 17);
            this.iTalk_Label2.Name = "iTalk_Label2";
            this.iTalk_Label2.Size = new System.Drawing.Size(54, 21);
            this.iTalk_Label2.TabIndex = 4;
            this.iTalk_Label2.Text = "기  간";
            // 
            // iTalk_Label1
            // 
            this.iTalk_Label1.AutoSize = true;
            this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label1.Location = new System.Drawing.Point(224, 11);
            this.iTalk_Label1.Name = "iTalk_Label1";
            this.iTalk_Label1.Size = new System.Drawing.Size(27, 30);
            this.iTalk_Label1.TabIndex = 2;
            this.iTalk_Label1.Text = "~";
            // 
            // iTalk_Separator1
            // 
            this.iTalk_Separator1.Location = new System.Drawing.Point(3, 315);
            this.iTalk_Separator1.Name = "iTalk_Separator1";
            this.iTalk_Separator1.Size = new System.Drawing.Size(748, 10);
            this.iTalk_Separator1.TabIndex = 20;
            this.iTalk_Separator1.Text = "iTalk_Separator1";
            // 
            // CtlEduHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.iTalk_Separator1);
            this.Controls.Add(this.iTalk_Label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.iTalk_Label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.iTalk_Label4);
            this.Controls.Add(this.iTalk_Label3);
            this.Controls.Add(this.iTalk_Label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.iTalk_Label1);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.maskedTextBox1);
            this.Name = "CtlEduHistory";
            this.Size = new System.Drawing.Size(753, 324);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private iTalk.iTalk_Label iTalk_Label1;
        private iTalk.iTalk_Label iTalk_Label2;
        private iTalk.iTalk_Label iTalk_Label3;
        private iTalk.iTalk_Label iTalk_Label4;
        private iTalk.iTalk_Label iTalk_Label5;
        private iTalk.iTalk_Label iTalk_Label6;
        private iTalk.iTalk_Separator iTalk_Separator1;
        internal System.Windows.Forms.MaskedTextBox maskedTextBox1;
        internal System.Windows.Forms.MaskedTextBox maskedTextBox2;
        internal System.Windows.Forms.TextBox textBox1;
        internal System.Windows.Forms.TextBox textBox2;
        internal System.Windows.Forms.TextBox textBox3;
        internal System.Windows.Forms.TextBox textBox4;
    }
}
