using System;
using System.Collections;
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
    public partial class adminDashBoard : Form
    {
        
        public adminDashBoard()
        {
            InitializeComponent();
        }

        private void adminDashBoard_Load(object sender, EventArgs e)
        {
            handleBtn();
            lbluserName.Text = adminLogin.loginuserName;
            btnBack.Visible = false;
        }

        public void handleBtn()
        {
            btnBack.Visible = true;           
        }

        private void btnActivity_Click(object sender, EventArgs e)
        {
            Activity adActivity = new Activity();
            this.Hide();
            adActivity.ShowDialog();
            
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            adminLogin adlogin = new adminLogin();
            this.Hide();
            adlogin.ShowDialog();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            adminRegister adRegister = new adminRegister();
            this.Hide();
            adRegister.ShowDialog();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            btnBack.Visible = true;
            adminsList aList= new adminsList();
            pnDataList.Controls.Clear();
            pnDataList.Controls.Add(aList);
        }

        private void btnMemberList_Click(object sender, EventArgs e)
        {
            btnBack.Visible = true;
            membersLIst mList = new membersLIst();
            pnDataList.Controls.Clear();
            pnDataList.Controls.Add(mList);
        }
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            dashBoard dash = new dashBoard(this);
            pnDataList.Controls.Clear();
            pnDataList.Controls.Add(dash);
            btnBack.Visible = false;
        }       
    }
}
