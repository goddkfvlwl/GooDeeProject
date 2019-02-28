namespace GoodeeProject
{
    partial class Agreement_enterprise_list
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
            this.agreementList1 = new MetroFramework.Controls.MetroListView();
            this.iTalk_HeaderLabel1 = new iTalk.iTalk_HeaderLabel();
            this.iTalk_Button_12 = new iTalk.iTalk_Button_1();
            this.SuspendLayout();
            // 
            // agreementList1
            // 
            this.agreementList1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.agreementList1.FullRowSelect = true;
            this.agreementList1.Location = new System.Drawing.Point(107, 79);
            this.agreementList1.Name = "agreementList1";
            this.agreementList1.OwnerDraw = true;
            this.agreementList1.Size = new System.Drawing.Size(604, 309);
            this.agreementList1.TabIndex = 7;
            this.agreementList1.UseCompatibleStateImageBehavior = false;
            this.agreementList1.UseSelectable = true;
            this.agreementList1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.agreementList1_ItemSelectionChanged);
            // 
            // iTalk_HeaderLabel1
            // 
            this.iTalk_HeaderLabel1.AutoSize = true;
            this.iTalk_HeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel1.Font = new System.Drawing.Font("함초롬돋움", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_HeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.iTalk_HeaderLabel1.Location = new System.Drawing.Point(13, 17);
            this.iTalk_HeaderLabel1.Name = "iTalk_HeaderLabel1";
            this.iTalk_HeaderLabel1.Size = new System.Drawing.Size(115, 43);
            this.iTalk_HeaderLabel1.TabIndex = 6;
            this.iTalk_HeaderLabel1.Text = "게시판";
            // 
            // iTalk_Button_12
            // 
            this.iTalk_Button_12.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_12.Font = new System.Drawing.Font("함초롬돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Button_12.Image = null;
            this.iTalk_Button_12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_12.Location = new System.Drawing.Point(737, 411);
            this.iTalk_Button_12.Name = "iTalk_Button_12";
            this.iTalk_Button_12.Size = new System.Drawing.Size(65, 26);
            this.iTalk_Button_12.TabIndex = 5;
            this.iTalk_Button_12.Text = "글쓰기";
            this.iTalk_Button_12.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // Agreement_enterprise_list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.agreementList1);
            this.Controls.Add(this.iTalk_HeaderLabel1);
            this.Controls.Add(this.iTalk_Button_12);
            this.Name = "Agreement_enterprise_list";
            this.Size = new System.Drawing.Size(815, 454);
            this.Load += new System.EventHandler(this.Agreement_enterprise_list_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroListView agreementList1;
        private iTalk.iTalk_HeaderLabel iTalk_HeaderLabel1;
        private iTalk.iTalk_Button_1 iTalk_Button_12;
    }
}
