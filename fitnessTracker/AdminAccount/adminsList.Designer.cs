namespace fitnessTracker.AdminAccount
{
    partial class adminsList
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
            this.dgvAdmins = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnDataList = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.adminIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPwdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fitnessTrackerDataSet = new fitnessTracker.fitnessTrackerDataSet();
            this.adminsTableAdapter = new fitnessTracker.fitnessTrackerDataSetTableAdapters.adminsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmins)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnDataList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessTrackerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAdmins
            // 
            this.dgvAdmins.AllowUserToAddRows = false;
            this.dgvAdmins.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAdmins.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAdmins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdmins.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adminIDDataGridViewTextBoxColumn,
            this.adminNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.userPwdDataGridViewTextBoxColumn,
            this.phoneNoDataGridViewTextBoxColumn});
            this.dgvAdmins.DataSource = this.adminsBindingSource;
            this.dgvAdmins.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(150)))), ((int)(((byte)(200)))));
            this.dgvAdmins.Location = new System.Drawing.Point(5, 64);
            this.dgvAdmins.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAdmins.Name = "dgvAdmins";
            this.dgvAdmins.ReadOnly = true;
            this.dgvAdmins.RowHeadersVisible = false;
            this.dgvAdmins.RowHeadersWidth = 51;
            this.dgvAdmins.Size = new System.Drawing.Size(496, 340);
            this.dgvAdmins.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.dgvAdmins);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(507, 406);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ADMINS";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(284, 28);
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
            this.txtSearch.Location = new System.Drawing.Point(0, 27);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(199, 26);
            this.txtSearch.TabIndex = 2;
            // 
            // pnDataList
            // 
            this.pnDataList.Controls.Add(this.groupBox1);
            this.pnDataList.Location = new System.Drawing.Point(0, 0);
            this.pnDataList.Margin = new System.Windows.Forms.Padding(4);
            this.pnDataList.Name = "pnDataList";
            this.pnDataList.Size = new System.Drawing.Size(535, 430);
            this.pnDataList.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(401, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 4;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminIDDataGridViewTextBoxColumn
            // 
            this.adminIDDataGridViewTextBoxColumn.DataPropertyName = "adminID";
            this.adminIDDataGridViewTextBoxColumn.HeaderText = "adminID";
            this.adminIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminIDDataGridViewTextBoxColumn.Name = "adminIDDataGridViewTextBoxColumn";
            this.adminIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.adminIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // adminNameDataGridViewTextBoxColumn
            // 
            this.adminNameDataGridViewTextBoxColumn.DataPropertyName = "adminName";
            this.adminNameDataGridViewTextBoxColumn.HeaderText = "adminName";
            this.adminNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adminNameDataGridViewTextBoxColumn.Name = "adminNameDataGridViewTextBoxColumn";
            this.adminNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.adminNameDataGridViewTextBoxColumn.Width = 125;
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
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "userName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "userName";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // userPwdDataGridViewTextBoxColumn
            // 
            this.userPwdDataGridViewTextBoxColumn.DataPropertyName = "userPwd";
            this.userPwdDataGridViewTextBoxColumn.HeaderText = "userPwd";
            this.userPwdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userPwdDataGridViewTextBoxColumn.Name = "userPwdDataGridViewTextBoxColumn";
            this.userPwdDataGridViewTextBoxColumn.ReadOnly = true;
            this.userPwdDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneNoDataGridViewTextBoxColumn
            // 
            this.phoneNoDataGridViewTextBoxColumn.DataPropertyName = "phoneNo";
            this.phoneNoDataGridViewTextBoxColumn.HeaderText = "phoneNo";
            this.phoneNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneNoDataGridViewTextBoxColumn.Name = "phoneNoDataGridViewTextBoxColumn";
            this.phoneNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.phoneNoDataGridViewTextBoxColumn.Width = 125;
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
            // adminsTableAdapter
            // 
            this.adminsTableAdapter.ClearBeforeFill = true;
            // 
            // adminsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnDataList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "adminsList";
            this.Size = new System.Drawing.Size(533, 431);
            this.Load += new System.EventHandler(this.adminsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdmins)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnDataList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessTrackerDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAdmins;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adminNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPwdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource adminsBindingSource;
        private fitnessTrackerDataSet fitnessTrackerDataSet;
        private fitnessTrackerDataSetTableAdapters.adminsTableAdapter adminsTableAdapter;
        private System.Windows.Forms.Panel pnDataList;
        private System.Windows.Forms.Button button1;
    }
}
