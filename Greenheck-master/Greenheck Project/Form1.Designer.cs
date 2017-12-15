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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPageComments = new System.Windows.Forms.TabPage();
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
            this.tabPageTeam = new System.Windows.Forms.TabPage();
            this.cbDeptID = new System.Windows.Forms.ComboBox();
            this.cbDelTeam = new System.Windows.Forms.ComboBox();
            this.lblDeptID = new System.Windows.Forms.Label();
            this.btnDelTeam = new System.Windows.Forms.Button();
            this.btnCreateTeam = new System.Windows.Forms.Button();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.lblTeams = new System.Windows.Forms.Label();
            this.tabPageSelection = new System.Windows.Forms.TabPage();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cbDept = new System.Windows.Forms.ComboBox();
            this.lblQuarter = new System.Windows.Forms.Label();
            this.cbQuarter = new System.Windows.Forms.ComboBox();
            this.lblTeam = new System.Windows.Forms.Label();
            this.cbTeams = new System.Windows.Forms.ComboBox();
            this.tabPageOverview = new System.Windows.Forms.TabPage();
            this.btnFilter = new System.Windows.Forms.Button();
            this.lblOvrYear = new System.Windows.Forms.Label();
            this.cbOvrYear = new System.Windows.Forms.ComboBox();
            this.dgvOverview = new System.Windows.Forms.DataGridView();
            this.tabOverview = new System.Windows.Forms.TabControl();
            this.chkFocus = new System.Windows.Forms.CheckedListBox();
            this.clmYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuarter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBackLog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOngoing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHiatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCancelled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFocusUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageComments.SuspendLayout();
            this.tabPageTeam.SuspendLayout();
            this.tabPageSelection.SuspendLayout();
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
            // lblFocus
            // 
            this.lblFocus.AutoSize = true;
            this.lblFocus.Location = new System.Drawing.Point(269, 59);
            this.lblFocus.Name = "lblFocus";
            this.lblFocus.Size = new System.Drawing.Size(113, 20);
            this.lblFocus.TabIndex = 10;
            this.lblFocus.Text = "Project Status:";
            // 
            // cbFocusStatus
            // 
            this.cbFocusStatus.FormattingEnabled = true;
            this.cbFocusStatus.Location = new System.Drawing.Point(388, 56);
            this.cbFocusStatus.Name = "cbFocusStatus";
            this.cbFocusStatus.Size = new System.Drawing.Size(121, 28);
            this.cbFocusStatus.TabIndex = 4;
            // 
            // btnCommAdd
            // 
            this.btnCommAdd.Location = new System.Drawing.Point(564, 324);
            this.btnCommAdd.Name = "btnCommAdd";
            this.btnCommAdd.Size = new System.Drawing.Size(113, 29);
            this.btnCommAdd.TabIndex = 6;
            this.btnCommAdd.Text = "Add Comment";
            this.btnCommAdd.UseVisualStyleBackColor = true;
            // 
            // txtFocusComments
            // 
            this.txtFocusComments.Location = new System.Drawing.Point(22, 127);
            this.txtFocusComments.Multiline = true;
            this.txtFocusComments.Name = "txtFocusComments";
            this.txtFocusComments.Size = new System.Drawing.Size(655, 182);
            this.txtFocusComments.TabIndex = 5;
            // 
            // cbFocusProject
            // 
            this.cbFocusProject.FormattingEnabled = true;
            this.cbFocusProject.Location = new System.Drawing.Point(388, 15);
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
            this.cbFocusYear.SelectedIndexChanged += new System.EventHandler(this.cbFocusYear_SelectedIndexChanged);
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
            this.label3.Location = new System.Drawing.Point(320, 18);
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
            // tabPageTeam
            // 
            this.tabPageTeam.Controls.Add(this.cbDeptID);
            this.tabPageTeam.Controls.Add(this.cbDelTeam);
            this.tabPageTeam.Controls.Add(this.lblDeptID);
            this.tabPageTeam.Controls.Add(this.btnDelTeam);
            this.tabPageTeam.Controls.Add(this.btnCreateTeam);
            this.tabPageTeam.Controls.Add(this.txtTeamName);
            this.tabPageTeam.Controls.Add(this.lblTeams);
            this.tabPageTeam.Location = new System.Drawing.Point(4, 29);
            this.tabPageTeam.Name = "tabPageTeam";
            this.tabPageTeam.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTeam.Size = new System.Drawing.Size(924, 368);
            this.tabPageTeam.TabIndex = 2;
            this.tabPageTeam.Text = "Teams";
            this.tabPageTeam.UseVisualStyleBackColor = true;
            // 
            // cbDeptID
            // 
            this.cbDeptID.FormattingEnabled = true;
            this.cbDeptID.Location = new System.Drawing.Point(156, 115);
            this.cbDeptID.Name = "cbDeptID";
            this.cbDeptID.Size = new System.Drawing.Size(100, 28);
            this.cbDeptID.TabIndex = 3;
            // 
            // cbDelTeam
            // 
            this.cbDelTeam.FormattingEnabled = true;
            this.cbDelTeam.Location = new System.Drawing.Point(385, 67);
            this.cbDelTeam.Name = "cbDelTeam";
            this.cbDelTeam.Size = new System.Drawing.Size(121, 28);
            this.cbDelTeam.TabIndex = 5;
            // 
            // lblDeptID
            // 
            this.lblDeptID.AutoSize = true;
            this.lblDeptID.Location = new System.Drawing.Point(31, 118);
            this.lblDeptID.Name = "lblDeptID";
            this.lblDeptID.Size = new System.Drawing.Size(119, 20);
            this.lblDeptID.TabIndex = 6;
            this.lblDeptID.Text = "Department ID:";
            // 
            // btnDelTeam
            // 
            this.btnDelTeam.Location = new System.Drawing.Point(396, 118);
            this.btnDelTeam.Name = "btnDelTeam";
            this.btnDelTeam.Size = new System.Drawing.Size(99, 29);
            this.btnDelTeam.TabIndex = 6;
            this.btnDelTeam.Text = "Remove Team";
            this.btnDelTeam.UseVisualStyleBackColor = true;
            this.btnDelTeam.Click += new System.EventHandler(this.btnDelTeam_Click);
            // 
            // btnCreateTeam
            // 
            this.btnCreateTeam.Location = new System.Drawing.Point(94, 184);
            this.btnCreateTeam.Name = "btnCreateTeam";
            this.btnCreateTeam.Size = new System.Drawing.Size(99, 28);
            this.btnCreateTeam.TabIndex = 4;
            this.btnCreateTeam.Text = "Add Team";
            this.btnCreateTeam.UseVisualStyleBackColor = true;
            this.btnCreateTeam.Click += new System.EventHandler(this.btnCreateTeam_Click);
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(156, 25);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(100, 26);
            this.txtTeamName.TabIndex = 1;
            // 
            // lblTeams
            // 
            this.lblTeams.AutoSize = true;
            this.lblTeams.Location = new System.Drawing.Point(31, 28);
            this.lblTeams.Name = "lblTeams";
            this.lblTeams.Size = new System.Drawing.Size(99, 20);
            this.lblTeams.TabIndex = 0;
            this.lblTeams.Text = "Team Name:";
            // 
            // tabPageSelection
            // 
            this.tabPageSelection.Controls.Add(this.lblDepartment);
            this.tabPageSelection.Controls.Add(this.cbDept);
            this.tabPageSelection.Controls.Add(this.lblQuarter);
            this.tabPageSelection.Controls.Add(this.cbQuarter);
            this.tabPageSelection.Controls.Add(this.lblTeam);
            this.tabPageSelection.Controls.Add(this.cbTeams);
            this.tabPageSelection.Location = new System.Drawing.Point(4, 29);
            this.tabPageSelection.Name = "tabPageSelection";
            this.tabPageSelection.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSelection.Size = new System.Drawing.Size(924, 368);
            this.tabPageSelection.TabIndex = 1;
            this.tabPageSelection.Text = "Selection";
            this.tabPageSelection.UseVisualStyleBackColor = true;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(31, 34);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(144, 20);
            this.lblDepartment.TabIndex = 5;
            this.lblDepartment.Text = "Department Name:";
            // 
            // cbDept
            // 
            this.cbDept.FormattingEnabled = true;
            this.cbDept.Location = new System.Drawing.Point(177, 31);
            this.cbDept.Name = "cbDept";
            this.cbDept.Size = new System.Drawing.Size(121, 28);
            this.cbDept.TabIndex = 4;
            this.cbDept.SelectedIndexChanged += new System.EventHandler(this.cbDept_SelectedIndexChanged);
            // 
            // lblQuarter
            // 
            this.lblQuarter.AutoSize = true;
            this.lblQuarter.Location = new System.Drawing.Point(31, 102);
            this.lblQuarter.Name = "lblQuarter";
            this.lblQuarter.Size = new System.Drawing.Size(67, 20);
            this.lblQuarter.TabIndex = 3;
            this.lblQuarter.Text = "Quarter:";
            this.lblQuarter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbQuarter
            // 
            this.cbQuarter.FormattingEnabled = true;
            this.cbQuarter.Location = new System.Drawing.Point(177, 99);
            this.cbQuarter.Name = "cbQuarter";
            this.cbQuarter.Size = new System.Drawing.Size(121, 28);
            this.cbQuarter.TabIndex = 2;
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Location = new System.Drawing.Point(31, 68);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(99, 20);
            this.lblTeam.TabIndex = 1;
            this.lblTeam.Text = "Team Name:";
            this.lblTeam.UseMnemonic = false;
            // 
            // cbTeams
            // 
            this.cbTeams.FormattingEnabled = true;
            this.cbTeams.Location = new System.Drawing.Point(177, 65);
            this.cbTeams.Name = "cbTeams";
            this.cbTeams.Size = new System.Drawing.Size(121, 28);
            this.cbTeams.TabIndex = 0;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOverview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvOverview.ColumnHeadersHeight = 28;
            this.dgvOverview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmYear,
            this.clmQuarter,
            this.clmBackLog,
            this.clmOngoing,
            this.clmDone,
            this.clmHiatus,
            this.clmCancelled});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOverview.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOverview.Location = new System.Drawing.Point(3, 145);
            this.dgvOverview.MultiSelect = false;
            this.dgvOverview.Name = "dgvOverview";
            this.dgvOverview.RowHeadersVisible = false;
            this.dgvOverview.Size = new System.Drawing.Size(913, 169);
            this.dgvOverview.TabIndex = 0;
            this.dgvOverview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOverview_CellContentClick);
            // 
            // tabOverview
            // 
            this.tabOverview.Controls.Add(this.tabPageOverview);
            this.tabOverview.Controls.Add(this.tabPageSelection);
            this.tabOverview.Controls.Add(this.tabPageTeam);
            this.tabOverview.Controls.Add(this.tabPageComments);
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
            // chkFocus
            // 
            this.chkFocus.CheckOnClick = true;
            this.chkFocus.FormattingEnabled = true;
            this.chkFocus.Location = new System.Drawing.Point(705, 18);
            this.chkFocus.Margin = new System.Windows.Forms.Padding(2);
            this.chkFocus.Name = "chkFocus";
            this.chkFocus.Size = new System.Drawing.Size(158, 109);
            this.chkFocus.TabIndex = 12;
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
            // btnFocusUpdate
            // 
            this.btnFocusUpdate.Location = new System.Drawing.Point(692, 324);
            this.btnFocusUpdate.Name = "btnFocusUpdate";
            this.btnFocusUpdate.Size = new System.Drawing.Size(105, 29);
            this.btnFocusUpdate.TabIndex = 13;
            this.btnFocusUpdate.Text = "Update";
            this.btnFocusUpdate.UseVisualStyleBackColor = true;
            this.btnFocusUpdate.Click += new System.EventHandler(this.btnFocusUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(932, 584);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabOverview);
            this.Name = "Form1";
            this.Text = "Reporting Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageComments.ResumeLayout(false);
            this.tabPageComments.PerformLayout();
            this.tabPageTeam.ResumeLayout(false);
            this.tabPageTeam.PerformLayout();
            this.tabPageSelection.ResumeLayout(false);
            this.tabPageSelection.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPageTeam;
        private System.Windows.Forms.ComboBox cbDeptID;
        private System.Windows.Forms.ComboBox cbDelTeam;
        private System.Windows.Forms.Label lblDeptID;
        private System.Windows.Forms.Button btnDelTeam;
        private System.Windows.Forms.Button btnCreateTeam;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label lblTeams;
        private System.Windows.Forms.TabPage tabPageSelection;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cbDept;
        private System.Windows.Forms.Label lblQuarter;
        private System.Windows.Forms.ComboBox cbQuarter;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.ComboBox cbTeams;
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
    }
}

