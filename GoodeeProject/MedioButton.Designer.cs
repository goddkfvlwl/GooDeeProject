namespace GoodeeProject
{
    partial class MedioButton
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
            this.LinkAddLabel = new iTalk.iTalk_HeaderLabel();
            this.mediaLabel = new iTalk.iTalk_HeaderLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // LinkAddLabel
            // 
            this.LinkAddLabel.AutoSize = true;
            this.LinkAddLabel.BackColor = System.Drawing.Color.Transparent;
            this.LinkAddLabel.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkAddLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.LinkAddLabel.Location = new System.Drawing.Point(262, 9);
            this.LinkAddLabel.Name = "LinkAddLabel";
            this.LinkAddLabel.Size = new System.Drawing.Size(74, 21);
            this.LinkAddLabel.TabIndex = 2;
            this.LinkAddLabel.Text = "링크걸기";
            this.LinkAddLabel.Click += new System.EventHandler(this.LinkAddLabel_Click);
            // 
            // mediaLabel
            // 
            this.mediaLabel.AutoSize = true;
            this.mediaLabel.BackColor = System.Drawing.Color.Transparent;
            this.mediaLabel.Font = new System.Drawing.Font("함초롬돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.mediaLabel.Location = new System.Drawing.Point(38, 9);
            this.mediaLabel.Name = "mediaLabel";
            this.mediaLabel.Size = new System.Drawing.Size(111, 21);
            this.mediaLabel.TabIndex = 1;
            this.mediaLabel.Text = "동영상 올리기";
            this.mediaLabel.Click += new System.EventHandler(this.iTalk_HeaderLabel1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MedioButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 254);
            this.Controls.Add(this.LinkAddLabel);
            this.Controls.Add(this.mediaLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MedioButton";
            this.Text = "MedioButton";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private iTalk.iTalk_HeaderLabel mediaLabel;
        private iTalk.iTalk_HeaderLabel LinkAddLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}