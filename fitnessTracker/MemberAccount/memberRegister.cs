using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static fitnessTracker.Program;

namespace fitnessTracker
{
    public partial class memberRegister : Form
    {
        customMessage custom=new customMessage();
        fitnessTrackerDataSetTableAdapters.MemberstbTableAdapter mbdb = new fitnessTrackerDataSetTableAdapters.MemberstbTableAdapter();
        DataTable mbdtb=new DataTable();
        public memberRegister()
        {
            InitializeComponent();
        }
        private void memberRegister_Load(object sender, EventArgs e)
        {
            memberAutoID();
            txtmbName.Focus();
        }
        public void memberAutoID()
        {
            mbdtb = mbdb.GetData();

            if (mbdtb.Rows.Count == 0)
            {
                txtmbID.Text = "M-001";
            }
            else
            {
                int size = mbdtb.Rows.Count - 1;
                string oldid = mbdtb.Rows[size][0].ToString();

                int newid = Convert.ToInt16(oldid.Substring(2, 3));

                if (newid >= 1 && newid < 9)
                {
                    txtmbID.Text = "M-00" + (newid + 1);
                }
                else if (newid >= 9 && newid < 99)
                {

                    txtmbID.Text = "M-0" + (newid + 1);
                }
                else if (newid >= 99 && newid < 999)
                {

                    txtmbID.Text = "M-" + (newid + 1);

                }
            }
        }
        public void clearBtn()
        {
            //txtmbID.Text = "";
            txtmbName.Text = "";
            txtuserName.Text = "";
            txtuserPassword.Text = "";
            txtEmail.Text = "";
        }        
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtuserName.Text, name = txtmbName.Text, pass = txtuserPassword.Text, email = txtEmail.Text;
            bool validPassword = is_valid(pass);
            bool validEmail = IsValidEmail(txtEmail.Text);

            try
            {
                if (string.IsNullOrWhiteSpace(name))//member name validation
                {
                    epName.SetError(txtmbName, "Enter your valid name for the registration!");
                    txtmbName.Focus();
                    return;
                }
                else if (name.Length < 3)
                {
                    custom.Message = "Member name must be at least 3 characters long!";
                    custom.ShowDialog();
                    txtmbName.Focus();
                    return;
                }
                else if (name.Any(char.IsDigit))
                {
                    custom.Message = "Member name cannot contain digits!";
                    custom.ShowDialog();
                    txtmbName.Focus();
                    return;
                }
                else
                {
                    epName.SetError(txtmbName, string.Empty);
                }

                if (string.IsNullOrWhiteSpace(username))//member username validation
                {
                    epUsername.SetError(txtuserName, "Username field cannot be left empty. Please enter a valid username!");
                    txtuserName.Focus();
                    return;
                }
                else if (username.Length < 4)
                {
                    custom.Message = "Username must be at least 4 characters long!";
                    custom.ShowDialog();
                    txtuserName.Focus();
                    return;
                }
                else if (!username.Any(char.IsDigit))
                {
                    custom.Message = " Username must contain at least one digit!";
                    custom.ShowDialog();
                    txtuserName.Focus();
                    return;
                }
                else
                {
                    epUsername.SetError(txtuserName, string.Empty);
                }

                if (string.IsNullOrWhiteSpace(pass))
                {
                    epPwd.SetError(txtuserPassword, "Empty Password");
                    txtuserPassword.Focus();
                    return;
                }
                else if (!validPassword)
                {
                    epPwd.SetError(txtuserPassword, "Invalid Password Format");
                    txtuserPassword.Focus();
                    return;
                }
                else
                {
                    epPwd.SetError(txtuserPassword, string.Empty);
                }

                if (string.IsNullOrWhiteSpace(email)) //member email validation
                {
                    epEmail.SetError(txtEmail, "Empty Email, Enter Valid Email!");
                    txtEmail.Focus();
                    return;
                }
                else if (!validEmail)
                {
                    custom.Message = "Invalid Email Format!";
                    custom.ShowDialog();
                    txtEmail.Focus();
                    return;
                }
                else
                {
                    epEmail.SetError(txtEmail, string.Empty);
                }

                // If all validations passed, proceed with registration
                mbCls memberCls = new mbCls();
                memberCls.mbID = txtmbID.Text;
                memberCls.mbName = txtmbName.Text;
                memberCls.mbuserName = txtuserName.Text;
                memberCls.mbuserPassword = txtuserPassword.Text;
                memberCls.mbEmail = txtEmail.Text;

                int mbdata = mbdb.mbRegister(memberCls.mbID, memberCls.mbName, memberCls.mbuserName, memberCls.mbuserPassword, memberCls.mbEmail);

                if (mbdata > 0)
                {
                    custom.Message = "Member Registration Successful!";
                    custom.ShowDialog();
                    clearBtn();
                    memberAutoID();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Try Again!", ex.Message, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearBtn();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Member memberForm=new Member();
            this.Hide();
            memberForm.ShowDialog();
        }

        private void loginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            memberLogin loginMember=new memberLogin();
            this.Hide();
            loginMember.ShowDialog();
        }

        private void txtuserPassword_TextChanged(object sender, EventArgs e)
        {
            bool validPassword = is_valid(txtuserPassword.Text);
            string pass=txtuserPassword.Text;
            passValidShow();

            if (pass.Length >= 6&&validPassword)
            {
                passValidHide();
            }
        }

        private void activityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivityInfo activityInfo = new ActivityInfo();
            this.Hide();
            activityInfo.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            memberLogin loginMember = new memberLogin();
            this.Hide();
            loginMember.ShowDialog();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            lblLogin.Cursor = Cursors.Hand;
        }

        private void lblLogin_MouseLeave(object sender, EventArgs e)
        {
            lblLogin.Cursor = Cursors.Default;
        }

        private void txtuserPassword_Click(object sender, EventArgs e)
        {
            passValidShow();
        }

        private void txtuserPassword_Leave(object sender, EventArgs e)
        {
            passValidHide();
        }
        private void passValidShow()
        {
            lblCharacter.Visible = true;
            lblUpper.Visible = true;
            lblLower.Visible = true;
            lblNumber.Visible = true;
        }
        private void passValidHide()
        {
            lblCharacter.Visible = false;
            lblUpper.Visible = false;
            lblLower.Visible = false;
            lblNumber.Visible = false;
        }
        public bool IsValidEmail(String email)
        {
            bool valid = true;
            string pattern = (@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Regex emailReg = new Regex(pattern);
            if (!emailReg.IsMatch(email))
            {
                valid = false;
                txtEmail.Focus();
            }
            return valid;
        }
        private bool is_valid(String password)
        {
            bool valid = true;
            Regex has_num = new Regex(@"[0-9]");
            Regex has_upper = new Regex(@"[A-Z]");
            Regex has_lower = new Regex(@"[a-z]");
            Regex minMaxChar = new Regex(@".{12,}");

            if (!minMaxChar.IsMatch(password))
            {

                lblCharacter.ForeColor = Color.Red;
                txtuserPassword.Focus();
                valid = false;
            }
            else
            {

                lblCharacter.ForeColor = Color.Green;
            }
            if (!has_num.IsMatch(password))
            {
                lblNumber.ForeColor = Color.Red;
                txtuserPassword.Focus();
                valid = false;
            }
            else
            {
                lblNumber.ForeColor = Color.Green;

            }

            if (!has_upper.IsMatch(password))
            {
                lblUpper.ForeColor = Color.Red;
                txtuserPassword.Focus();
                valid = false;
            }
            else
            {
                lblUpper.ForeColor = Color.Green;
            }
            if (!has_lower.IsMatch(password))
            {
                lblLower.ForeColor = Color.Red;
                txtuserPassword.Focus();
                valid = false;
            }
            else
            {
                lblLower.ForeColor = Color.Green;
            }

            return valid;
        }                
    }
}
