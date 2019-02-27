namespace GoodeeProject
{
    partial class KREDIT_JOBResult
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
            this.panelCompany = new System.Windows.Forms.Panel();
            this.panelRetirement = new System.Windows.Forms.Panel();
            this.panelHistory = new System.Windows.Forms.Panel();
            this.panelIncidence = new System.Windows.Forms.Panel();
            this.panelPerson = new System.Windows.Forms.Panel();
            this.Retirement = new iTalk.iTalk_Label();
            this.iTalk_Label4 = new iTalk.iTalk_Label();
            this.employment_history = new iTalk.iTalk_Label();
            this.iTalk_Label2 = new iTalk.iTalk_Label();
            this.iTalk_Label3 = new iTalk.iTalk_Label();
            this.Incidence = new iTalk.iTalk_Label();
            this.personNumber = new iTalk.iTalk_Label();
            this.iTalk_Label1 = new iTalk.iTalk_Label();
            this.companyinformation = new iTalk.iTalk_Label();
            this.companyJob = new iTalk.iTalk_Label();
            this.jobSearch = new iTalk.iTalk_RichTextBox();
            this.companyname = new iTalk.iTalk_Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelCompany.SuspendLayout();
            this.panelRetirement.SuspendLayout();
            this.panelHistory.SuspendLayout();
            this.panelIncidence.SuspendLayout();
            this.panelPerson.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GoodeeProject.Properties.Resources.company1;
            this.pictureBox1.Location = new System.Drawing.Point(8, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelCompany
            // 
            this.panelCompany.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCompany.Controls.Add(this.panelRetirement);
            this.panelCompany.Controls.Add(this.panelHistory);
            this.panelCompany.Controls.Add(this.panelIncidence);
            this.panelCompany.Controls.Add(this.panelPerson);
            this.panelCompany.Controls.Add(this.companyinformation);
            this.panelCompany.Controls.Add(this.companyJob);
            this.panelCompany.Location = new System.Drawing.Point(13, 94);
            this.panelCompany.Name = "panelCompany";
            this.panelCompany.Size = new System.Drawing.Size(449, 286);
            this.panelCompany.TabIndex = 2;
            // 
            // panelRetirement
            // 
            this.panelRetirement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRetirement.Controls.Add(this.Retirement);
            this.panelRetirement.Controls.Add(this.iTalk_Label4);
            this.panelRetirement.Location = new System.Drawing.Point(233, 143);
            this.panelRetirement.Name = "panelRetirement";
            this.panelRetirement.Size = new System.Drawing.Size(193, 54);
            this.panelRetirement.TabIndex = 6;
            // 
            // panelHistory
            // 
            this.panelHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHistory.Controls.Add(this.employment_history);
            this.panelHistory.Controls.Add(this.iTalk_Label2);
            this.panelHistory.Location = new System.Drawing.Point(233, 83);
            this.panelHistory.Name = "panelHistory";
            this.panelHistory.Size = new System.Drawing.Size(193, 54);
            this.panelHistory.TabIndex = 4;
            // 
            // panelIncidence
            // 
            this.panelIncidence.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelIncidence.Controls.Add(this.iTalk_Label3);
            this.panelIncidence.Controls.Add(this.Incidence);
            this.panelIncidence.Location = new System.Drawing.Point(29, 143);
            this.panelIncidence.Name = "panelIncidence";
            this.panelIncidence.Size = new System.Drawing.Size(193, 54);
            this.panelIncidence.TabIndex = 5;
            // 
            // panelPerson
            // 
            this.panelPerson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPerson.Controls.Add(this.personNumber);
            this.panelPerson.Controls.Add(this.iTalk_Label1);
            this.panelPerson.Location = new System.Drawing.Point(29, 83);
            this.panelPerson.Name = "panelPerson";
            this.panelPerson.Size = new System.Drawing.Size(193, 54);
            this.panelPerson.TabIndex = 3;
            // 
            // Retirement
            // 
            this.Retirement.AutoSize = true;
            this.Retirement.BackColor = System.Drawing.Color.Transparent;
            this.Retirement.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Retirement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.Retirement.Location = new System.Drawing.Point(139, 20);
            this.Retirement.Name = "Retirement";
            this.Retirement.Size = new System.Drawing.Size(29, 13);
            this.Retirement.TabIndex = 12;
            this.Retirement.Text = "퇴사";
            // 
            // iTalk_Label4
            // 
            this.iTalk_Label4.AutoSize = true;
            this.iTalk_Label4.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label4.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label4.Location = new System.Drawing.Point(13, 20);
            this.iTalk_Label4.Name = "iTalk_Label4";
            this.iTalk_Label4.Size = new System.Drawing.Size(29, 13);
            this.iTalk_Label4.TabIndex = 11;
            this.iTalk_Label4.Text = "퇴사";
            // 
            // employment_history
            // 
            this.employment_history.AutoSize = true;
            this.employment_history.BackColor = System.Drawing.Color.Transparent;
            this.employment_history.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.employment_history.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.employment_history.Location = new System.Drawing.Point(139, 20);
            this.employment_history.Name = "employment_history";
            this.employment_history.Size = new System.Drawing.Size(29, 13);
            this.employment_history.TabIndex = 10;
            this.employment_history.Text = "업력";
            // 
            // iTalk_Label2
            // 
            this.iTalk_Label2.AutoSize = true;
            this.iTalk_Label2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label2.Location = new System.Drawing.Point(13, 20);
            this.iTalk_Label2.Name = "iTalk_Label2";
            this.iTalk_Label2.Size = new System.Drawing.Size(29, 13);
            this.iTalk_Label2.TabIndex = 9;
            this.iTalk_Label2.Text = "업력";
            // 
            // iTalk_Label3
            // 
            this.iTalk_Label3.AutoSize = true;
            this.iTalk_Label3.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label3.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label3.Location = new System.Drawing.Point(12, 20);
            this.iTalk_Label3.Name = "iTalk_Label3";
            this.iTalk_Label3.Size = new System.Drawing.Size(29, 13);
            this.iTalk_Label3.TabIndex = 10;
            this.iTalk_Label3.Text = "입사";
            // 
            // Incidence
            // 
            this.Incidence.AutoSize = true;
            this.Incidence.BackColor = System.Drawing.Color.Transparent;
            this.Incidence.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Incidence.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.Incidence.Location = new System.Drawing.Point(140, 20);
            this.Incidence.Name = "Incidence";
            this.Incidence.Size = new System.Drawing.Size(40, 13);
            this.Incidence.TabIndex = 9;
            this.Incidence.Text = "입사율";
            // 
            // personNumber
            // 
            this.personNumber.AutoSize = true;
            this.personNumber.BackColor = System.Drawing.Color.Transparent;
            this.personNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.personNumber.Location = new System.Drawing.Point(134, 14);
            this.personNumber.Name = "personNumber";
            this.personNumber.Size = new System.Drawing.Size(50, 25);
            this.personNumber.TabIndex = 8;
            this.personNumber.Text = "인원";
            // 
            // iTalk_Label1
            // 
            this.iTalk_Label1.AutoSize = true;
            this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label1.Location = new System.Drawing.Point(12, 20);
            this.iTalk_Label1.Name = "iTalk_Label1";
            this.iTalk_Label1.Size = new System.Drawing.Size(29, 13);
            this.iTalk_Label1.TabIndex = 7;
            this.iTalk_Label1.Text = "인원";
            // 
            // companyinformation
            // 
            this.companyinformation.AutoSize = true;
            this.companyinformation.BackColor = System.Drawing.Color.Transparent;
            this.companyinformation.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyinformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.companyinformation.Location = new System.Drawing.Point(15, 55);
            this.companyinformation.Name = "companyinformation";
            this.companyinformation.Size = new System.Drawing.Size(51, 13);
            this.companyinformation.TabIndex = 2;
            this.companyinformation.Text = "기업정보";
            // 
            // companyJob
            // 
            this.companyJob.AutoSize = true;
            this.companyJob.BackColor = System.Drawing.Color.Transparent;
            this.companyJob.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.companyJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.companyJob.Location = new System.Drawing.Point(15, 14);
            this.companyJob.Name = "companyJob";
            this.companyJob.Size = new System.Drawing.Size(67, 13);
            this.companyJob.TabIndex = 1;
            this.companyJob.Text = "iTalk_Label2";
            // 
            // jobSearch
            // 
            this.jobSearch.AutoWordSelection = false;
            this.jobSearch.BackColor = System.Drawing.Color.Transparent;
            this.jobSearch.Font = new System.Drawing.Font("Tahoma", 10F);
            this.jobSearch.ForeColor = System.Drawing.Color.DimGray;
            this.jobSearch.Location = new System.Drawing.Point(199, 4);
            this.jobSearch.Name = "jobSearch";
            this.jobSearch.ReadOnly = false;
            this.jobSearch.Size = new System.Drawing.Size(258, 31);
            this.jobSearch.TabIndex = 1;
            this.jobSearch.Text = "기업을 검색해보세요";
            this.jobSearch.WordWrap = true;
            this.jobSearch.Click += new System.EventHandler(this.jobSearch_Click);
            this.jobSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.jobSearch_KeyDown);
            this.jobSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.jobSearch_KeyPress);
            // 
            // companyname
            // 
            this.companyname.AutoSize = true;
            this.companyname.BackColor = System.Drawing.Color.Transparent;
            this.companyname.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.companyname.Location = new System.Drawing.Point(10, 51);
            this.companyname.Name = "companyname";
            this.companyname.Size = new System.Drawing.Size(111, 25);
            this.companyname.TabIndex = 0;
            this.companyname.Text = "iTalk_Label1";
            // 
            // KREDIT_JOBResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelCompany);
            this.Controls.Add(this.jobSearch);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.companyname);
            this.Name = "KREDIT_JOBResult";
            this.Size = new System.Drawing.Size(803, 445);
            this.Load += new System.EventHandler(this.KREDIT_JOBResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelCompany.ResumeLayout(false);
            this.panelCompany.PerformLayout();
            this.panelRetirement.ResumeLayout(false);
            this.panelRetirement.PerformLayout();
            this.panelHistory.ResumeLayout(false);
            this.panelHistory.PerformLayout();
            this.panelIncidence.ResumeLayout(false);
            this.panelIncidence.PerformLayout();
            this.panelPerson.ResumeLayout(false);
            this.panelPerson.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private iTalk.iTalk_RichTextBox jobSearch;
        private System.Windows.Forms.Panel panelCompany;
        private iTalk.iTalk_Label companyinformation;
        private iTalk.iTalk_Label companyJob;
        private iTalk.iTalk_Label companyname;
        private System.Windows.Forms.Panel panelRetirement;
        private iTalk.iTalk_Label Retirement;
        private iTalk.iTalk_Label iTalk_Label4;
        private System.Windows.Forms.Panel panelHistory;
        private iTalk.iTalk_Label employment_history;
        private iTalk.iTalk_Label iTalk_Label2;
        private System.Windows.Forms.Panel panelIncidence;
        private iTalk.iTalk_Label iTalk_Label3;
        private iTalk.iTalk_Label Incidence;
        private System.Windows.Forms.Panel panelPerson;
        private iTalk.iTalk_Label personNumber;
        private iTalk.iTalk_Label iTalk_Label1;
    }
}
