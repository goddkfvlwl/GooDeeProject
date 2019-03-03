namespace GoodeeProject
{
    partial class FrmLogDetail
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
            this.tboxLogDetail = new iTalk.iTalk_RichTextBox();
            this.btnMinimum = new iTalk.iTalk_Button_1();
            this.btnExit = new iTalk.iTalk_Button_1();
            this.SuspendLayout();
            // 
            // tboxLogDetail
            // 
            this.tboxLogDetail.AutoWordSelection = false;
            this.tboxLogDetail.BackColor = System.Drawing.Color.Transparent;
            this.tboxLogDetail.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tboxLogDetail.ForeColor = System.Drawing.Color.DimGray;
            this.tboxLogDetail.Location = new System.Drawing.Point(12, 55);
            this.tboxLogDetail.Name = "tboxLogDetail";
            this.tboxLogDetail.ReadOnly = false;
            this.tboxLogDetail.Size = new System.Drawing.Size(396, 426);
            this.tboxLogDetail.TabIndex = 0;
            this.tboxLogDetail.WordWrap = true;
            // 
            // btnMinimum
            // 
            this.btnMinimum.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimum.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMinimum.Image = null;
            this.btnMinimum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimum.Location = new System.Drawing.Point(367, 5);
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
            this.btnExit.Location = new System.Drawing.Point(393, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "X";
            this.btnExit.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // FrmLogDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 493);
            this.Controls.Add(this.btnMinimum);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tboxLogDetail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLogDetail";
            this.Text = "FrmLogDetail";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Frm_BorderPaint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private iTalk.iTalk_RichTextBox tboxLogDetail;
        private iTalk.iTalk_Button_1 btnMinimum;
        private iTalk.iTalk_Button_1 btnExit;
    }
}