namespace GoodeeProject
{
    partial class CompanyMainForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RequestButton = new iTalk.iTalk_Button_1();
            this.iTalk_Label3 = new iTalk.iTalk_Label();
            this.iTalk_Separator1 = new iTalk.iTalk_Separator();
            this.btnMinimum = new iTalk.iTalk_Button_1();
            this.btnExit = new iTalk.iTalk_Button_1();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GoodeeProject.Properties.Resources.학생정보열람요청;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // RequestButton
            // 
            this.RequestButton.BackColor = System.Drawing.Color.Transparent;
            this.RequestButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RequestButton.Image = null;
            this.RequestButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RequestButton.Location = new System.Drawing.Point(159, 164);
            this.RequestButton.Name = "RequestButton";
            this.RequestButton.Size = new System.Drawing.Size(49, 31);
            this.RequestButton.TabIndex = 54;
            this.RequestButton.Text = "요청";
            this.RequestButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.RequestButton.Click += new System.EventHandler(this.RequestButton_Click);
            // 
            // iTalk_Label3
            // 
            this.iTalk_Label3.AutoSize = true;
            this.iTalk_Label3.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label3.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iTalk_Label3.ForeColor = System.Drawing.Color.Gray;
            this.iTalk_Label3.Location = new System.Drawing.Point(58, 126);
            this.iTalk_Label3.Name = "iTalk_Label3";
            this.iTalk_Label3.Size = new System.Drawing.Size(262, 17);
            this.iTalk_Label3.TabIndex = 53;
            this.iTalk_Label3.Text = "학생정보 열람을 원할시 버튼을 눌러주세요";
           
            // 
            // iTalk_Separator1
            // 
            this.iTalk_Separator1.Location = new System.Drawing.Point(-1, 65);
            this.iTalk_Separator1.Name = "iTalk_Separator1";
            this.iTalk_Separator1.Size = new System.Drawing.Size(364, 25);
            this.iTalk_Separator1.TabIndex = 50;
            this.iTalk_Separator1.Text = "iTalk_Separator1";
            // 
            // btnMinimum
            // 
            this.btnMinimum.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnMinimum.Image = null;
            this.btnMinimum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimum.Location = new System.Drawing.Point(300, 12);
            this.btnMinimum.Name = "btnMinimum";
            this.btnMinimum.Size = new System.Drawing.Size(20, 20);
            this.btnMinimum.TabIndex = 49;
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
            this.btnExit.Location = new System.Drawing.Point(326, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 48;
            this.btnExit.Text = "X";
            this.btnExit.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // CompanyMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(358, 291);
            this.Controls.Add(this.RequestButton);
            this.Controls.Add(this.iTalk_Label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.iTalk_Separator1);
            this.Controls.Add(this.btnMinimum);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CompanyMainForm";
            this.Text = "CompanyMainForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private iTalk.iTalk_Button_1 btnMinimum;
        private iTalk.iTalk_Button_1 btnExit;
        private iTalk.iTalk_Separator iTalk_Separator1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private iTalk.iTalk_Label iTalk_Label3;
        private iTalk.iTalk_Button_1 RequestButton;
    }
}