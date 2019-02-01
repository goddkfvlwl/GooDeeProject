namespace GoodeeProject
{
    partial class FrmSendEmail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tb_Check = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Change = new iTalk.iTalk_Button_1();
            this.iTalk_Label3 = new iTalk.iTalk_Label();
            this.iTalk_Separator3 = new iTalk.iTalk_Separator();
            this.iTalk_Separator2 = new iTalk.iTalk_Separator();
            this.iTalk_Separator1 = new iTalk.iTalk_Separator();
            this.btnMinimum = new iTalk.iTalk_Button_1();
            this.btnExit = new iTalk.iTalk_Button_1();
            this.lbl_Time = new iTalk.iTalk_Label();
            this.btn_Check = new iTalk.iTalk_Button_1();
            this.iTalk_Label5 = new iTalk.iTalk_Label();
            this.btn_Send = new iTalk.iTalk_Button_1();
            this.iTalk_Label2 = new iTalk.iTalk_Label();
            this.iTalk_Label1 = new iTalk.iTalk_Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Check
            // 
            this.tb_Check.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Check.Location = new System.Drawing.Point(126, 217);
            this.tb_Check.Name = "tb_Check";
            this.tb_Check.Size = new System.Drawing.Size(175, 14);
            this.tb_Check.TabIndex = 37;
            // 
            // tb_Email
            // 
            this.tb_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Email.Location = new System.Drawing.Point(126, 148);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(279, 14);
            this.tb_Email.TabIndex = 33;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(443, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Change
            // 
            this.btn_Change.BackColor = System.Drawing.Color.Transparent;
            this.btn_Change.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Change.Image = null;
            this.btn_Change.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Change.Location = new System.Drawing.Point(178, 289);
            this.btn_Change.Name = "btn_Change";
            this.btn_Change.Size = new System.Drawing.Size(147, 29);
            this.btn_Change.TabIndex = 55;
            this.btn_Change.Text = "변경";
            this.btn_Change.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_Change.Click += new System.EventHandler(this.btn_Change_Click);
            // 
            // iTalk_Label3
            // 
            this.iTalk_Label3.AutoSize = true;
            this.iTalk_Label3.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iTalk_Label3.ForeColor = System.Drawing.Color.Gray;
            this.iTalk_Label3.Location = new System.Drawing.Point(12, 81);
            this.iTalk_Label3.Name = "iTalk_Label3";
            this.iTalk_Label3.Size = new System.Drawing.Size(394, 21);
            this.iTalk_Label3.TabIndex = 52;
            this.iTalk_Label3.Text = "비밀번호변경을 위해 아이디(이메일)을 입력해주세요.";
            // 
            // iTalk_Separator3
            // 
            this.iTalk_Separator3.Location = new System.Drawing.Point(126, 229);
            this.iTalk_Separator3.Name = "iTalk_Separator3";
            this.iTalk_Separator3.Size = new System.Drawing.Size(172, 10);
            this.iTalk_Separator3.TabIndex = 51;
            this.iTalk_Separator3.Text = "iTalk_Separator3";
            // 
            // iTalk_Separator2
            // 
            this.iTalk_Separator2.Location = new System.Drawing.Point(123, 160);
            this.iTalk_Separator2.Name = "iTalk_Separator2";
            this.iTalk_Separator2.Size = new System.Drawing.Size(282, 10);
            this.iTalk_Separator2.TabIndex = 50;
            this.iTalk_Separator2.Text = "iTalk_Separator2";
            // 
            // iTalk_Separator1
            // 
            this.iTalk_Separator1.Location = new System.Drawing.Point(-2, 57);
            this.iTalk_Separator1.Name = "iTalk_Separator1";
            this.iTalk_Separator1.Size = new System.Drawing.Size(494, 10);
            this.iTalk_Separator1.TabIndex = 49;
            this.iTalk_Separator1.Text = "iTalk_Separator1";
            // 
            // btnMinimum
            // 
            this.btnMinimum.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnMinimum.Image = null;
            this.btnMinimum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimum.Location = new System.Drawing.Point(438, 5);
            this.btnMinimum.Name = "btnMinimum";
            this.btnMinimum.Size = new System.Drawing.Size(20, 20);
            this.btnMinimum.TabIndex = 47;
            this.btnMinimum.Text = "_";
            this.btnMinimum.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnMinimum.Click += new System.EventHandler(this.BtnMinimum_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnExit.Image = null;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(464, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 46;
            this.btnExit.Text = "X";
            this.btnExit.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lbl_Time
            // 
            this.lbl_Time.AutoSize = true;
            this.lbl_Time.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Time.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Time.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lbl_Time.Location = new System.Drawing.Point(377, 214);
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(0, 21);
            this.lbl_Time.TabIndex = 44;
            // 
            // btn_Check
            // 
            this.btn_Check.BackColor = System.Drawing.Color.Transparent;
            this.btn_Check.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Check.Image = null;
            this.btn_Check.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Check.Location = new System.Drawing.Point(314, 210);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(57, 25);
            this.btn_Check.TabIndex = 41;
            this.btn_Check.Text = "확인";
            this.btn_Check.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // iTalk_Label5
            // 
            this.iTalk_Label5.AutoSize = true;
            this.iTalk_Label5.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label5.ForeColor = System.Drawing.Color.Gray;
            this.iTalk_Label5.Location = new System.Drawing.Point(41, 210);
            this.iTalk_Label5.Name = "iTalk_Label5";
            this.iTalk_Label5.Size = new System.Drawing.Size(74, 21);
            this.iTalk_Label5.TabIndex = 38;
            this.iTalk_Label5.Text = "인증번호";
            // 
            // btn_Send
            // 
            this.btn_Send.BackColor = System.Drawing.Color.Transparent;
            this.btn_Send.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Send.Image = null;
            this.btn_Send.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Send.Location = new System.Drawing.Point(411, 147);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(57, 25);
            this.btn_Send.TabIndex = 36;
            this.btn_Send.Text = "발송";
            this.btn_Send.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // iTalk_Label2
            // 
            this.iTalk_Label2.AutoSize = true;
            this.iTalk_Label2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iTalk_Label2.ForeColor = System.Drawing.Color.Gray;
            this.iTalk_Label2.Location = new System.Drawing.Point(41, 146);
            this.iTalk_Label2.Name = "iTalk_Label2";
            this.iTalk_Label2.Size = new System.Drawing.Size(58, 21);
            this.iTalk_Label2.TabIndex = 34;
            this.iTalk_Label2.Text = "이메일";
            // 
            // iTalk_Label1
            // 
            this.iTalk_Label1.AutoSize = true;
            this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label1.Font = new System.Drawing.Font("맑은 고딕", 14F);
            this.iTalk_Label1.ForeColor = System.Drawing.Color.Green;
            this.iTalk_Label1.Location = new System.Drawing.Point(11, 29);
            this.iTalk_Label1.Name = "iTalk_Label1";
            this.iTalk_Label1.Size = new System.Drawing.Size(126, 25);
            this.iTalk_Label1.TabIndex = 32;
            this.iTalk_Label1.Text = "비밀번호변경";
            // 
            // FrmSendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(491, 330);
            this.Controls.Add(this.btn_Change);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.iTalk_Label3);
            this.Controls.Add(this.iTalk_Separator3);
            this.Controls.Add(this.iTalk_Separator2);
            this.Controls.Add(this.iTalk_Separator1);
            this.Controls.Add(this.btnMinimum);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lbl_Time);
            this.Controls.Add(this.btn_Check);
            this.Controls.Add(this.iTalk_Label5);
            this.Controls.Add(this.tb_Check);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.iTalk_Label2);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.iTalk_Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSendEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSendEmail";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private iTalk.iTalk_Button_1 btn_Check;
        private iTalk.iTalk_Label iTalk_Label5;
        private System.Windows.Forms.TextBox tb_Check;
        private iTalk.iTalk_Button_1 btn_Send;
        private iTalk.iTalk_Label iTalk_Label2;
        private System.Windows.Forms.TextBox tb_Email;
        private iTalk.iTalk_Label iTalk_Label1;
        private iTalk.iTalk_Label lbl_Time;
        private iTalk.iTalk_Button_1 btnMinimum;
        private iTalk.iTalk_Button_1 btnExit;
        private iTalk.iTalk_Separator iTalk_Separator1;
        private iTalk.iTalk_Separator iTalk_Separator2;
        private iTalk.iTalk_Separator iTalk_Separator3;
        private iTalk.iTalk_Label iTalk_Label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private iTalk.iTalk_Button_1 btn_Change;
    }
}