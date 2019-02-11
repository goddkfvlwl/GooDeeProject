namespace GoodeeProject
{
    partial class Agreement_enterprise
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.boardBoby = new System.Windows.Forms.RichTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.attachments = new iTalk.iTalk_ComboBox();
            this.iTalk_Label3 = new iTalk.iTalk_Label();
            this.iTalk_Button_13 = new iTalk.iTalk_Button_1();
            this.MedioButton = new iTalk.iTalk_Button_1();
            this.iTalk_Label1 = new iTalk.iTalk_Label();
            this.iTalk_HeaderLabel1 = new iTalk.iTalk_HeaderLabel();
            this.ColorButton = new iTalk.iTalk_Button_1();
            this.FontButton = new iTalk.iTalk_Button_1();
            this.save = new iTalk.iTalk_Button_1();
            this.picAdd = new iTalk.iTalk_Button_1();
            this.Title = new iTalk.iTalk_TextBox_Small();
            this.iTalk_Label2 = new iTalk.iTalk_Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // boardBoby
            // 
            this.boardBoby.Location = new System.Drawing.Point(22, 167);
            this.boardBoby.Name = "boardBoby";
            this.boardBoby.Size = new System.Drawing.Size(764, 201);
            this.boardBoby.TabIndex = 15;
            this.boardBoby.Text = "";
            // 
            // attachments
            // 
            this.attachments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.attachments.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.attachments.DropDownHeight = 100;
            this.attachments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.attachments.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.attachments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.attachments.FormattingEnabled = true;
            this.attachments.HoverSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.attachments.IntegralHeight = false;
            this.attachments.ItemHeight = 20;
            this.attachments.Location = new System.Drawing.Point(79, 374);
            this.attachments.Name = "attachments";
            this.attachments.Size = new System.Drawing.Size(707, 26);
            this.attachments.StartIndex = 0;
            this.attachments.TabIndex = 27;
            // 
            // iTalk_Label3
            // 
            this.iTalk_Label3.AutoSize = true;
            this.iTalk_Label3.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label3.Location = new System.Drawing.Point(22, 380);
            this.iTalk_Label3.Name = "iTalk_Label3";
            this.iTalk_Label3.Size = new System.Drawing.Size(51, 13);
            this.iTalk_Label3.TabIndex = 24;
            this.iTalk_Label3.Text = "첨부파일";
            // 
            // iTalk_Button_13
            // 
            this.iTalk_Button_13.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_13.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Button_13.Image = null;
            this.iTalk_Button_13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_13.Location = new System.Drawing.Point(283, 94);
            this.iTalk_Button_13.Name = "iTalk_Button_13";
            this.iTalk_Button_13.Size = new System.Drawing.Size(56, 24);
            this.iTalk_Button_13.TabIndex = 22;
            this.iTalk_Button_13.Text = "파일";
            this.iTalk_Button_13.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // MedioButton
            // 
            this.MedioButton.BackColor = System.Drawing.Color.Transparent;
            this.MedioButton.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedioButton.Image = null;
            this.MedioButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MedioButton.Location = new System.Drawing.Point(196, 94);
            this.MedioButton.Name = "MedioButton";
            this.MedioButton.Size = new System.Drawing.Size(56, 24);
            this.MedioButton.TabIndex = 20;
            this.MedioButton.Text = "동영상";
            this.MedioButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.MedioButton.Click += new System.EventHandler(this.MedioButton_Click);
            // 
            // iTalk_Label1
            // 
            this.iTalk_Label1.AutoSize = true;
            this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label1.Location = new System.Drawing.Point(25, 99);
            this.iTalk_Label1.Name = "iTalk_Label1";
            this.iTalk_Label1.Size = new System.Drawing.Size(51, 13);
            this.iTalk_Label1.TabIndex = 19;
            this.iTalk_Label1.Text = "파일첨부";
            // 
            // iTalk_HeaderLabel1
            // 
            this.iTalk_HeaderLabel1.AutoSize = true;
            this.iTalk_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel1.Font = new System.Drawing.Font("함초롬돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iTalk_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.iTalk_HeaderLabel1.Location = new System.Drawing.Point(16, 12);
            this.iTalk_HeaderLabel1.Name = "iTalk_HeaderLabel1";
            this.iTalk_HeaderLabel1.Size = new System.Drawing.Size(152, 27);
            this.iTalk_HeaderLabel1.TabIndex = 18;
            this.iTalk_HeaderLabel1.Text = "협약기업게시판";
            // 
            // ColorButton
            // 
            this.ColorButton.BackColor = System.Drawing.Color.Transparent;
            this.ColorButton.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorButton.Image = null;
            this.ColorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ColorButton.Location = new System.Drawing.Point(112, 135);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(56, 24);
            this.ColorButton.TabIndex = 17;
            this.ColorButton.Text = "색상";
            this.ColorButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ColorButton.Click += new System.EventHandler(this.iTalk_Button_16_Click);
            // 
            // FontButton
            // 
            this.FontButton.BackColor = System.Drawing.Color.Transparent;
            this.FontButton.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FontButton.Image = null;
            this.FontButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FontButton.Location = new System.Drawing.Point(22, 135);
            this.FontButton.Name = "FontButton";
            this.FontButton.Size = new System.Drawing.Size(56, 24);
            this.FontButton.TabIndex = 16;
            this.FontButton.Text = "글씨";
            this.FontButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.FontButton.Click += new System.EventHandler(this.iTalk_Button_15_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Transparent;
            this.save.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Image = null;
            this.save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save.Location = new System.Drawing.Point(730, 410);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(56, 24);
            this.save.TabIndex = 9;
            this.save.Text = "글 저장";
            this.save.TextAlignment = System.Drawing.StringAlignment.Center;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // picAdd
            // 
            this.picAdd.BackColor = System.Drawing.Color.Transparent;
            this.picAdd.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picAdd.Image = null;
            this.picAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.picAdd.Location = new System.Drawing.Point(112, 94);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(56, 24);
            this.picAdd.TabIndex = 4;
            this.picAdd.Text = "사진";
            this.picAdd.TextAlignment = System.Drawing.StringAlignment.Center;
            this.picAdd.Click += new System.EventHandler(this.picAdd_Click);
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Title.ForeColor = System.Drawing.Color.DimGray;
            this.Title.Location = new System.Drawing.Point(113, 55);
            this.Title.MaxLength = 32767;
            this.Title.Multiline = false;
            this.Title.Name = "Title";
            this.Title.ReadOnly = false;
            this.Title.Size = new System.Drawing.Size(175, 28);
            this.Title.TabIndex = 3;
            this.Title.Text = "게시글 제목을 입력하세요";
            this.Title.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.Title.UseSystemPasswordChar = false;
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // iTalk_Label2
            // 
            this.iTalk_Label2.AutoSize = true;
            this.iTalk_Label2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label2.Location = new System.Drawing.Point(25, 69);
            this.iTalk_Label2.Name = "iTalk_Label2";
            this.iTalk_Label2.Size = new System.Drawing.Size(32, 13);
            this.iTalk_Label2.TabIndex = 1;
            this.iTalk_Label2.Text = "제 목";
            // 
            // Agreement_enterprise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.attachments);
            this.Controls.Add(this.iTalk_Label3);
            this.Controls.Add(this.iTalk_Button_13);
            this.Controls.Add(this.MedioButton);
            this.Controls.Add(this.iTalk_Label1);
            this.Controls.Add(this.iTalk_HeaderLabel1);
            this.Controls.Add(this.ColorButton);
            this.Controls.Add(this.FontButton);
            this.Controls.Add(this.boardBoby);
            this.Controls.Add(this.save);
            this.Controls.Add(this.picAdd);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.iTalk_Label2);
            this.Name = "Agreement_enterprise";
            this.Size = new System.Drawing.Size(803, 445);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private iTalk.iTalk_Label iTalk_Label2;
        private iTalk.iTalk_TextBox_Small Title;
        private iTalk.iTalk_Button_1 picAdd;
        private iTalk.iTalk_Button_1 save;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox boardBoby;
        private iTalk.iTalk_Button_1 FontButton;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private iTalk.iTalk_Button_1 ColorButton;
        private iTalk.iTalk_HeaderLabel iTalk_HeaderLabel1;
        private iTalk.iTalk_Label iTalk_Label1;
        private iTalk.iTalk_Button_1 MedioButton;
        private iTalk.iTalk_Button_1 iTalk_Button_13;
        private iTalk.iTalk_Label iTalk_Label3;
        private iTalk.iTalk_ComboBox attachments;
    }
}
