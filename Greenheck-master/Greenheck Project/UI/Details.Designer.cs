namespace Greenheck_Project.UI
{
    partial class Details
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.colProject = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTeam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProject,
            this.colStatus,
            this.colTeam});
            this.listView1.Location = new System.Drawing.Point(37, 105);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(278, 144);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // colProject
            // 
            this.colProject.Text = "Project";
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            this.colStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colTeam
            // 
            this.colTeam.Text = "Team";
            this.colTeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 379);
            this.Controls.Add(this.listView1);
            this.Name = "Details";
            this.Text = "DetailsForm";
            this.Load += new System.EventHandler(this.Details_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colProject;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.ColumnHeader colTeam;
    }
}