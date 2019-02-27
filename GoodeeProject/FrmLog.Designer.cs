namespace GoodeeProject
{
    partial class FrmLog
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLog));
            this.lvLogFiles = new System.Windows.Forms.ListView();
            this.imgList = new System.Windows.Forms.ImageList(this.components);
            this.btnAll = new iTalk.iTalk_Button_1();
            this.btnSearch = new iTalk.iTalk_Button_1();
            this.tboxSearch = new iTalk.iTalk_TextBox_Small();
            this.btnMinimum = new iTalk.iTalk_Button_1();
            this.btnExit = new iTalk.iTalk_Button_1();
            this.pBarDown = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lvLogFiles
            // 
            this.lvLogFiles.Location = new System.Drawing.Point(12, 105);
            this.lvLogFiles.Name = "lvLogFiles";
            this.lvLogFiles.Size = new System.Drawing.Size(776, 350);
            this.lvLogFiles.TabIndex = 30;
            this.lvLogFiles.UseCompatibleStateImageBehavior = false;
            this.lvLogFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvLogFiles_MouseDoubleClick);
            // 
            // imgList
            // 
            this.imgList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgList.ImageStream")));
            this.imgList.TransparentColor = System.Drawing.Color.Transparent;
            this.imgList.Images.SetKeyName(0, "iconfinder_icon-69-document-text_314910.png");
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.Transparent;
            this.btnAll.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAll.Image = null;
            this.btnAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAll.Location = new System.Drawing.Point(523, 65);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(73, 28);
            this.btnAll.TabIndex = 33;
            this.btnAll.Text = "전체보기";
            this.btnAll.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSearch.Image = null;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(523, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(73, 28);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "검색";
            this.btnSearch.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tboxSearch
            // 
            this.tboxSearch.BackColor = System.Drawing.Color.Transparent;
            this.tboxSearch.Font = new System.Drawing.Font("Tahoma", 11F);
            this.tboxSearch.ForeColor = System.Drawing.Color.DimGray;
            this.tboxSearch.Location = new System.Drawing.Point(263, 26);
            this.tboxSearch.MaxLength = 32767;
            this.tboxSearch.Multiline = false;
            this.tboxSearch.Name = "tboxSearch";
            this.tboxSearch.ReadOnly = false;
            this.tboxSearch.Size = new System.Drawing.Size(237, 28);
            this.tboxSearch.TabIndex = 31;
            this.tboxSearch.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.tboxSearch.UseSystemPasswordChar = false;
            // 
            // btnMinimum
            // 
            this.btnMinimum.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimum.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnMinimum.Image = null;
            this.btnMinimum.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimum.Location = new System.Drawing.Point(742, 12);
            this.btnMinimum.Name = "btnMinimum";
            this.btnMinimum.Size = new System.Drawing.Size(20, 20);
            this.btnMinimum.TabIndex = 29;
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
            this.btnExit.Location = new System.Drawing.Point(768, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 28;
            this.btnExit.Text = "X";
            this.btnExit.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // pBarDown
            // 
            this.pBarDown.Location = new System.Drawing.Point(263, 67);
            this.pBarDown.Name = "pBarDown";
            this.pBarDown.Size = new System.Drawing.Size(237, 23);
            this.pBarDown.TabIndex = 34;
            this.pBarDown.Visible = false;
            // 
            // FrmLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(233)))));
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.pBarDown);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tboxSearch);
            this.Controls.Add(this.lvLogFiles);
            this.Controls.Add(this.btnMinimum);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLog";
            this.Text = "FrmLog";
            this.Load += new System.EventHandler(this.FrmLog_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Frm_BorderPaint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Frm_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private iTalk.iTalk_Button_1 btnMinimum;
        private iTalk.iTalk_Button_1 btnExit;
        private System.Windows.Forms.ListView lvLogFiles;
        private System.Windows.Forms.ImageList imgList;
        private iTalk.iTalk_TextBox_Small tboxSearch;
        private iTalk.iTalk_Button_1 btnSearch;
        private iTalk.iTalk_Button_1 btnAll;
        private System.Windows.Forms.ProgressBar pBarDown;
    }
}