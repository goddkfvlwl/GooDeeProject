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
            this.useTechnologyPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.PanelPortfolioBody = new System.Windows.Forms.FlowLayoutPanel();
            this.AddButtonPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddTextBox = new System.Windows.Forms.Button();
            this.btnAddPictureBox = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.introductionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblProjectPortfolio = new iTalk.iTalk_HeaderLabel();
            this.txtProjectTitle = new iTalk.iTalk_TextBox_Small();
            this.lblProjectTitle = new iTalk.iTalk_Label();
            this.txtProjectPart = new iTalk.iTalk_TextBox_Big();
            this.lblProjectPeriod = new iTalk.iTalk_Label();
            this.MemberCount = new iTalk.iTalk_NumericUpDown();
            this.lblProjectMemberCount = new iTalk.iTalk_Label();
            this.iTalk_Label1 = new iTalk.iTalk_Label();
            this.lblProjectPart = new iTalk.iTalk_Label();
            this.lblProjectInfo = new iTalk.iTalk_HeaderLabel();
            this.iTalk_HeaderLabel3 = new iTalk.iTalk_HeaderLabel();
            this.txtDevEnvironment = new iTalk.iTalk_TextBox_Small();
            this.lblDevEnvironment = new iTalk.iTalk_Label();
            this.lblUseTools = new iTalk.iTalk_Label();
            this.txtUseTools = new iTalk.iTalk_TextBox_Small();
            this.txtUseTechnique = new iTalk.iTalk_TextBox_Small();
            this.lblUseTechnique = new iTalk.iTalk_Label();
            this.iTalk_Label2 = new iTalk.iTalk_Label();
            this.lblIntroduction = new iTalk.iTalk_HeaderLabel();
            this.textboxTitle = new iTalk.iTalk_TextBox_Small();
            this.projectInfoPanel.SuspendLayout();
            this.useTechnologyPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.PanelPortfolioBody.SuspendLayout();
            this.AddButtonPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.introductionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dpProjectStartDate
            // 
            this.dpProjectStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpProjectStartDate.Location = new System.Drawing.Point(94, 97);
            this.dpProjectStartDate.Name = "dpProjectStartDate";
            this.dpProjectStartDate.Size = new System.Drawing.Size(90, 21);
            this.dpProjectStartDate.TabIndex = 14;
            // 
            // dpProjectEndDate
            // 
            this.dpProjectEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpProjectEndDate.Location = new System.Drawing.Point(215, 97);
            this.dpProjectEndDate.Name = "dpProjectEndDate";
            this.dpProjectEndDate.Size = new System.Drawing.Size(90, 21);
            this.dpProjectEndDate.TabIndex = 15;
            // 
            // projectInfoPanel
            // 
            this.projectInfoPanel.AutoSize = true;
            this.projectInfoPanel.Controls.Add(this.txtProjectTitle);
            this.projectInfoPanel.Controls.Add(this.lblProjectTitle);
            this.projectInfoPanel.Controls.Add(this.txtProjectPart);
            this.projectInfoPanel.Controls.Add(this.lblProjectPeriod);
            this.projectInfoPanel.Controls.Add(this.MemberCount);
            this.projectInfoPanel.Controls.Add(this.lblProjectMemberCount);
            this.projectInfoPanel.Controls.Add(this.iTalk_Label1);
            this.projectInfoPanel.Controls.Add(this.lblProjectPart);
            this.projectInfoPanel.Controls.Add(this.dpProjectEndDate);
            this.projectInfoPanel.Controls.Add(this.lblProjectInfo);
            this.projectInfoPanel.Controls.Add(this.dpProjectStartDate);
            this.projectInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.projectInfoPanel.Location = new System.Drawing.Point(3, 49);
            this.projectInfoPanel.Name = "projectInfoPanel";
            this.projectInfoPanel.Size = new System.Drawing.Size(795, 258);
            this.projectInfoPanel.TabIndex = 20;
            // 
            // useTechnologyPanel
            // 
            this.useTechnologyPanel.AutoSize = true;
            this.useTechnologyPanel.Controls.Add(this.iTalk_HeaderLabel3);
            this.useTechnologyPanel.Controls.Add(this.panel4);
            this.useTechnologyPanel.Controls.Add(this.panel5);
            this.useTechnologyPanel.Controls.Add(this.panel6);
            this.useTechnologyPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.useTechnologyPanel.Location = new System.Drawing.Point(3, 313);
            this.useTechnologyPanel.Name = "useTechnologyPanel";
            this.useTechnologyPanel.Size = new System.Drawing.Size(798, 159);
            this.useTechnologyPanel.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.AutoSize = true;
            this.panel4.Controls.Add(this.txtDevEnvironment);
            this.panel4.Controls.Add(this.lblDevEnvironment);
            this.panel4.Location = new System.Drawing.Point(3, 31);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(792, 38);
            this.panel4.TabIndex = 22;
            // 
            // panel5
            // 
            this.panel5.AutoSize = true;
            this.panel5.Controls.Add(this.lblUseTools);
            this.panel5.Controls.Add(this.txtUseTools);
            this.panel5.Location = new System.Drawing.Point(3, 75);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(792, 37);
            this.panel5.TabIndex = 23;
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.Controls.Add(this.txtUseTechnique);
            this.panel6.Controls.Add(this.lblUseTechnique);
            this.panel6.Location = new System.Drawing.Point(3, 118);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(792, 38);
            this.panel6.TabIndex = 23;
            // 
            // PanelPortfolioBody
            // 
            this.PanelPortfolioBody.AutoSize = true;
            this.PanelPortfolioBody.Controls.Add(this.lblProjectPortfolio);
            this.PanelPortfolioBody.Controls.Add(this.projectInfoPanel);
            this.PanelPortfolioBody.Controls.Add(this.useTechnologyPanel);
            this.PanelPortfolioBody.Controls.Add(this.AddButtonPanel);
            this.PanelPortfolioBody.Controls.Add(this.panel3);
            this.PanelPortfolioBody.Controls.Add(this.introductionPanel);
            this.PanelPortfolioBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelPortfolioBody.Location = new System.Drawing.Point(0, 0);
            this.PanelPortfolioBody.Name = "PanelPortfolioBody";
            this.PanelPortfolioBody.Size = new System.Drawing.Size(798, 596);
            this.PanelPortfolioBody.TabIndex = 21;
            // 
            // AddButtonPanel
            // 
            this.AddButtonPanel.Controls.Add(this.btnAddTextBox);
            this.AddButtonPanel.Controls.Add(this.btnAddPictureBox);
            this.AddButtonPanel.Controls.Add(this.iTalk_Label2);
            this.AddButtonPanel.Location = new System.Drawing.Point(3, 478);
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
            // panel3
            // 
            this.panel3.Controls.Add(this.lblIntroduction);
            this.panel3.Location = new System.Drawing.Point(3, 515);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(789, 38);
            this.panel3.TabIndex = 22;
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
            // introductionPanel
            // 
            this.introductionPanel.AutoSize = true;
            this.introductionPanel.Controls.Add(this.textboxTitle);
            this.introductionPanel.Location = new System.Drawing.Point(3, 559);
            this.introductionPanel.Name = "introductionPanel";
            this.introductionPanel.Size = new System.Drawing.Size(795, 34);
            this.introductionPanel.TabIndex = 22;
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
            // txtProjectTitle
            // 
            this.txtProjectTitle.BackColor = System.Drawing.Color.Transparent;
            this.txtProjectTitle.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtProjectTitle.ForeColor = System.Drawing.Color.DimGray;
            this.txtProjectTitle.Location = new System.Drawing.Point(94, 53);
            this.txtProjectTitle.MaxLength = 32767;
            this.txtProjectTitle.Multiline = false;
            this.txtProjectTitle.Name = "txtProjectTitle";
            this.txtProjectTitle.ReadOnly = false;
            this.txtProjectTitle.Size = new System.Drawing.Size(135, 28);
            this.txtProjectTitle.TabIndex = 13;
            this.txtProjectTitle.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProjectTitle.UseSystemPasswordChar = false;
            // 
            // lblProjectTitle
            // 
            this.lblProjectTitle.AutoSize = true;
            this.lblProjectTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblProjectTitle.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblProjectTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lblProjectTitle.Location = new System.Drawing.Point(15, 59);
            this.lblProjectTitle.Name = "lblProjectTitle";
            this.lblProjectTitle.Size = new System.Drawing.Size(73, 17);
            this.lblProjectTitle.TabIndex = 8;
            this.lblProjectTitle.Text = "프로젝트명";
            // 
            // txtProjectPart
            // 
            this.txtProjectPart.BackColor = System.Drawing.Color.Transparent;
            this.txtProjectPart.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtProjectPart.ForeColor = System.Drawing.Color.DimGray;
            this.txtProjectPart.Image = null;
            this.txtProjectPart.Location = new System.Drawing.Point(83, 179);
            this.txtProjectPart.MaxLength = 32767;
            this.txtProjectPart.Multiline = true;
            this.txtProjectPart.Name = "txtProjectPart";
            this.txtProjectPart.ReadOnly = false;
            this.txtProjectPart.Size = new System.Drawing.Size(709, 76);
            this.txtProjectPart.TabIndex = 18;
            this.txtProjectPart.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProjectPart.UseSystemPasswordChar = false;
            this.txtProjectPart.TextChanged += new System.EventHandler(this.BigTextBox_TextChanged);
            // 
            // lblProjectPeriod
            // 
            this.lblProjectPeriod.AutoSize = true;
            this.lblProjectPeriod.BackColor = System.Drawing.Color.Transparent;
            this.lblProjectPeriod.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblProjectPeriod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lblProjectPeriod.Location = new System.Drawing.Point(15, 99);
            this.lblProjectPeriod.Name = "lblProjectPeriod";
            this.lblProjectPeriod.Size = new System.Drawing.Size(60, 17);
            this.lblProjectPeriod.TabIndex = 9;
            this.lblProjectPeriod.Text = "개발기간";
            // 
            // MemberCount
            // 
            this.MemberCount.BackColor = System.Drawing.Color.Transparent;
            this.MemberCount.Font = new System.Drawing.Font("Tahoma", 11F);
            this.MemberCount.ForeColor = System.Drawing.Color.DimGray;
            this.MemberCount.Location = new System.Drawing.Point(94, 134);
            this.MemberCount.Maximum = ((long)(100));
            this.MemberCount.Minimum = ((long)(0));
            this.MemberCount.MinimumSize = new System.Drawing.Size(62, 28);
            this.MemberCount.Name = "MemberCount";
            this.MemberCount.Size = new System.Drawing.Size(70, 28);
            this.MemberCount.TabIndex = 17;
            this.MemberCount.Text = "iTalk_NumericUpDown1";
            this.MemberCount.TextAlignment = iTalk.iTalk_NumericUpDown._TextAlignment.Near;
            this.MemberCount.Value = ((long)(0));
            // 
            // lblProjectMemberCount
            // 
            this.lblProjectMemberCount.AutoSize = true;
            this.lblProjectMemberCount.BackColor = System.Drawing.Color.Transparent;
            this.lblProjectMemberCount.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblProjectMemberCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lblProjectMemberCount.Location = new System.Drawing.Point(15, 139);
            this.lblProjectMemberCount.Name = "lblProjectMemberCount";
            this.lblProjectMemberCount.Size = new System.Drawing.Size(60, 17);
            this.lblProjectMemberCount.TabIndex = 10;
            this.lblProjectMemberCount.Text = "참여인원";
            // 
            // iTalk_Label1
            // 
            this.iTalk_Label1.AutoSize = true;
            this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
            this.iTalk_Label1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.iTalk_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.iTalk_Label1.Location = new System.Drawing.Point(194, 101);
            this.iTalk_Label1.Name = "iTalk_Label1";
            this.iTalk_Label1.Size = new System.Drawing.Size(15, 13);
            this.iTalk_Label1.TabIndex = 16;
            this.iTalk_Label1.Text = "~";
            // 
            // lblProjectPart
            // 
            this.lblProjectPart.AutoSize = true;
            this.lblProjectPart.BackColor = System.Drawing.Color.Transparent;
            this.lblProjectPart.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblProjectPart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lblProjectPart.Location = new System.Drawing.Point(15, 179);
            this.lblProjectPart.Name = "lblProjectPart";
            this.lblProjectPart.Size = new System.Drawing.Size(60, 17);
            this.lblProjectPart.TabIndex = 11;
            this.lblProjectPart.Text = "담당업무";
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
            // txtDevEnvironment
            // 
            this.txtDevEnvironment.BackColor = System.Drawing.Color.Transparent;
            this.txtDevEnvironment.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtDevEnvironment.ForeColor = System.Drawing.Color.DimGray;
            this.txtDevEnvironment.Location = new System.Drawing.Point(81, 7);
            this.txtDevEnvironment.MaxLength = 32767;
            this.txtDevEnvironment.Multiline = true;
            this.txtDevEnvironment.Name = "txtDevEnvironment";
            this.txtDevEnvironment.ReadOnly = false;
            this.txtDevEnvironment.Size = new System.Drawing.Size(708, 28);
            this.txtDevEnvironment.TabIndex = 4;
            this.txtDevEnvironment.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDevEnvironment.UseSystemPasswordChar = false;
            this.txtDevEnvironment.TextChanged += new System.EventHandler(this.SmallTextBox_TextChanged);
            // 
            // lblDevEnvironment
            // 
            this.lblDevEnvironment.AutoSize = true;
            this.lblDevEnvironment.BackColor = System.Drawing.Color.Transparent;
            this.lblDevEnvironment.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDevEnvironment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lblDevEnvironment.Location = new System.Drawing.Point(5, 13);
            this.lblDevEnvironment.Name = "lblDevEnvironment";
            this.lblDevEnvironment.Size = new System.Drawing.Size(60, 17);
            this.lblDevEnvironment.TabIndex = 1;
            this.lblDevEnvironment.Text = "개발환경";
            // 
            // lblUseTools
            // 
            this.lblUseTools.AutoSize = true;
            this.lblUseTools.BackColor = System.Drawing.Color.Transparent;
            this.lblUseTools.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblUseTools.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lblUseTools.Location = new System.Drawing.Point(5, 12);
            this.lblUseTools.Name = "lblUseTools";
            this.lblUseTools.Size = new System.Drawing.Size(60, 17);
            this.lblUseTools.TabIndex = 2;
            this.lblUseTools.Text = "사용도구";
            // 
            // txtUseTools
            // 
            this.txtUseTools.BackColor = System.Drawing.Color.Transparent;
            this.txtUseTools.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUseTools.ForeColor = System.Drawing.Color.DimGray;
            this.txtUseTools.Location = new System.Drawing.Point(81, 6);
            this.txtUseTools.MaxLength = 32767;
            this.txtUseTools.Multiline = true;
            this.txtUseTools.Name = "txtUseTools";
            this.txtUseTools.ReadOnly = false;
            this.txtUseTools.Size = new System.Drawing.Size(708, 28);
            this.txtUseTools.TabIndex = 5;
            this.txtUseTools.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUseTools.UseSystemPasswordChar = false;
            this.txtUseTools.TextChanged += new System.EventHandler(this.SmallTextBox_TextChanged);
            // 
            // txtUseTechnique
            // 
            this.txtUseTechnique.BackColor = System.Drawing.Color.Transparent;
            this.txtUseTechnique.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtUseTechnique.ForeColor = System.Drawing.Color.DimGray;
            this.txtUseTechnique.Location = new System.Drawing.Point(81, 7);
            this.txtUseTechnique.MaxLength = 32767;
            this.txtUseTechnique.Multiline = true;
            this.txtUseTechnique.Name = "txtUseTechnique";
            this.txtUseTechnique.ReadOnly = false;
            this.txtUseTechnique.Size = new System.Drawing.Size(708, 28);
            this.txtUseTechnique.TabIndex = 6;
            this.txtUseTechnique.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUseTechnique.UseSystemPasswordChar = false;
            this.txtUseTechnique.TextChanged += new System.EventHandler(this.SmallTextBox_TextChanged);
            // 
            // lblUseTechnique
            // 
            this.lblUseTechnique.AutoSize = true;
            this.lblUseTechnique.BackColor = System.Drawing.Color.Transparent;
            this.lblUseTechnique.Font = new System.Drawing.Font("맑은 고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblUseTechnique.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lblUseTechnique.Location = new System.Drawing.Point(5, 13);
            this.lblUseTechnique.Name = "lblUseTechnique";
            this.lblUseTechnique.Size = new System.Drawing.Size(60, 17);
            this.lblUseTechnique.TabIndex = 3;
            this.lblUseTechnique.Text = "사용기술";
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
            // textboxTitle
            // 
            this.textboxTitle.BackColor = System.Drawing.Color.Transparent;
            this.textboxTitle.Font = new System.Drawing.Font("Tahoma", 11F);
            this.textboxTitle.ForeColor = System.Drawing.Color.DimGray;
            this.textboxTitle.Location = new System.Drawing.Point(3, 3);
            this.textboxTitle.MaxLength = 32767;
            this.textboxTitle.Multiline = false;
            this.textboxTitle.Name = "textboxTitle";
            this.textboxTitle.ReadOnly = false;
            this.textboxTitle.Size = new System.Drawing.Size(789, 28);
            this.textboxTitle.TabIndex = 23;
            this.textboxTitle.Text = "Title";
            this.textboxTitle.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.textboxTitle.UseSystemPasswordChar = false;
            // 
            // PortfolioDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.PanelPortfolioBody);
            this.Name = "PortfolioDetail";
            this.Size = new System.Drawing.Size(815, 454);
            this.projectInfoPanel.ResumeLayout(false);
            this.projectInfoPanel.PerformLayout();
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
            this.contextMenuStrip1.ResumeLayout(false);
            this.introductionPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private iTalk.iTalk_HeaderLabel lblProjectPortfolio;
        private iTalk.iTalk_Label lblProjectTitle;
        private iTalk.iTalk_Label lblProjectPeriod;
        private iTalk.iTalk_Label lblProjectMemberCount;
        private iTalk.iTalk_Label lblProjectPart;
        private iTalk.iTalk_HeaderLabel lblProjectInfo;
        private iTalk.iTalk_TextBox_Small txtProjectTitle;
        private System.Windows.Forms.DateTimePicker dpProjectStartDate;
        private System.Windows.Forms.DateTimePicker dpProjectEndDate;
        private iTalk.iTalk_Label iTalk_Label1;
        private iTalk.iTalk_NumericUpDown MemberCount;
        private iTalk.iTalk_TextBox_Big txtProjectPart;
        private System.Windows.Forms.Panel projectInfoPanel;
        private System.Windows.Forms.FlowLayoutPanel PanelPortfolioBody;
        private iTalk.iTalk_TextBox_Small txtUseTechnique;
        private iTalk.iTalk_TextBox_Small txtUseTools;
        private iTalk.iTalk_TextBox_Small txtDevEnvironment;
        private iTalk.iTalk_Label lblUseTechnique;
        private iTalk.iTalk_Label lblUseTools;
        private iTalk.iTalk_Label lblDevEnvironment;
        private iTalk.iTalk_HeaderLabel iTalk_HeaderLabel3;
        private System.Windows.Forms.FlowLayoutPanel AddButtonPanel;
        private System.Windows.Forms.Button btnAddTextBox;
        private System.Windows.Forms.Button btnAddPictureBox;
        private iTalk.iTalk_HeaderLabel lblIntroduction;
        private System.Windows.Forms.Panel panel3;
        private iTalk.iTalk_Label iTalk_Label2;
        private iTalk.iTalk_TextBox_Small textboxTitle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnDelete;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.FlowLayoutPanel useTechnologyPanel;
        private System.Windows.Forms.FlowLayoutPanel introductionPanel;
    }
}
