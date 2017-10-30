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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabOverview = new System.Windows.Forms.TabControl();
            this.tabPageOverview = new System.Windows.Forms.TabPage();
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
            this.cbDeptID = new System.Windows.Forms.ComboBox();
            this.cbTeamID = new System.Windows.Forms.ComboBox();
            this.cbDelTeam = new System.Windows.Forms.ComboBox();
            this.lblDeptID = new System.Windows.Forms.Label();
            this.btnDelTeam = new System.Windows.Forms.Button();
            this.btnCreateTeam = new System.Windows.Forms.Button();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.lblTeamID = new System.Windows.Forms.Label();
            this.lblTeams = new System.Windows.Forms.Label();
            this.tabPageComments = new System.Windows.Forms.TabPage();
            this.btnCommAdd = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblComments = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblComQuar = new System.Windows.Forms.Label();
            this.lblComYear = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.tabOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabOverview.Location = new System.Drawing.Point(12, 142);
            this.tabOverview.Name = "tabOverview";
            this.tabOverview.SelectedIndex = 0;
            this.tabOverview.Size = new System.Drawing.Size(723, 401);
            this.tabOverview.TabIndex = 0;
            this.tabOverview.Tag = "";
            this.tabOverview.SelectedIndexChanged += new System.EventHandler(this.tabOverview_SelectedIndexChanged);
            // 
            // tabPageOverview
            // 
            this.tabPageOverview.Controls.Add(this.dgvOverview);
            this.tabPageOverview.Location = new System.Drawing.Point(4, 29);
            this.tabPageOverview.Name = "tabPageOverview";
            this.tabPageOverview.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOverview.Size = new System.Drawing.Size(715, 368);
            this.tabPageOverview.TabIndex = 0;
            this.tabPageOverview.Text = "Overview";
            this.tabPageOverview.UseVisualStyleBackColor = true;
            // 
            // dgvOverview
            // 
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
            this.dgvOverview.Location = new System.Drawing.Point(6, 75);
            this.dgvOverview.Name = "dgvOverview";
            this.dgvOverview.RowHeadersVisible = false;
            this.dgvOverview.Size = new System.Drawing.Size(705, 148);
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
            this.tabPageSelection.Location = new System.Drawing.Point(4, 29);
            this.tabPageSelection.Name = "tabPageSelection";
            this.tabPageSelection.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSelection.Size = new System.Drawing.Size(715, 368);
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
            // tabPageTeam
            // 
            this.tabPageTeam.Controls.Add(this.cbDeptID);
            this.tabPageTeam.Controls.Add(this.cbTeamID);
            this.tabPageTeam.Controls.Add(this.cbDelTeam);
            this.tabPageTeam.Controls.Add(this.lblDeptID);
            this.tabPageTeam.Controls.Add(this.btnDelTeam);
            this.tabPageTeam.Controls.Add(this.btnCreateTeam);
            this.tabPageTeam.Controls.Add(this.txtTeamName);
            this.tabPageTeam.Controls.Add(this.lblTeamID);
            this.tabPageTeam.Controls.Add(this.lblTeams);
            this.tabPageTeam.Location = new System.Drawing.Point(4, 29);
            this.tabPageTeam.Name = "tabPageTeam";
            this.tabPageTeam.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTeam.Size = new System.Drawing.Size(715, 368);
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
            this.cbDeptID.TabIndex = 10;
            // 
            // cbTeamID
            // 
            this.cbTeamID.FormattingEnabled = true;
            this.cbTeamID.Location = new System.Drawing.Point(156, 67);
            this.cbTeamID.Name = "cbTeamID";
            this.cbTeamID.Size = new System.Drawing.Size(100, 28);
            this.cbTeamID.TabIndex = 9;
            // 
            // cbDelTeam
            // 
            this.cbDelTeam.FormattingEnabled = true;
            this.cbDelTeam.Location = new System.Drawing.Point(385, 67);
            this.cbDelTeam.Name = "cbDelTeam";
            this.cbDelTeam.Size = new System.Drawing.Size(121, 28);
            this.cbDelTeam.TabIndex = 8;
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
            this.btnDelTeam.TabIndex = 5;
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
            this.txtTeamName.TabIndex = 2;
            // 
            // lblTeamID
            // 
            this.lblTeamID.AutoSize = true;
            this.lblTeamID.Location = new System.Drawing.Point(31, 70);
            this.lblTeamID.Name = "lblTeamID";
            this.lblTeamID.Size = new System.Drawing.Size(74, 20);
            this.lblTeamID.TabIndex = 1;
            this.lblTeamID.Text = "Team ID:";
            // 
            // lblTeams
            // 
            this.lblTeams.AutoSize = true;
            this.lblTeams.Location = new System.Drawing.Point(31, 31);
            this.lblTeams.Name = "lblTeams";
            this.lblTeams.Size = new System.Drawing.Size(99, 20);
            this.lblTeams.TabIndex = 0;
            this.lblTeams.Text = "Team Name:";
            // 
            // tabPageComments
            // 
            this.tabPageComments.Controls.Add(this.btnCommAdd);
            this.tabPageComments.Controls.Add(this.textBox1);
            this.tabPageComments.Controls.Add(this.comboBox3);
            this.tabPageComments.Controls.Add(this.comboBox2);
            this.tabPageComments.Controls.Add(this.comboBox1);
            this.tabPageComments.Controls.Add(this.lblComments);
            this.tabPageComments.Controls.Add(this.label3);
            this.tabPageComments.Controls.Add(this.lblComQuar);
            this.tabPageComments.Controls.Add(this.lblComYear);
            this.tabPageComments.Location = new System.Drawing.Point(4, 29);
            this.tabPageComments.Name = "tabPageComments";
            this.tabPageComments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageComments.Size = new System.Drawing.Size(715, 368);
            this.tabPageComments.TabIndex = 3;
            this.tabPageComments.Text = "Focus Comments";
            this.tabPageComments.UseVisualStyleBackColor = true;
            // 
            // btnCommAdd
            // 
            this.btnCommAdd.Location = new System.Drawing.Point(564, 135);
            this.btnCommAdd.Name = "btnCommAdd";
            this.btnCommAdd.Size = new System.Drawing.Size(113, 29);
            this.btnCommAdd.TabIndex = 8;
            this.btnCommAdd.Text = "Add Comment";
            this.btnCommAdd.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 170);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(655, 182);
            this.textBox1.TabIndex = 7;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(136, 93);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 28);
            this.comboBox3.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(136, 56);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(136, 15);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 4;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(18, 147);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(138, 20);
            this.lblComments.TabIndex = 3;
            this.lblComments.Text = "Focus Comments:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 96);
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
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "H:\\private\\CIS 480 Capstone\\ghlogo_notag.png";
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(661, 124);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(747, 555);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabOverview);
            this.Name = "Form1";
            this.Text = "Reporting Program";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabOverview.ResumeLayout(false);
            this.tabPageOverview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverview)).EndInit();
            this.tabPageSelection.ResumeLayout(false);
            this.tabPageSelection.PerformLayout();
            this.tabPageTeam.ResumeLayout(false);
            this.tabPageTeam.PerformLayout();
            this.tabPageComments.ResumeLayout(false);
            this.tabPageComments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label lblTeamID;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblComQuar;
        private System.Windows.Forms.Label lblComYear;
        private System.Windows.Forms.ComboBox cbTeamID;
        private System.Windows.Forms.ComboBox cbDeptID;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

