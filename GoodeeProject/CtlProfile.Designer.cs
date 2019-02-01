namespace GoodeeProject
{
    partial class CtlProfile
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
            this.pboxProFile = new System.Windows.Forms.PictureBox();
            this.lblName = new iTalk.iTalk_Label();
            this.lblEmailID = new iTalk.iTalk_Label();
            this.btnLogOut = new iTalk.iTalk_Button_1();
            this.btnModify = new iTalk.iTalk_Button_1();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCreateID = new iTalk.iTalk_Button_1();
            this.btnStudent = new iTalk.iTalk_Button_1();
            this.btnLog = new iTalk.iTalk_Button_1();
            ((System.ComponentModel.ISupportInitialize)(this.pboxProFile)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxProFile)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxProFile
            // 
            this.pboxProFile.Image = global::GoodeeProject.Properties.Resources.profile2;
            this.pboxProFile.Location = new System.Drawing.Point(15, 28);
            this.pboxProFile.Name = "pboxProFile";
            this.pboxProFile.Size = new System.Drawing.Size(60, 60);
            this.pboxProFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxProFile.TabIndex = 0;
            this.pboxProFile.TabStop = false;
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.lblName.ForeColor = System.Drawing.Color.Gray;
            this.lblName.Location = new System.Drawing.Point(96, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(31, 15);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "이름";
            // 
            // lblEmailID
            // 
            this.lblEmailID.AutoSize = true;
            this.lblEmailID.BackColor = System.Drawing.Color.Transparent;
            this.lblEmailID.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.lblEmailID.ForeColor = System.Drawing.Color.Gray;
            this.lblEmailID.Location = new System.Drawing.Point(96, 44);
            this.lblEmailID.Name = "lblEmailID";
            this.lblEmailID.Size = new System.Drawing.Size(79, 15);
            this.lblEmailID.TabIndex = 2;
            this.lblEmailID.Text = "이메일아이디";
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOut.Font = new System.Drawing.Font("맑은 고딕", 8F);
            this.btnLogOut.Image = null;
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(207, 3);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(62, 31);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "로그아웃";
            this.btnLogOut.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.Transparent;
            this.btnModify.Font = new System.Drawing.Font("맑은 고딕", 8F);
            this.btnModify.Image = null;
            this.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModify.Location = new System.Drawing.Point(139, 3);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(62, 31);
            this.btnModify.TabIndex = 4;
            this.btnModify.Text = "정보수정";
            this.btnModify.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnStudent);
            this.flowLayoutPanel1.Controls.Add(this.btnLog);
            this.flowLayoutPanel1.Controls.Add(this.btnModify);
            this.flowLayoutPanel1.Controls.Add(this.btnLogOut);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(88, 74);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(280, 34);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // btnCreateID
            // 
            this.btnCreateID.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateID.Font = new System.Drawing.Font("맑은 고딕", 8F);
            this.btnCreateID.Image = null;
            this.btnCreateID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateID.Location = new System.Drawing.Point(287, 3);
            this.btnCreateID.Name = "btnCreateID";
            this.btnCreateID.Size = new System.Drawing.Size(70, 31);
            this.btnCreateID.TabIndex = 7;
            this.btnCreateID.Text = "관리자생성";
            this.btnCreateID.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.Transparent;
            this.btnStudent.Font = new System.Drawing.Font("맑은 고딕", 8F);
            this.btnStudent.Image = null;
            this.btnStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudent.Location = new System.Drawing.Point(3, 3);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(62, 31);
            this.btnStudent.TabIndex = 7;
            this.btnStudent.Text = "수강생관리";
            this.btnStudent.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.Transparent;
            this.btnLog.Font = new System.Drawing.Font("맑은 고딕", 8F);
            this.btnLog.Image = null;
            this.btnLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLog.Location = new System.Drawing.Point(71, 3);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(62, 31);
            this.btnLog.TabIndex = 6;
            this.btnLog.Text = "로그관리";
            this.btnLog.TextAlignment = System.Drawing.StringAlignment.Center;
<<<<<<< HEAD
=======
            // 
            // btnCreateID
            // 
            this.btnCreateID.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateID.Font = new System.Drawing.Font("맑은 고딕", 8F);
            this.btnCreateID.Image = null;
            this.btnCreateID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateID.Location = new System.Drawing.Point(287, 3);
            this.btnCreateID.Name = "btnCreateID";
            this.btnCreateID.Size = new System.Drawing.Size(70, 31);
            this.btnCreateID.TabIndex = 7;
            this.btnCreateID.Text = "관리자생성";
            this.btnCreateID.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnCreateID.Click += new System.EventHandler(this.btnCreateID_Click);
            // 
            // pboxProFile
            // 
            this.pboxProFile.Image = global::GoodeeProject.Properties.Resources.profile2;
            this.pboxProFile.Location = new System.Drawing.Point(15, 28);
            this.pboxProFile.Name = "pboxProFile";
            this.pboxProFile.Size = new System.Drawing.Size(60, 60);
            this.pboxProFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxProFile.TabIndex = 0;
            this.pboxProFile.TabStop = false;
            // 
>>>>>>> dff3ca2507f7f8c5f71fd4e5ac373eb1bef8cdf8
            // CtlProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.Controls.Add(this.btnCreateID);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblEmailID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pboxProFile);
            this.Name = "CtlProfile";
            this.Size = new System.Drawing.Size(360, 111);
            this.Load += new System.EventHandler(this.CtlProfile_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxProFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox pboxProFile;
        internal iTalk.iTalk_Label lblName;
        internal iTalk.iTalk_Label lblEmailID;
        internal iTalk.iTalk_Button_1 btnLogOut;
        internal iTalk.iTalk_Button_1 btnModify;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        internal iTalk.iTalk_Button_1 btnStudent;
        internal iTalk.iTalk_Button_1 btnLog;
        internal iTalk.iTalk_Button_1 btnCreateID;
    }
}
