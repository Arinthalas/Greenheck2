namespace Greenheck_Project
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabOverview = new System.Windows.Forms.TabControl();
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
            this.tabPageSelection = new System.Windows.Forms.TabPage();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cbDept = new System.Windows.Forms.ComboBox();
            this.lblQuarter = new System.Windows.Forms.Label();
            this.cbQuarter = new System.Windows.Forms.ComboBox();
            this.lblTeam = new System.Windows.Forms.Label();
            this.cbTeams = new System.Windows.Forms.ComboBox();
            this.tabPageTeam = new System.Windows.Forms.TabPage();
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
            this.tabPageComments = new System.Windows.Forms.TabPage();
            this.lblFocus = new System.Windows.Forms.Label();
            this.cbFocus = new System.Windows.Forms.ComboBox();
            this.btnCommAdd = new System.Windows.Forms.Button();
            this.txtFocusComments = new System.Windows.Forms.TextBox();
            this.cbFocusProject = new System.Windows.Forms.ComboBox();
            this.cbFocusQuarter = new System.Windows.Forms.ComboBox();
            this.cbFocusYear = new System.Windows.Forms.ComboBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblComQuar = new System.Windows.Forms.Label();
            this.lblComYear = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chkFocus = new System.Windows.Forms.CheckedListBox();
            this.tabOverview.SuspendLayout();
            this.tabPageOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverview)).BeginInit();
            this.tabPageSelection.SuspendLayout();
            this.tabPageTeam.SuspendLayout();
            this.tabPageComments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabOverview
            // 
            this.tabOverview.Controls.Add(this.tabPageOverview);
            this.tabOverview.Controls.Add(this.tabPageSelection);
            this.tabOverview.Controls.Add(this.tabPageTeam);
            this.tabOverview.Controls.Add(this.tabPageComments);
            this.tabOverview.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabOverview.Location = new System.Drawing.Point(0, 225);
            this.tabOverview.Margin = new System.Windows.Forms.Padding(4);
            this.tabOverview.Name = "tabOverview";
            this.tabOverview.SelectedIndex = 0;
            this.tabOverview.Size = new System.Drawing.Size(1243, 494);
            this.tabOverview.TabIndex = 0;
            this.tabOverview.Tag = "";
            this.tabOverview.SelectedIndexChanged += new System.EventHandler(this.tabOverview_SelectedIndexChanged);
            // 
            // tabPageOverview
            // 
            this.tabPageOverview.AutoScroll = true;
            this.tabPageOverview.Controls.Add(this.btnFilter);
            this.tabPageOverview.Controls.Add(this.lblOvrYear);
            this.tabPageOverview.Controls.Add(this.cbOvrYear);
            this.tabPageOverview.Controls.Add(this.dgvOverview);
            this.tabPageOverview.Location = new System.Drawing.Point(4, 34);
            this.tabPageOverview.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageOverview.Name = "tabPageOverview";
            this.tabPageOverview.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageOverview.Size = new System.Drawing.Size(1235, 456);
            this.tabPageOverview.TabIndex = 0;
            this.tabPageOverview.Text = "Overview";
            this.tabPageOverview.UseVisualStyleBackColor = true;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(333, 53);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(161, 34);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // lblOvrYear
            // 
            this.lblOvrYear.AutoSize = true;
            this.lblOvrYear.Location = new System.Drawing.Point(11, 57);
            this.lblOvrYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOvrYear.Name = "lblOvrYear";
            this.lblOvrYear.Size = new System.Drawing.Size(115, 25);
            this.lblOvrYear.TabIndex = 2;
            this.lblOvrYear.Text = "Fiscal Year:";
            // 
            // cbOvrYear
            // 
            this.cbOvrYear.FormattingEnabled = true;
            this.cbOvrYear.Location = new System.Drawing.Point(141, 53);
            this.cbOvrYear.Margin = new System.Windows.Forms.Padding(4);
            this.cbOvrYear.Name = "cbOvrYear";
            this.cbOvrYear.Size = new System.Drawing.Size(160, 33);
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
            this.dgvOverview.Location = new System.Drawing.Point(4, 178);
            this.dgvOverview.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOverview.MultiSelect = false;
            this.dgvOverview.Name = "dgvOverview";
            this.dgvOverview.RowHeadersVisible = false;
            this.dgvOverview.Size = new System.Drawing.Size(1217, 208);
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
            this.clmHiatus.HeaderText = "On Hiatus";
            this.clmHiatus.Name = "clmHiatus";
            this.clmHiatus.ReadOnly = true;
            // 
            // clmCancelled
            // 
            this.clmCancelled.HeaderText = "Cancelled";
            this.clmCancelled.Name = "clmCancelled";
            // 
            // tabPageSelection
            // 
            this.tabPageSelection.Controls.Add(this.lblDepartment);
            this.tabPageSelection.Controls.Add(this.cbDept);
            this.tabPageSelection.Controls.Add(this.lblQuarter);
            this.tabPageSelection.Controls.Add(this.cbQuarter);
            this.tabPageSelection.Controls.Add(this.lblTeam);
            this.tabPageSelection.Controls.Add(this.cbTeams);
            this.tabPageSelection.Location = new System.Drawing.Point(4, 34);
            this.tabPageSelection.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageSelection.Name = "tabPageSelection";
            this.tabPageSelection.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageSelection.Size = new System.Drawing.Size(1235, 456);
            this.tabPageSelection.TabIndex = 1;
            this.tabPageSelection.Text = "Selection";
            this.tabPageSelection.UseVisualStyleBackColor = true;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(41, 42);
            this.lblDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(176, 25);
            this.lblDepartment.TabIndex = 5;
            this.lblDepartment.Text = "Department Name:";
            // 
            // cbDept
            // 
            this.cbDept.FormattingEnabled = true;
            this.cbDept.Location = new System.Drawing.Point(236, 38);
            this.cbDept.Margin = new System.Windows.Forms.Padding(4);
            this.cbDept.Name = "cbDept";
            this.cbDept.Size = new System.Drawing.Size(160, 33);
            this.cbDept.TabIndex = 4;
            this.cbDept.SelectedIndexChanged += new System.EventHandler(this.cbDept_SelectedIndexChanged);
            // 
            // lblQuarter
            // 
            this.lblQuarter.AutoSize = true;
            this.lblQuarter.Location = new System.Drawing.Point(41, 126);
            this.lblQuarter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuarter.Name = "lblQuarter";
            this.lblQuarter.Size = new System.Drawing.Size(84, 25);
            this.lblQuarter.TabIndex = 3;
            this.lblQuarter.Text = "Quarter:";
            this.lblQuarter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbQuarter
            // 
            this.cbQuarter.FormattingEnabled = true;
            this.cbQuarter.Location = new System.Drawing.Point(236, 122);
            this.cbQuarter.Margin = new System.Windows.Forms.Padding(4);
            this.cbQuarter.Name = "cbQuarter";
            this.cbQuarter.Size = new System.Drawing.Size(160, 33);
            this.cbQuarter.TabIndex = 2;
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Location = new System.Drawing.Point(41, 84);
            this.lblTeam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(126, 25);
            this.lblTeam.TabIndex = 1;
            this.lblTeam.Text = "Team Name:";
            this.lblTeam.UseMnemonic = false;
            // 
            // cbTeams
            // 
            this.cbTeams.FormattingEnabled = true;
            this.cbTeams.Location = new System.Drawing.Point(236, 80);
            this.cbTeams.Margin = new System.Windows.Forms.Padding(4);
            this.cbTeams.Name = "cbTeams";
            this.cbTeams.Size = new System.Drawing.Size(160, 33);
            this.cbTeams.TabIndex = 0;
            // 
            // tabPageTeam
            // 
            this.tabPageTeam.Controls.Add(this.txtDepartmentHead);
            this.tabPageTeam.Controls.Add(this.label6);
            this.tabPageTeam.Controls.Add(this.btnDelDepartment);
            this.tabPageTeam.Controls.Add(this.cbDelDepartment);
            this.tabPageTeam.Controls.Add(this.btnCreateDepartment);
            this.tabPageTeam.Controls.Add(this.txtDepartmentName);
            this.tabPageTeam.Controls.Add(this.label1);
            this.tabPageTeam.Controls.Add(this.btnDelProject);
            this.tabPageTeam.Controls.Add(this.cbDelProject);
            this.tabPageTeam.Controls.Add(this.btnCreateProject);
            this.tabPageTeam.Controls.Add(this.cbTeamID);
            this.tabPageTeam.Controls.Add(this.cbStatus);
            this.tabPageTeam.Controls.Add(this.label4);
            this.tabPageTeam.Controls.Add(this.label5);
            this.tabPageTeam.Controls.Add(this.txtProjectName);
            this.tabPageTeam.Controls.Add(this.label2);
            this.tabPageTeam.Controls.Add(this.cbDeptID);
            this.tabPageTeam.Controls.Add(this.cbDelTeam);
            this.tabPageTeam.Controls.Add(this.lblDeptID);
            this.tabPageTeam.Controls.Add(this.btnDelTeam);
            this.tabPageTeam.Controls.Add(this.btnCreateTeam);
            this.tabPageTeam.Controls.Add(this.txtTeamName);
            this.tabPageTeam.Controls.Add(this.lblTeams);
            this.tabPageTeam.Location = new System.Drawing.Point(4, 34);
            this.tabPageTeam.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageTeam.Name = "tabPageTeam";
            this.tabPageTeam.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageTeam.Size = new System.Drawing.Size(1235, 456);
            this.tabPageTeam.TabIndex = 2;
            this.tabPageTeam.Text = "Teams";
            this.tabPageTeam.UseVisualStyleBackColor = true;
            // 
            // txtDepartmentHead
            // 
            this.txtDepartmentHead.Location = new System.Drawing.Point(648, 111);
            this.txtDepartmentHead.Margin = new System.Windows.Forms.Padding(4);
            this.txtDepartmentHead.Name = "txtDepartmentHead";
            this.txtDepartmentHead.Size = new System.Drawing.Size(132, 30);
            this.txtDepartmentHead.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 25);
            this.label6.TabIndex = 24;
            this.label6.Text = "Department Head:";
            // 
            // btnDelDepartment
            // 
            this.btnDelDepartment.Location = new System.Drawing.Point(648, 373);
            this.btnDelDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelDepartment.Name = "btnDelDepartment";
            this.btnDelDepartment.Size = new System.Drawing.Size(132, 36);
            this.btnDelDepartment.TabIndex = 23;
            this.btnDelDepartment.Text = "Remove Department";
            this.btnDelDepartment.UseVisualStyleBackColor = true;
            this.btnDelDepartment.Click += new System.EventHandler(this.btnDelDepartment_Click);
            // 
            // cbDelDepartment
            // 
            this.cbDelDepartment.FormattingEnabled = true;
            this.cbDelDepartment.Location = new System.Drawing.Point(620, 296);
            this.cbDelDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.cbDelDepartment.Name = "cbDelDepartment";
            this.cbDelDepartment.Size = new System.Drawing.Size(160, 33);
            this.cbDelDepartment.TabIndex = 22;
            // 
            // btnCreateDepartment
            // 
            this.btnCreateDepartment.Location = new System.Drawing.Point(598, 186);
            this.btnCreateDepartment.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateDepartment.Name = "btnCreateDepartment";
            this.btnCreateDepartment.Size = new System.Drawing.Size(182, 34);
            this.btnCreateDepartment.TabIndex = 21;
            this.btnCreateDepartment.Text = "Add Department";
            this.btnCreateDepartment.UseVisualStyleBackColor = true;
            this.btnCreateDepartment.Click += new System.EventHandler(this.btnCreateDepartment_Click);
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Location = new System.Drawing.Point(648, 31);
            this.txtDepartmentName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(132, 30);
            this.txtDepartmentName.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Department Name:";
            // 
            // btnDelProject
            // 
            this.btnDelProject.Location = new System.Drawing.Point(1055, 373);
            this.btnDelProject.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelProject.Name = "btnDelProject";
            this.btnDelProject.Size = new System.Drawing.Size(132, 36);
            this.btnDelProject.TabIndex = 18;
            this.btnDelProject.Text = "Remove Team";
            this.btnDelProject.UseVisualStyleBackColor = true;
            this.btnDelProject.Click += new System.EventHandler(this.btnDelProject_Click);
            // 
            // cbDelProject
            // 
            this.cbDelProject.FormattingEnabled = true;
            this.cbDelProject.Location = new System.Drawing.Point(1027, 296);
            this.cbDelProject.Margin = new System.Windows.Forms.Padding(4);
            this.cbDelProject.Name = "cbDelProject";
            this.cbDelProject.Size = new System.Drawing.Size(160, 33);
            this.cbDelProject.TabIndex = 17;
            // 
            // btnCreateProject
            // 
            this.btnCreateProject.Location = new System.Drawing.Point(1044, 210);
            this.btnCreateProject.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateProject.Name = "btnCreateProject";
            this.btnCreateProject.Size = new System.Drawing.Size(132, 34);
            this.btnCreateProject.TabIndex = 16;
            this.btnCreateProject.Text = "Add Project";
            this.btnCreateProject.UseVisualStyleBackColor = true;
            this.btnCreateProject.Click += new System.EventHandler(this.btnCreateProject_Click);
            // 
            // cbTeamID
            // 
            this.cbTeamID.FormattingEnabled = true;
            this.cbTeamID.Location = new System.Drawing.Point(1043, 89);
            this.cbTeamID.Margin = new System.Windows.Forms.Padding(4);
            this.cbTeamID.Name = "cbTeamID";
            this.cbTeamID.Size = new System.Drawing.Size(132, 33);
            this.cbTeamID.TabIndex = 15;
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(1042, 147);
            this.cbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(132, 33);
            this.cbStatus.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(875, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(875, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Team ID:";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(1042, 30);
            this.txtProjectName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(132, 30);
            this.txtProjectName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(875, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Project Name:";
            // 
            // cbDeptID
            // 
            this.cbDeptID.FormattingEnabled = true;
            this.cbDeptID.Location = new System.Drawing.Point(208, 111);
            this.cbDeptID.Margin = new System.Windows.Forms.Padding(4);
            this.cbDeptID.Name = "cbDeptID";
            this.cbDeptID.Size = new System.Drawing.Size(132, 33);
            this.cbDeptID.TabIndex = 3;
            // 
            // cbDelTeam
            // 
            this.cbDelTeam.FormattingEnabled = true;
            this.cbDelTeam.Location = new System.Drawing.Point(180, 296);
            this.cbDelTeam.Margin = new System.Windows.Forms.Padding(4);
            this.cbDelTeam.Name = "cbDelTeam";
            this.cbDelTeam.Size = new System.Drawing.Size(160, 33);
            this.cbDelTeam.TabIndex = 5;
            // 
            // lblDeptID
            // 
            this.lblDeptID.AutoSize = true;
            this.lblDeptID.Location = new System.Drawing.Point(41, 114);
            this.lblDeptID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeptID.Name = "lblDeptID";
            this.lblDeptID.Size = new System.Drawing.Size(143, 25);
            this.lblDeptID.TabIndex = 6;
            this.lblDeptID.Text = "Department ID:";
            // 
            // btnDelTeam
            // 
            this.btnDelTeam.Location = new System.Drawing.Point(208, 373);
            this.btnDelTeam.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelTeam.Name = "btnDelTeam";
            this.btnDelTeam.Size = new System.Drawing.Size(132, 36);
            this.btnDelTeam.TabIndex = 6;
            this.btnDelTeam.Text = "Remove Team";
            this.btnDelTeam.UseVisualStyleBackColor = true;
            this.btnDelTeam.Click += new System.EventHandler(this.btnDelTeam_Click);
            // 
            // btnCreateTeam
            // 
            this.btnCreateTeam.Location = new System.Drawing.Point(208, 186);
            this.btnCreateTeam.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateTeam.Name = "btnCreateTeam";
            this.btnCreateTeam.Size = new System.Drawing.Size(132, 34);
            this.btnCreateTeam.TabIndex = 4;
            this.btnCreateTeam.Text = "Add Team";
            this.btnCreateTeam.UseVisualStyleBackColor = true;
            this.btnCreateTeam.Click += new System.EventHandler(this.btnCreateTeam_Click);
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(208, 31);
            this.txtTeamName.Margin = new System.Windows.Forms.Padding(4);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(132, 30);
            this.txtTeamName.TabIndex = 1;
            // 
            // lblTeams
            // 
            this.lblTeams.AutoSize = true;
            this.lblTeams.Location = new System.Drawing.Point(41, 34);
            this.lblTeams.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeams.Name = "lblTeams";
            this.lblTeams.Size = new System.Drawing.Size(126, 25);
            this.lblTeams.TabIndex = 0;
            this.lblTeams.Text = "Team Name:";
            // 
            // tabPageComments
            // 
            this.tabPageComments.Controls.Add(this.chkFocus);
            this.tabPageComments.Controls.Add(this.lblFocus);
            this.tabPageComments.Controls.Add(this.cbFocus);
            this.tabPageComments.Controls.Add(this.btnCommAdd);
            this.tabPageComments.Controls.Add(this.txtFocusComments);
            this.tabPageComments.Controls.Add(this.cbFocusProject);
            this.tabPageComments.Controls.Add(this.cbFocusQuarter);
            this.tabPageComments.Controls.Add(this.cbFocusYear);
            this.tabPageComments.Controls.Add(this.lblComments);
            this.tabPageComments.Controls.Add(this.label3);
            this.tabPageComments.Controls.Add(this.lblComQuar);
            this.tabPageComments.Controls.Add(this.lblComYear);
            this.tabPageComments.Location = new System.Drawing.Point(4, 34);
            this.tabPageComments.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageComments.Name = "tabPageComments";
            this.tabPageComments.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageComments.Size = new System.Drawing.Size(1235, 456);
            this.tabPageComments.TabIndex = 3;
            this.tabPageComments.Text = "Focus Comments";
            this.tabPageComments.UseVisualStyleBackColor = true;
            // 
            // lblFocus
            // 
            this.lblFocus.AutoSize = true;
            this.lblFocus.Location = new System.Drawing.Point(633, 76);
            this.lblFocus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFocus.Name = "lblFocus";
            this.lblFocus.Size = new System.Drawing.Size(72, 25);
            this.lblFocus.TabIndex = 10;
            this.lblFocus.Text = "Focus:";
            // 
            // cbFocus
            // 
            this.cbFocus.FormattingEnabled = true;
            this.cbFocus.Location = new System.Drawing.Point(724, 73);
            this.cbFocus.Margin = new System.Windows.Forms.Padding(4);
            this.cbFocus.Name = "cbFocus";
            this.cbFocus.Size = new System.Drawing.Size(160, 33);
            this.cbFocus.TabIndex = 4;
            // 
            // btnCommAdd
            // 
            this.btnCommAdd.Location = new System.Drawing.Point(1047, 407);
            this.btnCommAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnCommAdd.Name = "btnCommAdd";
            this.btnCommAdd.Size = new System.Drawing.Size(151, 36);
            this.btnCommAdd.TabIndex = 6;
            this.btnCommAdd.Text = "Add Comment";
            this.btnCommAdd.UseVisualStyleBackColor = true;
            this.btnCommAdd.Click += new System.EventHandler(this.btnCommAdd_Click);
            // 
            // txtFocusComments
            // 
            this.txtFocusComments.Location = new System.Drawing.Point(29, 156);
            this.txtFocusComments.Margin = new System.Windows.Forms.Padding(4);
            this.txtFocusComments.Multiline = true;
            this.txtFocusComments.Name = "txtFocusComments";
            this.txtFocusComments.Size = new System.Drawing.Size(1167, 223);
            this.txtFocusComments.TabIndex = 5;
            // 
            // cbFocusProject
            // 
            this.cbFocusProject.FormattingEnabled = true;
            this.cbFocusProject.Location = new System.Drawing.Point(724, 22);
            this.cbFocusProject.Margin = new System.Windows.Forms.Padding(4);
            this.cbFocusProject.Name = "cbFocusProject";
            this.cbFocusProject.Size = new System.Drawing.Size(160, 33);
            this.cbFocusProject.TabIndex = 3;
            // 
            // cbFocusQuarter
            // 
            this.cbFocusQuarter.FormattingEnabled = true;
            this.cbFocusQuarter.Location = new System.Drawing.Point(181, 69);
            this.cbFocusQuarter.Margin = new System.Windows.Forms.Padding(4);
            this.cbFocusQuarter.Name = "cbFocusQuarter";
            this.cbFocusQuarter.Size = new System.Drawing.Size(160, 33);
            this.cbFocusQuarter.TabIndex = 2;
            // 
            // cbFocusYear
            // 
            this.cbFocusYear.FormattingEnabled = true;
            this.cbFocusYear.Location = new System.Drawing.Point(181, 18);
            this.cbFocusYear.Margin = new System.Windows.Forms.Padding(4);
            this.cbFocusYear.Name = "cbFocusYear";
            this.cbFocusYear.Size = new System.Drawing.Size(160, 33);
            this.cbFocusYear.TabIndex = 1;
            this.cbFocusYear.SelectedIndexChanged += new System.EventHandler(this.cbFocusYear_SelectedIndexChanged);
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(24, 128);
            this.lblComments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(172, 25);
            this.lblComments.TabIndex = 3;
            this.lblComments.Text = "Focus Comments:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(633, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Project:";
            // 
            // lblComQuar
            // 
            this.lblComQuar.AutoSize = true;
            this.lblComQuar.Location = new System.Drawing.Point(24, 73);
            this.lblComQuar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComQuar.Name = "lblComQuar";
            this.lblComQuar.Size = new System.Drawing.Size(84, 25);
            this.lblComQuar.TabIndex = 1;
            this.lblComQuar.Text = "Quarter:";
            // 
            // lblComYear
            // 
            this.lblComYear.AutoSize = true;
            this.lblComYear.Location = new System.Drawing.Point(24, 22);
            this.lblComYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComYear.Name = "lblComYear";
            this.lblComYear.Size = new System.Drawing.Size(110, 25);
            this.lblComYear.TabIndex = 0;
            this.lblComYear.Text = "FiscalYear:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1243, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // chkFocus
            // 
            this.chkFocus.FormattingEnabled = true;
            this.chkFocus.Location = new System.Drawing.Point(929, 73);
            this.chkFocus.Name = "chkFocus";
            this.chkFocus.Size = new System.Drawing.Size(209, 54);
            this.chkFocus.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1243, 719);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabOverview);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Reporting Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabOverview.ResumeLayout(false);
            this.tabPageOverview.ResumeLayout(false);
            this.tabPageOverview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverview)).EndInit();
            this.tabPageSelection.ResumeLayout(false);
            this.tabPageSelection.PerformLayout();
            this.tabPageTeam.ResumeLayout(false);
            this.tabPageTeam.PerformLayout();
            this.tabPageComments.ResumeLayout(false);
            this.tabPageComments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabOverview;
        private System.Windows.Forms.TabPage tabPageOverview;
        private System.Windows.Forms.TabPage tabPageSelection;
        private System.Windows.Forms.Label lblQuarter;
        private System.Windows.Forms.ComboBox cbQuarter;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.ComboBox cbTeams;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cbDept;
        private System.Windows.Forms.TabPage tabPageTeam;
        private System.Windows.Forms.Button btnDelTeam;
        private System.Windows.Forms.Button btnCreateTeam;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label lblTeams;
        private System.Windows.Forms.Label lblDeptID;
        private System.Windows.Forms.DataGridView dgvOverview;
        private System.Windows.Forms.ComboBox cbDelTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuarter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBackLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOngoing;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHiatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCancelled;
        private System.Windows.Forms.TabPage tabPageComments;
        private System.Windows.Forms.Button btnCommAdd;
        private System.Windows.Forms.TextBox txtFocusComments;
        private System.Windows.Forms.ComboBox cbFocusProject;
        private System.Windows.Forms.ComboBox cbFocusQuarter;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblComQuar;
        private System.Windows.Forms.Label lblComYear;
        private System.Windows.Forms.ComboBox cbDeptID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFocus;
        private System.Windows.Forms.Label lblOvrYear;
        private System.Windows.Forms.ComboBox cbOvrYear;
        private System.Windows.Forms.Button btnFilter;
        protected System.Windows.Forms.ComboBox cbFocus;
        public System.Windows.Forms.ComboBox cbFocusYear;
        private System.Windows.Forms.Button btnCreateProject;
        private System.Windows.Forms.ComboBox cbTeamID;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelProject;
        private System.Windows.Forms.ComboBox cbDelProject;
        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreateDepartment;
        private System.Windows.Forms.TextBox txtDepartmentHead;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDelDepartment;
        private System.Windows.Forms.ComboBox cbDelDepartment;
        private System.Windows.Forms.CheckedListBox chkFocus;
    }
}

