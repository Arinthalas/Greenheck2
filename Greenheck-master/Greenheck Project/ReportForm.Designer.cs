namespace Greenheck_Project
{
    partial class ReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPageComments = new System.Windows.Forms.TabPage();
            this.btnFocusUpdate = new System.Windows.Forms.Button();
            this.chkFocus = new System.Windows.Forms.CheckedListBox();
            this.lblFocus = new System.Windows.Forms.Label();
            this.cbFocusStatus = new System.Windows.Forms.ComboBox();
            this.btnCommAdd = new System.Windows.Forms.Button();
            this.txtFocusComments = new System.Windows.Forms.TextBox();
            this.cbFocusProject = new System.Windows.Forms.ComboBox();
            this.cbFocusQuarter = new System.Windows.Forms.ComboBox();
            this.cbFocusYear = new System.Windows.Forms.ComboBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblComQuar = new System.Windows.Forms.Label();
            this.lblComYear = new System.Windows.Forms.Label();
            this.tabPageHR = new System.Windows.Forms.TabPage();
            this.lblRemProject = new System.Windows.Forms.Label();
            this.lblRemDepartment = new System.Windows.Forms.Label();
            this.lblRemTeam = new System.Windows.Forms.Label();
            this.lblProjectFocus = new System.Windows.Forms.Label();
            this.chkAddProjectFocus = new System.Windows.Forms.CheckedListBox();
            this.txtDepartmentHead = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelDepartment = new System.Windows.Forms.Button();
            this.cbDelDepartment = new System.Windows.Forms.ComboBox();
            this.btnCreateDepartment = new System.Windows.Forms.Button();
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelProject = new System.Windows.Forms.Button();
            this.cbDelProject = new System.Windows.Forms.ComboBox();
            this.btnCreateProject = new System.Windows.Forms.Button();
            this.cbTeamID = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDeptID = new System.Windows.Forms.ComboBox();
            this.cbDelTeam = new System.Windows.Forms.ComboBox();
            this.lblDeptID = new System.Windows.Forms.Label();
            this.btnDelTeam = new System.Windows.Forms.Button();
            this.btnCreateTeam = new System.Windows.Forms.Button();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.lblTeams = new System.Windows.Forms.Label();
            this.tabPageOverview = new System.Windows.Forms.TabPage();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblOvrYear = new System.Windows.Forms.Label();
            this.cbOvrYear = new System.Windows.Forms.ComboBox();
            this.dgvOverview = new System.Windows.Forms.DataGridView();
            this.clmYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuarter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBackLog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOngoing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHiatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCancelled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabOverview = new System.Windows.Forms.TabControl();
            this.btnDelFocusComment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageComments.SuspendLayout();
            this.tabPageHR.SuspendLayout();
            this.tabPageOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverview)).BeginInit();
            this.tabOverview.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(932, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tabPageComments
            // 
            this.tabPageComments.Controls.Add(this.btnDelFocusComment);
            this.tabPageComments.Controls.Add(this.btnFocusUpdate);
            this.tabPageComments.Controls.Add(this.chkFocus);
            this.tabPageComments.Controls.Add(this.lblFocus);
            this.tabPageComments.Controls.Add(this.cbFocusStatus);
            this.tabPageComments.Controls.Add(this.btnCommAdd);
            this.tabPageComments.Controls.Add(this.txtFocusComments);
            this.tabPageComments.Controls.Add(this.cbFocusProject);
            this.tabPageComments.Controls.Add(this.cbFocusQuarter);
            this.tabPageComments.Controls.Add(this.cbFocusYear);
            this.tabPageComments.Controls.Add(this.lblComments);
            this.tabPageComments.Controls.Add(this.label3);
            this.tabPageComments.Controls.Add(this.lblComQuar);
            this.tabPageComments.Controls.Add(this.lblComYear);
            this.tabPageComments.Location = new System.Drawing.Point(4, 29);
            this.tabPageComments.Name = "tabPageComments";
            this.tabPageComments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageComments.Size = new System.Drawing.Size(924, 368);
            this.tabPageComments.TabIndex = 3;
            this.tabPageComments.Text = "Focus Comments";
            this.tabPageComments.UseVisualStyleBackColor = true;
            // 
            // btnFocusUpdate
            // 
            this.btnFocusUpdate.Location = new System.Drawing.Point(631, 317);
            this.btnFocusUpdate.Name = "btnFocusUpdate";
            this.btnFocusUpdate.Size = new System.Drawing.Size(113, 29);
            this.btnFocusUpdate.TabIndex = 13;
            this.btnFocusUpdate.Text = "Update";
            this.btnFocusUpdate.UseVisualStyleBackColor = true;
            this.btnFocusUpdate.Click += new System.EventHandler(this.btnFocusUpdate_Click);
            // 
            // chkFocus
            // 
            this.chkFocus.CheckOnClick = true;
            this.chkFocus.FormattingEnabled = true;
            this.chkFocus.Location = new System.Drawing.Point(717, 127);
            this.chkFocus.Margin = new System.Windows.Forms.Padding(2);
            this.chkFocus.Name = "chkFocus";
            this.chkFocus.Size = new System.Drawing.Size(158, 172);
            this.chkFocus.TabIndex = 12;
            // 
            // lblFocus
            // 
            this.lblFocus.AutoSize = true;
            this.lblFocus.Location = new System.Drawing.Point(344, 59);
            this.lblFocus.Name = "lblFocus";
            this.lblFocus.Size = new System.Drawing.Size(113, 20);
            this.lblFocus.TabIndex = 10;
            this.lblFocus.Text = "Project Status:";
            // 
            // cbFocusStatus
            // 
            this.cbFocusStatus.FormattingEnabled = true;
            this.cbFocusStatus.Location = new System.Drawing.Point(463, 56);
            this.cbFocusStatus.Name = "cbFocusStatus";
            this.cbFocusStatus.Size = new System.Drawing.Size(121, 28);
            this.cbFocusStatus.TabIndex = 4;
            // 
            // btnCommAdd
            // 
            this.btnCommAdd.Location = new System.Drawing.Point(500, 317);
            this.btnCommAdd.Name = "btnCommAdd";
            this.btnCommAdd.Size = new System.Drawing.Size(113, 29);
            this.btnCommAdd.TabIndex = 6;
            this.btnCommAdd.Text = "Add Comment";
            this.btnCommAdd.UseVisualStyleBackColor = true;
            this.btnCommAdd.Click += new System.EventHandler(this.btnCommAdd_Click);
            // 
            // txtFocusComments
            // 
            this.txtFocusComments.Location = new System.Drawing.Point(22, 127);
            this.txtFocusComments.Multiline = true;
            this.txtFocusComments.Name = "txtFocusComments";
            this.txtFocusComments.Size = new System.Drawing.Size(655, 172);
            this.txtFocusComments.TabIndex = 5;
            // 
            // cbFocusProject
            // 
            this.cbFocusProject.FormattingEnabled = true;
            this.cbFocusProject.Location = new System.Drawing.Point(463, 15);
            this.cbFocusProject.Name = "cbFocusProject";
            this.cbFocusProject.Size = new System.Drawing.Size(121, 28);
            this.cbFocusProject.TabIndex = 3;
            // 
            // cbFocusQuarter
            // 
            this.cbFocusQuarter.FormattingEnabled = true;
            this.cbFocusQuarter.Location = new System.Drawing.Point(136, 56);
            this.cbFocusQuarter.Name = "cbFocusQuarter";
            this.cbFocusQuarter.Size = new System.Drawing.Size(121, 28);
            this.cbFocusQuarter.TabIndex = 2;
            // 
            // cbFocusYear
            // 
            this.cbFocusYear.FormattingEnabled = true;
            this.cbFocusYear.Location = new System.Drawing.Point(136, 15);
            this.cbFocusYear.Name = "cbFocusYear";
            this.cbFocusYear.Size = new System.Drawing.Size(121, 28);
            this.cbFocusYear.TabIndex = 1;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(18, 104);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(138, 20);
            this.lblComments.TabIndex = 3;
            this.lblComments.Text = "Focus Comments:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Project:";
            // 
            // lblComQuar
            // 
            this.lblComQuar.AutoSize = true;
            this.lblComQuar.Location = new System.Drawing.Point(18, 59);
            this.lblComQuar.Name = "lblComQuar";
            this.lblComQuar.Size = new System.Drawing.Size(67, 20);
            this.lblComQuar.TabIndex = 1;
            this.lblComQuar.Text = "Quarter:";
            // 
            // lblComYear
            // 
            this.lblComYear.AutoSize = true;
            this.lblComYear.Location = new System.Drawing.Point(18, 18);
            this.lblComYear.Name = "lblComYear";
            this.lblComYear.Size = new System.Drawing.Size(88, 20);
            this.lblComYear.TabIndex = 0;
            this.lblComYear.Text = "FiscalYear:";
            // 
            // tabPageHR
            // 
            this.tabPageHR.Controls.Add(this.lblRemProject);
            this.tabPageHR.Controls.Add(this.lblRemDepartment);
            this.tabPageHR.Controls.Add(this.lblRemTeam);
            this.tabPageHR.Controls.Add(this.lblProjectFocus);
            this.tabPageHR.Controls.Add(this.chkAddProjectFocus);
            this.tabPageHR.Controls.Add(this.txtDepartmentHead);
            this.tabPageHR.Controls.Add(this.label6);
            this.tabPageHR.Controls.Add(this.btnDelDepartment);
            this.tabPageHR.Controls.Add(this.cbDelDepartment);
            this.tabPageHR.Controls.Add(this.btnCreateDepartment);
            this.tabPageHR.Controls.Add(this.txtDepartmentName);
            this.tabPageHR.Controls.Add(this.label1);
            this.tabPageHR.Controls.Add(this.btnDelProject);
            this.tabPageHR.Controls.Add(this.cbDelProject);
            this.tabPageHR.Controls.Add(this.btnCreateProject);
            this.tabPageHR.Controls.Add(this.cbTeamID);
            this.tabPageHR.Controls.Add(this.cbStatus);
            this.tabPageHR.Controls.Add(this.label4);
            this.tabPageHR.Controls.Add(this.label5);
            this.tabPageHR.Controls.Add(this.txtProjectName);
            this.tabPageHR.Controls.Add(this.label2);
            this.tabPageHR.Controls.Add(this.cbDeptID);
            this.tabPageHR.Controls.Add(this.cbDelTeam);
            this.tabPageHR.Controls.Add(this.lblDeptID);
            this.tabPageHR.Controls.Add(this.btnDelTeam);
            this.tabPageHR.Controls.Add(this.btnCreateTeam);
            this.tabPageHR.Controls.Add(this.txtTeamName);
            this.tabPageHR.Controls.Add(this.lblTeams);
            this.tabPageHR.Location = new System.Drawing.Point(4, 29);
            this.tabPageHR.Name = "tabPageHR";
            this.tabPageHR.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHR.Size = new System.Drawing.Size(924, 368);
            this.tabPageHR.TabIndex = 2;
            this.tabPageHR.Text = "HR";
            this.tabPageHR.UseVisualStyleBackColor = true;
            // 
            // lblRemProject
            // 
            this.lblRemProject.AutoSize = true;
            this.lblRemProject.Location = new System.Drawing.Point(12, 303);
            this.lblRemProject.Name = "lblRemProject";
            this.lblRemProject.Size = new System.Drawing.Size(125, 20);
            this.lblRemProject.TabIndex = 53;
            this.lblRemProject.Text = "Remove Project:";
            // 
            // lblRemDepartment
            // 
            this.lblRemDepartment.AutoSize = true;
            this.lblRemDepartment.Location = new System.Drawing.Point(8, 258);
            this.lblRemDepartment.Name = "lblRemDepartment";
            this.lblRemDepartment.Size = new System.Drawing.Size(161, 20);
            this.lblRemDepartment.TabIndex = 52;
            this.lblRemDepartment.Text = "Remove Department:";
            // 
            // lblRemTeam
            // 
            this.lblRemTeam.AutoSize = true;
            this.lblRemTeam.Location = new System.Drawing.Point(8, 209);
            this.lblRemTeam.Name = "lblRemTeam";
            this.lblRemTeam.Size = new System.Drawing.Size(116, 20);
            this.lblRemTeam.TabIndex = 51;
            this.lblRemTeam.Text = "Remove Team:";
            // 
            // lblProjectFocus
            // 
            this.lblProjectFocus.AutoSize = true;
            this.lblProjectFocus.Location = new System.Drawing.Point(589, 164);
            this.lblProjectFocus.Name = "lblProjectFocus";
            this.lblProjectFocus.Size = new System.Drawing.Size(110, 20);
            this.lblProjectFocus.TabIndex = 50;
            this.lblProjectFocus.Text = "Project Focus:";
            // 
            // chkAddProjectFocus
            // 
            this.chkAddProjectFocus.CheckOnClick = true;
            this.chkAddProjectFocus.FormattingEnabled = true;
            this.chkAddProjectFocus.HorizontalScrollbar = true;
            this.chkAddProjectFocus.Location = new System.Drawing.Point(704, 164);
            this.chkAddProjectFocus.Margin = new System.Windows.Forms.Padding(2);
            this.chkAddProjectFocus.Name = "chkAddProjectFocus";
            this.chkAddProjectFocus.Size = new System.Drawing.Size(213, 130);
            this.chkAddProjectFocus.TabIndex = 49;
            // 
            // txtDepartmentHead
            // 
            this.txtDepartmentHead.Location = new System.Drawing.Point(459, 78);
            this.txtDepartmentHead.Name = "txtDepartmentHead";
            this.txtDepartmentHead.Size = new System.Drawing.Size(100, 26);
            this.txtDepartmentHead.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "Department Head:";
            // 
            // btnDelDepartment
            // 
            this.btnDelDepartment.Location = new System.Drawing.Point(316, 254);
            this.btnDelDepartment.Name = "btnDelDepartment";
            this.btnDelDepartment.Size = new System.Drawing.Size(121, 29);
            this.btnDelDepartment.TabIndex = 46;
            this.btnDelDepartment.Text = "Remove";
            this.btnDelDepartment.UseVisualStyleBackColor = true;
            this.btnDelDepartment.Click += new System.EventHandler(this.btnDelDepartment_Click);
            // 
            // cbDelDepartment
            // 
            this.cbDelDepartment.FormattingEnabled = true;
            this.cbDelDepartment.Location = new System.Drawing.Point(172, 255);
            this.cbDelDepartment.Name = "cbDelDepartment";
            this.cbDelDepartment.Size = new System.Drawing.Size(121, 28);
            this.cbDelDepartment.TabIndex = 45;
            // 
            // btnCreateDepartment
            // 
            this.btnCreateDepartment.Location = new System.Drawing.Point(423, 124);
            this.btnCreateDepartment.Name = "btnCreateDepartment";
            this.btnCreateDepartment.Size = new System.Drawing.Size(136, 28);
            this.btnCreateDepartment.TabIndex = 44;
            this.btnCreateDepartment.Text = "Add Department";
            this.btnCreateDepartment.UseVisualStyleBackColor = true;
            this.btnCreateDepartment.Click += new System.EventHandler(this.btnCreateDepartment_Click);
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Location = new System.Drawing.Point(459, 30);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(100, 26);
            this.txtDepartmentName.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 42;
            this.label1.Text = "Department Name:";
            // 
            // btnDelProject
            // 
            this.btnDelProject.Location = new System.Drawing.Point(316, 302);
            this.btnDelProject.Name = "btnDelProject";
            this.btnDelProject.Size = new System.Drawing.Size(121, 29);
            this.btnDelProject.TabIndex = 41;
            this.btnDelProject.Text = "Remove";
            this.btnDelProject.UseVisualStyleBackColor = true;
            this.btnDelProject.Click += new System.EventHandler(this.btnDelProject_Click);
            // 
            // cbDelProject
            // 
            this.cbDelProject.FormattingEnabled = true;
            this.cbDelProject.Location = new System.Drawing.Point(172, 303);
            this.cbDelProject.Name = "cbDelProject";
            this.cbDelProject.Size = new System.Drawing.Size(121, 28);
            this.cbDelProject.TabIndex = 40;
            // 
            // btnCreateProject
            // 
            this.btnCreateProject.Location = new System.Drawing.Point(715, 308);
            this.btnCreateProject.Name = "btnCreateProject";
            this.btnCreateProject.Size = new System.Drawing.Size(117, 28);
            this.btnCreateProject.TabIndex = 39;
            this.btnCreateProject.Text = "Add Project";
            this.btnCreateProject.UseVisualStyleBackColor = true;
            this.btnCreateProject.Click += new System.EventHandler(this.btnCreateProject_Click);
            // 
            // cbTeamID
            // 
            this.cbTeamID.FormattingEnabled = true;
            this.cbTeamID.Location = new System.Drawing.Point(704, 78);
            this.cbTeamID.Name = "cbTeamID";
            this.cbTeamID.Size = new System.Drawing.Size(117, 28);
            this.cbTeamID.TabIndex = 38;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(704, 125);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(117, 28);
            this.cbStatus.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(589, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(589, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Team ID:";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(704, 30);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(117, 26);
            this.txtProjectName.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(589, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Project Name:";
            // 
            // cbDeptID
            // 
            this.cbDeptID.FormattingEnabled = true;
            this.cbDeptID.Location = new System.Drawing.Point(157, 78);
            this.cbDeptID.Name = "cbDeptID";
            this.cbDeptID.Size = new System.Drawing.Size(101, 28);
            this.cbDeptID.TabIndex = 28;
            // 
            // cbDelTeam
            // 
            this.cbDelTeam.FormattingEnabled = true;
            this.cbDelTeam.Location = new System.Drawing.Point(172, 206);
            this.cbDelTeam.Name = "cbDelTeam";
            this.cbDelTeam.Size = new System.Drawing.Size(121, 28);
            this.cbDelTeam.TabIndex = 30;
            // 
            // lblDeptID
            // 
            this.lblDeptID.AutoSize = true;
            this.lblDeptID.Location = new System.Drawing.Point(23, 81);
            this.lblDeptID.Name = "lblDeptID";
            this.lblDeptID.Size = new System.Drawing.Size(119, 20);
            this.lblDeptID.TabIndex = 32;
            this.lblDeptID.Text = "Department ID:";
            // 
            // btnDelTeam
            // 
            this.btnDelTeam.Location = new System.Drawing.Point(316, 205);
            this.btnDelTeam.Name = "btnDelTeam";
            this.btnDelTeam.Size = new System.Drawing.Size(121, 29);
            this.btnDelTeam.TabIndex = 31;
            this.btnDelTeam.Text = "Remove";
            this.btnDelTeam.UseVisualStyleBackColor = true;
            this.btnDelTeam.Click += new System.EventHandler(this.btnDelTeam_Click);
            // 
            // btnCreateTeam
            // 
            this.btnCreateTeam.Location = new System.Drawing.Point(157, 124);
            this.btnCreateTeam.Name = "btnCreateTeam";
            this.btnCreateTeam.Size = new System.Drawing.Size(101, 28);
            this.btnCreateTeam.TabIndex = 29;
            this.btnCreateTeam.Text = "Add Team";
            this.btnCreateTeam.UseVisualStyleBackColor = true;
            this.btnCreateTeam.Click += new System.EventHandler(this.btnCreateTeam_Click);
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(157, 28);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(101, 26);
            this.txtTeamName.TabIndex = 27;
            // 
            // lblTeams
            // 
            this.lblTeams.AutoSize = true;
            this.lblTeams.Location = new System.Drawing.Point(33, 33);
            this.lblTeams.Name = "lblTeams";
            this.lblTeams.Size = new System.Drawing.Size(99, 20);
            this.lblTeams.TabIndex = 26;
            this.lblTeams.Text = "Team Name:";
            // 
            // tabPageOverview
            // 
            this.tabPageOverview.AutoScroll = true;
            this.tabPageOverview.Controls.Add(this.btnFilter);
            this.tabPageOverview.Controls.Add(this.lblOvrYear);
            this.tabPageOverview.Controls.Add(this.cbOvrYear);
            this.tabPageOverview.Controls.Add(this.dgvOverview);
            this.tabPageOverview.Location = new System.Drawing.Point(4, 29);
            this.tabPageOverview.Name = "tabPageOverview";
            this.tabPageOverview.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOverview.Size = new System.Drawing.Size(924, 368);
            this.tabPageOverview.TabIndex = 0;
            this.tabPageOverview.Text = "Overview";
            this.tabPageOverview.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(250, 43);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(121, 28);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblOvrYear
            // 
            this.lblOvrYear.AutoSize = true;
            this.lblOvrYear.Location = new System.Drawing.Point(8, 46);
            this.lblOvrYear.Name = "lblOvrYear";
            this.lblOvrYear.Size = new System.Drawing.Size(92, 20);
            this.lblOvrYear.TabIndex = 2;
            this.lblOvrYear.Text = "Fiscal Year:";
            // 
            // cbOvrYear
            // 
            this.cbOvrYear.FormattingEnabled = true;
            this.cbOvrYear.Location = new System.Drawing.Point(106, 43);
            this.cbOvrYear.Name = "cbOvrYear";
            this.cbOvrYear.Size = new System.Drawing.Size(121, 28);
            this.cbOvrYear.TabIndex = 1;
            // 
            // dgvOverview
            // 
            this.dgvOverview.AllowUserToAddRows = false;
            this.dgvOverview.AllowUserToDeleteRows = false;
            this.dgvOverview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOverview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOverview.ColumnHeadersHeight = 28;
            this.dgvOverview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmYear,
            this.clmQuarter,
            this.clmBackLog,
            this.clmOngoing,
            this.clmDone,
            this.clmHiatus,
            this.clmCancelled});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOverview.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOverview.Location = new System.Drawing.Point(3, 145);
            this.dgvOverview.MultiSelect = false;
            this.dgvOverview.Name = "dgvOverview";
            this.dgvOverview.RowHeadersVisible = false;
            this.dgvOverview.Size = new System.Drawing.Size(913, 169);
            this.dgvOverview.TabIndex = 0;
            this.dgvOverview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOverview_CellContentClick);
            // 
            // clmYear
            // 
            this.clmYear.HeaderText = "Fiscal Year";
            this.clmYear.Name = "clmYear";
            // 
            // clmQuarter
            // 
            this.clmQuarter.HeaderText = "Quarter";
            this.clmQuarter.Name = "clmQuarter";
            this.clmQuarter.ReadOnly = true;
            // 
            // clmBackLog
            // 
            this.clmBackLog.HeaderText = "Not Started";
            this.clmBackLog.Name = "clmBackLog";
            this.clmBackLog.ReadOnly = true;
            // 
            // clmOngoing
            // 
            this.clmOngoing.HeaderText = "In Progress";
            this.clmOngoing.Name = "clmOngoing";
            this.clmOngoing.ReadOnly = true;
            // 
            // clmDone
            // 
            this.clmDone.HeaderText = "Completed";
            this.clmDone.Name = "clmDone";
            this.clmDone.ReadOnly = true;
            // 
            // clmHiatus
            // 
            this.clmHiatus.HeaderText = "Delayed";
            this.clmHiatus.Name = "clmHiatus";
            this.clmHiatus.ReadOnly = true;
            // 
            // clmCancelled
            // 
            this.clmCancelled.HeaderText = "Cancelled";
            this.clmCancelled.Name = "clmCancelled";
            // 
            // tabOverview
            // 
            this.tabOverview.Controls.Add(this.tabPageOverview);
            this.tabOverview.Controls.Add(this.tabPageComments);
            this.tabOverview.Controls.Add(this.tabPageHR);
            this.tabOverview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabOverview.Location = new System.Drawing.Point(0, 183);
            this.tabOverview.Name = "tabOverview";
            this.tabOverview.SelectedIndex = 0;
            this.tabOverview.Size = new System.Drawing.Size(932, 401);
            this.tabOverview.TabIndex = 0;
            this.tabOverview.Tag = "";
            this.tabOverview.SelectedIndexChanged += new System.EventHandler(this.tabOverview_SelectedIndexChanged);
            // 
            // btnDelFocusComment
            // 
            this.btnDelFocusComment.Location = new System.Drawing.Point(763, 317);
            this.btnDelFocusComment.Name = "btnDelFocusComment";
            this.btnDelFocusComment.Size = new System.Drawing.Size(113, 29);
            this.btnDelFocusComment.TabIndex = 14;
            this.btnDelFocusComment.Text = "Remove";
            this.btnDelFocusComment.UseVisualStyleBackColor = true;
            this.btnDelFocusComment.Click += new System.EventHandler(this.btnDelFocusComment_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(932, 584);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabOverview);
            this.Name = "ReportForm";
            this.Text = "Reporting Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageComments.ResumeLayout(false);
            this.tabPageComments.PerformLayout();
            this.tabPageHR.ResumeLayout(false);
            this.tabPageHR.PerformLayout();
            this.tabPageOverview.ResumeLayout(false);
            this.tabPageOverview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverview)).EndInit();
            this.tabOverview.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPageComments;
        private System.Windows.Forms.Label lblFocus;
        protected System.Windows.Forms.ComboBox cbFocusStatus;
        private System.Windows.Forms.Button btnCommAdd;
        private System.Windows.Forms.TextBox txtFocusComments;
        private System.Windows.Forms.ComboBox cbFocusProject;
        private System.Windows.Forms.ComboBox cbFocusQuarter;
        public System.Windows.Forms.ComboBox cbFocusYear;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblComQuar;
        private System.Windows.Forms.Label lblComYear;
        private System.Windows.Forms.TabPage tabPageHR;
        private System.Windows.Forms.TabPage tabPageOverview;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Label lblOvrYear;
        private System.Windows.Forms.ComboBox cbOvrYear;
        private System.Windows.Forms.DataGridView dgvOverview;
        private System.Windows.Forms.TabControl tabOverview;
        private System.Windows.Forms.CheckedListBox chkFocus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuarter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBackLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOngoing;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHiatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCancelled;
        private System.Windows.Forms.Button btnFocusUpdate;
        private System.Windows.Forms.TextBox txtDepartmentHead;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelDepartment;
        private System.Windows.Forms.ComboBox cbDelDepartment;
        private System.Windows.Forms.Button btnCreateDepartment;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelProject;
        private System.Windows.Forms.ComboBox cbDelProject;
        private System.Windows.Forms.Button btnCreateProject;
        private System.Windows.Forms.ComboBox cbTeamID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDeptID;
        private System.Windows.Forms.ComboBox cbDelTeam;
        private System.Windows.Forms.Label lblDeptID;
        private System.Windows.Forms.Button btnDelTeam;
        private System.Windows.Forms.Button btnCreateTeam;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label lblTeams;
        private System.Windows.Forms.Label lblProjectFocus;
        private System.Windows.Forms.CheckedListBox chkAddProjectFocus;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lblRemProject;
        private System.Windows.Forms.Label lblRemDepartment;
        private System.Windows.Forms.Label lblRemTeam;
        private System.Windows.Forms.Button btnDelFocusComment;
    }
}

