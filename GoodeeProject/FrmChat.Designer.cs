namespace GoodeeProject
{
    partial class FrmChat
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
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.txtChatContent = new System.Windows.Forms.TextBox();
            this.txtSendMsg = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Location = new System.Drawing.Point(229, 415);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(75, 23);
            this.btnSendMsg.TabIndex = 0;
            this.btnSendMsg.Text = "전송";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // txtChatContent
            // 
            this.txtChatContent.Location = new System.Drawing.Point(12, 12);
            this.txtChatContent.Multiline = true;
            this.txtChatContent.Name = "txtChatContent";
            this.txtChatContent.ReadOnly = true;
            this.txtChatContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtChatContent.Size = new System.Drawing.Size(292, 397);
            this.txtChatContent.TabIndex = 1;
            this.txtChatContent.TextChanged += new System.EventHandler(this.txtChatContent_TextChanged);
            // 
            // txtSendMsg
            // 
            this.txtSendMsg.Location = new System.Drawing.Point(12, 417);
            this.txtSendMsg.Name = "txtSendMsg";
            this.txtSendMsg.Size = new System.Drawing.Size(211, 21);
            this.txtSendMsg.TabIndex = 2;
            this.txtSendMsg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSendMsg_KeyDown);
            // 
            // FrmChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 450);
            this.Controls.Add(this.txtSendMsg);
            this.Controls.Add(this.txtChatContent);
            this.Controls.Add(this.btnSendMsg);
            this.Name = "FrmChat";
            this.Text = "FrmChat";
            this.Load += new System.EventHandler(this.FrmChat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.TextBox txtChatContent;
        private System.Windows.Forms.TextBox txtSendMsg;
    }
}