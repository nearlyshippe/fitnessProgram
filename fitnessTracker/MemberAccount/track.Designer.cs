namespace fitnessTracker
{
    partial class track
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(track));
            this.dgvTrack = new System.Windows.Forms.DataGridView();
            this.trackBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fitnessTrackerDataSet = new fitnessTracker.fitnessTrackerDataSet();
            this.gbCalories = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTotalCal = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTotalCal = new System.Windows.Forms.Label();
            this.txtGoal = new System.Windows.Forms.TextBox();
            this.lblCalGoal = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtMET = new System.Windows.Forms.TextBox();
            this.txtTrackID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setGoalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sEARCHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackTableAdapter = new fitnessTracker.fitnessTrackerDataSetTableAdapters.TrackTableAdapter();
            this.trackIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activityTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalCalBurnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activityIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trackingDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessTrackerDataSet)).BeginInit();
            this.gbCalories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTrack
            // 
            this.dgvTrack.AllowUserToAddRows = false;
            this.dgvTrack.AutoGenerateColumns = false;
            this.dgvTrack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrack.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trackIDDataGridViewTextBoxColumn,
            this.activityTitleDataGridViewTextBoxColumn,
            this.totalCalBurnDataGridViewTextBoxColumn,
            this.trackStatusDataGridViewTextBoxColumn,
            this.memberIDDataGridViewTextBoxColumn,
            this.activityIDDataGridViewTextBoxColumn,
            this.trackingDateDataGridViewTextBoxColumn,
            this.goalDataGridViewTextBoxColumn});
            this.dgvTrack.DataSource = this.trackBindingSource;
            this.dgvTrack.Location = new System.Drawing.Point(20, 480);
            this.dgvTrack.Name = "dgvTrack";
            this.dgvTrack.RowHeadersVisible = false;
            this.dgvTrack.RowHeadersWidth = 51;
            this.dgvTrack.RowTemplate.Height = 24;
            this.dgvTrack.Size = new System.Drawing.Size(800, 250);
            this.dgvTrack.TabIndex = 0;
            this.dgvTrack.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrack_CellClick);
            // 
            // trackBindingSource
            // 
            this.trackBindingSource.DataMember = "Track";
            this.trackBindingSource.DataSource = this.fitnessTrackerDataSet;
            // 
            // fitnessTrackerDataSet
            // 
            this.fitnessTrackerDataSet.DataSetName = "fitnessTrackerDataSet";
            this.fitnessTrackerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbCalories
            // 
            this.gbCalories.Controls.Add(this.btnDelete);
            this.gbCalories.Controls.Add(this.pictureBox1);
            this.gbCalories.Controls.Add(this.txtTotalCal);
            this.gbCalories.Controls.Add(this.btnCalculate);
            this.gbCalories.Controls.Add(this.btnSave);
            this.gbCalories.Controls.Add(this.lblTotalCal);
            this.gbCalories.Controls.Add(this.txtGoal);
            this.gbCalories.Controls.Add(this.lblCalGoal);
            this.gbCalories.Controls.Add(this.txtTime);
            this.gbCalories.Controls.Add(this.txtWeight);
            this.gbCalories.Controls.Add(this.txtMET);
            this.gbCalories.Controls.Add(this.txtTrackID);
            this.gbCalories.Controls.Add(this.label4);
            this.gbCalories.Controls.Add(this.label3);
            this.gbCalories.Controls.Add(this.label2);
            this.gbCalories.Controls.Add(this.label1);
            this.gbCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCalories.ForeColor = System.Drawing.Color.White;
            this.gbCalories.Location = new System.Drawing.Point(12, 69);
            this.gbCalories.Name = "gbCalories";
            this.gbCalories.Size = new System.Drawing.Size(500, 380);
            this.gbCalories.TabIndex = 1;
            this.gbCalories.TabStop = false;
            this.gbCalories.Text = "Calculate Calories";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(20, 325);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 35);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(400, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // txtTotalCal
            // 
            this.txtTotalCal.AutoSize = true;
            this.txtTotalCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCal.Location = new System.Drawing.Point(200, 280);
            this.txtTotalCal.Name = "txtTotalCal";
            this.txtTotalCal.Size = new System.Drawing.Size(0, 20);
            this.txtTotalCal.TabIndex = 13;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(205, 325);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 35);
            this.btnCalculate.TabIndex = 12;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(380, 325);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTotalCal
            // 
            this.lblTotalCal.AutoSize = true;
            this.lblTotalCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCal.Location = new System.Drawing.Point(20, 280);
            this.lblTotalCal.Name = "lblTotalCal";
            this.lblTotalCal.Size = new System.Drawing.Size(154, 20);
            this.lblTotalCal.TabIndex = 10;
            this.lblTotalCal.Text = "Total Calories Burn";
            // 
            // txtGoal
            // 
            this.txtGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGoal.Location = new System.Drawing.Point(200, 80);
            this.txtGoal.Name = "txtGoal";
            this.txtGoal.Size = new System.Drawing.Size(150, 27);
            this.txtGoal.TabIndex = 9;
            // 
            // lblCalGoal
            // 
            this.lblCalGoal.AutoSize = true;
            this.lblCalGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalGoal.Location = new System.Drawing.Point(20, 80);
            this.lblCalGoal.Name = "lblCalGoal";
            this.lblCalGoal.Size = new System.Drawing.Size(56, 20);
            this.lblCalGoal.TabIndex = 8;
            this.lblCalGoal.Text = "GOAL";
            // 
            // txtTime
            // 
            this.txtTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime.Location = new System.Drawing.Point(200, 230);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(150, 27);
            this.txtTime.TabIndex = 7;
            // 
            // txtWeight
            // 
            this.txtWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(200, 180);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(150, 27);
            this.txtWeight.TabIndex = 6;
            // 
            // txtMET
            // 
            this.txtMET.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMET.Location = new System.Drawing.Point(200, 130);
            this.txtMET.Name = "txtMET";
            this.txtMET.Size = new System.Drawing.Size(150, 27);
            this.txtMET.TabIndex = 5;
            // 
            // txtTrackID
            // 
            this.txtTrackID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrackID.Location = new System.Drawing.Point(200, 30);
            this.txtTrackID.Name = "txtTrackID";
            this.txtTrackID.Size = new System.Drawing.Size(150, 27);
            this.txtTrackID.TabIndex = 4;
            this.txtTrackID.TextChanged += new System.EventHandler(this.txtTrackID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Time Taken(hour)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Body Weight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "MET";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Track ID";
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
            this.menuStrip1.TabIndex = 4;
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
            // 
            // sEARCHToolStripMenuItem
            // 
            this.sEARCHToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.sEARCHToolStripMenuItem.Name = "sEARCHToolStripMenuItem";
            this.sEARCHToolStripMenuItem.Size = new System.Drawing.Size(78, 46);
            this.sEARCHToolStripMenuItem.Text = "SEARCH";
            this.sEARCHToolStripMenuItem.Click += new System.EventHandler(this.sEARCHToolStripMenuItem_Click);
            // 
            // trackTableAdapter
            // 
            this.trackTableAdapter.ClearBeforeFill = true;
            // 
            // trackIDDataGridViewTextBoxColumn
            // 
            this.trackIDDataGridViewTextBoxColumn.DataPropertyName = "trackID";
            this.trackIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.trackIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trackIDDataGridViewTextBoxColumn.Name = "trackIDDataGridViewTextBoxColumn";
            this.trackIDDataGridViewTextBoxColumn.Width = 75;
            // 
            // activityTitleDataGridViewTextBoxColumn
            // 
            this.activityTitleDataGridViewTextBoxColumn.DataPropertyName = "activityTitle";
            this.activityTitleDataGridViewTextBoxColumn.HeaderText = "Activity Title";
            this.activityTitleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.activityTitleDataGridViewTextBoxColumn.Name = "activityTitleDataGridViewTextBoxColumn";
            this.activityTitleDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalCalBurnDataGridViewTextBoxColumn
            // 
            this.totalCalBurnDataGridViewTextBoxColumn.DataPropertyName = "totalCalBurn";
            this.totalCalBurnDataGridViewTextBoxColumn.HeaderText = "Total Calorie Burn";
            this.totalCalBurnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalCalBurnDataGridViewTextBoxColumn.Name = "totalCalBurnDataGridViewTextBoxColumn";
            this.totalCalBurnDataGridViewTextBoxColumn.Width = 150;
            // 
            // trackStatusDataGridViewTextBoxColumn
            // 
            this.trackStatusDataGridViewTextBoxColumn.DataPropertyName = "trackStatus";
            this.trackStatusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.trackStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trackStatusDataGridViewTextBoxColumn.Name = "trackStatusDataGridViewTextBoxColumn";
            this.trackStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // memberIDDataGridViewTextBoxColumn
            // 
            this.memberIDDataGridViewTextBoxColumn.DataPropertyName = "memberID";
            this.memberIDDataGridViewTextBoxColumn.HeaderText = "Member ID";
            this.memberIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberIDDataGridViewTextBoxColumn.Name = "memberIDDataGridViewTextBoxColumn";
            this.memberIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // activityIDDataGridViewTextBoxColumn
            // 
            this.activityIDDataGridViewTextBoxColumn.DataPropertyName = "activityID";
            this.activityIDDataGridViewTextBoxColumn.HeaderText = "Activity ID";
            this.activityIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.activityIDDataGridViewTextBoxColumn.Name = "activityIDDataGridViewTextBoxColumn";
            this.activityIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // trackingDateDataGridViewTextBoxColumn
            // 
            this.trackingDateDataGridViewTextBoxColumn.DataPropertyName = "trackingDate";
            this.trackingDateDataGridViewTextBoxColumn.HeaderText = "Track Date";
            this.trackingDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.trackingDateDataGridViewTextBoxColumn.Name = "trackingDateDataGridViewTextBoxColumn";
            this.trackingDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // goalDataGridViewTextBoxColumn
            // 
            this.goalDataGridViewTextBoxColumn.DataPropertyName = "Goal";
            this.goalDataGridViewTextBoxColumn.HeaderText = "Goal";
            this.goalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.goalDataGridViewTextBoxColumn.Name = "goalDataGridViewTextBoxColumn";
            this.goalDataGridViewTextBoxColumn.Width = 125;
            // 
            // track
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(842, 753);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbCalories);
            this.Controls.Add(this.dgvTrack);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "track";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "track";
            this.Load += new System.EventHandler(this.track_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitnessTrackerDataSet)).EndInit();
            this.gbCalories.ResumeLayout(false);
            this.gbCalories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTrack;
        private System.Windows.Forms.GroupBox gbCalories;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTotalCal;
        private System.Windows.Forms.TextBox txtGoal;
        private System.Windows.Forms.Label lblCalGoal;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtMET;
        private System.Windows.Forms.TextBox txtTrackID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private fitnessTrackerDataSet fitnessTrackerDataSet;
        private System.Windows.Forms.BindingSource trackBindingSource;
        private fitnessTrackerDataSetTableAdapters.TrackTableAdapter trackTableAdapter;
        private System.Windows.Forms.Label txtTotalCal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setGoalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trackingToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem sEARCHToolStripMenuItem;
        private System.Windows.Forms.Button btnDelete;
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