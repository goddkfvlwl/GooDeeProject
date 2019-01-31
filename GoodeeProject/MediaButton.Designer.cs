namespace GoodeeProject
{
    partial class MediaButton
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            iTalk.ControlRenderer controlRenderer1 = new iTalk.ControlRenderer();
            iTalk.MSColorTable msColorTable1 = new iTalk.MSColorTable();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.iTalk_MenuStrip1 = new iTalk.iTalk_MenuStrip();
            this.동영상올리기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.링크걸기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iTalk_MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // iTalk_MenuStrip1
            // 
            this.iTalk_MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.동영상올리기ToolStripMenuItem,
            this.링크걸기ToolStripMenuItem});
            this.iTalk_MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.iTalk_MenuStrip1.Name = "iTalk_MenuStrip1";
            controlRenderer1.ColorTable = msColorTable1;
            controlRenderer1.RoundedEdges = true;
            this.iTalk_MenuStrip1.Renderer = controlRenderer1;
            this.iTalk_MenuStrip1.Size = new System.Drawing.Size(179, 24);
            this.iTalk_MenuStrip1.TabIndex = 0;
            this.iTalk_MenuStrip1.Text = "iTalk_MenuStrip1";
            // 
            // 동영상올리기ToolStripMenuItem
            // 
            this.동영상올리기ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.동영상올리기ToolStripMenuItem.Name = "동영상올리기ToolStripMenuItem";
            this.동영상올리기ToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.동영상올리기ToolStripMenuItem.Text = "동영상 올리기";
            this.동영상올리기ToolStripMenuItem.Click += new System.EventHandler(this.동영상올리기ToolStripMenuItem_Click);
            // 
            // 링크걸기ToolStripMenuItem
            // 
            this.링크걸기ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.링크걸기ToolStripMenuItem.Name = "링크걸기ToolStripMenuItem";
            this.링크걸기ToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.링크걸기ToolStripMenuItem.Text = "링크걸기";
            // 
            // MedeioButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.iTalk_MenuStrip1);
            this.Name = "MedeioButton";
            this.Size = new System.Drawing.Size(179, 162);
            this.Click += new System.EventHandler(this.MedeioButton_Click);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MedeioButton_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MedeioButton_MouseDown_1);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MedeioButton_MouseMove);
            this.iTalk_MenuStrip1.ResumeLayout(false);
            this.iTalk_MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private iTalk.iTalk_MenuStrip iTalk_MenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 동영상올리기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 링크걸기ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
