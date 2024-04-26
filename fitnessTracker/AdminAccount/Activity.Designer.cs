namespace fitnessTracker
{
    partial class Activity
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.activityDataGrid = new System.Windows.Forms.DataGridView();
            this.activitiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fitnessTrackerDataSet = new fitnessTracker.fitnessTrackerDataSet();
            this.lblactivityID = new System.Windows.Forms.Label();
            this.lblactivityTitle = new System.Windows.Forms.Label();
            this.txtactivityTitle = new System.Windows.Forms.TextBox();
            this.txtactivityID = new System.Windows.Forms.TextBox();
            this.lblMetric3 = new System.Windows.Forms.Label();
            this.lblMetric2 = new System.Windows.Forms.Label();
            this.lblMetric1 = new System.Windows.Forms.Label();
            this.txtMetric1 = new System.Windows.Forms.TextBox();
            this.txtMetric2 = new System.Windows.Forms.TextBox();
            this.txtMetric3 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.activitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminsTableAdapter = new fitnessTracker.fitnessTrackerDataSetTableAdapters.adminsTableAdapter();
            this.activitiesTableAdapter = new fitnessTracker.fitnessTrackerDataSetTableAdapters.activitiesTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.activityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activityTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metric1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metric2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metric3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.activityDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessTrackerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // activityDataGrid
            // 
            this.activityDataGrid.AllowUserToAddRows = false;
            this.activityDataGrid.AutoGenerateColumns = false;
            this.activityDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.activityDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.activityDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activityDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.activityIDDataGridViewTextBoxColumn,
            this.activityTitleDataGridViewTextBoxColumn,
            this.metric1DataGridViewTextBoxColumn,
            this.metric2DataGridViewTextBoxColumn,
            this.metric3DataGridViewTextBoxColumn});
            this.activityDataGrid.DataSource = this.activitiesBindingSource1;
            this.activityDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.activityDataGrid.Location = new System.Drawing.Point(154, 371);
            this.activityDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activityDataGrid.Name = "activityDataGrid";
            this.activityDataGrid.ReadOnly = true;
            this.activityDataGrid.RowHeadersVisible = false;
            this.activityDataGrid.RowHeadersWidth = 51;
            this.activityDataGrid.RowTemplate.Height = 24;
            this.activityDataGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.activityDataGrid.Size = new System.Drawing.Size(627, 185);
            this.activityDataGrid.TabIndex = 0;
            this.activityDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.activityDataGrid_CellClick);
            // 
            // activitiesBindingSource1
            // 
            this.activitiesBindingSource1.DataMember = "activities";
            this.activitiesBindingSource1.DataSource = this.fitnessTrackerDataSet;
            // 
            // fitnessTrackerDataSet
            // 
            this.fitnessTrackerDataSet.DataSetName = "fitnessTrackerDataSet";
            this.fitnessTrackerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblactivityID
            // 
            this.lblactivityID.AutoSize = true;
            this.lblactivityID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblactivityID.ForeColor = System.Drawing.Color.White;
            this.lblactivityID.Location = new System.Drawing.Point(130, 50);
            this.lblactivityID.Name = "lblactivityID";
            this.lblactivityID.Size = new System.Drawing.Size(104, 19);
            this.lblactivityID.TabIndex = 5;
            this.lblactivityID.Text = "ACTIVITY ID";
            // 
            // lblactivityTitle
            // 
            this.lblactivityTitle.AutoSize = true;
            this.lblactivityTitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblactivityTitle.ForeColor = System.Drawing.Color.White;
            this.lblactivityTitle.Location = new System.Drawing.Point(130, 100);
            this.lblactivityTitle.Name = "lblactivityTitle";
            this.lblactivityTitle.Size = new System.Drawing.Size(130, 19);
            this.lblactivityTitle.TabIndex = 4;
            this.lblactivityTitle.Text = "ACTIVITY TITLE";
            // 
            // txtactivityTitle
            // 
            this.txtactivityTitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtactivityTitle.Location = new System.Drawing.Point(335, 90);
            this.txtactivityTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtactivityTitle.Name = "txtactivityTitle";
            this.txtactivityTitle.Size = new System.Drawing.Size(199, 26);
            this.txtactivityTitle.TabIndex = 6;
            // 
            // txtactivityID
            // 
            this.txtactivityID.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtactivityID.Location = new System.Drawing.Point(335, 40);
            this.txtactivityID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtactivityID.Name = "txtactivityID";
            this.txtactivityID.Size = new System.Drawing.Size(199, 26);
            this.txtactivityID.TabIndex = 7;
            // 
            // lblMetric3
            // 
            this.lblMetric3.AutoSize = true;
            this.lblMetric3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetric3.ForeColor = System.Drawing.Color.White;
            this.lblMetric3.Location = new System.Drawing.Point(130, 250);
            this.lblMetric3.Name = "lblMetric3";
            this.lblMetric3.Size = new System.Drawing.Size(90, 19);
            this.lblMetric3.TabIndex = 8;
            this.lblMetric3.Text = "METRIC III";
            // 
            // lblMetric2
            // 
            this.lblMetric2.AutoSize = true;
            this.lblMetric2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetric2.ForeColor = System.Drawing.Color.White;
            this.lblMetric2.Location = new System.Drawing.Point(130, 200);
            this.lblMetric2.Name = "lblMetric2";
            this.lblMetric2.Size = new System.Drawing.Size(85, 19);
            this.lblMetric2.TabIndex = 9;
            this.lblMetric2.Text = "METRIC II";
            // 
            // lblMetric1
            // 
            this.lblMetric1.AutoSize = true;
            this.lblMetric1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMetric1.ForeColor = System.Drawing.Color.White;
            this.lblMetric1.Location = new System.Drawing.Point(130, 150);
            this.lblMetric1.Name = "lblMetric1";
            this.lblMetric1.Size = new System.Drawing.Size(80, 19);
            this.lblMetric1.TabIndex = 10;
            this.lblMetric1.Text = "METRIC I";
            // 
            // txtMetric1
            // 
            this.txtMetric1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMetric1.Location = new System.Drawing.Point(335, 140);
            this.txtMetric1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMetric1.Name = "txtMetric1";
            this.txtMetric1.Size = new System.Drawing.Size(199, 26);
            this.txtMetric1.TabIndex = 11;
            // 
            // txtMetric2
            // 
            this.txtMetric2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMetric2.Location = new System.Drawing.Point(335, 190);
            this.txtMetric2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMetric2.Name = "txtMetric2";
            this.txtMetric2.Size = new System.Drawing.Size(199, 26);
            this.txtMetric2.TabIndex = 12;
            // 
            // txtMetric3
            // 
            this.txtMetric3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMetric3.Location = new System.Drawing.Point(335, 240);
            this.txtMetric3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMetric3.Name = "txtMetric3";
            this.txtMetric3.Size = new System.Drawing.Size(199, 26);
            this.txtMetric3.TabIndex = 13;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(187, 283);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 43);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(27, 283);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 43);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(507, 283);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(133, 43);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(347, 283);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 43);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(400, 572);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 43);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // activitiesBindingSource
            // 
            this.activitiesBindingSource.DataMember = "activities";
            this.activitiesBindingSource.DataSource = this.fitnessTrackerDataSet;
            // 
            // adminsBindingSource
            // 
            this.adminsBindingSource.DataMember = "admins";
            this.adminsBindingSource.DataSource = this.fitnessTrackerDataSet;
            // 
            // adminsTableAdapter
            // 
            this.adminsTableAdapter.ClearBeforeFill = true;
            // 
            // activitiesTableAdapter
            // 
            this.activitiesTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMetric2);
            this.groupBox1.Controls.Add(this.lblactivityTitle);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.lblactivityID);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.txtactivityTitle);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.txtactivityID);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lblMetric3);
            this.groupBox1.Controls.Add(this.txtMetric3);
            this.groupBox1.Controls.Add(this.lblMetric2);
            this.groupBox1.Controls.Add(this.lblMetric1);
            this.groupBox1.Controls.Add(this.txtMetric1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(127, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(667, 336);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ACTIVITY";
            // 
            // activityIDDataGridViewTextBoxColumn
            // 
            this.activityIDDataGridViewTextBoxColumn.DataPropertyName = "activityID";
            this.activityIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.activityIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.activityIDDataGridViewTextBoxColumn.Name = "activityIDDataGridViewTextBoxColumn";
            this.activityIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.activityIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // activityTitleDataGridViewTextBoxColumn
            // 
            this.activityTitleDataGridViewTextBoxColumn.DataPropertyName = "activityTitle";
            this.activityTitleDataGridViewTextBoxColumn.HeaderText = "Activity Title";
            this.activityTitleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.activityTitleDataGridViewTextBoxColumn.Name = "activityTitleDataGridViewTextBoxColumn";
            this.activityTitleDataGridViewTextBoxColumn.ReadOnly = true;
            this.activityTitleDataGridViewTextBoxColumn.Width = 125;
            // 
            // metric1DataGridViewTextBoxColumn
            // 
            this.metric1DataGridViewTextBoxColumn.DataPropertyName = "metric1";
            this.metric1DataGridViewTextBoxColumn.HeaderText = "Metric";
            this.metric1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.metric1DataGridViewTextBoxColumn.Name = "metric1DataGridViewTextBoxColumn";
            this.metric1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // metric2DataGridViewTextBoxColumn
            // 
            this.metric2DataGridViewTextBoxColumn.DataPropertyName = "metric2";
            this.metric2DataGridViewTextBoxColumn.HeaderText = "Metric";
            this.metric2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.metric2DataGridViewTextBoxColumn.Name = "metric2DataGridViewTextBoxColumn";
            this.metric2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // metric3DataGridViewTextBoxColumn
            // 
            this.metric3DataGridViewTextBoxColumn.DataPropertyName = "metric3";
            this.metric3DataGridViewTextBoxColumn.HeaderText = "Metric";
            this.metric3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.metric3DataGridViewTextBoxColumn.Name = "metric3DataGridViewTextBoxColumn";
            this.metric3DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Activity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(912, 629);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.activityDataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Activity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activity";
            this.Load += new System.EventHandler(this.Activity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activityDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessTrackerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activitiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView activityDataGrid;
        private fitnessTrackerDataSet fitnessTrackerDataSet;
        private System.Windows.Forms.BindingSource adminsBindingSource;
        private fitnessTrackerDataSetTableAdapters.adminsTableAdapter adminsTableAdapter;
        private System.Windows.Forms.BindingSource activitiesBindingSource;
        private fitnessTrackerDataSetTableAdapters.activitiesTableAdapter activitiesTableAdapter;
        private System.Windows.Forms.Label lblactivityID;
        private System.Windows.Forms.Label lblactivityTitle;
        private System.Windows.Forms.TextBox txtactivityTitle;
        private System.Windows.Forms.TextBox txtactivityID;
        private System.Windows.Forms.Label lblMetric3;
        private System.Windows.Forms.Label lblMetric2;
        private System.Windows.Forms.Label lblMetric1;
        private System.Windows.Forms.TextBox txtMetric1;
        private System.Windows.Forms.TextBox txtMetric2;
        private System.Windows.Forms.TextBox txtMetric3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.BindingSource activitiesBindingSource1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn activityIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activityTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metric1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metric2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn metric3DataGridViewTextBoxColumn;
    }
}