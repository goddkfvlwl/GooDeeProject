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
            this.btnMinimum = new iTalk.iTalk_Button_1();
            this.btnExit = new iTalk.iTalk_Button_1();
            this.btn_CreateCom = new System.Windows.Forms.Button();
            this.btn_CreateManager = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
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
            // btn_CreateCom
            // 
            this.btn_CreateCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateCom.ForeColor = System.Drawing.Color.Gray;
            this.btn_CreateCom.Location = new System.Drawing.Point(236, 40);
            this.btn_CreateCom.Name = "btn_CreateCom";
            this.btn_CreateCom.Size = new System.Drawing.Size(236, 50);
            this.btn_CreateCom.TabIndex = 93;
            this.btn_CreateCom.Text = "협약업체 계정 생성";
            this.btn_CreateCom.UseVisualStyleBackColor = true;
            this.btn_CreateCom.Click += new System.EventHandler(this.btn_CreateCom_Click);
            // 
            // btn_CreateManager
            // 
            this.btn_CreateManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CreateManager.ForeColor = System.Drawing.Color.Gray;
            this.btn_CreateManager.Location = new System.Drawing.Point(0, 40);
            this.btn_CreateManager.Name = "btn_CreateManager";
            this.btn_CreateManager.Size = new System.Drawing.Size(236, 50);
            this.btn_CreateManager.TabIndex = 92;
            this.btn_CreateManager.Text = "관리자 계정 생성";
            this.btn_CreateManager.UseVisualStyleBackColor = true;
            this.btn_CreateManager.Click += new System.EventHandler(this.btn_CreateManager_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(1, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 488);
            this.panel1.TabIndex = 94;
            // 
            // FrmCreateID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(472, 585);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_CreateCom);
            this.Controls.Add(this.btn_CreateManager);
            this.Controls.Add(this.btnMinimum);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCreateID";
            this.Text = "FrmCreateID";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Frm_BorderPaint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion
        private iTalk.iTalk_Button_1 btnMinimum;
        private iTalk.iTalk_Button_1 btnExit;
        private System.Windows.Forms.Button btn_CreateCom;
        private System.Windows.Forms.Button btn_CreateManager;
        private System.Windows.Forms.Panel panel1;
    }
}