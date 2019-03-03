namespace GoodeeProject
{
    partial class CommantLsit
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
            this.components = new System.ComponentModel.Container();
            this.agreementList1 = new System.Windows.Forms.ListView();
            this.iTalk_Button_11 = new iTalk.iTalk_Button_1();
            this.board = new iTalk.iTalk_Button_1();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.InsertComm = new iTalk.iTalk_Button_1();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // agreementList1
            // 
            this.agreementList1.Location = new System.Drawing.Point(80, 64);
            this.agreementList1.Name = "agreementList1";
            this.agreementList1.Size = new System.Drawing.Size(681, 288);
            this.agreementList1.TabIndex = 1;
            this.agreementList1.UseCompatibleStateImageBehavior = false;
            // 
            // iTalk_Button_11
            // 
            this.iTalk_Button_11.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Button_11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_Button_11.Image = null;
            this.iTalk_Button_11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iTalk_Button_11.Location = new System.Drawing.Point(767, 312);
            this.iTalk_Button_11.Name = "iTalk_Button_11";
            this.iTalk_Button_11.Size = new System.Drawing.Size(76, 40);
            this.iTalk_Button_11.TabIndex = 2;
            this.iTalk_Button_11.Text = "댓글달기";
            this.iTalk_Button_11.TextAlignment = System.Drawing.StringAlignment.Center;
            this.iTalk_Button_11.Click += new System.EventHandler(this.iTalk_Button_11_Click);
            // 
            // board
            // 
            this.board.BackColor = System.Drawing.Color.Transparent;
            this.board.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.board.Image = null;
            this.board.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.board.Location = new System.Drawing.Point(12, 12);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(57, 33);
            this.board.TabIndex = 3;
            this.board.Text = "본문";
            this.board.TextAlignment = System.Drawing.StringAlignment.Center;
            this.board.Click += new System.EventHandler(this.iTalk_Button_12_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(80, 359);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(681, 113);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "글을 작성해 주세요";
            this.richTextBox1.Visible = false;
            this.richTextBox1.Click += new System.EventHandler(this.richTextBox1_Click);
            // 
            // InsertComm
            // 
            this.InsertComm.BackColor = System.Drawing.Color.Transparent;
            this.InsertComm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertComm.Image = null;
            this.InsertComm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.InsertComm.Location = new System.Drawing.Point(767, 440);
            this.InsertComm.Name = "InsertComm";
            this.InsertComm.Size = new System.Drawing.Size(54, 32);
            this.InsertComm.TabIndex = 5;
            this.InsertComm.Text = "등록";
            this.InsertComm.TextAlignment = System.Drawing.StringAlignment.Center;
            this.InsertComm.Visible = false;
            this.InsertComm.Click += new System.EventHandler(this.InsertComm_Click);
            // 
            // CommantLsit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.InsertComm);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.board);
            this.Controls.Add(this.iTalk_Button_11);
            this.Controls.Add(this.agreementList1);
            this.Name = "CommantLsit";
            this.Size = new System.Drawing.Size(918, 556);
            this.Load += new System.EventHandler(this.CommantLsit_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView agreementList1;
        private iTalk.iTalk_Button_1 iTalk_Button_11;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private iTalk.iTalk_Button_1 InsertComm;
        private System.Windows.Forms.ToolTip toolTip1;
        internal iTalk.iTalk_Button_1 board;
    }
}
