namespace GoodeeProject
{
    partial class CtlModifyPW
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
            this.iTalk_Label1 = new iTalk.iTalk_Label();
            this.iTalk_Label2 = new iTalk.iTalk_Label();
            this.iTalk_Label3 = new iTalk.iTalk_Label();
            this.iTalk_Separator2 = new iTalk.iTalk_Separator();
            this.tboxNowPW = new System.Windows.Forms.TextBox();
            this.iTalk_Label4 = new iTalk.iTalk_Label();
            this.iTalk_Separator1 = new iTalk.iTalk_Separator();
            this.tboxNewPW = new System.Windows.Forms.TextBox();
            this.iTalk_Label5 = new iTalk.iTalk_Label();
            this.iTalk_Separator3 = new iTalk.iTalk_Separator();
            this.tboxNewREPW = new System.Windows.Forms.TextBox();
            this.iTalk_Label6 = new iTalk.iTalk_Label();
            this.iTalk_Label7 = new iTalk.iTalk_Label();
            this.pboxCaptcha = new System.Windows.Forms.PictureBox();
            this.tboxCaptcha = new iTalk.iTalk_TextBox_Small();
            this.btnOK = new iTalk.iTalk_Button_1();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCaptcha)).BeginInit();
            this.SuspendLayout();
            // 
            // iTalk_Label1
            // 
            this.iTalk_Label1.AutoSize = true;
            this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iTalk_Label1.Location = new System.Drawing.Point(75, 56);
            this.iTalk_Label1.Name = "iTalk_Label1";
            this.iTalk_Label1.Size = new System.Drawing.Size(254, 13);
            this.iTalk_Label1.TabIndex = 0;
            this.iTalk_Label1.Text = "* 다른 아이디/사이트에서 사용한 적 없는 비밀번호";
            // 
            // iTalk_Label2
            // 
            this.iTalk_Label2.AutoSize = true;
            this.iTalk_Label2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iTalk_Label2.Location = new System.Drawing.Point(75, 93);
            this.iTalk_Label2.Name = "iTalk_Label2";
            this.iTalk_Label2.Size = new System.Drawing.Size(170, 13);
            this.iTalk_Label2.TabIndex = 1;
            this.iTalk_Label2.Text = "* 이전에 사용한 적 없는 비밀번호";
            // 
            // iTalk_Label3
            // 
            this.iTalk_Label3.AutoSize = true;
            this.iTalk_Label3.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label3.Location = new System.Drawing.Point(251, 93);
            this.iTalk_Label3.Name = "iTalk_Label3";
            this.iTalk_Label3.Size = new System.Drawing.Size(76, 13);
            this.iTalk_Label3.TabIndex = 2;
            this.iTalk_Label3.Text = "가 안전합니다";
            // 
            // iTalk_Separator2
            // 
            this.iTalk_Separator2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iTalk_Separator2.Location = new System.Drawing.Point(154, 158);
            this.iTalk_Separator2.Name = "iTalk_Separator2";
            this.iTalk_Separator2.Size = new System.Drawing.Size(175, 10);
            this.iTalk_Separator2.TabIndex = 29;
            this.iTalk_Separator2.Text = "iTalk_Separator2";
            // 
            // tboxNowPW
            // 
            this.tboxNowPW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxNowPW.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxNowPW.Location = new System.Drawing.Point(154, 141);
            this.tboxNowPW.Name = "tboxNowPW";
            this.tboxNowPW.PasswordChar = '*';
            this.tboxNowPW.Size = new System.Drawing.Size(175, 20);
            this.tboxNowPW.TabIndex = 28;
            // 
            // iTalk_Label4
            // 
            this.iTalk_Label4.AutoSize = true;
            this.iTalk_Label4.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label4.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iTalk_Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label4.Location = new System.Drawing.Point(79, 141);
            this.iTalk_Label4.Name = "iTalk_Label4";
            this.iTalk_Label4.Size = new System.Drawing.Size(69, 20);
            this.iTalk_Label4.TabIndex = 27;
            this.iTalk_Label4.Text = "비밀번호";
            // 
            // iTalk_Separator1
            // 
            this.iTalk_Separator1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iTalk_Separator1.Location = new System.Drawing.Point(154, 206);
            this.iTalk_Separator1.Name = "iTalk_Separator1";
            this.iTalk_Separator1.Size = new System.Drawing.Size(175, 10);
            this.iTalk_Separator1.TabIndex = 32;
            this.iTalk_Separator1.Text = "iTalk_Separator1";
            // 
            // tboxNewPW
            // 
            this.tboxNewPW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxNewPW.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxNewPW.Location = new System.Drawing.Point(154, 189);
            this.tboxNewPW.Name = "tboxNewPW";
            this.tboxNewPW.PasswordChar = '*';
            this.tboxNewPW.Size = new System.Drawing.Size(175, 20);
            this.tboxNewPW.TabIndex = 31;
            // 
            // iTalk_Label5
            // 
            this.iTalk_Label5.AutoSize = true;
            this.iTalk_Label5.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label5.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iTalk_Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label5.Location = new System.Drawing.Point(59, 189);
            this.iTalk_Label5.Name = "iTalk_Label5";
            this.iTalk_Label5.Size = new System.Drawing.Size(89, 20);
            this.iTalk_Label5.TabIndex = 30;
            this.iTalk_Label5.Text = "새 비밀번호";
            // 
            // iTalk_Separator3
            // 
            this.iTalk_Separator3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iTalk_Separator3.Location = new System.Drawing.Point(152, 258);
            this.iTalk_Separator3.Name = "iTalk_Separator3";
            this.iTalk_Separator3.Size = new System.Drawing.Size(175, 10);
            this.iTalk_Separator3.TabIndex = 35;
            this.iTalk_Separator3.Text = "iTalk_Separator3";
            // 
            // tboxNewREPW
            // 
            this.tboxNewREPW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboxNewREPW.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tboxNewREPW.Location = new System.Drawing.Point(152, 241);
            this.tboxNewREPW.Name = "tboxNewREPW";
            this.tboxNewREPW.PasswordChar = '*';
            this.tboxNewREPW.Size = new System.Drawing.Size(175, 20);
            this.tboxNewREPW.TabIndex = 34;
            // 
            // iTalk_Label6
            // 
            this.iTalk_Label6.AutoSize = true;
            this.iTalk_Label6.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label6.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iTalk_Label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label6.Location = new System.Drawing.Point(24, 241);
            this.iTalk_Label6.Name = "iTalk_Label6";
            this.iTalk_Label6.Size = new System.Drawing.Size(124, 20);
            this.iTalk_Label6.TabIndex = 33;
            this.iTalk_Label6.Text = "새 비밀번호 확인";
            // 
            // iTalk_Label7
            // 
            this.iTalk_Label7.AutoSize = true;
            this.iTalk_Label7.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label7.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label7.Location = new System.Drawing.Point(103, 319);
            this.iTalk_Label7.Name = "iTalk_Label7";
            this.iTalk_Label7.Size = new System.Drawing.Size(209, 13);
            this.iTalk_Label7.TabIndex = 36;
            this.iTalk_Label7.Text = "아래 이미지를 보이는 대로 입력해주세요.";
            // 
            // pboxCaptcha
            // 
            this.pboxCaptcha.Location = new System.Drawing.Point(83, 337);
            this.pboxCaptcha.Name = "pboxCaptcha";
            this.pboxCaptcha.Size = new System.Drawing.Size(249, 114);
            this.pboxCaptcha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxCaptcha.TabIndex = 37;
            this.pboxCaptcha.TabStop = false;
            // 
            // tboxCaptcha
            // 
            this.tboxCaptcha.BackColor = System.Drawing.Color.Transparent;
            this.tboxCaptcha.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tboxCaptcha.ForeColor = System.Drawing.Color.DimGray;
            this.tboxCaptcha.Location = new System.Drawing.Point(106, 467);
            this.tboxCaptcha.MaxLength = 32767;
            this.tboxCaptcha.Multiline = false;
            this.tboxCaptcha.Name = "tboxCaptcha";
            this.tboxCaptcha.ReadOnly = false;
            this.tboxCaptcha.Size = new System.Drawing.Size(206, 28);
            this.tboxCaptcha.TabIndex = 38;
            this.tboxCaptcha.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.tboxCaptcha.UseSystemPasswordChar = false;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnOK.Image = null;
            this.btnOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOK.Location = new System.Drawing.Point(106, 522);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(206, 39);
            this.btnOK.TabIndex = 39;
            this.btnOK.Text = "확인";
            this.btnOK.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // CtlModifyPW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tboxCaptcha);
            this.Controls.Add(this.pboxCaptcha);
            this.Controls.Add(this.iTalk_Label7);
            this.Controls.Add(this.iTalk_Separator3);
            this.Controls.Add(this.tboxNewREPW);
            this.Controls.Add(this.iTalk_Label6);
            this.Controls.Add(this.iTalk_Separator1);
            this.Controls.Add(this.tboxNewPW);
            this.Controls.Add(this.iTalk_Label5);
            this.Controls.Add(this.iTalk_Separator2);
            this.Controls.Add(this.tboxNowPW);
            this.Controls.Add(this.iTalk_Label4);
            this.Controls.Add(this.iTalk_Label3);
            this.Controls.Add(this.iTalk_Label2);
            this.Controls.Add(this.iTalk_Label1);
            this.Name = "CtlModifyPW";
            this.Size = new System.Drawing.Size(399, 571);
            this.Load += new System.EventHandler(this.CtlModifyPW_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxCaptcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private iTalk.iTalk_Label iTalk_Label1;
        private iTalk.iTalk_Label iTalk_Label2;
        private iTalk.iTalk_Label iTalk_Label3;
        private iTalk.iTalk_Separator iTalk_Separator2;
        private System.Windows.Forms.TextBox tboxNowPW;
        private iTalk.iTalk_Label iTalk_Label4;
        private iTalk.iTalk_Separator iTalk_Separator1;
        private System.Windows.Forms.TextBox tboxNewPW;
        private iTalk.iTalk_Label iTalk_Label5;
        private iTalk.iTalk_Separator iTalk_Separator3;
        private System.Windows.Forms.TextBox tboxNewREPW;
        private iTalk.iTalk_Label iTalk_Label6;
        private iTalk.iTalk_Label iTalk_Label7;
        private System.Windows.Forms.PictureBox pboxCaptcha;
        private iTalk.iTalk_TextBox_Small tboxCaptcha;
        private iTalk.iTalk_Button_1 btnOK;
    }
}
