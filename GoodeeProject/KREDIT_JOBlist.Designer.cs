﻿namespace GoodeeProject
{
    partial class KREDIT_JOBlist
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.jobSearch = new iTalk.iTalk_RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GoodeeProject.Properties.Resources.company1;
            this.pictureBox1.Location = new System.Drawing.Point(15, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 72);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(768, 354);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // jobSearch
            // 
            this.jobSearch.AutoWordSelection = false;
            this.jobSearch.BackColor = System.Drawing.Color.Transparent;
            this.jobSearch.Font = new System.Drawing.Font("Tahoma", 10F);
            this.jobSearch.ForeColor = System.Drawing.Color.DimGray;
            this.jobSearch.Location = new System.Drawing.Point(174, 19);
            this.jobSearch.Name = "jobSearch";
            this.jobSearch.ReadOnly = false;
            this.jobSearch.Size = new System.Drawing.Size(258, 31);
            this.jobSearch.TabIndex = 2;
            this.jobSearch.Text = "기업을 검색해보세요";
            this.jobSearch.WordWrap = true;
            // 
            // KREDIT_JOBlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.jobSearch);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "KREDIT_JOBlist";
            this.Size = new System.Drawing.Size(803, 445);
            this.Load += new System.EventHandler(this.KREDIT_JOBlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private iTalk.iTalk_RichTextBox jobSearch;
    }
}