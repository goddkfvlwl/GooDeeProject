namespace GoodeeProject
{
    partial class CtlModifyMemberInfo
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
            this.btnSearhAddr = new iTalk.iTalk_Button_1();
            this.iTalk_Label1 = new iTalk.iTalk_Label();
            this.iTalk_Label3 = new iTalk.iTalk_Label();
            this.tboxAddr = new iTalk.iTalk_TextBox_Small();
            this.iTalk_Label4 = new iTalk.iTalk_Label();
            this.tboxDetailAddr = new iTalk.iTalk_TextBox_Small();
            this.btnModify = new iTalk.iTalk_Button_1();
            this.tboxHopePay = new iTalk.iTalk_TextBox_Small();
            this.iTalk_Label2 = new iTalk.iTalk_Label();
            this.tboxMobile = new iTalk.iTalk_TextBox_Small();
            this.btnPicture = new iTalk.iTalk_Button_1();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.iTalk_Label5 = new iTalk.iTalk_Label();
            this.pboxPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearhAddr
            // 
            this.btnSearhAddr.BackColor = System.Drawing.Color.Transparent;
            this.btnSearhAddr.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearhAddr.Image = null;
            this.btnSearhAddr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearhAddr.Location = new System.Drawing.Point(9, 258);
            this.btnSearhAddr.Name = "btnSearhAddr";
            this.btnSearhAddr.Size = new System.Drawing.Size(92, 32);
            this.btnSearhAddr.TabIndex = 0;
            this.btnSearhAddr.Text = "주소검색";
            this.btnSearhAddr.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSearhAddr.Click += new System.EventHandler(this.btnSearhAddr_Click);
            // 
            // iTalk_Label1
            // 
            this.iTalk_Label1.AutoSize = true;
            this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iTalk_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label1.Location = new System.Drawing.Point(25, 414);
            this.iTalk_Label1.Name = "iTalk_Label1";
            this.iTalk_Label1.Size = new System.Drawing.Size(74, 21);
            this.iTalk_Label1.TabIndex = 1;
            this.iTalk_Label1.Text = "희망연봉";
            // 
            // iTalk_Label3
            // 
            this.iTalk_Label3.AutoSize = true;
            this.iTalk_Label3.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iTalk_Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label3.Location = new System.Drawing.Point(57, 306);
            this.iTalk_Label3.Name = "iTalk_Label3";
            this.iTalk_Label3.Size = new System.Drawing.Size(42, 21);
            this.iTalk_Label3.TabIndex = 3;
            this.iTalk_Label3.Text = "주소";
            // 
            // tboxAddr
            // 
            this.tboxAddr.BackColor = System.Drawing.Color.Transparent;
            this.tboxAddr.Enabled = false;
            this.tboxAddr.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tboxAddr.ForeColor = System.Drawing.Color.DimGray;
            this.tboxAddr.Location = new System.Drawing.Point(105, 306);
            this.tboxAddr.MaxLength = 32767;
            this.tboxAddr.Multiline = false;
            this.tboxAddr.Name = "tboxAddr";
            this.tboxAddr.ReadOnly = false;
            this.tboxAddr.Size = new System.Drawing.Size(291, 28);
            this.tboxAddr.TabIndex = 4;
            this.tboxAddr.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tboxAddr.UseSystemPasswordChar = false;
            // 
            // iTalk_Label4
            // 
            this.iTalk_Label4.AutoSize = true;
            this.iTalk_Label4.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iTalk_Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label4.Location = new System.Drawing.Point(19, 340);
            this.iTalk_Label4.Name = "iTalk_Label4";
            this.iTalk_Label4.Size = new System.Drawing.Size(80, 21);
            this.iTalk_Label4.TabIndex = 5;
            this.iTalk_Label4.Text = "상세 주소";
            // 
            // tboxDetailAddr
            // 
            this.tboxDetailAddr.BackColor = System.Drawing.Color.Transparent;
            this.tboxDetailAddr.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tboxDetailAddr.ForeColor = System.Drawing.Color.DimGray;
            this.tboxDetailAddr.Location = new System.Drawing.Point(105, 340);
            this.tboxDetailAddr.MaxLength = 32767;
            this.tboxDetailAddr.Multiline = false;
            this.tboxDetailAddr.Name = "tboxDetailAddr";
            this.tboxDetailAddr.ReadOnly = false;
            this.tboxDetailAddr.Size = new System.Drawing.Size(291, 28);
            this.tboxDetailAddr.TabIndex = 6;
            this.tboxDetailAddr.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tboxDetailAddr.UseSystemPasswordChar = false;
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.Transparent;
            this.btnModify.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnModify.Image = null;
            this.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModify.Location = new System.Drawing.Point(154, 515);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(98, 30);
            this.btnModify.TabIndex = 7;
            this.btnModify.Text = "수정";
            this.btnModify.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // tboxHopePay
            // 
            this.tboxHopePay.BackColor = System.Drawing.Color.Transparent;
            this.tboxHopePay.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tboxHopePay.ForeColor = System.Drawing.Color.DimGray;
            this.tboxHopePay.Location = new System.Drawing.Point(105, 411);
            this.tboxHopePay.MaxLength = 32767;
            this.tboxHopePay.Multiline = false;
            this.tboxHopePay.Name = "tboxHopePay";
            this.tboxHopePay.ReadOnly = false;
            this.tboxHopePay.Size = new System.Drawing.Size(161, 28);
            this.tboxHopePay.TabIndex = 8;
            this.tboxHopePay.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tboxHopePay.UseSystemPasswordChar = false;
            // 
            // iTalk_Label2
            // 
            this.iTalk_Label2.AutoSize = true;
            this.iTalk_Label2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iTalk_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label2.Location = new System.Drawing.Point(3, 202);
            this.iTalk_Label2.Name = "iTalk_Label2";
            this.iTalk_Label2.Size = new System.Drawing.Size(96, 21);
            this.iTalk_Label2.TabIndex = 9;
            this.iTalk_Label2.Text = "핸드폰 번호";
            // 
            // tboxMobile
            // 
            this.tboxMobile.BackColor = System.Drawing.Color.Transparent;
            this.tboxMobile.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tboxMobile.ForeColor = System.Drawing.Color.DimGray;
            this.tboxMobile.Location = new System.Drawing.Point(105, 202);
            this.tboxMobile.MaxLength = 32767;
            this.tboxMobile.Multiline = false;
            this.tboxMobile.Name = "tboxMobile";
            this.tboxMobile.ReadOnly = false;
            this.tboxMobile.Size = new System.Drawing.Size(269, 28);
            this.tboxMobile.TabIndex = 10;
            this.tboxMobile.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tboxMobile.UseSystemPasswordChar = false;
            // 
            // btnPicture
            // 
            this.btnPicture.BackColor = System.Drawing.Color.Transparent;
            this.btnPicture.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPicture.Image = null;
            this.btnPicture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPicture.Location = new System.Drawing.Point(173, 130);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(92, 32);
            this.btnPicture.TabIndex = 12;
            this.btnPicture.Text = "찾아보기";
            this.btnPicture.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // iTalk_Label5
            // 
            this.iTalk_Label5.AutoSize = true;
            this.iTalk_Label5.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iTalk_Label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iTalk_Label5.Location = new System.Drawing.Point(87, 476);
            this.iTalk_Label5.Name = "iTalk_Label5";
            this.iTalk_Label5.Size = new System.Drawing.Size(229, 15);
            this.iTalk_Label5.TabIndex = 13;
            this.iTalk_Label5.Text = "핸드폰번호, 주소는 필수기재사항 입니다.";
            // 
            // pboxPic
            // 
            this.pboxPic.BackColor = System.Drawing.Color.DarkGray;
            this.pboxPic.Location = new System.Drawing.Point(9, 15);
            this.pboxPic.Name = "pboxPic";
            this.pboxPic.Size = new System.Drawing.Size(132, 147);
            this.pboxPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxPic.TabIndex = 11;
            this.pboxPic.TabStop = false;
            // 
            // CtlModifyMemberInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.iTalk_Label5);
            this.Controls.Add(this.btnPicture);
            this.Controls.Add(this.pboxPic);
            this.Controls.Add(this.tboxMobile);
            this.Controls.Add(this.iTalk_Label2);
            this.Controls.Add(this.tboxHopePay);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.tboxDetailAddr);
            this.Controls.Add(this.iTalk_Label4);
            this.Controls.Add(this.tboxAddr);
            this.Controls.Add(this.iTalk_Label3);
            this.Controls.Add(this.iTalk_Label1);
            this.Controls.Add(this.btnSearhAddr);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CtlModifyMemberInfo";
            this.Size = new System.Drawing.Size(399, 571);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CtlModifyMemberInfo_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pboxPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private iTalk.iTalk_Button_1 btnSearhAddr;
        private iTalk.iTalk_Label iTalk_Label1;
        private iTalk.iTalk_Label iTalk_Label3;
        private iTalk.iTalk_Label iTalk_Label4;
        private iTalk.iTalk_Button_1 btnModify;
        private iTalk.iTalk_TextBox_Small tboxHopePay;
        private iTalk.iTalk_Label iTalk_Label2;
        private iTalk.iTalk_TextBox_Small tboxMobile;
        private iTalk.iTalk_Button_1 btnPicture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        internal iTalk.iTalk_TextBox_Small tboxAddr;
        internal iTalk.iTalk_TextBox_Small tboxDetailAddr;
        private iTalk.iTalk_Label iTalk_Label5;
        private System.Windows.Forms.PictureBox pboxPic;
    }
}
