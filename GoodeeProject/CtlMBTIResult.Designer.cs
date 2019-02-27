namespace GoodeeProject
{
    partial class CtlMBTIResult
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
            this.lvResult = new System.Windows.Forms.ListView();
            this.iTalk_Label1 = new iTalk.iTalk_Label();
            this.btnReload = new iTalk.iTalk_Button_1();
            this.SuspendLayout();
            // 
            // lvResult
            // 
            this.lvResult.Location = new System.Drawing.Point(3, 96);
            this.lvResult.Name = "lvResult";
            this.lvResult.Size = new System.Drawing.Size(808, 355);
            this.lvResult.TabIndex = 1;
            this.lvResult.UseCompatibleStateImageBehavior = false;
            this.lvResult.DoubleClick += new System.EventHandler(this.lvResult_DoubleClick);
            // 
            // iTalk_Label1
            // 
            this.iTalk_Label1.AutoSize = true;
            this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iTalk_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label1.Location = new System.Drawing.Point(222, 61);
            this.iTalk_Label1.Name = "iTalk_Label1";
            this.iTalk_Label1.Size = new System.Drawing.Size(291, 21);
            this.iTalk_Label1.TabIndex = 2;
            this.iTalk_Label1.Text = "결과를 보고싶은 MBTI를 클릭해주세요";
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.Transparent;
            this.btnReload.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnReload.Image = global::GoodeeProject.Properties.Resources.reload24;
            this.btnReload.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReload.Location = new System.Drawing.Point(529, 57);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(31, 26);
            this.btnReload.TabIndex = 3;
            this.btnReload.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // CtlMBTIResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.iTalk_Label1);
            this.Controls.Add(this.lvResult);
            this.Name = "CtlMBTIResult";
            this.Size = new System.Drawing.Size(815, 454);
            this.Load += new System.EventHandler(this.CtlMBTIResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvResult;
        private iTalk.iTalk_Label iTalk_Label1;
        private iTalk.iTalk_Button_1 btnReload;
    }
}
