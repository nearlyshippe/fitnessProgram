namespace fitnessTracker
{
    partial class searchActivity
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblActivityTitle = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setGoalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sEARCHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefrash = new System.Windows.Forms.Button();
            this.fitnessTrackerDataSet = new fitnessTracker.fitnessTrackerDataSet();
            this.trackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trackTableAdapter = new fitnessTracker.fitnessTrackerDataSetTableAdapters.TrackTableAdapter();
            this.trackIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activityTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCalBurnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessTrackerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblActivityTitle
            // 
            this.lblActivityTitle.AutoSize = true;
            this.lblActivityTitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivityTitle.ForeColor = System.Drawing.Color.White;
            this.lblActivityTitle.Location = new System.Drawing.Point(25, 90);
            this.lblActivityTitle.Name = "lblActivityTitle";
            this.lblActivityTitle.Size = new System.Drawing.Size(200, 38);
            this.lblActivityTitle.TabIndex = 0;
            this.lblActivityTitle.Text = "ACTIVITY TITLE";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(275, 135);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 35);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(30, 135);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(225, 30);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // dgvSearch
            // 
            this.dgvSearch.AllowUserToAddRows = false;
            this.dgvSearch.AutoGenerateColumns = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trackIDDataGridViewTextBoxColumn,
            this.activityTitleDataGridViewTextBoxColumn,
            this.totalCalBurnDataGridViewTextBoxColumn,
            this.trackStatusDataGridViewTextBoxColumn,
            this.memberIDDataGridViewTextBoxColumn,
            this.activityIDDataGridViewTextBoxColumn,
            this.trackingDateDataGridViewTextBoxColumn,
            this.goalDataGridViewTextBoxColumn});
            this.dgvSearch.DataSource = this.trackBindingSource;
            this.dgvSearch.Location = new System.Drawing.Point(12, 176);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSearch.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSearch.RowHeadersVisible = false;
            this.dgvSearch.RowHeadersWidth = 51;
            this.dgvSearch.RowTemplate.Height = 24;
            this.dgvSearch.Size = new System.Drawing.Size(818, 565);
            this.dgvSearch.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Salmon;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setGoalsToolStripMenuItem,
            this.trackingToolStripMenuItem,
            this.sEARCHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(842, 50);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // setGoalsToolStripMenuItem
            // 
            this.setGoalsToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setGoalsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.setGoalsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.setGoalsToolStripMenuItem.Name = "setGoalsToolStripMenuItem";
            this.setGoalsToolStripMenuItem.Size = new System.Drawing.Size(103, 46);
            this.setGoalsToolStripMenuItem.Text = "SET GOAL";
            this.setGoalsToolStripMenuItem.Click += new System.EventHandler(this.setGoalsToolStripMenuItem_Click);
            // 
            // trackingToolStripMenuItem
            // 
            this.trackingToolStripMenuItem.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trackingToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.trackingToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.trackingToolStripMenuItem.Name = "trackingToolStripMenuItem";
            this.trackingToolStripMenuItem.Size = new System.Drawing.Size(105, 46);
            this.trackingToolStripMenuItem.Text = "TRACKING";
            this.trackingToolStripMenuItem.Click += new System.EventHandler(this.trackingToolStripMenuItem_Click);
            // 
            // sEARCHToolStripMenuItem
            // 
            this.sEARCHToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.sEARCHToolStripMenuItem.Name = "sEARCHToolStripMenuItem";
            this.sEARCHToolStripMenuItem.Size = new System.Drawing.Size(78, 46);
            this.sEARCHToolStripMenuItem.Text = "SEARCH";
            // 
            // btnRefrash
            // 
            this.btnRefrash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnRefrash.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefrash.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrash.ForeColor = System.Drawing.Color.White;
            this.btnRefrash.Location = new System.Drawing.Point(400, 135);
            this.btnRefrash.Name = "btnRefrash";
            this.btnRefrash.Size = new System.Drawing.Size(100, 35);
            this.btnRefrash.TabIndex = 6;
            this.btnRefrash.Text = "Refrash";
            this.btnRefrash.UseVisualStyleBackColor = false;
            this.btnRefrash.Click += new System.EventHandler(this.btnRefrash_Click);
            // 
            // fitnessTrackerDataSet
            // 
            this.fitnessTrackerDataSet.DataSetName = "fitnessTrackerDataSet";
            this.fitnessTrackerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trackBindingSource
            // 
            this.trackBindingSource.DataMember = "Track";
            this.trackBindingSource.DataSource = this.fitnessTrackerDataSet;
            // 
            // trackTableAdapter
            // 
            this.trackTableAdapter.ClearBeforeFill = true;
            // 
            // trackIDDataGridViewTextBoxColumn
            // 
            this.trackIDDataGridViewTextBoxColumn.DataPropertyName = "trackID";
            this.trackIDDataGridViewTextBoxColumn.HeaderText = "trackID";
            this.trackIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trackIDDataGridViewTextBoxColumn.Name = "trackIDDataGridViewTextBoxColumn";
            this.trackIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.trackIDDataGridViewTextBoxColumn.Width = 75;
            // 
            // activityTitleDataGridViewTextBoxColumn
            // 
            this.activityTitleDataGridViewTextBoxColumn.DataPropertyName = "activityTitle";
            this.activityTitleDataGridViewTextBoxColumn.HeaderText = "Activity";
            this.activityTitleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.activityTitleDataGridViewTextBoxColumn.Name = "activityTitleDataGridViewTextBoxColumn";
            this.activityTitleDataGridViewTextBoxColumn.ReadOnly = true;
            this.activityTitleDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalCalBurnDataGridViewTextBoxColumn
            // 
            this.totalCalBurnDataGridViewTextBoxColumn.DataPropertyName = "totalCalBurn";
            this.totalCalBurnDataGridViewTextBoxColumn.HeaderText = "Total Calories Burn";
            this.totalCalBurnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalCalBurnDataGridViewTextBoxColumn.Name = "totalCalBurnDataGridViewTextBoxColumn";
            this.totalCalBurnDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalCalBurnDataGridViewTextBoxColumn.Width = 125;
            // 
            // trackStatusDataGridViewTextBoxColumn
            // 
            this.trackStatusDataGridViewTextBoxColumn.DataPropertyName = "trackStatus";
            this.trackStatusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.trackStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trackStatusDataGridViewTextBoxColumn.Name = "trackStatusDataGridViewTextBoxColumn";
            this.trackStatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memberIDDataGridViewTextBoxColumn
            // 
            this.memberIDDataGridViewTextBoxColumn.DataPropertyName = "memberID";
            this.memberIDDataGridViewTextBoxColumn.HeaderText = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberIDDataGridViewTextBoxColumn.Name = "memberIDDataGridViewTextBoxColumn";
            this.memberIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.memberIDDataGridViewTextBoxColumn.Width = 75;
            // 
            // activityIDDataGridViewTextBoxColumn
            // 
            this.activityIDDataGridViewTextBoxColumn.DataPropertyName = "activityID";
            this.activityIDDataGridViewTextBoxColumn.HeaderText = "ActivityID";
            this.activityIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.activityIDDataGridViewTextBoxColumn.Name = "activityIDDataGridViewTextBoxColumn";
            this.activityIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.activityIDDataGridViewTextBoxColumn.Width = 75;
            // 
            // trackingDateDataGridViewTextBoxColumn
            // 
            this.trackingDateDataGridViewTextBoxColumn.DataPropertyName = "trackingDate";
            this.trackingDateDataGridViewTextBoxColumn.HeaderText = "track Date";
            this.trackingDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trackingDateDataGridViewTextBoxColumn.Name = "trackingDateDataGridViewTextBoxColumn";
            this.trackingDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.trackingDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // goalDataGridViewTextBoxColumn
            // 
            this.goalDataGridViewTextBoxColumn.DataPropertyName = "Goal";
            this.goalDataGridViewTextBoxColumn.HeaderText = "Goal";
            this.goalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goalDataGridViewTextBoxColumn.Name = "goalDataGridViewTextBoxColumn";
            this.goalDataGridViewTextBoxColumn.ReadOnly = true;
            this.goalDataGridViewTextBoxColumn.Width = 50;
            // 
            // searchActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(842, 753);
            this.Controls.Add(this.btnRefrash);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblActivityTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "searchActivity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.searchActivity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessTrackerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblActivityTitle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setGoalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trackingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sEARCHToolStripMenuItem;
        private System.Windows.Forms.Button btnRefrash;
        private fitnessTrackerDataSet fitnessTrackerDataSet;
        private System.Windows.Forms.BindingSource trackBindingSource;
        private fitnessTrackerDataSetTableAdapters.TrackTableAdapter trackTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activityTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalCalBurnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trackingDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goalDataGridViewTextBoxColumn;
    }
}