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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctlModifyPW1 = new GoodeeProject.CtlModifyPW();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.btnModifyMember = new System.Windows.Forms.Button();
            this.btnModifyPW = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.btnMinimum.Click += new System.EventHandler(this.BtnMinimum_Click);
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
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ctlModifyPW1);
            this.panel1.Location = new System.Drawing.Point(37, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 571);
            this.panel1.TabIndex = 28;
            // 
            // ctlModifyPW1
            // 
            this.ctlModifyPW1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.ctlModifyPW1.Location = new System.Drawing.Point(0, 0);
            this.ctlModifyPW1.Name = "ctlModifyPW1";
            this.ctlModifyPW1.Size = new System.Drawing.Size(399, 571);
            this.ctlModifyPW1.TabIndex = 0;
            this.ctlModifyPW1.Visible = false;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(187)))), ((int)(((byte)(104)))));
            this.bottomPanel.Location = new System.Drawing.Point(37, 101);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(186, 10);
            this.bottomPanel.TabIndex = 29;
            this.bottomPanel.Visible = false;
            // 
            // btnModifyMember
            // 
            this.btnModifyMember.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.btnModifyMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyMember.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnModifyMember.ForeColor = System.Drawing.Color.Gray;
            this.btnModifyMember.Image = global::GoodeeProject.Properties.Resources.ModifyMember;
            this.btnModifyMember.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifyMember.Location = new System.Drawing.Point(250, 35);
            this.btnModifyMember.Name = "btnModifyMember";
            this.btnModifyMember.Size = new System.Drawing.Size(186, 66);
            this.btnModifyMember.TabIndex = 27;
            this.btnModifyMember.Text = "회원정보 수정";
            this.btnModifyMember.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModifyMember.UseVisualStyleBackColor = false;
            this.btnModifyMember.Click += new System.EventHandler(this.btnModifyMember_Click);
            // 
            // btnModifyPW
            // 
            this.btnModifyPW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.btnModifyPW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifyPW.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnModifyPW.ForeColor = System.Drawing.Color.Gray;
            this.btnModifyPW.Image = global::GoodeeProject.Properties.Resources.ModifyPW;
            this.btnModifyPW.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifyPW.Location = new System.Drawing.Point(37, 35);
            this.btnModifyPW.Name = "btnModifyPW";
            this.btnModifyPW.Size = new System.Drawing.Size(186, 66);
            this.btnModifyPW.TabIndex = 26;
            this.btnModifyPW.Text = "비밀번호 수정";
            this.btnModifyPW.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModifyPW.UseVisualStyleBackColor = false;
            this.btnModifyPW.Click += new System.EventHandler(this.btnModifyPW_Click);
            // 
            // FrmModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(472, 707);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnModifyMember);
            this.Controls.Add(this.btnModifyPW);
            this.Controls.Add(this.btnMinimum);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmModify";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmModify_FormClosed);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Frm_BorderPaint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseMove);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private iTalk.iTalk_Button_1 btnMinimum;
        private iTalk.iTalk_Button_1 btnExit;
        private System.Windows.Forms.Button btnModifyPW;
        private System.Windows.Forms.Button btnModifyMember;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel bottomPanel;
        private CtlModifyPW ctlModifyPW1;
    }
}