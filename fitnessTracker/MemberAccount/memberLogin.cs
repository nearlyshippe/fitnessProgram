using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static fitnessTracker.Program;

namespace fitnessTracker
{
    public partial class memberLogin : Form
    {
        fitnessTrackerDataSetTableAdapters.MemberstbTableAdapter memberTA=new fitnessTrackerDataSetTableAdapters.MemberstbTableAdapter();
        DataTable memberTB=new DataTable();
        
        public static string MID, MName;
        string validPass, password;
        int loginCount = 0;
        customMessage custom=new customMessage();
        public memberLogin()
        {
            InitializeComponent();
        }
        private void memberLogin_Load(object sender, EventArgs e)
        {
            txtuserName.Focus();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberRegister registerMember = new memberRegister();
            this.Hide();
            registerMember.ShowDialog();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Member memberForm = new Member();
            this.Hide();
            memberForm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string mbusername=txtuserName.Text, mbpassword=txtuserPassword.Text;
            try
            {
                DataTable mbLoginCheck=new DataTable();
                if (loginCount == 5)
                {                   
                    custom.Message = "Maximum login attempts reached. Please try again later.";
                    custom.ShowDialog();
                    Application.Exit();
                }
                else
                {                 
                    if (string.IsNullOrWhiteSpace(mbusername))
                    {
                        epUsername.SetError(txtuserName,"Empty Username!");
                        txtuserName.Focus();                       
                    }
                    else if (string.IsNullOrWhiteSpace(mbpassword))
                    {
                        epPwd.SetError(txtuserPassword, "Empty Password!");
                        txtuserPassword.Focus();
                    }
                    else
                    {
                        
                        mbLoginCheck = memberTA.selectUserName(mbusername);
                        if (mbLoginCheck.Rows.Count == 0)
                        {
                            //custom.Message = "Username does not exist!";
                            //custom.ShowDialog();
                            epUsername.SetError(txtuserName, "Username does not exist!");
                            txtuserName.Focus();                            
                        }
                        else
                        {                            
                            validPass = mbLoginCheck.Rows[0][3].ToString();
                            password = mbpassword;
                            if (validPass != password)
                            {
                                custom.Message = "Incorrect Password!";
                                custom.ShowDialog();
                                txtuserPassword.Focus();                               
                            }
                        }
                        
                        if (mbLoginCheck.Rows.Count > 0&&validPass==password)
                        {
                            custom.Message = "Login Success!";
                            custom.ShowDialog();                           
                            MID = mbLoginCheck.Rows[0][0].ToString();
                            MName = mbLoginCheck.Rows[0][1].ToString();
                            activityGoals actGoals = new activityGoals();
                            this.Hide();
                            actGoals.ShowDialog();
                        }
                        else
                        {
                            loginCount += 1;
                            MessageBox.Show("Incorrect Login Details, Login Attempts:" + loginCount);
                        }
                    }
                    if (!string.IsNullOrWhiteSpace(txtuserName.Text))
                    {
                        epUsername.SetError(txtuserName, string.Empty);
                    }
                    if (!string.IsNullOrWhiteSpace(txtuserPassword.Text))
                    {
                        epPwd.SetError(txtuserPassword, string.Empty);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Try Again", ex.Message, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void clearAll()
        {
            txtuserName.Text = string.Empty;
            txtuserPassword.Text = string.Empty;
        }

        private void activityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivityInfo activityInfo = new ActivityInfo();
            this.Hide();
            activityInfo.ShowDialog();
        }

        private void lblRegisterbtn_Click(object sender, EventArgs e)
        {
            memberRegister register=new memberRegister();
            this.Hide();
            register.ShowDialog();
        }

        private void lblRegisterbtn_MouseEnter(object sender, EventArgs e)
        {
            lblRegisterbtn.Cursor=Cursors.Hand;
        }

        private void lblRegisterbtn_MouseLeave(object sender, EventArgs e)
        {
            lblRegisterbtn.Cursor=Cursors.Default;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtuserPassword.PasswordChar == '*')
            {
                txtuserPassword.PasswordChar = '\0';
                btnShow.Text = "Hide";
            }
            else
            {
                txtuserPassword.PasswordChar = '*';
                btnShow.Text = "Show";

            }
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.Salmon;
            btnLogin.Cursor=Cursors.Hand;
            btnLogin.ForeColor = Color.FromArgb(50, 50, 50);
        }


        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor= Color.FromArgb(50, 50, 50);
            btnLogin.Cursor=Cursors.Default;
            btnLogin.ForeColor = Color.Salmon;
        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.Salmon;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.ForeColor = Color.FromArgb(50, 50, 50);
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.FromArgb(50, 50, 50);
            btnCancel.Cursor = Cursors.Default;
            btnCancel.ForeColor = Color.Salmon;
        }
       
        
    }
}
