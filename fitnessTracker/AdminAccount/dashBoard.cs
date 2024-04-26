using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fitnessTracker.AdminAccount
{
    public partial class dashBoard : UserControl
    {
        private adminDashBoard parentForm;
        public dashBoard(adminDashBoard parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }        
        private void btnActivity_Click(object sender, EventArgs e)
        {
            parentForm.Hide();
            Activity activity = new Activity();
            activity.ShowDialog();
            
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            adminsList aList = new adminsList();
            pnDataList.Controls.Clear();
            pnDataList.Controls.Add(aList);
            adminDashBoard adminDashBoard = this.parentForm as adminDashBoard;
            adminDashBoard.handleBtn();
        }

        private void btnMemberList_Click(object sender, EventArgs e)
        {
            membersLIst mLIst = new membersLIst();
            pnDataList.Controls.Clear();
            pnDataList.Controls.Add(mLIst);
            adminDashBoard adminDashBoard = this.parentForm as adminDashBoard;
            adminDashBoard.handleBtn();
        }
    }
}
