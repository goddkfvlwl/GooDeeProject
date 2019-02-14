namespace GoodeeProject
{
    partial class oneJobMatResult
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
            this.companyName = new iTalk.iTalk_Label();
            this.companyTiltle = new iTalk.iTalk_Label();
            this.companyIntroduce = new iTalk.iTalk_Label();
            this.keword = new iTalk.iTalk_Label();
            this.SuspendLayout();
            // 
            // companyName
            // 
            this.companyName.AutoSize = true;
            this.companyName.BackColor = System.Drawing.Color.Transparent;
            this.companyName.Font = new System.Drawing.Font("함초롬돋움", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.companyName.Location = new System.Drawing.Point(4, 7);
            this.companyName.Name = "companyName";
            this.companyName.Size = new System.Drawing.Size(54, 15);
            this.companyName.TabIndex = 0;
            this.companyName.Text = "회사 이름";
            this.companyName.Click += new System.EventHandler(this.companyName_Click);
            // 
            // companyTiltle
            // 
            this.companyTiltle.AutoSize = true;
            this.companyTiltle.BackColor = System.Drawing.Color.Transparent;
            this.companyTiltle.Font = new System.Drawing.Font("함초롬돋움", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyTiltle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.companyTiltle.Location = new System.Drawing.Point(4, 31);
            this.companyTiltle.Name = "companyTiltle";
            this.companyTiltle.Size = new System.Drawing.Size(86, 17);
            this.companyTiltle.TabIndex = 1;
            this.companyTiltle.Text = "회사채용내용";
            // 
            // companyIntroduce
            // 
            this.companyIntroduce.AutoSize = true;
            this.companyIntroduce.BackColor = System.Drawing.Color.Transparent;
            this.companyIntroduce.Font = new System.Drawing.Font("함초롬돋움", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyIntroduce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.companyIntroduce.Location = new System.Drawing.Point(4, 57);
            this.companyIntroduce.Name = "companyIntroduce";
            this.companyIntroduce.Size = new System.Drawing.Size(150, 15);
            this.companyIntroduce.TabIndex = 2;
            this.companyIntroduce.Text = "경력 / 학력 /  근무형태 / 지역";
            // 
            // keword
            // 
            this.keword.AutoSize = true;
            this.keword.BackColor = System.Drawing.Color.Transparent;
            this.keword.Font = new System.Drawing.Font("함초롬돋움", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.keword.Location = new System.Drawing.Point(4, 81);
            this.keword.Name = "keword";
            this.keword.Size = new System.Drawing.Size(40, 15);
            this.keword.TabIndex = 3;
            this.keword.Text = "키워드";
            // 
            // oneJobMatResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.keword);
            this.Controls.Add(this.companyIntroduce);
            this.Controls.Add(this.companyTiltle);
            this.Controls.Add(this.companyName);
            this.Name = "oneJobMatResult";
            this.Size = new System.Drawing.Size(395, 108);
            this.Load += new System.EventHandler(this.oneJobMatResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private iTalk.iTalk_Label companyName;
        private iTalk.iTalk_Label companyTiltle;
        private iTalk.iTalk_Label companyIntroduce;
        private iTalk.iTalk_Label keword;
    }
}
