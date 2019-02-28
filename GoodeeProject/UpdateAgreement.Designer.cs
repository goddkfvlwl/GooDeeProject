namespace GoodeeProject
{
    partial class UpdateAgreement
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
            this.save = new iTalk.iTalk_Button_1();
            this.boardBoby = new System.Windows.Forms.RichTextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.iTalk_Button_13 = new iTalk.iTalk_Button_1();
            this.MedioButton = new iTalk.iTalk_Button_1();
            this.iTalk_Label1 = new iTalk.iTalk_Label();
            this.ColorButton = new iTalk.iTalk_Button_1();
            this.FontButton = new iTalk.iTalk_Button_1();
            this.picAdd = new iTalk.iTalk_Button_1();
            this.iTalk_Label2 = new iTalk.iTalk_Label();
            this.iTalk_HeaderLabel1 = new iTalk.iTalk_HeaderLabel();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Transparent;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Image = null;
            this.save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save.Location = new System.Drawing.Point(734, 405);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(56, 24);
            this.save.TabIndex = 44;
            this.save.Text = "글 수정";
            this.save.TextAlignment = System.Drawing.StringAlignment.Center;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // boardBoby
            // 
            this.boardBoby.Location = new System.Drawing.Point(12, 180);
            this.boardBoby.Name = "boardBoby";
            this.boardBoby.Size = new System.Drawing.Size(778, 213);
            this.boardBoby.TabIndex = 43;
            this.boardBoby.Text = "";
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(118, 68);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(227, 14);
            this.txtTitle.TabIndex = 42;
            // 
            // iTalk_Button_13
            // 
            this.iTalk_Button_13.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Button_13.Image = null;
            this.iTalk_Button_13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_13.Location = new System.Drawing.Point(289, 101);
            this.iTalk_Button_13.Name = "iTalk_Button_13";
            this.iTalk_Button_13.Size = new System.Drawing.Size(56, 24);
            this.iTalk_Button_13.TabIndex = 41;
            this.iTalk_Button_13.Text = "파일";
            this.iTalk_Button_13.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // MedioButton
            // 
            this.MedioButton.BackColor = System.Drawing.Color.Transparent;
            this.MedioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedioButton.Image = null;
            this.MedioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MedioButton.Location = new System.Drawing.Point(202, 101);
            this.MedioButton.Name = "MedioButton";
            this.MedioButton.Size = new System.Drawing.Size(56, 24);
            this.MedioButton.TabIndex = 40;
            this.MedioButton.Text = "동영상";
            this.MedioButton.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // iTalk_Label1
            // 
            this.iTalk_Label1.AutoSize = true;
            this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label1.Location = new System.Drawing.Point(31, 106);
            this.iTalk_Label1.Name = "iTalk_Label1";
            this.iTalk_Label1.Size = new System.Drawing.Size(51, 13);
            this.iTalk_Label1.TabIndex = 39;
            this.iTalk_Label1.Text = "파일첨부";
            // 
            // ColorButton
            // 
            this.ColorButton.BackColor = System.Drawing.Color.Transparent;
            this.ColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorButton.Image = null;
            this.ColorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ColorButton.Location = new System.Drawing.Point(118, 142);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(56, 24);
            this.ColorButton.TabIndex = 38;
            this.ColorButton.Text = "색상";
            this.ColorButton.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // FontButton
            // 
            this.FontButton.BackColor = System.Drawing.Color.Transparent;
            this.FontButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontButton.Image = null;
            this.FontButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FontButton.Location = new System.Drawing.Point(28, 142);
            this.FontButton.Name = "FontButton";
            this.FontButton.Size = new System.Drawing.Size(56, 24);
            this.FontButton.TabIndex = 37;
            this.FontButton.Text = "글씨";
            this.FontButton.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // picAdd
            // 
            this.picAdd.BackColor = System.Drawing.Color.Transparent;
            this.picAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picAdd.Image = null;
            this.picAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.picAdd.Location = new System.Drawing.Point(118, 101);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(56, 24);
            this.picAdd.TabIndex = 36;
            this.picAdd.Text = "사진";
            this.picAdd.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // iTalk_Label2
            // 
            this.iTalk_Label2.AutoSize = true;
            this.iTalk_Label2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label2.Location = new System.Drawing.Point(31, 69);
            this.iTalk_Label2.Name = "iTalk_Label2";
            this.iTalk_Label2.Size = new System.Drawing.Size(32, 13);
            this.iTalk_Label2.TabIndex = 35;
            this.iTalk_Label2.Text = "제 목";
            // 
            // iTalk_HeaderLabel1
            // 
            this.iTalk_HeaderLabel1.AutoSize = true;
            this.iTalk_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iTalk_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.iTalk_HeaderLabel1.Location = new System.Drawing.Point(22, 16);
            this.iTalk_HeaderLabel1.Name = "iTalk_HeaderLabel1";
            this.iTalk_HeaderLabel1.Size = new System.Drawing.Size(124, 25);
            this.iTalk_HeaderLabel1.TabIndex = 34;
            this.iTalk_HeaderLabel1.Text = "협약기업게시판";
            // 
            // UpdateAgreement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.save);
            this.Controls.Add(this.boardBoby);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.iTalk_Button_13);
            this.Controls.Add(this.MedioButton);
            this.Controls.Add(this.iTalk_Label1);
            this.Controls.Add(this.ColorButton);
            this.Controls.Add(this.FontButton);
            this.Controls.Add(this.picAdd);
            this.Controls.Add(this.iTalk_Label2);
            this.Controls.Add(this.iTalk_HeaderLabel1);
            this.Name = "UpdateAgreement";
            this.Size = new System.Drawing.Size(803, 445);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private iTalk.iTalk_Button_1 save;
        private System.Windows.Forms.RichTextBox boardBoby;
        private System.Windows.Forms.TextBox txtTitle;
        private iTalk.iTalk_Button_1 iTalk_Button_13;
        private iTalk.iTalk_Button_1 MedioButton;
        private iTalk.iTalk_Label iTalk_Label1;
        private iTalk.iTalk_Button_1 ColorButton;
        private iTalk.iTalk_Button_1 FontButton;
        private iTalk.iTalk_Button_1 picAdd;
        private iTalk.iTalk_Label iTalk_Label2;
        private iTalk.iTalk_HeaderLabel iTalk_HeaderLabel1;
    }
}
