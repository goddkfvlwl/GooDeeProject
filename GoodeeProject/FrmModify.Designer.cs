namespace GoodeeProject
{
    partial class FrmModify
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
            this.btnMinimum = new iTalk.iTalk_Button_1();
            this.btnExit = new iTalk.iTalk_Button_1();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSurvey = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnMinimum
            // 
            this.btnMinimum.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimum.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMinimum.Image = null;
            this.btnMinimum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimum.Location = new System.Drawing.Point(416, 10);
            this.btnMinimum.Name = "btnMinimum";
            this.btnMinimum.Size = new System.Drawing.Size(20, 20);
            this.btnMinimum.TabIndex = 25;
            this.btnMinimum.Text = "_";
            this.btnMinimum.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnExit.Image = null;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(442, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "X";
            this.btnExit.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.Image = global::GoodeeProject.Properties.Resources.ModifyMember;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(250, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 76);
            this.button1.TabIndex = 27;
            this.button1.Text = "회원정보 수정";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnSurvey
            // 
            this.btnSurvey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.btnSurvey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSurvey.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSurvey.ForeColor = System.Drawing.Color.Gray;
            this.btnSurvey.Image = global::GoodeeProject.Properties.Resources.ModifyPW;
            this.btnSurvey.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSurvey.Location = new System.Drawing.Point(37, 35);
            this.btnSurvey.Name = "btnSurvey";
            this.btnSurvey.Size = new System.Drawing.Size(186, 76);
            this.btnSurvey.TabIndex = 26;
            this.btnSurvey.Text = "비밀번호 수정";
            this.btnSurvey.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSurvey.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(37, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 598);
            this.panel1.TabIndex = 28;
            // 
            // FrmModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(472, 778);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSurvey);
            this.Controls.Add(this.btnMinimum);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModify";
            this.Text = "FrmModify";
            this.ResumeLayout(false);

        }

        #endregion

        private iTalk.iTalk_Button_1 btnMinimum;
        private iTalk.iTalk_Button_1 btnExit;
        private System.Windows.Forms.Button btnSurvey;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
    }
}