namespace fitnessTracker
{
    partial class adminLogin
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
            this.btnClear = new System.Windows.Forms.Button();
            this.txtuserName = new System.Windows.Forms.TextBox();
            this.txtuserPwd = new System.Windows.Forms.TextBox();
            this.lbluserPwd = new System.Windows.Forms.Label();
            this.lbluserName = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.msAdmin = new System.Windows.Forms.MenuStrip();
            this.hOMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEGISTERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.msAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(133, 369);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 43);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtuserName
            // 
            this.txtuserName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuserName.Location = new System.Drawing.Point(367, 185);
            this.txtuserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtuserName.Name = "txtuserName";
            this.txtuserName.Size = new System.Drawing.Size(199, 26);
            this.txtuserName.TabIndex = 12;
            // 
            // txtuserPwd
            // 
            this.txtuserPwd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuserPwd.Location = new System.Drawing.Point(367, 246);
            this.txtuserPwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtuserPwd.Name = "txtuserPwd";
            this.txtuserPwd.PasswordChar = '*';
            this.txtuserPwd.Size = new System.Drawing.Size(199, 26);
            this.txtuserPwd.TabIndex = 11;
            // 
            // lbluserPwd
            // 
            this.lbluserPwd.AutoSize = true;
            this.lbluserPwd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserPwd.Location = new System.Drawing.Point(133, 246);
            this.lbluserPwd.Name = "lbluserPwd";
            this.lbluserPwd.Size = new System.Drawing.Size(104, 19);
            this.lbluserPwd.TabIndex = 9;
            this.lbluserPwd.Text = "PASSWORD";
            // 
            // lbluserName
            // 
            this.lbluserName.AutoSize = true;
            this.lbluserName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserName.Location = new System.Drawing.Point(133, 185);
            this.lbluserName.Name = "lbluserName";
            this.lbluserName.Size = new System.Drawing.Size(99, 19);
            this.lbluserName.TabIndex = 6;
            this.lbluserName.Text = "USERNAME";
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(433, 369);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(133, 43);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShow);
            this.groupBox1.Controls.Add(this.lbluserName);
            this.groupBox1.Controls.Add(this.txtuserName);
            this.groupBox1.Controls.Add(this.lbluserPwd);
            this.groupBox1.Controls.Add(this.btnLogin);
            this.groupBox1.Controls.Add(this.txtuserPwd);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(129, 103);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(667, 492);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOGIN";
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShow.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(467, 289);
            this.btnShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(100, 31);
            this.btnShow.TabIndex = 17;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // msAdmin
            // 
            this.msAdmin.AutoSize = false;
            this.msAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            this.msAdmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msAdmin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hOMEToolStripMenuItem,
            this.lOGINToolStripMenuItem,
            this.rEGISTERToolStripMenuItem});
            this.msAdmin.Location = new System.Drawing.Point(0, 0);
            this.msAdmin.Name = "msAdmin";
            this.msAdmin.Size = new System.Drawing.Size(912, 49);
            this.msAdmin.TabIndex = 18;
            this.msAdmin.Text = "menuStrip1";
            // 
            // hOMEToolStripMenuItem
            // 
            this.hOMEToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.hOMEToolStripMenuItem.Name = "hOMEToolStripMenuItem";
            this.hOMEToolStripMenuItem.Size = new System.Drawing.Size(83, 45);
            this.hOMEToolStripMenuItem.Text = "HOME";
            this.hOMEToolStripMenuItem.Click += new System.EventHandler(this.hOMEToolStripMenuItem_Click);
            // 
            // lOGINToolStripMenuItem
            // 
            this.lOGINToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.lOGINToolStripMenuItem.Name = "lOGINToolStripMenuItem";
            this.lOGINToolStripMenuItem.Size = new System.Drawing.Size(83, 45);
            this.lOGINToolStripMenuItem.Text = "LOGIN";
            // 
            // rEGISTERToolStripMenuItem
            // 
            this.rEGISTERToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.rEGISTERToolStripMenuItem.Name = "rEGISTERToolStripMenuItem";
            this.rEGISTERToolStripMenuItem.Size = new System.Drawing.Size(110, 45);
            this.rEGISTERToolStripMenuItem.Text = "REGISTER";
            this.rEGISTERToolStripMenuItem.Click += new System.EventHandler(this.rEGISTERToolStripMenuItem_Click);
            // 
            // adminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(912, 629);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.msAdmin);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msAdmin;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "adminLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adminLogin";
            this.Load += new System.EventHandler(this.adminLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.msAdmin.ResumeLayout(false);
            this.msAdmin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtuserName;
        private System.Windows.Forms.TextBox txtuserPwd;
        private System.Windows.Forms.Label lbluserPwd;
        private System.Windows.Forms.Label lbluserName;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip msAdmin;
        private System.Windows.Forms.ToolStripMenuItem hOMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lOGINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEGISTERToolStripMenuItem;
        private System.Windows.Forms.Button btnShow;
    }
}