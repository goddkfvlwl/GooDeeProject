namespace GoodeeProject
{
    partial class PortfolioDetail
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
            this.dpProjectStartDate = new System.Windows.Forms.DateTimePicker();
            this.dpProjectEndDate = new System.Windows.Forms.DateTimePicker();
            this.projectInfoPanel = new System.Windows.Forms.Panel();
            this.MemberCount = new System.Windows.Forms.NumericUpDown();
            this.ProjectPart = new System.Windows.Forms.TextBox();
            this.MemberCountInfo = new System.Windows.Forms.TextBox();
            this.DevPeriod = new System.Windows.Forms.TextBox();
            this.ProjectName = new System.Windows.Forms.TextBox();
            this.txtProjectPart = new System.Windows.Forms.TextBox();
            this.txtProjectTitle = new System.Windows.Forms.TextBox();
            this.iTalk_Label1 = new iTalk.iTalk_Label();
            this.lblProjectInfo = new iTalk.iTalk_HeaderLabel();
            this.useTechnologyPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.iTalk_HeaderLabel3 = new iTalk.iTalk_HeaderLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtDevEnvironment = new System.Windows.Forms.TextBox();
            this.DevEnvironment = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtUseTools = new System.Windows.Forms.TextBox();
            this.UseTools = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.UseTechnique = new System.Windows.Forms.TextBox();
            this.txtUseTechnique = new System.Windows.Forms.TextBox();
            this.PanelPortfolioBody = new System.Windows.Forms.FlowLayoutPanel();
            this.lblProjectPortfolio = new iTalk.iTalk_HeaderLabel();
            this.AddButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddTextBox = new System.Windows.Forms.Button();
            this.btnAddPictureBox = new System.Windows.Forms.Button();
            this.iTalk_Label2 = new iTalk.iTalk_Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblIntroduction = new iTalk.iTalk_HeaderLabel();
            this.introductionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.textboxTitle = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.projectInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemberCount)).BeginInit();
            this.useTechnologyPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.PanelPortfolioBody.SuspendLayout();
            this.AddButtonPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.introductionPanel.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dpProjectStartDate
            // 
            this.dpProjectStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpProjectStartDate.Location = new System.Drawing.Point(103, 99);
            this.dpProjectStartDate.Name = "dpProjectStartDate";
            this.dpProjectStartDate.Size = new System.Drawing.Size(90, 21);
            this.dpProjectStartDate.TabIndex = 14;
            // 
            // dpProjectEndDate
            // 
            this.dpProjectEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpProjectEndDate.Location = new System.Drawing.Point(224, 99);
            this.dpProjectEndDate.Name = "dpProjectEndDate";
            this.dpProjectEndDate.Size = new System.Drawing.Size(90, 21);
            this.dpProjectEndDate.TabIndex = 15;
            // 
            // projectInfoPanel
            // 
            this.projectInfoPanel.AutoSize = true;
            this.projectInfoPanel.Controls.Add(this.MemberCount);
            this.projectInfoPanel.Controls.Add(this.ProjectPart);
            this.projectInfoPanel.Controls.Add(this.MemberCountInfo);
            this.projectInfoPanel.Controls.Add(this.DevPeriod);
            this.projectInfoPanel.Controls.Add(this.ProjectName);
            this.projectInfoPanel.Controls.Add(this.txtProjectPart);
            this.projectInfoPanel.Controls.Add(this.txtProjectTitle);
            this.projectInfoPanel.Controls.Add(this.iTalk_Label1);
            this.projectInfoPanel.Controls.Add(this.dpProjectEndDate);
            this.projectInfoPanel.Controls.Add(this.lblProjectInfo);
            this.projectInfoPanel.Controls.Add(this.dpProjectStartDate);
            this.projectInfoPanel.Location = new System.Drawing.Point(3, 49);
            this.projectInfoPanel.Name = "projectInfoPanel";
            this.projectInfoPanel.Size = new System.Drawing.Size(730, 203);
            this.projectInfoPanel.TabIndex = 20;
            // 
            // MemberCount
            // 
            this.MemberCount.Location = new System.Drawing.Point(103, 139);
            this.MemberCount.Name = "MemberCount";
            this.MemberCount.Size = new System.Drawing.Size(120, 21);
            this.MemberCount.TabIndex = 25;
            // 
            // ProjectPart
            // 
            this.ProjectPart.Location = new System.Drawing.Point(3, 179);
            this.ProjectPart.Name = "ProjectPart";
            this.ProjectPart.ReadOnly = true;
            this.ProjectPart.Size = new System.Drawing.Size(100, 21);
            this.ProjectPart.TabIndex = 24;
            this.ProjectPart.Text = "담당업무";
            this.ProjectPart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MemberCountInfo
            // 
            this.MemberCountInfo.Location = new System.Drawing.Point(3, 139);
            this.MemberCountInfo.Name = "MemberCountInfo";
            this.MemberCountInfo.ReadOnly = true;
            this.MemberCountInfo.Size = new System.Drawing.Size(100, 21);
            this.MemberCountInfo.TabIndex = 23;
            this.MemberCountInfo.Text = "참여인원";
            this.MemberCountInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DevPeriod
            // 
            this.DevPeriod.Location = new System.Drawing.Point(3, 99);
            this.DevPeriod.Name = "DevPeriod";
            this.DevPeriod.ReadOnly = true;
            this.DevPeriod.Size = new System.Drawing.Size(100, 21);
            this.DevPeriod.TabIndex = 22;
            this.DevPeriod.Text = "개발기간";
            this.DevPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ProjectName
            // 
            this.ProjectName.Location = new System.Drawing.Point(3, 55);
            this.ProjectName.Name = "ProjectName";
            this.ProjectName.ReadOnly = true;
            this.ProjectName.Size = new System.Drawing.Size(100, 21);
            this.ProjectName.TabIndex = 21;
            this.ProjectName.Text = "프로젝트명";
            this.ProjectName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtProjectPart
            // 
            this.txtProjectPart.Location = new System.Drawing.Point(103, 179);
            this.txtProjectPart.Multiline = true;
            this.txtProjectPart.Name = "txtProjectPart";
            this.txtProjectPart.Size = new System.Drawing.Size(624, 21);
            this.txtProjectPart.TabIndex = 20;
            this.txtProjectPart.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // txtProjectTitle
            // 
            this.txtProjectTitle.Location = new System.Drawing.Point(103, 55);
            this.txtProjectTitle.Name = "txtProjectTitle";
            this.txtProjectTitle.Size = new System.Drawing.Size(624, 21);
            this.txtProjectTitle.TabIndex = 19;
            this.txtProjectTitle.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // iTalk_Label1
            // 
            this.iTalk_Label1.AutoSize = true;
            this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label1.Location = new System.Drawing.Point(201, 103);
            this.iTalk_Label1.Name = "iTalk_Label1";
            this.iTalk_Label1.Size = new System.Drawing.Size(15, 13);
            this.iTalk_Label1.TabIndex = 16;
            this.iTalk_Label1.Text = "~";
            // 
            // lblProjectInfo
            // 
            this.lblProjectInfo.AutoSize = true;
            this.lblProjectInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblProjectInfo.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblProjectInfo.Location = new System.Drawing.Point(4, 4);
            this.lblProjectInfo.Name = "lblProjectInfo";
            this.lblProjectInfo.Size = new System.Drawing.Size(116, 28);
            this.lblProjectInfo.TabIndex = 12;
            this.lblProjectInfo.Text = "Project Info";
            // 
            // useTechnologyPanel
            // 
            this.useTechnologyPanel.AutoSize = true;
            this.useTechnologyPanel.Controls.Add(this.iTalk_HeaderLabel3);
            this.useTechnologyPanel.Controls.Add(this.panel4);
            this.useTechnologyPanel.Controls.Add(this.panel5);
            this.useTechnologyPanel.Controls.Add(this.panel6);
            this.useTechnologyPanel.Location = new System.Drawing.Point(3, 258);
            this.useTechnologyPanel.Name = "useTechnologyPanel";
            this.useTechnologyPanel.Size = new System.Drawing.Size(795, 150);
            this.useTechnologyPanel.TabIndex = 22;
            // 
            // iTalk_HeaderLabel3
            // 
            this.iTalk_HeaderLabel3.AutoSize = true;
            this.iTalk_HeaderLabel3.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_HeaderLabel3.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iTalk_HeaderLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.iTalk_HeaderLabel3.Location = new System.Drawing.Point(3, 0);
            this.iTalk_HeaderLabel3.Name = "iTalk_HeaderLabel3";
            this.iTalk_HeaderLabel3.Size = new System.Drawing.Size(159, 28);
            this.iTalk_HeaderLabel3.TabIndex = 0;
            this.iTalk_HeaderLabel3.Text = "Use Technology";
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.txtDevEnvironment);
            this.panel4.Controls.Add(this.DevEnvironment);
            this.panel4.Location = new System.Drawing.Point(3, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(789, 35);
            this.panel4.TabIndex = 22;
            // 
            // txtDevEnvironment
            // 
            this.txtDevEnvironment.Location = new System.Drawing.Point(106, 11);
            this.txtDevEnvironment.Multiline = true;
            this.txtDevEnvironment.Name = "txtDevEnvironment";
            this.txtDevEnvironment.Size = new System.Drawing.Size(680, 21);
            this.txtDevEnvironment.TabIndex = 21;
            this.txtDevEnvironment.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // DevEnvironment
            // 
            this.DevEnvironment.Location = new System.Drawing.Point(6, 11);
            this.DevEnvironment.Name = "DevEnvironment";
            this.DevEnvironment.ReadOnly = true;
            this.DevEnvironment.Size = new System.Drawing.Size(100, 21);
            this.DevEnvironment.TabIndex = 25;
            this.DevEnvironment.Text = "개발환경";
            this.DevEnvironment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.Controls.Add(this.txtUseTools);
            this.panel5.Controls.Add(this.UseTools);
            this.panel5.Location = new System.Drawing.Point(3, 72);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(789, 34);
            this.panel5.TabIndex = 23;
            // 
            // txtUseTools
            // 
            this.txtUseTools.Location = new System.Drawing.Point(106, 10);
            this.txtUseTools.Multiline = true;
            this.txtUseTools.Name = "txtUseTools";
            this.txtUseTools.Size = new System.Drawing.Size(680, 21);
            this.txtUseTools.TabIndex = 23;
            this.txtUseTools.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // UseTools
            // 
            this.UseTools.Location = new System.Drawing.Point(6, 10);
            this.UseTools.Name = "UseTools";
            this.UseTools.ReadOnly = true;
            this.UseTools.Size = new System.Drawing.Size(100, 21);
            this.UseTools.TabIndex = 26;
            this.UseTools.Text = "사용도구";
            this.UseTools.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.Controls.Add(this.UseTechnique);
            this.panel6.Controls.Add(this.txtUseTechnique);
            this.panel6.Location = new System.Drawing.Point(3, 112);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(789, 35);
            this.panel6.TabIndex = 23;
            // 
            // UseTechnique
            // 
            this.UseTechnique.Location = new System.Drawing.Point(6, 11);
            this.UseTechnique.Name = "UseTechnique";
            this.UseTechnique.ReadOnly = true;
            this.UseTechnique.Size = new System.Drawing.Size(100, 21);
            this.UseTechnique.TabIndex = 27;
            this.UseTechnique.Text = "사용기술";
            this.UseTechnique.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUseTechnique
            // 
            this.txtUseTechnique.Location = new System.Drawing.Point(106, 11);
            this.txtUseTechnique.Multiline = true;
            this.txtUseTechnique.Name = "txtUseTechnique";
            this.txtUseTechnique.Size = new System.Drawing.Size(680, 21);
            this.txtUseTechnique.TabIndex = 24;
            this.txtUseTechnique.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // PanelPortfolioBody
            // 
            this.PanelPortfolioBody.AutoSize = true;
            this.PanelPortfolioBody.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelPortfolioBody.Controls.Add(this.lblProjectPortfolio);
            this.PanelPortfolioBody.Controls.Add(this.projectInfoPanel);
            this.PanelPortfolioBody.Controls.Add(this.useTechnologyPanel);
            this.PanelPortfolioBody.Controls.Add(this.AddButtonPanel);
            this.PanelPortfolioBody.Controls.Add(this.panel3);
            this.PanelPortfolioBody.Controls.Add(this.introductionPanel);
            this.PanelPortfolioBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelPortfolioBody.Location = new System.Drawing.Point(0, 0);
            this.PanelPortfolioBody.Name = "PanelPortfolioBody";
            this.PanelPortfolioBody.Size = new System.Drawing.Size(747, 529);
            this.PanelPortfolioBody.TabIndex = 21;
            // 
            // lblProjectPortfolio
            // 
            this.lblProjectPortfolio.AutoSize = true;
            this.lblProjectPortfolio.BackColor = System.Drawing.Color.Transparent;
            this.lblProjectPortfolio.Font = new System.Drawing.Font("맑은 고딕", 25F);
            this.lblProjectPortfolio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblProjectPortfolio.Location = new System.Drawing.Point(3, 0);
            this.lblProjectPortfolio.Name = "lblProjectPortfolio";
            this.lblProjectPortfolio.Size = new System.Drawing.Size(267, 46);
            this.lblProjectPortfolio.TabIndex = 6;
            this.lblProjectPortfolio.Text = "Project Portfolio";
            // 
            // AddButtonPanel
            // 
            this.AddButtonPanel.Controls.Add(this.btnAddTextBox);
            this.AddButtonPanel.Controls.Add(this.btnAddPictureBox);
            this.AddButtonPanel.Controls.Add(this.iTalk_Label2);
            this.AddButtonPanel.Location = new System.Drawing.Point(3, 414);
            this.AddButtonPanel.Name = "AddButtonPanel";
            this.AddButtonPanel.Size = new System.Drawing.Size(789, 31);
            this.AddButtonPanel.TabIndex = 21;
            // 
            // btnAddTextBox
            // 
            this.btnAddTextBox.AutoSize = true;
            this.btnAddTextBox.Location = new System.Drawing.Point(3, 3);
            this.btnAddTextBox.Name = "btnAddTextBox";
            this.btnAddTextBox.Size = new System.Drawing.Size(75, 23);
            this.btnAddTextBox.TabIndex = 0;
            this.btnAddTextBox.Text = "Text 추가";
            this.btnAddTextBox.UseVisualStyleBackColor = true;
            this.btnAddTextBox.Click += new System.EventHandler(this.btnAddTextBox_Click);
            // 
            // btnAddPictureBox
            // 
            this.btnAddPictureBox.AutoSize = true;
            this.btnAddPictureBox.Location = new System.Drawing.Point(84, 3);
            this.btnAddPictureBox.Name = "btnAddPictureBox";
            this.btnAddPictureBox.Size = new System.Drawing.Size(78, 23);
            this.btnAddPictureBox.TabIndex = 1;
            this.btnAddPictureBox.Text = "Image 추가";
            this.btnAddPictureBox.UseVisualStyleBackColor = true;
            this.btnAddPictureBox.Click += new System.EventHandler(this.btnAddPictureBox_Click);
            // 
            // iTalk_Label2
            // 
            this.iTalk_Label2.AutoSize = true;
            this.iTalk_Label2.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label2.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iTalk_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label2.Location = new System.Drawing.Point(168, 0);
            this.iTalk_Label2.Name = "iTalk_Label2";
            this.iTalk_Label2.Size = new System.Drawing.Size(458, 23);
            this.iTalk_Label2.TabIndex = 2;
            this.iTalk_Label2.Text = "이미지를 드레그하면 이미지의 크기를 조절할 수 있습니다.";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblIntroduction);
            this.panel3.Location = new System.Drawing.Point(3, 451);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(789, 38);
            this.panel3.TabIndex = 22;
            // 
            // lblIntroduction
            // 
            this.lblIntroduction.AutoSize = true;
            this.lblIntroduction.BackColor = System.Drawing.Color.Transparent;
            this.lblIntroduction.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntroduction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lblIntroduction.Location = new System.Drawing.Point(3, 6);
            this.lblIntroduction.Name = "lblIntroduction";
            this.lblIntroduction.Size = new System.Drawing.Size(124, 28);
            this.lblIntroduction.TabIndex = 7;
            this.lblIntroduction.Text = "Introduction";
            // 
            // introductionPanel
            // 
            this.introductionPanel.AutoSize = true;
            this.introductionPanel.Controls.Add(this.textboxTitle);
            this.introductionPanel.Location = new System.Drawing.Point(3, 495);
            this.introductionPanel.Name = "introductionPanel";
            this.introductionPanel.Size = new System.Drawing.Size(795, 27);
            this.introductionPanel.TabIndex = 22;
            // 
            // textboxTitle
            // 
            this.textboxTitle.Location = new System.Drawing.Point(3, 3);
            this.textboxTitle.Name = "textboxTitle";
            this.textboxTitle.Size = new System.Drawing.Size(789, 21);
            this.textboxTitle.TabIndex = 22;
            this.textboxTitle.Text = "Title";
            this.textboxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textboxTitle.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 26);
            // 
            // btnDelete
            // 
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 22);
            this.btnDelete.Text = "삭제";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // PortfolioDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.PanelPortfolioBody);
            this.Name = "PortfolioDetail";
            this.Size = new System.Drawing.Size(747, 454);
            this.projectInfoPanel.ResumeLayout(false);
            this.projectInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemberCount)).EndInit();
            this.useTechnologyPanel.ResumeLayout(false);
            this.useTechnologyPanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.PanelPortfolioBody.ResumeLayout(false);
            this.PanelPortfolioBody.PerformLayout();
            this.AddButtonPanel.ResumeLayout(false);
            this.AddButtonPanel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.introductionPanel.ResumeLayout(false);
            this.introductionPanel.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private iTalk.iTalk_HeaderLabel lblProjectPortfolio;
        private iTalk.iTalk_HeaderLabel lblProjectInfo;
        private System.Windows.Forms.DateTimePicker dpProjectStartDate;
        private System.Windows.Forms.DateTimePicker dpProjectEndDate;
        private iTalk.iTalk_Label iTalk_Label1;
        private System.Windows.Forms.Panel projectInfoPanel;
        private System.Windows.Forms.FlowLayoutPanel PanelPortfolioBody;
        private iTalk.iTalk_HeaderLabel iTalk_HeaderLabel3;
        private System.Windows.Forms.FlowLayoutPanel AddButtonPanel;
        private System.Windows.Forms.Button btnAddTextBox;
        private System.Windows.Forms.Button btnAddPictureBox;
        private iTalk.iTalk_HeaderLabel lblIntroduction;
        private System.Windows.Forms.Panel panel3;
        private iTalk.iTalk_Label iTalk_Label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnDelete;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.FlowLayoutPanel useTechnologyPanel;
        private System.Windows.Forms.TextBox txtProjectPart;
        private System.Windows.Forms.TextBox txtProjectTitle;
        private System.Windows.Forms.TextBox txtDevEnvironment;
        private System.Windows.Forms.TextBox txtUseTools;
        private System.Windows.Forms.TextBox txtUseTechnique;
        private System.Windows.Forms.TextBox textboxTitle;
        private System.Windows.Forms.TextBox ProjectPart;
        private System.Windows.Forms.TextBox MemberCountInfo;
        private System.Windows.Forms.TextBox DevPeriod;
        private System.Windows.Forms.TextBox ProjectName;
        private System.Windows.Forms.TextBox DevEnvironment;
        private System.Windows.Forms.TextBox UseTools;
        private System.Windows.Forms.TextBox UseTechnique;
        private System.Windows.Forms.NumericUpDown MemberCount;
        internal System.Windows.Forms.FlowLayoutPanel introductionPanel;
    }
}
