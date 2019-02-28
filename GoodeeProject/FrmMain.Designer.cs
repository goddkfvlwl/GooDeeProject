namespace GoodeeProject
{
    partial class FrmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ctlProfile1 = new GoodeeProject.CtlProfile();
            this.iTalk_Separator1 = new iTalk.iTalk_Separator();
            this.btnMinimum = new iTalk.iTalk_Button_1();
            this.btnExit = new iTalk.iTalk_Button_1();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnChat = new System.Windows.Forms.Button();
            this.btnMBTI = new System.Windows.Forms.Button();
            this.btnSurvey = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnBoard = new System.Windows.Forms.Button();
            this.btnSpec = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.ctlProfile1);
            this.panel1.Controls.Add(this.iTalk_Separator1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnMinimum);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 146);
            this.panel1.TabIndex = 26;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Frm_BorderPaint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseMove);
            // 
            // ctlProfile1
            // 
            this.ctlProfile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.ctlProfile1.Location = new System.Drawing.Point(640, 29);
            this.ctlProfile1.Name = "ctlProfile1";
            this.ctlProfile1.Size = new System.Drawing.Size(360, 111);
            this.ctlProfile1.TabIndex = 0;
            // 
            // iTalk_Separator1
            // 
            this.iTalk_Separator1.Location = new System.Drawing.Point(0, 140);
            this.iTalk_Separator1.Name = "iTalk_Separator1";
            this.iTalk_Separator1.Size = new System.Drawing.Size(1000, 10);
            this.iTalk_Separator1.TabIndex = 7;
            this.iTalk_Separator1.Text = "iTalk_Separator1";
            // 
            // ctlProfile1
            // 
            this.ctlProfile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.ctlProfile1.Location = new System.Drawing.Point(640, 29);
            this.ctlProfile1.Name = "ctlProfile1";
            this.ctlProfile1.Size = new System.Drawing.Size(360, 111);
            this.ctlProfile1.TabIndex = 0;
            // 
            // iTalk_Separator1
            // 
            this.iTalk_Separator1.Location = new System.Drawing.Point(0, 140);
            this.iTalk_Separator1.Name = "iTalk_Separator1";
            this.iTalk_Separator1.Size = new System.Drawing.Size(1000, 10);
            this.iTalk_Separator1.TabIndex = 7;
            this.iTalk_Separator1.Text = "iTalk_Separator1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GoodeeProject.Properties.Resources.구디로고;
            this.pictureBox1.Location = new System.Drawing.Point(6, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // btnMinimum
            // 
            this.btnMinimum.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimum.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMinimum.Image = null;
            this.btnMinimum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimum.Location = new System.Drawing.Point(949, 3);
            this.btnMinimum.Name = "btnMinimum";
            this.btnMinimum.Size = new System.Drawing.Size(20, 20);
            this.btnMinimum.TabIndex = 25;
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
            this.btnExit.Location = new System.Drawing.Point(975, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "X";
            this.btnExit.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.IFormControl.BtnExit_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.sidePanel);
            this.panel2.Controls.Add(this.btnChat);
            this.panel2.Controls.Add(this.btnMBTI);
            this.panel2.Controls.Add(this.btnSurvey);
            this.panel2.Controls.Add(this.btnInfo);
            this.panel2.Controls.Add(this.btnBoard);
            this.panel2.Controls.Add(this.btnSpec);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 146);
            this.panel2.MinimumSize = new System.Drawing.Size(126, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 454);
            this.panel2.TabIndex = 27;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(187)))), ((int)(((byte)(104)))));
            this.sidePanel.Location = new System.Drawing.Point(174, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(10, 76);
            this.sidePanel.TabIndex = 6;
            this.sidePanel.Visible = false;
            // 
            // btnChat
            // 
            this.btnChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.btnChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChat.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnChat.ForeColor = System.Drawing.Color.Gray;
            this.btnChat.Image = global::GoodeeProject.Properties.Resources.chat_48;
            this.btnChat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChat.Location = new System.Drawing.Point(0, 375);
            this.btnChat.Name = "btnChat";
            this.btnChat.Size = new System.Drawing.Size(186, 79);
            this.btnChat.TabIndex = 5;
            this.btnChat.Text = "상담";
            this.btnChat.UseVisualStyleBackColor = false;
            this.btnChat.Click += new System.EventHandler(this.btnChat_Click);
            // 
            // btnMBTI
            // 
            this.btnMBTI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.btnMBTI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMBTI.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMBTI.ForeColor = System.Drawing.Color.Gray;
            this.btnMBTI.Image = global::GoodeeProject.Properties.Resources.write_48;
            this.btnMBTI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMBTI.Location = new System.Drawing.Point(0, 150);
            this.btnMBTI.Name = "btnMBTI";
            this.btnMBTI.Size = new System.Drawing.Size(186, 76);
            this.btnMBTI.TabIndex = 4;
            this.btnMBTI.Text = " MBTI";
            this.btnMBTI.UseVisualStyleBackColor = false;
            this.btnMBTI.Click += new System.EventHandler(this.btnMBTI_Click);
            // 
            // btnSurvey
            // 
            this.btnSurvey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.btnSurvey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSurvey.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSurvey.ForeColor = System.Drawing.Color.Gray;
            this.btnSurvey.Image = global::GoodeeProject.Properties.Resources.survey_48;
            this.btnSurvey.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSurvey.Location = new System.Drawing.Point(0, 75);
            this.btnSurvey.Name = "btnSurvey";
            this.btnSurvey.Size = new System.Drawing.Size(186, 76);
            this.btnSurvey.TabIndex = 3;
            this.btnSurvey.Text = "설문";
            this.btnSurvey.UseVisualStyleBackColor = false;
            this.btnSurvey.Click += new System.EventHandler(this.btnSurvey_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInfo.ForeColor = System.Drawing.Color.Gray;
            this.btnInfo.Image = global::GoodeeProject.Properties.Resources.info_48;
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(0, 225);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(186, 76);
            this.btnInfo.TabIndex = 2;
            this.btnInfo.Text = "   기업정보";
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnBoard
            // 
            this.btnBoard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.btnBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoard.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBoard.ForeColor = System.Drawing.Color.Gray;
            this.btnBoard.Image = global::GoodeeProject.Properties.Resources.board_48;
            this.btnBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoard.Location = new System.Drawing.Point(0, 300);
            this.btnBoard.Name = "btnBoard";
            this.btnBoard.Size = new System.Drawing.Size(186, 76);
            this.btnBoard.TabIndex = 1;
            this.btnBoard.Text = "협약기업 게시판";
            this.btnBoard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBoard.UseVisualStyleBackColor = false;
            this.btnBoard.Click += new System.EventHandler(this.btnBoard_Click);
            // 
            // btnSpec
            // 
            this.btnSpec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.btnSpec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpec.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSpec.ForeColor = System.Drawing.Color.Gray;
            this.btnSpec.Image = global::GoodeeProject.Properties.Resources.user_48;
            this.btnSpec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpec.Location = new System.Drawing.Point(0, 0);
            this.btnSpec.Name = "btnSpec";
            this.btnSpec.Size = new System.Drawing.Size(186, 76);
            this.btnSpec.TabIndex = 0;
            this.btnSpec.Text = "   스펙관리";
            this.btnSpec.UseVisualStyleBackColor = false;
            this.btnSpec.Click += new System.EventHandler(this.btnSpec_Click);
            // 
            // ctlProfile1
            // 
            this.ctlProfile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.ctlProfile1.Location = new System.Drawing.Point(633, 29);
            this.ctlProfile1.Name = "ctlProfile1";
            this.ctlProfile1.Size = new System.Drawing.Size(362, 111);
            this.ctlProfile1.TabIndex = 27;
            // 
            // iTalk_Separator1
            // 
            this.iTalk_Separator1.Location = new System.Drawing.Point(0, 140);
            this.iTalk_Separator1.Name = "iTalk_Separator1";
            this.iTalk_Separator1.Size = new System.Drawing.Size(1000, 10);
            this.iTalk_Separator1.TabIndex = 7;
            this.iTalk_Separator1.Text = "iTalk_Separator1";
            // 
            // btnMinimum
            // 
            this.btnMinimum.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimum.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMinimum.Image = null;
            this.btnMinimum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimum.Location = new System.Drawing.Point(949, 3);
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
            this.btnExit.Location = new System.Drawing.Point(975, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "X";
            this.btnExit.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(126, 39);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iTalk_ThemeContainer1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private iTalk.iTalk_Button_1 btnMinimum;
        private iTalk.iTalk_Button_1 btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btnChat;
        private System.Windows.Forms.Button btnMBTI;
        private System.Windows.Forms.Button btnSurvey;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnBoard;
        private System.Windows.Forms.Button btnSpec;
        private System.Windows.Forms.PictureBox pictureBox1;
        private iTalk.iTalk_Separator iTalk_Separator1;

        private StudentManagement studentManagement1;
        private Portfolio portfolio1;
        internal CtlProfile ctlProfile1;
        internal System.Windows.Forms.Panel panel2;
    }
}