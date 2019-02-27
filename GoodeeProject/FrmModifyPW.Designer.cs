namespace GoodeeProject
{
    partial class FrmModifyPW
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
            this.ctlModifyPW1 = new GoodeeProject.CtlModifyPW();
            this.btnMinimum = new iTalk.iTalk_Button_1();
            this.btnExit = new iTalk.iTalk_Button_1();
            this.SuspendLayout();
            // 
            // ctlModifyPW1
            // 
            this.ctlModifyPW1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.ctlModifyPW1.Location = new System.Drawing.Point(0, 25);
            this.ctlModifyPW1.Name = "ctlModifyPW1";
            this.ctlModifyPW1.Size = new System.Drawing.Size(399, 571);
            this.ctlModifyPW1.TabIndex = 0;
            // 
            // btnMinimum
            // 
            this.btnMinimum.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimum.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMinimum.Image = null;
            this.btnMinimum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimum.Location = new System.Drawing.Point(350, 3);
            this.btnMinimum.Name = "btnMinimum";
            this.btnMinimum.Size = new System.Drawing.Size(20, 20);
            this.btnMinimum.TabIndex = 27;
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
            this.btnExit.Location = new System.Drawing.Point(376, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "X";
            this.btnExit.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmModifyPW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(399, 598);
            this.Controls.Add(this.btnMinimum);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.ctlModifyPW1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmModifyPW";
            this.Text = "FrmModifyPW";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Frm_BorderPaint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private CtlModifyPW ctlModifyPW1;
        private iTalk.iTalk_Button_1 btnMinimum;
        private iTalk.iTalk_Button_1 btnExit;
    }
}