using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fitnessTracker.AdminAccount;
using static fitnessTracker.Program;

namespace fitnessTracker
{
    public partial class adminLogin : Form
    {
        fitnessTrackerDataSetTableAdapters.adminsTableAdapter admintb = new fitnessTrackerDataSetTableAdapters.adminsTableAdapter();
        DataTable adminData = new DataTable();
        public int loginCount = 0;
        public static string loginuserName, loginuserID;
        string validPass, validName, password;
        public adminLogin()
        {
            InitializeComponent();
        }

        public void clearBtn()
        {
            txtuserName.Text = "";
            txtuserPwd.Text = "";
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearBtn();
        }
        private void adminLogin_Load(object sender, EventArgs e)
        {

        }
        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminWelcome adwelcome = new AdminWelcome();
            this.Hide();
            adwelcome.ShowDialog();
        }
        private void rEGISTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminRegister adRegister = new adminRegister();
            this.Hide();
            adRegister.ShowDialog();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtuserPwd.PasswordChar == '*')
            {
                txtuserPwd.PasswordChar = '\0';
                btnShow.Text = "Hide";
            }
            else
            {
                txtuserPwd.PasswordChar = '*';
                btnShow.Text = "Show";
            }
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable adLoginCheck=new DataTable();                                            
                if (loginCount == 5)
                {
                    MessageBox.Show("Maximum login attempts reached. Please try again later!");
                    Application.Exit();
                }
                else
                {
                    if (txtuserName.Text == "")
                    {
                        MessageBox.Show("Please Enter UserName!");
                        txtuserName.Focus();
                    }
                    else if (txtuserPwd.Text == "")
                    {
                        MessageBox.Show("Please Enter Password!");
                        txtuserPwd.Focus();
                    }
                    else
                    {
                        adLoginCheck = admintb.selectUserName(txtuserName.Text);
                        if (adLoginCheck.Rows.Count == 0)
                        {
                            MessageBox.Show("Username does not exist!");
                        }
                        else
                        {
                            validPass = adLoginCheck.Rows[0][4].ToString();
                            password = txtuserPwd.Text;
                            if (validPass != password)
                            {
                                MessageBox.Show("Incorrect Password!");
                            }
                        }
                        clsAdmin adminObj = new clsAdmin();
                        adminObj.adminUserName = txtuserName.Text;
                        adminObj.adminPwd = txtuserPwd.Text;

                        adminData = admintb.adminLogin(adminObj.adminUserName, adminObj.adminPwd);
                        if (adminData.Rows.Count > 0)
                        {
                            MessageBox.Show("Login Success!");
                            loginuserID = adminData.Rows[0][0].ToString();
                            loginuserName = adminData.Rows[0][1].ToString();

                            adminDashBoard adBoard = new adminDashBoard();
                            this.Hide();
                            adBoard.ShowDialog();
                        }
                        else
                        {
                            loginCount += 1;
                            MessageBox.Show("Incorrect Login Details, Login Attempts:" + loginCount);
                        }
                    }                   
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Please Try Again", MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
        }      
    }
}
