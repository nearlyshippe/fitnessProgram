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
    public partial class adminsList : UserControl
    {
        adminDashBoard admindashboard;
        fitnessTrackerDataSetTableAdapters.adminsTableAdapter adminTA=new fitnessTrackerDataSetTableAdapters.adminsTableAdapter();
        DataTable adminData=new DataTable();
        public adminsList()
        {
            InitializeComponent();
        }
       
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvAdmins.DataSource = adminTA.searchByAdminName(txtSearch.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void adminsList_Load(object sender, EventArgs e)
        {
            adminData=adminTA.GetData();
            dgvAdmins.DataSource = adminData;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            dgvAdmins.DataSource = adminData;
        }
    }
}
