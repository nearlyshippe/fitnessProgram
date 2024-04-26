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
    public partial class membersLIst : UserControl
    {
        adminDashBoard admindashboard;
        fitnessTrackerDataSetTableAdapters.MemberstbTableAdapter memberTA=new fitnessTrackerDataSetTableAdapters.MemberstbTableAdapter();
        DataTable memberData=new DataTable();
        
        public membersLIst()
        {
            InitializeComponent();

        }

        private void membersLIst_Load(object sender, EventArgs e)
        {
            memberData=memberTA.GetData();
            dgvMembers.DataSource = memberData;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvMembers.DataSource = memberTA.searchByMemberName(txtSearch.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefrash_Click(object sender, EventArgs e)
        {
            txtSearch.Text=string.Empty;
            dgvMembers.DataSource = memberData;
        }
    }
}
