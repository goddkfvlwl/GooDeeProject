namespace GoodeeProject
{
    partial class CompanyForm
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
            this.btnSpec = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnExit = new iTalk.iTalk_Button_1();
            this.btnMinimum = new iTalk.iTalk_Button_1();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iTalk_Separator1 = new iTalk.iTalk_Separator();
            this.ctlProfile1 = new GoodeeProject.CtlProfile();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSpec
            // 
            this.btnSpec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.btnSpec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpec.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSpec.ForeColor = System.Drawing.Color.Gray;
            this.btnSpec.Image = global::GoodeeProject.Properties.Resources.user_48;
            this.btnSpec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpec.Location = new System.Drawing.Point(0, 146);
            this.btnSpec.Name = "btnSpec";
            this.btnSpec.Size = new System.Drawing.Size(186, 76);
            this.btnSpec.TabIndex = 28;
            this.btnSpec.Text = "자기소개서";
            this.btnSpec.UseVisualStyleBackColor = false;
            this.btnSpec.Click += new System.EventHandler(this.btnSpec_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(186, 146);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(844, 466);
            this.panel2.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.Image = global::GoodeeProject.Properties.Resources.user_48;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 76);
            this.button1.TabIndex = 30;
            this.button1.Text = "이력서";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.ForeColor = System.Drawing.Color.Gray;
            this.button2.Image = global::GoodeeProject.Properties.Resources.user_48;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 310);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(186, 76);
            this.button2.TabIndex = 31;
            this.button2.Text = "포토폴리오";
            this.button2.UseVisualStyleBackColor = false;
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
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
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
            this.ctlProfile1.Location = new System.Drawing.Point(633, 29);
            this.ctlProfile1.Name = "ctlProfile1";
            this.ctlProfile1.Size = new System.Drawing.Size(362, 111);
            this.ctlProfile1.TabIndex = 27;
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
            this.panel1.Size = new System.Drawing.Size(1033, 146);
            this.panel1.TabIndex = 27;
            // 
            // CompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 613);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSpec);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CompanyForm";
            this.Text = "CompanyForm";
            this.Load += new System.EventHandler(this.CompanyForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Frm_BorderPaint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSpec;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private iTalk.iTalk_Button_1 btnExit;
        private iTalk.iTalk_Button_1 btnMinimum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private iTalk.iTalk_Separator iTalk_Separator1;
        internal CtlProfile ctlProfile1;
        private System.Windows.Forms.Panel panel1;
    }
}