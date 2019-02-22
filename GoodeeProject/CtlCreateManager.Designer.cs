namespace GoodeeProject
{
    partial class CtlCreateManager
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
            this.tb_BirthDate = new System.Windows.Forms.TextBox();
            this.chk_ArmyN = new System.Windows.Forms.CheckBox();
            this.chk_ArmyY = new System.Windows.Forms.CheckBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.tb_AddressDetail = new System.Windows.Forms.TextBox();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.chk_Female = new System.Windows.Forms.CheckBox();
            this.chk_Male = new System.Windows.Forms.CheckBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_CreateID = new iTalk.iTalk_Button_1();
            this.iTalk_Label11 = new iTalk.iTalk_Label();
            this.iTalk_Separator1 = new iTalk.iTalk_Separator();
            this.iTalk_Separator2 = new iTalk.iTalk_Separator();
            this.iTalk_Label5 = new iTalk.iTalk_Label();
            this.iTalk_Label2 = new iTalk.iTalk_Label();
            this.iTalk_Separator8 = new iTalk.iTalk_Separator();
            this.iTalk_Label10 = new iTalk.iTalk_Label();
            this.btn_Search = new iTalk.iTalk_Button_1();
            this.iTalk_Label9 = new iTalk.iTalk_Label();
            this.iTalk_Separator6 = new iTalk.iTalk_Separator();
            this.iTalk_Separator5 = new iTalk.iTalk_Separator();
            this.iTalk_Label8 = new iTalk.iTalk_Label();
            this.iTalk_Label7 = new iTalk.iTalk_Label();
            this.iTalk_Label6 = new iTalk.iTalk_Label();
            this.iTalk_Separator4 = new iTalk.iTalk_Separator();
            this.iTalk_Label4 = new iTalk.iTalk_Label();
            this.iTalk_Separator3 = new iTalk.iTalk_Separator();
            this.iTalk_Label3 = new iTalk.iTalk_Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_BirthDate
            // 
            this.tb_BirthDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_BirthDate.Location = new System.Drawing.Point(128, 159);
            this.tb_BirthDate.Name = "tb_BirthDate";
            this.tb_BirthDate.Size = new System.Drawing.Size(65, 14);
            this.tb_BirthDate.TabIndex = 124;
            this.tb_BirthDate.TextChanged += new System.EventHandler(this.tb_BirthDate_TextChanged);
            // 
            // chk_ArmyN
            // 
            this.chk_ArmyN.AutoSize = true;
            this.chk_ArmyN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_ArmyN.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chk_ArmyN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chk_ArmyN.Location = new System.Drawing.Point(185, 375);
            this.chk_ArmyN.Name = "chk_ArmyN";
            this.chk_ArmyN.Size = new System.Drawing.Size(50, 21);
            this.chk_ArmyN.TabIndex = 150;
            this.chk_ArmyN.Tag = "N";
            this.chk_ArmyN.Text = "미필";
            this.chk_ArmyN.UseVisualStyleBackColor = true;
            this.chk_ArmyN.CheckedChanged += new System.EventHandler(this.chk_ArmyN_CheckedChanged);
            // 
            // chk_ArmyY
            // 
            this.chk_ArmyY.AutoSize = true;
            this.chk_ArmyY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_ArmyY.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chk_ArmyY.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chk_ArmyY.Location = new System.Drawing.Point(128, 375);
            this.chk_ArmyY.Name = "chk_ArmyY";
            this.chk_ArmyY.Size = new System.Drawing.Size(50, 21);
            this.chk_ArmyY.TabIndex = 149;
            this.chk_ArmyY.Tag = "Y";
            this.chk_ArmyY.Text = "군필";
            this.chk_ArmyY.UseVisualStyleBackColor = true;
            this.chk_ArmyY.CheckedChanged += new System.EventHandler(this.chk_ArmyY_CheckedChanged);
            // 
            // tb_Password
            // 
            this.tb_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Password.Location = new System.Drawing.Point(128, 75);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(306, 14);
            this.tb_Password.TabIndex = 122;
            // 
            // tb_Email
            // 
            this.tb_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Email.Location = new System.Drawing.Point(128, 33);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(306, 14);
            this.tb_Email.TabIndex = 121;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Location = new System.Drawing.Point(317, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 140);
            this.pictureBox1.TabIndex = 143;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tb_Phone
            // 
            this.tb_Phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Phone.Location = new System.Drawing.Point(131, 201);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(115, 14);
            this.tb_Phone.TabIndex = 125;
            // 
            // tb_AddressDetail
            // 
            this.tb_AddressDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_AddressDetail.Location = new System.Drawing.Point(128, 322);
            this.tb_AddressDetail.Name = "tb_AddressDetail";
            this.tb_AddressDetail.Size = new System.Drawing.Size(306, 14);
            this.tb_AddressDetail.TabIndex = 127;
            // 
            // tb_Address
            // 
            this.tb_Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Address.Enabled = false;
            this.tb_Address.Location = new System.Drawing.Point(128, 293);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(246, 14);
            this.tb_Address.TabIndex = 126;
            // 
            // chk_Female
            // 
            this.chk_Female.AutoSize = true;
            this.chk_Female.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_Female.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chk_Female.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chk_Female.Location = new System.Drawing.Point(185, 242);
            this.chk_Female.Name = "chk_Female";
            this.chk_Female.Size = new System.Drawing.Size(37, 21);
            this.chk_Female.TabIndex = 134;
            this.chk_Female.Tag = "F";
            this.chk_Female.Text = "여";
            this.chk_Female.UseVisualStyleBackColor = true;
            this.chk_Female.CheckedChanged += new System.EventHandler(this.chk_Female_CheckedChanged);
            // 
            // chk_Male
            // 
            this.chk_Male.AutoSize = true;
            this.chk_Male.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_Male.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chk_Male.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chk_Male.Location = new System.Drawing.Point(128, 242);
            this.chk_Male.Name = "chk_Male";
            this.chk_Male.Size = new System.Drawing.Size(37, 21);
            this.chk_Male.TabIndex = 133;
            this.chk_Male.Tag = "M";
            this.chk_Male.Text = "남";
            this.chk_Male.UseVisualStyleBackColor = true;
            this.chk_Male.CheckedChanged += new System.EventHandler(this.chk_Male_CheckedChanged);
            // 
            // tb_Name
            // 
            this.tb_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Name.Location = new System.Drawing.Point(131, 121);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(94, 14);
            this.tb_Name.TabIndex = 123;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_CreateID
            // 
            this.btn_CreateID.BackColor = System.Drawing.Color.Transparent;
            this.btn_CreateID.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_CreateID.Image = null;
            this.btn_CreateID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CreateID.Location = new System.Drawing.Point(197, 428);
            this.btn_CreateID.Name = "btn_CreateID";
            this.btn_CreateID.Size = new System.Drawing.Size(84, 31);
            this.btn_CreateID.TabIndex = 151;
            this.btn_CreateID.Text = "생성";
            this.btn_CreateID.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_CreateID.Click += new System.EventHandler(this.btn_CreateID_Click);
            // 
            // iTalk_Label11
            // 
            this.iTalk_Label11.AutoSize = true;
            this.iTalk_Label11.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label11.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label11.ForeColor = System.Drawing.Color.Gray;
            this.iTalk_Label11.Location = new System.Drawing.Point(253, 121);
            this.iTalk_Label11.Name = "iTalk_Label11";
            this.iTalk_Label11.Size = new System.Drawing.Size(42, 21);
            this.iTalk_Label11.TabIndex = 148;
            this.iTalk_Label11.Text = "사진";
            // 
            // iTalk_Separator1
            // 
            this.iTalk_Separator1.Location = new System.Drawing.Point(131, 87);
            this.iTalk_Separator1.Name = "iTalk_Separator1";
            this.iTalk_Separator1.Size = new System.Drawing.Size(303, 10);
            this.iTalk_Separator1.TabIndex = 147;
            this.iTalk_Separator1.Text = "iTalk_Separator1";
            // 
            // iTalk_Separator2
            // 
            this.iTalk_Separator2.Location = new System.Drawing.Point(131, 45);
            this.iTalk_Separator2.Name = "iTalk_Separator2";
            this.iTalk_Separator2.Size = new System.Drawing.Size(303, 10);
            this.iTalk_Separator2.TabIndex = 146;
            this.iTalk_Separator2.Text = "iTalk_Separator2";
            // 
            // iTalk_Label5
            // 
            this.iTalk_Label5.AutoSize = true;
            this.iTalk_Label5.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label5.ForeColor = System.Drawing.Color.Gray;
            this.iTalk_Label5.Location = new System.Drawing.Point(36, 73);
            this.iTalk_Label5.Name = "iTalk_Label5";
            this.iTalk_Label5.Size = new System.Drawing.Size(74, 21);
            this.iTalk_Label5.TabIndex = 145;
            this.iTalk_Label5.Text = "비밀번호";
            // 
            // iTalk_Label2
            // 
            this.iTalk_Label2.AutoSize = true;
            this.iTalk_Label2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iTalk_Label2.ForeColor = System.Drawing.Color.Gray;
            this.iTalk_Label2.Location = new System.Drawing.Point(36, 31);
            this.iTalk_Label2.Name = "iTalk_Label2";
            this.iTalk_Label2.Size = new System.Drawing.Size(58, 21);
            this.iTalk_Label2.TabIndex = 144;
            this.iTalk_Label2.Text = "이메일";
            // 
            // iTalk_Separator8
            // 
            this.iTalk_Separator8.Location = new System.Drawing.Point(131, 213);
            this.iTalk_Separator8.Name = "iTalk_Separator8";
            this.iTalk_Separator8.Size = new System.Drawing.Size(115, 10);
            this.iTalk_Separator8.TabIndex = 142;
            this.iTalk_Separator8.Text = "iTalk_Separator8";
            // 
            // iTalk_Label10
            // 
            this.iTalk_Label10.AutoSize = true;
            this.iTalk_Label10.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label10.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label10.ForeColor = System.Drawing.Color.Gray;
            this.iTalk_Label10.Location = new System.Drawing.Point(36, 375);
            this.iTalk_Label10.Name = "iTalk_Label10";
            this.iTalk_Label10.Size = new System.Drawing.Size(74, 21);
            this.iTalk_Label10.TabIndex = 141;
            this.iTalk_Label10.Text = "병역여부";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Transparent;
            this.btn_Search.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Search.Image = null;
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(380, 293);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(57, 22);
            this.btn_Search.TabIndex = 140;
            this.btn_Search.Text = "검색";
            this.btn_Search.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // iTalk_Label9
            // 
            this.iTalk_Label9.AutoSize = true;
            this.iTalk_Label9.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label9.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label9.ForeColor = System.Drawing.Color.Gray;
            this.iTalk_Label9.Location = new System.Drawing.Point(36, 322);
            this.iTalk_Label9.Name = "iTalk_Label9";
            this.iTalk_Label9.Size = new System.Drawing.Size(74, 21);
            this.iTalk_Label9.TabIndex = 139;
            this.iTalk_Label9.Text = "상세주소";
            // 
            // iTalk_Separator6
            // 
            this.iTalk_Separator6.Location = new System.Drawing.Point(128, 334);
            this.iTalk_Separator6.Name = "iTalk_Separator6";
            this.iTalk_Separator6.Size = new System.Drawing.Size(306, 10);
            this.iTalk_Separator6.TabIndex = 138;
            this.iTalk_Separator6.Text = "iTalk_Separator6";
            // 
            // iTalk_Separator5
            // 
            this.iTalk_Separator5.Location = new System.Drawing.Point(128, 305);
            this.iTalk_Separator5.Name = "iTalk_Separator5";
            this.iTalk_Separator5.Size = new System.Drawing.Size(246, 10);
            this.iTalk_Separator5.TabIndex = 137;
            this.iTalk_Separator5.Text = "iTalk_Separator5";
            // 
            // iTalk_Label8
            // 
            this.iTalk_Label8.AutoSize = true;
            this.iTalk_Label8.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label8.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label8.ForeColor = System.Drawing.Color.Gray;
            this.iTalk_Label8.Location = new System.Drawing.Point(36, 286);
            this.iTalk_Label8.Name = "iTalk_Label8";
            this.iTalk_Label8.Size = new System.Drawing.Size(42, 21);
            this.iTalk_Label8.TabIndex = 136;
            this.iTalk_Label8.Text = "주소";
            // 
            // iTalk_Label7
            // 
            this.iTalk_Label7.AutoSize = true;
            this.iTalk_Label7.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label7.ForeColor = System.Drawing.Color.Gray;
            this.iTalk_Label7.Location = new System.Drawing.Point(36, 201);
            this.iTalk_Label7.Name = "iTalk_Label7";
            this.iTalk_Label7.Size = new System.Drawing.Size(58, 21);
            this.iTalk_Label7.TabIndex = 135;
            this.iTalk_Label7.Text = "연락처";
            // 
            // iTalk_Label6
            // 
            this.iTalk_Label6.AutoSize = true;
            this.iTalk_Label6.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label6.ForeColor = System.Drawing.Color.Gray;
            this.iTalk_Label6.Location = new System.Drawing.Point(36, 242);
            this.iTalk_Label6.Name = "iTalk_Label6";
            this.iTalk_Label6.Size = new System.Drawing.Size(42, 21);
            this.iTalk_Label6.TabIndex = 132;
            this.iTalk_Label6.Text = "성별";
            // 
            // iTalk_Separator4
            // 
            this.iTalk_Separator4.Location = new System.Drawing.Point(128, 171);
            this.iTalk_Separator4.Name = "iTalk_Separator4";
            this.iTalk_Separator4.Size = new System.Drawing.Size(64, 10);
            this.iTalk_Separator4.TabIndex = 131;
            this.iTalk_Separator4.Text = "iTalk_Separator4";
            // 
            // iTalk_Label4
            // 
            this.iTalk_Label4.AutoSize = true;
            this.iTalk_Label4.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label4.ForeColor = System.Drawing.Color.Gray;
            this.iTalk_Label4.Location = new System.Drawing.Point(36, 159);
            this.iTalk_Label4.Name = "iTalk_Label4";
            this.iTalk_Label4.Size = new System.Drawing.Size(74, 21);
            this.iTalk_Label4.TabIndex = 130;
            this.iTalk_Label4.Text = "생년월일";
            // 
            // iTalk_Separator3
            // 
            this.iTalk_Separator3.Location = new System.Drawing.Point(131, 133);
            this.iTalk_Separator3.Name = "iTalk_Separator3";
            this.iTalk_Separator3.Size = new System.Drawing.Size(94, 10);
            this.iTalk_Separator3.TabIndex = 129;
            this.iTalk_Separator3.Text = "iTalk_Separator3";
            // 
            // iTalk_Label3
            // 
            this.iTalk_Label3.AutoSize = true;
            this.iTalk_Label3.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label3.ForeColor = System.Drawing.Color.Gray;
            this.iTalk_Label3.Location = new System.Drawing.Point(36, 121);
            this.iTalk_Label3.Name = "iTalk_Label3";
            this.iTalk_Label3.Size = new System.Drawing.Size(42, 21);
            this.iTalk_Label3.TabIndex = 128;
            this.iTalk_Label3.Text = "이름";
            // 
            // CtlCreateManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tb_BirthDate);
            this.Controls.Add(this.btn_CreateID);
            this.Controls.Add(this.chk_ArmyN);
            this.Controls.Add(this.chk_ArmyY);
            this.Controls.Add(this.iTalk_Label11);
            this.Controls.Add(this.iTalk_Separator1);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.iTalk_Separator2);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.iTalk_Label5);
            this.Controls.Add(this.iTalk_Label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.iTalk_Separator8);
            this.Controls.Add(this.tb_Phone);
            this.Controls.Add(this.iTalk_Label10);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.iTalk_Label9);
            this.Controls.Add(this.iTalk_Separator6);
            this.Controls.Add(this.tb_AddressDetail);
            this.Controls.Add(this.iTalk_Separator5);
            this.Controls.Add(this.tb_Address);
            this.Controls.Add(this.iTalk_Label8);
            this.Controls.Add(this.iTalk_Label7);
            this.Controls.Add(this.chk_Female);
            this.Controls.Add(this.chk_Male);
            this.Controls.Add(this.iTalk_Label6);
            this.Controls.Add(this.iTalk_Separator4);
            this.Controls.Add(this.iTalk_Label4);
            this.Controls.Add(this.iTalk_Separator3);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.iTalk_Label3);
            this.Name = "CtlCreateManager";
            this.Size = new System.Drawing.Size(472, 490);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_BirthDate;
        private iTalk.iTalk_Button_1 btn_CreateID;
        private System.Windows.Forms.CheckBox chk_ArmyN;
        private System.Windows.Forms.CheckBox chk_ArmyY;
        private iTalk.iTalk_Label iTalk_Label11;
        private iTalk.iTalk_Separator iTalk_Separator1;
        private System.Windows.Forms.TextBox tb_Password;
        private iTalk.iTalk_Separator iTalk_Separator2;
        private System.Windows.Forms.TextBox tb_Email;
        private iTalk.iTalk_Label iTalk_Label5;
        private iTalk.iTalk_Label iTalk_Label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private iTalk.iTalk_Separator iTalk_Separator8;
        private System.Windows.Forms.TextBox tb_Phone;
        private iTalk.iTalk_Label iTalk_Label10;
        private iTalk.iTalk_Button_1 btn_Search;
        private iTalk.iTalk_Label iTalk_Label9;
        private iTalk.iTalk_Separator iTalk_Separator6;
        private System.Windows.Forms.TextBox tb_AddressDetail;
        private iTalk.iTalk_Separator iTalk_Separator5;
        private System.Windows.Forms.TextBox tb_Address;
        private iTalk.iTalk_Label iTalk_Label8;
        private iTalk.iTalk_Label iTalk_Label7;
        private System.Windows.Forms.CheckBox chk_Female;
        private System.Windows.Forms.CheckBox chk_Male;
        private iTalk.iTalk_Label iTalk_Label6;
        private iTalk.iTalk_Separator iTalk_Separator4;
        private iTalk.iTalk_Label iTalk_Label4;
        private iTalk.iTalk_Separator iTalk_Separator3;
        private System.Windows.Forms.TextBox tb_Name;
        private iTalk.iTalk_Label iTalk_Label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
