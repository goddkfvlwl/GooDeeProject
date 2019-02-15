namespace GoodeeProject
{
    partial class FrmCreateID
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
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.chk_Male = new System.Windows.Forms.CheckBox();
            this.chk_Female = new System.Windows.Forms.CheckBox();
            this.tb_Address = new System.Windows.Forms.TextBox();
            this.tb_AddressDetail = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.chk_ArmyN = new System.Windows.Forms.CheckBox();
            this.chk_ArmyY = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.tb_BirthDate = new System.Windows.Forms.TextBox();
            this.btnMinimum = new iTalk.iTalk_Button_1();
            this.btnExit = new iTalk.iTalk_Button_1();
            this.btn_CreateID = new iTalk.iTalk_Button_1();
            this.iTalk_Label11 = new iTalk.iTalk_Label();
            this.iTalk_Separator1 = new iTalk.iTalk_Separator();
            this.iTalk_Separator2 = new iTalk.iTalk_Separator();
            this.iTalk_Label5 = new iTalk.iTalk_Label();
            this.iTalk_Label2 = new iTalk.iTalk_Label();
            this.iTalk_Separator8 = new iTalk.iTalk_Separator();
            this.iTalk_Label10 = new iTalk.iTalk_Label();
            this.btn_Search = new iTalk.iTalk_Button_1();
            this.iTalk_Separator7 = new iTalk.iTalk_Separator();
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
            this.iTalk_Label1 = new iTalk.iTalk_Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Name
            // 
            this.tb_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Name.Location = new System.Drawing.Point(128, 200);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(94, 14);
            this.tb_Name.TabIndex = 3;
            // 
            // chk_Male
            // 
            this.chk_Male.AutoSize = true;
            this.chk_Male.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_Male.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chk_Male.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chk_Male.Location = new System.Drawing.Point(125, 321);
            this.chk_Male.Name = "chk_Male";
            this.chk_Male.Size = new System.Drawing.Size(37, 21);
            this.chk_Male.TabIndex = 63;
            this.chk_Male.Tag = "M";
            this.chk_Male.Text = "남";
            this.chk_Male.UseVisualStyleBackColor = true;
            this.chk_Male.CheckedChanged += new System.EventHandler(this.chk_Male_CheckedChanged);
            // 
            // chk_Female
            // 
            this.chk_Female.AutoSize = true;
            this.chk_Female.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_Female.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chk_Female.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chk_Female.Location = new System.Drawing.Point(182, 321);
            this.chk_Female.Name = "chk_Female";
            this.chk_Female.Size = new System.Drawing.Size(37, 21);
            this.chk_Female.TabIndex = 64;
            this.chk_Female.Tag = "F";
            this.chk_Female.Text = "여";
            this.chk_Female.UseVisualStyleBackColor = true;
            this.chk_Female.CheckedChanged += new System.EventHandler(this.chk_Female_CheckedChanged);
            // 
            // tb_Address
            // 
            this.tb_Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Address.Enabled = false;
            this.tb_Address.Location = new System.Drawing.Point(125, 372);
            this.tb_Address.Name = "tb_Address";
            this.tb_Address.Size = new System.Drawing.Size(246, 14);
            this.tb_Address.TabIndex = 6;
            // 
            // tb_AddressDetail
            // 
            this.tb_AddressDetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_AddressDetail.Location = new System.Drawing.Point(125, 401);
            this.tb_AddressDetail.Name = "tb_AddressDetail";
            this.tb_AddressDetail.Size = new System.Drawing.Size(306, 14);
            this.tb_AddressDetail.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Location = new System.Drawing.Point(314, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 140);
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tb_Password
            // 
            this.tb_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Password.Location = new System.Drawing.Point(125, 154);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(306, 14);
            this.tb_Password.TabIndex = 2;
            // 
            // tb_Email
            // 
            this.tb_Email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Email.Location = new System.Drawing.Point(125, 112);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(306, 14);
            this.tb_Email.TabIndex = 1;
            // 
            // chk_ArmyN
            // 
            this.chk_ArmyN.AutoSize = true;
            this.chk_ArmyN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chk_ArmyN.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chk_ArmyN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chk_ArmyN.Location = new System.Drawing.Point(182, 454);
            this.chk_ArmyN.Name = "chk_ArmyN";
            this.chk_ArmyN.Size = new System.Drawing.Size(50, 21);
            this.chk_ArmyN.TabIndex = 86;
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
            this.chk_ArmyY.Location = new System.Drawing.Point(125, 454);
            this.chk_ArmyY.Name = "chk_ArmyY";
            this.chk_ArmyY.Size = new System.Drawing.Size(50, 21);
            this.chk_ArmyY.TabIndex = 85;
            this.chk_ArmyY.Tag = "Y";
            this.chk_ArmyY.Text = "군필";
            this.chk_ArmyY.UseVisualStyleBackColor = true;
            this.chk_ArmyY.CheckedChanged += new System.EventHandler(this.chk_ArmyY_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tb_Phone
            // 
            this.tb_Phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Phone.Location = new System.Drawing.Point(128, 280);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(115, 14);
            this.tb_Phone.TabIndex = 5;
            // 
            // tb_BirthDate
            // 
            this.tb_BirthDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_BirthDate.Location = new System.Drawing.Point(125, 238);
            this.tb_BirthDate.Name = "tb_BirthDate";
            this.tb_BirthDate.Size = new System.Drawing.Size(65, 14);
            this.tb_BirthDate.TabIndex = 4;
            // 
            // btnMinimum
            // 
            this.btnMinimum.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimum.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMinimum.Image = null;
            this.btnMinimum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimum.Location = new System.Drawing.Point(422, 4);
            this.btnMinimum.Name = "btnMinimum";
            this.btnMinimum.Size = new System.Drawing.Size(20, 20);
            this.btnMinimum.TabIndex = 89;
            this.btnMinimum.Text = "_";
            this.btnMinimum.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnMinimum.Click += new System.EventHandler(this.BtnMinimum_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnExit.Image = null;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(448, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 88;
            this.btnExit.Text = "X";
            this.btnExit.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // btn_CreateID
            // 
            this.btn_CreateID.BackColor = System.Drawing.Color.Transparent;
            this.btn_CreateID.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_CreateID.Image = null;
            this.btn_CreateID.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_CreateID.Location = new System.Drawing.Point(194, 507);
            this.btn_CreateID.Name = "btn_CreateID";
            this.btn_CreateID.Size = new System.Drawing.Size(84, 31);
            this.btn_CreateID.TabIndex = 87;
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
            this.iTalk_Label11.Location = new System.Drawing.Point(250, 200);
            this.iTalk_Label11.Name = "iTalk_Label11";
            this.iTalk_Label11.Size = new System.Drawing.Size(42, 21);
            this.iTalk_Label11.TabIndex = 84;
            this.iTalk_Label11.Text = "사진";
            // 
            // iTalk_Separator1
            // 
            this.iTalk_Separator1.Location = new System.Drawing.Point(128, 166);
            this.iTalk_Separator1.Name = "iTalk_Separator1";
            this.iTalk_Separator1.Size = new System.Drawing.Size(303, 10);
            this.iTalk_Separator1.TabIndex = 83;
            this.iTalk_Separator1.Text = "iTalk_Separator1";
            // 
            // iTalk_Separator2
            // 
            this.iTalk_Separator2.Location = new System.Drawing.Point(128, 124);
            this.iTalk_Separator2.Name = "iTalk_Separator2";
            this.iTalk_Separator2.Size = new System.Drawing.Size(303, 10);
            this.iTalk_Separator2.TabIndex = 82;
            this.iTalk_Separator2.Text = "iTalk_Separator2";
            // 
            // iTalk_Label5
            // 
            this.iTalk_Label5.AutoSize = true;
            this.iTalk_Label5.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label5.ForeColor = System.Drawing.Color.Gray;
            this.iTalk_Label5.Location = new System.Drawing.Point(33, 152);
            this.iTalk_Label5.Name = "iTalk_Label5";
            this.iTalk_Label5.Size = new System.Drawing.Size(74, 21);
            this.iTalk_Label5.TabIndex = 81;
            this.iTalk_Label5.Text = "비밀번호";
            // 
            // iTalk_Label2
            // 
            this.iTalk_Label2.AutoSize = true;
            this.iTalk_Label2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iTalk_Label2.ForeColor = System.Drawing.Color.Gray;
            this.iTalk_Label2.Location = new System.Drawing.Point(33, 110);
            this.iTalk_Label2.Name = "iTalk_Label2";
            this.iTalk_Label2.Size = new System.Drawing.Size(58, 21);
            this.iTalk_Label2.TabIndex = 80;
            this.iTalk_Label2.Text = "이메일";
            // 
            // iTalk_Separator8
            // 
            this.iTalk_Separator8.Location = new System.Drawing.Point(128, 292);
            this.iTalk_Separator8.Name = "iTalk_Separator8";
            this.iTalk_Separator8.Size = new System.Drawing.Size(115, 10);
            this.iTalk_Separator8.TabIndex = 76;
            this.iTalk_Separator8.Text = "iTalk_Separator8";
            // 
            // iTalk_Label10
            // 
            this.iTalk_Label10.AutoSize = true;
            this.iTalk_Label10.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label10.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label10.ForeColor = System.Drawing.Color.Gray;
            this.iTalk_Label10.Location = new System.Drawing.Point(33, 454);
            this.iTalk_Label10.Name = "iTalk_Label10";
            this.iTalk_Label10.Size = new System.Drawing.Size(74, 21);
            this.iTalk_Label10.TabIndex = 74;
            this.iTalk_Label10.Text = "병역여부";
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.Transparent;
            this.btn_Search.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_Search.Image = null;
            this.btn_Search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Search.Location = new System.Drawing.Point(377, 371);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(57, 22);
            this.btn_Search.TabIndex = 73;
            this.btn_Search.Text = "검색";
            this.btn_Search.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // iTalk_Separator7
            // 
            this.iTalk_Separator7.Location = new System.Drawing.Point(0, 62);
            this.iTalk_Separator7.Name = "iTalk_Separator7";
            this.iTalk_Separator7.Size = new System.Drawing.Size(472, 10);
            this.iTalk_Separator7.TabIndex = 72;
            this.iTalk_Separator7.Text = "iTalk_Separator7";
            // 
            // iTalk_Label9
            // 
            this.iTalk_Label9.AutoSize = true;
            this.iTalk_Label9.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label9.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label9.ForeColor = System.Drawing.Color.Gray;
            this.iTalk_Label9.Location = new System.Drawing.Point(33, 401);
            this.iTalk_Label9.Name = "iTalk_Label9";
            this.iTalk_Label9.Size = new System.Drawing.Size(74, 21);
            this.iTalk_Label9.TabIndex = 71;
            this.iTalk_Label9.Text = "상세주소";
            // 
            // iTalk_Separator6
            // 
            this.iTalk_Separator6.Location = new System.Drawing.Point(125, 413);
            this.iTalk_Separator6.Name = "iTalk_Separator6";
            this.iTalk_Separator6.Size = new System.Drawing.Size(306, 10);
            this.iTalk_Separator6.TabIndex = 70;
            this.iTalk_Separator6.Text = "iTalk_Separator6";
            // 
            // iTalk_Separator5
            // 
            this.iTalk_Separator5.Location = new System.Drawing.Point(125, 384);
            this.iTalk_Separator5.Name = "iTalk_Separator5";
            this.iTalk_Separator5.Size = new System.Drawing.Size(246, 10);
            this.iTalk_Separator5.TabIndex = 68;
            this.iTalk_Separator5.Text = "iTalk_Separator5";
            // 
            // iTalk_Label8
            // 
            this.iTalk_Label8.AutoSize = true;
            this.iTalk_Label8.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label8.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label8.ForeColor = System.Drawing.Color.Gray;
            this.iTalk_Label8.Location = new System.Drawing.Point(33, 372);
            this.iTalk_Label8.Name = "iTalk_Label8";
            this.iTalk_Label8.Size = new System.Drawing.Size(42, 21);
            this.iTalk_Label8.TabIndex = 66;
            this.iTalk_Label8.Text = "주소";
            // 
            // iTalk_Label7
            // 
            this.iTalk_Label7.AutoSize = true;
            this.iTalk_Label7.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label7.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label7.ForeColor = System.Drawing.Color.Gray;
            this.iTalk_Label7.Location = new System.Drawing.Point(33, 280);
            this.iTalk_Label7.Name = "iTalk_Label7";
            this.iTalk_Label7.Size = new System.Drawing.Size(58, 21);
            this.iTalk_Label7.TabIndex = 65;
            this.iTalk_Label7.Text = "연락처";
            // 
            // iTalk_Label6
            // 
            this.iTalk_Label6.AutoSize = true;
            this.iTalk_Label6.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label6.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label6.ForeColor = System.Drawing.Color.Gray;
            this.iTalk_Label6.Location = new System.Drawing.Point(33, 319);
            this.iTalk_Label6.Name = "iTalk_Label6";
            this.iTalk_Label6.Size = new System.Drawing.Size(42, 21);
            this.iTalk_Label6.TabIndex = 62;
            this.iTalk_Label6.Text = "성별";
            // 
            // iTalk_Separator4
            // 
            this.iTalk_Separator4.Location = new System.Drawing.Point(125, 250);
            this.iTalk_Separator4.Name = "iTalk_Separator4";
            this.iTalk_Separator4.Size = new System.Drawing.Size(64, 10);
            this.iTalk_Separator4.TabIndex = 60;
            this.iTalk_Separator4.Text = "iTalk_Separator4";
            // 
            // iTalk_Label4
            // 
            this.iTalk_Label4.AutoSize = true;
            this.iTalk_Label4.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label4.ForeColor = System.Drawing.Color.Gray;
            this.iTalk_Label4.Location = new System.Drawing.Point(33, 238);
            this.iTalk_Label4.Name = "iTalk_Label4";
            this.iTalk_Label4.Size = new System.Drawing.Size(74, 21);
            this.iTalk_Label4.TabIndex = 58;
            this.iTalk_Label4.Text = "생년월일";
            // 
            // iTalk_Separator3
            // 
            this.iTalk_Separator3.Location = new System.Drawing.Point(128, 212);
            this.iTalk_Separator3.Name = "iTalk_Separator3";
            this.iTalk_Separator3.Size = new System.Drawing.Size(94, 10);
            this.iTalk_Separator3.TabIndex = 57;
            this.iTalk_Separator3.Text = "iTalk_Separator3";
            // 
            // iTalk_Label3
            // 
            this.iTalk_Label3.AutoSize = true;
            this.iTalk_Label3.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Label3.ForeColor = System.Drawing.Color.Gray;
            this.iTalk_Label3.Location = new System.Drawing.Point(33, 200);
            this.iTalk_Label3.Name = "iTalk_Label3";
            this.iTalk_Label3.Size = new System.Drawing.Size(42, 21);
            this.iTalk_Label3.TabIndex = 55;
            this.iTalk_Label3.Text = "이름";
            // 
            // iTalk_Label1
            // 
            this.iTalk_Label1.AutoSize = true;
            this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label1.Font = new System.Drawing.Font("맑은 고딕", 14F);
            this.iTalk_Label1.ForeColor = System.Drawing.Color.Green;
            this.iTalk_Label1.Location = new System.Drawing.Point(12, 34);
            this.iTalk_Label1.Name = "iTalk_Label1";
            this.iTalk_Label1.Size = new System.Drawing.Size(178, 25);
            this.iTalk_Label1.TabIndex = 33;
            this.iTalk_Label1.Text = "관리자 아이디 생성";
            // 
            // FrmCreateID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(472, 550);
            this.Controls.Add(this.tb_BirthDate);
            this.Controls.Add(this.btnMinimum);
            this.Controls.Add(this.btnExit);
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
            this.Controls.Add(this.iTalk_Separator7);
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
            this.Controls.Add(this.iTalk_Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCreateID";
            this.Text = "FrmCreateID";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Frm_BorderPaint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private iTalk.iTalk_Label iTalk_Label1;
        private iTalk.iTalk_Separator iTalk_Separator3;
        private System.Windows.Forms.TextBox tb_Name;
        private iTalk.iTalk_Label iTalk_Label3;
        private iTalk.iTalk_Separator iTalk_Separator4;
        private iTalk.iTalk_Label iTalk_Label4;
        private iTalk.iTalk_Label iTalk_Label6;
        private System.Windows.Forms.CheckBox chk_Male;
        private System.Windows.Forms.CheckBox chk_Female;
        private iTalk.iTalk_Label iTalk_Label7;
        private iTalk.iTalk_Label iTalk_Label8;
        private iTalk.iTalk_Separator iTalk_Separator5;
        private System.Windows.Forms.TextBox tb_Address;
        private iTalk.iTalk_Separator iTalk_Separator6;
        private System.Windows.Forms.TextBox tb_AddressDetail;
        private iTalk.iTalk_Label iTalk_Label9;
        private iTalk.iTalk_Separator iTalk_Separator7;
        private iTalk.iTalk_Button_1 btn_Search;
        private iTalk.iTalk_Separator iTalk_Separator8;
        private iTalk.iTalk_Label iTalk_Label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private iTalk.iTalk_Separator iTalk_Separator1;
        private System.Windows.Forms.TextBox tb_Password;
        private iTalk.iTalk_Separator iTalk_Separator2;
        private System.Windows.Forms.TextBox tb_Email;
        private iTalk.iTalk_Label iTalk_Label5;
        private iTalk.iTalk_Label iTalk_Label2;
        private iTalk.iTalk_Label iTalk_Label11;
        private System.Windows.Forms.CheckBox chk_ArmyN;
        private System.Windows.Forms.CheckBox chk_ArmyY;
        private iTalk.iTalk_Button_1 btn_CreateID;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private iTalk.iTalk_Button_1 btnMinimum;
        private iTalk.iTalk_Button_1 btnExit;
        private System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.TextBox tb_BirthDate;
    }
}