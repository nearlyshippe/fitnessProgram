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
    public partial class adminRegister : Form
    {
        fitnessTrackerDataSetTableAdapters.adminsTableAdapter admintb = new fitnessTrackerDataSetTableAdapters.adminsTableAdapter();
        DataTable adminData = new DataTable();
        public adminRegister()
        {
            InitializeComponent();
        }
        private void lOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminLogin login = new adminLogin();
            this.Hide();
            login.ShowDialog();
        }

        private void hOMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminWelcome adwelcome = new AdminWelcome();
            this.Hide();
            adwelcome.ShowDialog();
        }
        public void clearAdmin()
        {
            txtadminName.Text = "";
            txtemail.Text = "";
            txtuserName.Text = "";
            txtuserPwd.Text = "";
            txtphoneNo.Text = "";
        }

        public void adminAutoID()
        {
            adminData = admintb.GetData();

            if (adminData.Rows.Count == 0)
            {
                txtadminID.Text = "AD-001";
            }
            else
            {
                int size = adminData.Rows.Count - 1;
                string oldid = adminData.Rows[size][0].ToString();

                int newid = Convert.ToInt16(oldid.Substring(3, 3));

                if (newid >= 1 && newid < 9)
                {
                    txtadminID.Text = "AD-00" + (newid + 1);
                }
                else if (newid >= 9 && newid < 99)
                {

                    txtadminID.Text = "AD-0" + (newid + 1);
                }
                else if (newid >= 99 && newid < 999)
                {

                    txtadminID.Text = "AD-" + (newid + 1);

                }
            }
        }

                       
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAdmin();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string adminuserName = txtuserName.Text;
            string adminpassWord = txtuserPwd.Text;
            try
            {

            if (txtadminName.Text == "")
            {
                MessageBox.Show("!EMPTY!");
                txtadminName.Focus();
            }
            else if (txtemail.Text == "")
            {
                MessageBox.Show("!EMPTY Email!");
                txtemail.Focus();
            }
            else if (txtuserName.Text=="")
            {
                MessageBox.Show("!EMPTY User Name!");
                txtuserName.Focus();
            }
            else if (txtuserName.Text.Length <3 || txtuserName.Text.Length > 10)
            {
                MessageBox.Show("Enter Valid Username length, Should enter between 3 and 10!");
                txtuserName.Focus();
            }
            else if(!adminuserName.Any(char.IsLetter)){
                MessageBox.Show("Username should include Character!");
                txtuserName.Focus();
            }
            else if (!adminuserName.Any(char.IsDigit))
            {
                MessageBox.Show("Username should include digit Character!");
                txtuserName.Focus();
            }
            else if (txtuserPwd.Text == "")
            {
                MessageBox.Show("!EMPTY User Password!");
                txtuserPwd.Focus();
            }
                else if (txtuserPwd.Text.Length < 8 || txtuserPwd.Text.Length>16)
            {
                MessageBox.Show("Enter Valid Password length, Should enter between 8 and 16!");
                txtuserPwd.Focus();
            }
            else if (!adminpassWord.Any(char.IsUpper))
            {
                MessageBox.Show("Password should include Upper Character!");
                txtuserPwd.Focus();
            }

            else if (!adminpassWord.Any(char.IsLower))
            {
                MessageBox.Show("Password should include Lower Character!");
                txtuserPwd.Focus();
            }

            else if (!adminpassWord.Any(char.IsDigit))
            {
                MessageBox.Show("Password should include digit Character!");
                txtuserPwd.Focus();
            }
            else if (txtphoneNo.Text == "")
            {
                MessageBox.Show("!EMPTY PhoneNumber");
                txtphoneNo.Focus();
            }
            else
            {
                clsAdmin adminObj = new clsAdmin();
                adminObj.AdminID = txtadminID.Text;
                adminObj.AdminName = txtadminName.Text;
                adminObj.adminEmail = txtemail.Text;
                adminObj.adminUserName = txtuserName.Text;
                adminObj.adminPwd = txtuserPwd.Text;
                adminObj.adminPhone = txtphoneNo.Text;

                int adminInsert = admintb.adminRegister(adminObj.AdminID, adminObj.AdminName, adminObj.adminEmail, adminObj.adminUserName, adminObj.adminPwd, adminObj.adminPhone);
                if (adminInsert > 0)
                {
                    MessageBox.Show("Registered Success!");
                    clearAdmin();
                    adminAutoID();
                }
            }
        }
            catch(Exception ex)
            {
                MessageBox.Show("Try Again!",ex.Message,MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
        }

        private void adminRegister_Load(object sender, EventArgs e)
        {
            adminAutoID();
        }
        
        
    }
}
