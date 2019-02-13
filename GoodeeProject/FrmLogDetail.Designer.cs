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
            this.SuspendLayout();
            // 
            // tboxLogDetail
            // 
            this.tboxLogDetail.AutoWordSelection = false;
            this.tboxLogDetail.BackColor = System.Drawing.Color.Transparent;
            this.tboxLogDetail.Font = new System.Drawing.Font("Tahoma", 10F);
            this.tboxLogDetail.ForeColor = System.Drawing.Color.DimGray;
            this.tboxLogDetail.Location = new System.Drawing.Point(12, 12);
            this.tboxLogDetail.Name = "tboxLogDetail";
            this.tboxLogDetail.ReadOnly = false;
            this.tboxLogDetail.Size = new System.Drawing.Size(396, 426);
            this.tboxLogDetail.TabIndex = 0;
            this.tboxLogDetail.Text = "iTalk_RichTextBox1";
            this.tboxLogDetail.WordWrap = true;
            // 
            // FrmLogDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 450);
            this.Controls.Add(this.tboxLogDetail);
            this.Name = "FrmLogDetail";
            this.Text = "FrmLogDetail";
            this.ResumeLayout(false);

        }

        #endregion

        private iTalk.iTalk_RichTextBox tboxLogDetail;
    }
}