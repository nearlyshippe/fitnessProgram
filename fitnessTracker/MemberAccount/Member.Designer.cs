namespace fitnessTracker
{
    partial class Member
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Member));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.pbWalk = new System.Windows.Forms.PictureBox();
            this.pbRun = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbOverview = new System.Windows.Forms.GroupBox();
            this.btnStart = new System.Windows.Forms.Label();
            this.pbWeight = new System.Windows.Forms.PictureBox();
            this.lblIntro = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWalk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRun)).BeginInit();
            this.gbOverview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeight)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Salmon;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.activityToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(135, 753);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.homeToolStripMenuItem.Text = "Home";
            // 
            // activityToolStripMenuItem
            // 
            this.activityToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.activityToolStripMenuItem.Name = "activityToolStripMenuItem";
            this.activityToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.activityToolStripMenuItem.Text = "Activity";
            this.activityToolStripMenuItem.Click += new System.EventHandler(this.activityToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.BackColor = System.Drawing.Color.Salmon;
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.accountToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.BackColor = System.Drawing.Color.Salmon;
            this.registerToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.BackColor = System.Drawing.Color.Salmon;
            this.loginToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.exitToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 500, 0, 0);
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(370, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "FitnessPal";
            // 
            // pbWalk
            // 
            this.pbWalk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbWalk.BackgroundImage")));
            this.pbWalk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbWalk.Location = new System.Drawing.Point(0, 300);
            this.pbWalk.Name = "pbWalk";
            this.pbWalk.Size = new System.Drawing.Size(100, 100);
            this.pbWalk.TabIndex = 3;
            this.pbWalk.TabStop = false;
            // 
            // pbRun
            // 
            this.pbRun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbRun.BackgroundImage")));
            this.pbRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbRun.Location = new System.Drawing.Point(400, 300);
            this.pbRun.Name = "pbRun";
            this.pbRun.Size = new System.Drawing.Size(100, 100);
            this.pbRun.TabIndex = 4;
            this.pbRun.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(180, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(590, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Start Tracking, Start Thriving: Your Fitness Adventure Begins Now!";
            // 
            // gbOverview
            // 
            this.gbOverview.Controls.Add(this.btnStart);
            this.gbOverview.Controls.Add(this.pbWeight);
            this.gbOverview.Controls.Add(this.lblIntro);
            this.gbOverview.Controls.Add(this.pbWalk);
            this.gbOverview.Controls.Add(this.pbRun);
            this.gbOverview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOverview.ForeColor = System.Drawing.Color.Black;
            this.gbOverview.Location = new System.Drawing.Point(240, 225);
            this.gbOverview.Name = "gbOverview";
            this.gbOverview.Size = new System.Drawing.Size(500, 400);
            this.gbOverview.TabIndex = 6;
            this.gbOverview.TabStop = false;
            this.gbOverview.Text = "Activity | Calorie Tracking";
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(320, 230);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(151, 28);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start Tracking !";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.MouseEnter += new System.EventHandler(this.btnStart_MouseEnter);
            this.btnStart.MouseLeave += new System.EventHandler(this.btnStart_MouseLeave);
            // 
            // pbWeight
            // 
            this.pbWeight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbWeight.BackgroundImage")));
            this.pbWeight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbWeight.Location = new System.Drawing.Point(400, 11);
            this.pbWeight.Name = "pbWeight";
            this.pbWeight.Size = new System.Drawing.Size(100, 100);
            this.pbWeight.TabIndex = 5;
            this.pbWeight.TabStop = false;
            // 
            // lblIntro
            // 
            this.lblIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntro.ForeColor = System.Drawing.Color.Linen;
            this.lblIntro.Location = new System.Drawing.Point(5, 125);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(488, 110);
            this.lblIntro.TabIndex = 0;
            this.lblIntro.Text = resources.GetString("lblIntro.Text");
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(842, 753);
            this.Controls.Add(this.gbOverview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Member";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Member_FormClosing);
            this.Load += new System.EventHandler(this.Member_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWalk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRun)).EndInit();
            this.gbOverview.ResumeLayout(false);
            this.gbOverview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbWalk;
        private System.Windows.Forms.PictureBox pbRun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbOverview;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.PictureBox pbWeight;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label btnStart;
    }
}