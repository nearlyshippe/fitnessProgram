namespace fitnessTracker
{
    partial class ActivityInfo
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainInfoUI = new System.Windows.Forms.Panel();
            this.activityPanel = new System.Windows.Forms.Panel();
            this.msActivity = new System.Windows.Forms.MenuStrip();
            this.walkingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.swimmingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yogaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bikingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jumpingRopeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weightLiftingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.mainInfoUI.SuspendLayout();
            this.msActivity.SuspendLayout();
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
            this.accountToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(135, 753);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.BackColor = System.Drawing.Color.Salmon;
            this.homeToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // activityToolStripMenuItem
            // 
            this.activityToolStripMenuItem.BackColor = System.Drawing.Color.Salmon;
            this.activityToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.activityToolStripMenuItem.Name = "activityToolStripMenuItem";
            this.activityToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.activityToolStripMenuItem.Text = "Activity";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.BackColor = System.Drawing.Color.Salmon;
            this.accountToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.accountToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
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
            // mainInfoUI
            // 
            this.mainInfoUI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainInfoUI.Controls.Add(this.activityPanel);
            this.mainInfoUI.Controls.Add(this.msActivity);
            this.mainInfoUI.Location = new System.Drawing.Point(139, 0);
            this.mainInfoUI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainInfoUI.Name = "mainInfoUI";
            this.mainInfoUI.Size = new System.Drawing.Size(701, 745);
            this.mainInfoUI.TabIndex = 3;
            // 
            // activityPanel
            // 
            this.activityPanel.ForeColor = System.Drawing.Color.White;
            this.activityPanel.Location = new System.Drawing.Point(0, 39);
            this.activityPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.activityPanel.Name = "activityPanel";
            this.activityPanel.Size = new System.Drawing.Size(700, 702);
            this.activityPanel.TabIndex = 4;
            // 
            // msActivity
            // 
            this.msActivity.AutoSize = false;
            this.msActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.msActivity.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msActivity.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.walkingToolStripMenuItem,
            this.swimmingToolStripMenuItem,
            this.yogaToolStripMenuItem,
            this.bikingToolStripMenuItem,
            this.jumpingRopeToolStripMenuItem,
            this.weightLiftingToolStripMenuItem});
            this.msActivity.Location = new System.Drawing.Point(0, 0);
            this.msActivity.Name = "msActivity";
            this.msActivity.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.msActivity.Size = new System.Drawing.Size(699, 37);
            this.msActivity.TabIndex = 0;
            this.msActivity.Text = "menuStrip3";
            // 
            // walkingToolStripMenuItem
            // 
            this.walkingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walkingToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.walkingToolStripMenuItem.Margin = new System.Windows.Forms.Padding(50, 0, 0, 0);
            this.walkingToolStripMenuItem.Name = "walkingToolStripMenuItem";
            this.walkingToolStripMenuItem.Size = new System.Drawing.Size(85, 33);
            this.walkingToolStripMenuItem.Text = "Walking";
            this.walkingToolStripMenuItem.Click += new System.EventHandler(this.walkingToolStripMenuItem_Click);
            // 
            // swimmingToolStripMenuItem
            // 
            this.swimmingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swimmingToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.swimmingToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.swimmingToolStripMenuItem.Name = "swimmingToolStripMenuItem";
            this.swimmingToolStripMenuItem.Size = new System.Drawing.Size(104, 33);
            this.swimmingToolStripMenuItem.Text = "Swimming";
            this.swimmingToolStripMenuItem.Click += new System.EventHandler(this.swimmingToolStripMenuItem_Click);
            // 
            // yogaToolStripMenuItem
            // 
            this.yogaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yogaToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.yogaToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.yogaToolStripMenuItem.Name = "yogaToolStripMenuItem";
            this.yogaToolStripMenuItem.Size = new System.Drawing.Size(61, 33);
            this.yogaToolStripMenuItem.Text = "Yoga";
            this.yogaToolStripMenuItem.Click += new System.EventHandler(this.yogaToolStripMenuItem_Click);
            // 
            // bikingToolStripMenuItem
            // 
            this.bikingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bikingToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.bikingToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.bikingToolStripMenuItem.Name = "bikingToolStripMenuItem";
            this.bikingToolStripMenuItem.Size = new System.Drawing.Size(71, 33);
            this.bikingToolStripMenuItem.Text = "Biking";
            this.bikingToolStripMenuItem.Click += new System.EventHandler(this.bikingToolStripMenuItem_Click);
            // 
            // jumpingRopeToolStripMenuItem
            // 
            this.jumpingRopeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jumpingRopeToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.jumpingRopeToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.jumpingRopeToolStripMenuItem.Name = "jumpingRopeToolStripMenuItem";
            this.jumpingRopeToolStripMenuItem.Size = new System.Drawing.Size(135, 33);
            this.jumpingRopeToolStripMenuItem.Text = "Jumping Rope";
            this.jumpingRopeToolStripMenuItem.Click += new System.EventHandler(this.jumpingRopeToolStripMenuItem_Click);
            // 
            // weightLiftingToolStripMenuItem
            // 
            this.weightLiftingToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weightLiftingToolStripMenuItem.ForeColor = System.Drawing.Color.Snow;
            this.weightLiftingToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.weightLiftingToolStripMenuItem.Name = "weightLiftingToolStripMenuItem";
            this.weightLiftingToolStripMenuItem.Size = new System.Drawing.Size(132, 33);
            this.weightLiftingToolStripMenuItem.Text = "Weight Lifting";
            this.weightLiftingToolStripMenuItem.Click += new System.EventHandler(this.weightLiftingToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ActivityInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(843, 753);
            this.Controls.Add(this.mainInfoUI);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msActivity;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "ActivityInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ActivityInfo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainInfoUI.ResumeLayout(false);
            this.msActivity.ResumeLayout(false);
            this.msActivity.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.Panel mainInfoUI;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip msActivity;
        private System.Windows.Forms.Panel activityPanel;
        private System.Windows.Forms.ToolStripMenuItem walkingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem swimmingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yogaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bikingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jumpingRopeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weightLiftingToolStripMenuItem;
    }
}