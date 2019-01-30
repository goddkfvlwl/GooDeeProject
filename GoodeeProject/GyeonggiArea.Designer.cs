namespace GoodeeProject
{
    partial class GyeonggiArea
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.iTalk_CheckBox1 = new iTalk.iTalk_CheckBox();
            this.iTalk_CheckBox2 = new iTalk.iTalk_CheckBox();
            this.iTalk_CheckBox3 = new iTalk.iTalk_CheckBox();
            this.iTalk_CheckBox4 = new iTalk.iTalk_CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.iTalk_CheckBox1);
            this.panel1.Controls.Add(this.iTalk_CheckBox2);
            this.panel1.Controls.Add(this.iTalk_CheckBox3);
            this.panel1.Controls.Add(this.iTalk_CheckBox4);
            this.panel1.Location = new System.Drawing.Point(4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 241);
            this.panel1.TabIndex = 1;
            // 
            // iTalk_CheckBox1
            // 
            this.iTalk_CheckBox1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_CheckBox1.Checked = false;
            this.iTalk_CheckBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iTalk_CheckBox1.Location = new System.Drawing.Point(22, 28);
            this.iTalk_CheckBox1.Name = "iTalk_CheckBox1";
            this.iTalk_CheckBox1.Size = new System.Drawing.Size(91, 15);
            this.iTalk_CheckBox1.TabIndex = 26;
            this.iTalk_CheckBox1.Text = "서울전체";
            // 
            // iTalk_CheckBox2
            // 
            this.iTalk_CheckBox2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_CheckBox2.Checked = false;
            this.iTalk_CheckBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iTalk_CheckBox2.Location = new System.Drawing.Point(127, 28);
            this.iTalk_CheckBox2.Name = "iTalk_CheckBox2";
            this.iTalk_CheckBox2.Size = new System.Drawing.Size(91, 15);
            this.iTalk_CheckBox2.TabIndex = 27;
            this.iTalk_CheckBox2.Text = "강남구";
            // 
            // iTalk_CheckBox3
            // 
            this.iTalk_CheckBox3.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_CheckBox3.Checked = false;
            this.iTalk_CheckBox3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iTalk_CheckBox3.Location = new System.Drawing.Point(232, 28);
            this.iTalk_CheckBox3.Name = "iTalk_CheckBox3";
            this.iTalk_CheckBox3.Size = new System.Drawing.Size(91, 15);
            this.iTalk_CheckBox3.TabIndex = 28;
            this.iTalk_CheckBox3.Text = "강동구";
            // 
            // iTalk_CheckBox4
            // 
            this.iTalk_CheckBox4.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_CheckBox4.Checked = false;
            this.iTalk_CheckBox4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.iTalk_CheckBox4.Location = new System.Drawing.Point(337, 28);
            this.iTalk_CheckBox4.Name = "iTalk_CheckBox4";
            this.iTalk_CheckBox4.Size = new System.Drawing.Size(91, 15);
            this.iTalk_CheckBox4.TabIndex = 29;
            this.iTalk_CheckBox4.Text = "강북구";
            // 
            // GyeonggiArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "GyeonggiArea";
            this.Size = new System.Drawing.Size(462, 244);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private iTalk.iTalk_CheckBox iTalk_CheckBox1;
        private iTalk.iTalk_CheckBox iTalk_CheckBox2;
        private iTalk.iTalk_CheckBox iTalk_CheckBox3;
        private iTalk.iTalk_CheckBox iTalk_CheckBox4;
    }
}
