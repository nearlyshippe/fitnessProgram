namespace fitnessTracker
{
    partial class memberRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(memberRegister));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtmbName = new System.Windows.Forms.TextBox();
            this.txtuserName = new System.Windows.Forms.TextBox();
            this.txtuserPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lbluserPassword = new System.Windows.Forms.Label();
            this.lbluserName = new System.Windows.Forms.Label();
            this.lblmbName = new System.Windows.Forms.Label();
            this.lblmbID = new System.Windows.Forms.Label();
            this.lblUpper = new System.Windows.Forms.Label();
            this.lblCharacter = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblLower = new System.Windows.Forms.Label();
            this.gbRegister = new System.Windows.Forms.GroupBox();
            this.txtmbID = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbLogo1 = new System.Windows.Forms.PictureBox();
            this.epName = new System.Windows.Forms.ErrorProvider(this.components);
            this.epUsername = new System.Windows.Forms.ErrorProvider(this.components);
            this.epPwd = new System.Windows.Forms.ErrorProvider(this.components);
            this.epEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1.SuspendLayout();
            this.gbRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUsername)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPwd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmail)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(135, 753);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
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
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.BackColor = System.Drawing.Color.Salmon;
            this.loginToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(67, 398);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(352, 398);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 35);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtmbName
            // 
            this.txtmbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmbName.ForeColor = System.Drawing.Color.Black;
            this.txtmbName.Location = new System.Drawing.Point(292, 193);
            this.txtmbName.Name = "txtmbName";
            this.txtmbName.Size = new System.Drawing.Size(160, 27);
            this.txtmbName.TabIndex = 9;
            // 
            // txtuserName
            // 
            this.txtuserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuserName.ForeColor = System.Drawing.Color.Black;
            this.txtuserName.Location = new System.Drawing.Point(292, 243);
            this.txtuserName.Name = "txtuserName";
            this.txtuserName.Size = new System.Drawing.Size(160, 27);
            this.txtuserName.TabIndex = 7;
            // 
            // txtuserPassword
            // 
            this.txtuserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuserPassword.ForeColor = System.Drawing.Color.Black;
            this.txtuserPassword.Location = new System.Drawing.Point(292, 293);
            this.txtuserPassword.Name = "txtuserPassword";
            this.txtuserPassword.Size = new System.Drawing.Size(160, 27);
            this.txtuserPassword.TabIndex = 6;
            this.txtuserPassword.Click += new System.EventHandler(this.txtuserPassword_Click);
            this.txtuserPassword.TextChanged += new System.EventHandler(this.txtuserPassword_TextChanged);
            this.txtuserPassword.Leave += new System.EventHandler(this.txtuserPassword_Leave);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(292, 343);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(160, 27);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(67, 343);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "EMAIL";
            // 
            // lbluserPassword
            // 
            this.lbluserPassword.AutoSize = true;
            this.lbluserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserPassword.ForeColor = System.Drawing.Color.White;
            this.lbluserPassword.Location = new System.Drawing.Point(67, 293);
            this.lbluserPassword.Name = "lbluserPassword";
            this.lbluserPassword.Size = new System.Drawing.Size(107, 20);
            this.lbluserPassword.TabIndex = 3;
            this.lbluserPassword.Text = "PASSWORD";
            // 
            // lbluserName
            // 
            this.lbluserName.AutoSize = true;
            this.lbluserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserName.ForeColor = System.Drawing.Color.White;
            this.lbluserName.Location = new System.Drawing.Point(67, 243);
            this.lbluserName.Name = "lbluserName";
            this.lbluserName.Size = new System.Drawing.Size(103, 20);
            this.lbluserName.TabIndex = 2;
            this.lbluserName.Text = "USERNAME";
            // 
            // lblmbName
            // 
            this.lblmbName.AutoSize = true;
            this.lblmbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmbName.ForeColor = System.Drawing.Color.White;
            this.lblmbName.Location = new System.Drawing.Point(67, 193);
            this.lblmbName.Name = "lblmbName";
            this.lblmbName.Size = new System.Drawing.Size(57, 20);
            this.lblmbName.TabIndex = 1;
            this.lblmbName.Text = "NAME";
            // 
            // lblmbID
            // 
            this.lblmbID.AutoSize = true;
            this.lblmbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmbID.ForeColor = System.Drawing.Color.White;
            this.lblmbID.Location = new System.Drawing.Point(67, 143);
            this.lblmbID.Name = "lblmbID";
            this.lblmbID.Size = new System.Drawing.Size(105, 20);
            this.lblmbID.TabIndex = 0;
            this.lblmbID.Text = "MEMBER ID";
            // 
            // lblUpper
            // 
            this.lblUpper.AutoSize = true;
            this.lblUpper.Font = new System.Drawing.Font("Segoe UI Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpper.Location = new System.Drawing.Point(473, 665);
            this.lblUpper.Name = "lblUpper";
            this.lblUpper.Size = new System.Drawing.Size(262, 23);
            this.lblUpper.TabIndex = 3;
            this.lblUpper.Text = "AT LEAST ONE UPPER CHATACTER";
            this.lblUpper.Visible = false;
            // 
            // lblCharacter
            // 
            this.lblCharacter.AutoSize = true;
            this.lblCharacter.Font = new System.Drawing.Font("Segoe UI Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharacter.Location = new System.Drawing.Point(546, 614);
            this.lblCharacter.Name = "lblCharacter";
            this.lblCharacter.Size = new System.Drawing.Size(195, 23);
            this.lblCharacter.TabIndex = 2;
            this.lblCharacter.Text = "AT LEAST 12 CHARACTER";
            this.lblCharacter.Visible = false;
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Segoe UI Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(231, 665);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(186, 23);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "AT LEAST ONE NUMBER";
            this.lblNumber.Visible = false;
            // 
            // lblLower
            // 
            this.lblLower.AutoSize = true;
            this.lblLower.Font = new System.Drawing.Font("Segoe UI Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLower.Location = new System.Drawing.Point(231, 614);
            this.lblLower.Name = "lblLower";
            this.lblLower.Size = new System.Drawing.Size(272, 23);
            this.lblLower.TabIndex = 0;
            this.lblLower.Text = "AT LEAST ONE LOWER CHARACTER";
            this.lblLower.Visible = false;
            // 
            // gbRegister
            // 
            this.gbRegister.Controls.Add(this.txtmbID);
            this.gbRegister.Controls.Add(this.lblLogin);
            this.gbRegister.Controls.Add(this.label1);
            this.gbRegister.Controls.Add(this.pbLogo1);
            this.gbRegister.Controls.Add(this.lblmbID);
            this.gbRegister.Controls.Add(this.btnCancel);
            this.gbRegister.Controls.Add(this.lbluserPassword);
            this.gbRegister.Controls.Add(this.lblEmail);
            this.gbRegister.Controls.Add(this.btnRegister);
            this.gbRegister.Controls.Add(this.lbluserName);
            this.gbRegister.Controls.Add(this.txtmbName);
            this.gbRegister.Controls.Add(this.txtEmail);
            this.gbRegister.Controls.Add(this.lblmbName);
            this.gbRegister.Controls.Add(this.txtuserPassword);
            this.gbRegister.Controls.Add(this.txtuserName);
            this.gbRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gbRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRegister.ForeColor = System.Drawing.Color.White;
            this.gbRegister.Location = new System.Drawing.Point(235, 100);
            this.gbRegister.Name = "gbRegister";
            this.gbRegister.Size = new System.Drawing.Size(500, 500);
            this.gbRegister.TabIndex = 12;
            this.gbRegister.TabStop = false;
            this.gbRegister.Text = "Member Register";
            // 
            // txtmbID
            // 
            this.txtmbID.AutoSize = true;
            this.txtmbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmbID.Location = new System.Drawing.Point(290, 140);
            this.txtmbID.Name = "txtmbID";
            this.txtmbID.Size = new System.Drawing.Size(0, 29);
            this.txtmbID.TabIndex = 22;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(280, 460);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(102, 20);
            this.lblLogin.TabIndex = 21;
            this.lblLogin.Text = "Login Here";
            this.lblLogin.Click += new System.EventHandler(this.label2_Click);
            this.lblLogin.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.lblLogin.MouseLeave += new System.EventHandler(this.lblLogin_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 460);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Already a Member?";
            // 
            // pbLogo1
            // 
            this.pbLogo1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbLogo1.BackgroundImage")));
            this.pbLogo1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo1.Location = new System.Drawing.Point(400, 10);
            this.pbLogo1.Name = "pbLogo1";
            this.pbLogo1.Size = new System.Drawing.Size(100, 100);
            this.pbLogo1.TabIndex = 19;
            this.pbLogo1.TabStop = false;
            // 
            // epName
            // 
            this.epName.ContainerControl = this;
            // 
            // epUsername
            // 
            this.epUsername.ContainerControl = this;
            // 
            // epPwd
            // 
            this.epPwd.ContainerControl = this;
            // 
            // epEmail
            // 
            this.epEmail.ContainerControl = this;
            // 
            // memberRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(842, 753);
            this.Controls.Add(this.lblUpper);
            this.Controls.Add(this.gbRegister);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblCharacter);
            this.Controls.Add(this.lblLower);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "memberRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.memberRegister_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbRegister.ResumeLayout(false);
            this.gbRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epUsername)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epPwd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epEmail)).EndInit();
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
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lbluserPassword;
        private System.Windows.Forms.Label lbluserName;
        private System.Windows.Forms.Label lblmbName;
        private System.Windows.Forms.Label lblmbID;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtmbName;
        private System.Windows.Forms.TextBox txtuserName;
        private System.Windows.Forms.TextBox txtuserPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblUpper;
        private System.Windows.Forms.Label lblCharacter;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblLower;
        private System.Windows.Forms.GroupBox gbRegister;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbLogo1;
        private System.Windows.Forms.Label txtmbID;
        private System.Windows.Forms.ErrorProvider epName;
        private System.Windows.Forms.ErrorProvider epUsername;
        private System.Windows.Forms.ErrorProvider epPwd;
        private System.Windows.Forms.ErrorProvider epEmail;
    }
}