namespace fitnessTracker.AdminAccount
{
    partial class membersLIst
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.adminsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fitnessTrackerDataSet = new fitnessTracker.fitnessTrackerDataSet();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.memberstbBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.fitnessTrackerDataSet1 = new fitnessTracker.fitnessTrackerDataSet();
            this.btnRefrash = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.adminsTableAdapter = new fitnessTracker.fitnessTrackerDataSetTableAdapters.adminsTableAdapter();
            this.memberstbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberstbTableAdapter = new fitnessTracker.fitnessTrackerDataSetTableAdapters.MemberstbTableAdapter();
            this.memberstbBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pnDataList = new System.Windows.Forms.Panel();
            this.memberstbBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.memberstbBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.fitnessTrackerDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memberstbBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.memberstbBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.memberstbBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.memberstbBindingSource8 = new System.Windows.Forms.BindingSource(this.components);
            this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessTrackerDataSet)).BeginInit();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberstbBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessTrackerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberstbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberstbBindingSource1)).BeginInit();
            this.pnDataList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberstbBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberstbBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessTrackerDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberstbBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberstbBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberstbBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberstbBindingSource8)).BeginInit();
            this.SuspendLayout();
            // 
            // adminsBindingSource
            // 
            this.adminsBindingSource.DataMember = "admins";
            this.adminsBindingSource.DataSource = this.fitnessTrackerDataSet;
            // 
            // fitnessTrackerDataSet
            // 
            this.fitnessTrackerDataSet.DataSetName = "fitnessTrackerDataSet";
            this.fitnessTrackerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.dgvMembers);
            this.gbData.Controls.Add(this.btnRefrash);
            this.gbData.Controls.Add(this.btnSearch);
            this.gbData.Controls.Add(this.txtSearch);
            this.gbData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbData.ForeColor = System.Drawing.Color.Black;
            this.gbData.Location = new System.Drawing.Point(13, 12);
            this.gbData.Margin = new System.Windows.Forms.Padding(4);
            this.gbData.Name = "gbData";
            this.gbData.Padding = new System.Windows.Forms.Padding(4);
            this.gbData.Size = new System.Drawing.Size(507, 406);
            this.gbData.TabIndex = 2;
            this.gbData.TabStop = false;
            this.gbData.Text = "MEMBERS";
            // 
            // memberstbBindingSource6
            // 
            this.memberstbBindingSource6.DataMember = "Memberstb";
            this.memberstbBindingSource6.DataSource = this.fitnessTrackerDataSet1;
            // 
            // fitnessTrackerDataSet1
            // 
            this.fitnessTrackerDataSet1.DataSetName = "fitnessTrackerDataSet";
            this.fitnessTrackerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRefrash
            // 
            this.btnRefrash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnRefrash.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefrash.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefrash.ForeColor = System.Drawing.Color.White;
            this.btnRefrash.Location = new System.Drawing.Point(400, 41);
            this.btnRefrash.Name = "btnRefrash";
            this.btnRefrash.Size = new System.Drawing.Size(100, 25);
            this.btnRefrash.TabIndex = 7;
            this.btnRefrash.Text = "Refrash";
            this.btnRefrash.UseVisualStyleBackColor = false;
            this.btnRefrash.Click += new System.EventHandler(this.btnRefrash_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(263, 41);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 25);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "search name";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(8, 39);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 26);
            this.txtSearch.TabIndex = 2;
            // 
            // adminsTableAdapter
            // 
            this.adminsTableAdapter.ClearBeforeFill = true;
            // 
            // memberstbBindingSource
            // 
            this.memberstbBindingSource.DataMember = "Memberstb";
            this.memberstbBindingSource.DataSource = this.fitnessTrackerDataSet;
            // 
            // memberstbTableAdapter
            // 
            this.memberstbTableAdapter.ClearBeforeFill = true;
            // 
            // memberstbBindingSource1
            // 
            this.memberstbBindingSource1.DataMember = "Memberstb";
            this.memberstbBindingSource1.DataSource = this.fitnessTrackerDataSet;
            // 
            // pnDataList
            // 
            this.pnDataList.Controls.Add(this.gbData);
            this.pnDataList.Location = new System.Drawing.Point(0, 0);
            this.pnDataList.Margin = new System.Windows.Forms.Padding(4);
            this.pnDataList.Name = "pnDataList";
            this.pnDataList.Size = new System.Drawing.Size(535, 430);
            this.pnDataList.TabIndex = 3;
            // 
            // memberstbBindingSource2
            // 
            this.memberstbBindingSource2.DataMember = "Memberstb";
            this.memberstbBindingSource2.DataSource = this.fitnessTrackerDataSet1;
            // 
            // memberstbBindingSource3
            // 
            this.memberstbBindingSource3.DataMember = "Memberstb";
            this.memberstbBindingSource3.DataSource = this.fitnessTrackerDataSet1;
            // 
            // fitnessTrackerDataSet1BindingSource
            // 
            this.fitnessTrackerDataSet1BindingSource.DataSource = this.fitnessTrackerDataSet1;
            this.fitnessTrackerDataSet1BindingSource.Position = 0;
            // 
            // memberstbBindingSource4
            // 
            this.memberstbBindingSource4.DataMember = "Memberstb";
            this.memberstbBindingSource4.DataSource = this.fitnessTrackerDataSet1;
            // 
            // memberstbBindingSource5
            // 
            this.memberstbBindingSource5.DataMember = "Memberstb";
            this.memberstbBindingSource5.DataSource = this.fitnessTrackerDataSet1;
            // 
            // dgvMembers
            // 
            this.dgvMembers.AllowUserToAddRows = false;
            this.dgvMembers.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memberIDDataGridViewTextBoxColumn,
            this.memberNameDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.userPasswordDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgvMembers.DataSource = this.memberstbBindingSource8;
            this.dgvMembers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.dgvMembers.Location = new System.Drawing.Point(0, 72);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.ReadOnly = true;
            this.dgvMembers.RowHeadersVisible = false;
            this.dgvMembers.RowHeadersWidth = 51;
            this.dgvMembers.RowTemplate.Height = 24;
            this.dgvMembers.Size = new System.Drawing.Size(500, 334);
            this.dgvMembers.TabIndex = 8;
            // 
            // memberstbBindingSource7
            // 
            this.memberstbBindingSource7.DataMember = "Memberstb";
            this.memberstbBindingSource7.DataSource = this.fitnessTrackerDataSet;
            // 
            // memberstbBindingSource8
            // 
            this.memberstbBindingSource8.DataMember = "Memberstb";
            this.memberstbBindingSource8.DataSource = this.fitnessTrackerDataSet;
            // 
            // memberIDDataGridViewTextBoxColumn
            // 
            this.memberIDDataGridViewTextBoxColumn.DataPropertyName = "memberID";
            this.memberIDDataGridViewTextBoxColumn.HeaderText = "memberID";
            this.memberIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberIDDataGridViewTextBoxColumn.Name = "memberIDDataGridViewTextBoxColumn";
            this.memberIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.memberIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // memberNameDataGridViewTextBoxColumn
            // 
            this.memberNameDataGridViewTextBoxColumn.DataPropertyName = "memberName";
            this.memberNameDataGridViewTextBoxColumn.HeaderText = "memberName";
            this.memberNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberNameDataGridViewTextBoxColumn.Name = "memberNameDataGridViewTextBoxColumn";
            this.memberNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.memberNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "userName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "userName";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // userPasswordDataGridViewTextBoxColumn
            // 
            this.userPasswordDataGridViewTextBoxColumn.DataPropertyName = "userPassword";
            this.userPasswordDataGridViewTextBoxColumn.HeaderText = "userPassword";
            this.userPasswordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userPasswordDataGridViewTextBoxColumn.Name = "userPasswordDataGridViewTextBoxColumn";
            this.userPasswordDataGridViewTextBoxColumn.ReadOnly = true;
            this.userPasswordDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // membersLIst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnDataList);
            this.ForeColor = System.Drawing.Color.Salmon;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "membersLIst";
            this.Size = new System.Drawing.Size(533, 431);
            this.Load += new System.EventHandler(this.membersLIst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessTrackerDataSet)).EndInit();
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberstbBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessTrackerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberstbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberstbBindingSource1)).EndInit();
            this.pnDataList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memberstbBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberstbBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessTrackerDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberstbBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberstbBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberstbBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberstbBindingSource8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource memberstbBindingSource1;
        private fitnessTrackerDataSet fitnessTrackerDataSet;
        private System.Windows.Forms.BindingSource adminsBindingSource;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private fitnessTrackerDataSetTableAdapters.adminsTableAdapter adminsTableAdapter;
        private System.Windows.Forms.BindingSource memberstbBindingSource;
        private fitnessTrackerDataSetTableAdapters.MemberstbTableAdapter memberstbTableAdapter;
        private System.Windows.Forms.Panel pnDataList;
        private System.Windows.Forms.Button btnRefrash;
        private System.Windows.Forms.BindingSource memberstbBindingSource2;
        private fitnessTrackerDataSet fitnessTrackerDataSet1;
        private System.Windows.Forms.BindingSource memberstbBindingSource4;
        private System.Windows.Forms.BindingSource memberstbBindingSource3;
        private System.Windows.Forms.BindingSource fitnessTrackerDataSet1BindingSource;
        private System.Windows.Forms.BindingSource memberstbBindingSource6;
        private System.Windows.Forms.BindingSource memberstbBindingSource5;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.BindingSource memberstbBindingSource7;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource memberstbBindingSource8;
    }
}
