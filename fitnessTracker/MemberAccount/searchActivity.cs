using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static fitnessTracker.Program;

namespace fitnessTracker
{
    public partial class searchActivity : Form
    {
        public static string trrackID, activityTitle, uid;
        fitnessTrackerDataSetTableAdapters.TrackTableAdapter trackTA=new fitnessTrackerDataSetTableAdapters.TrackTableAdapter();
        DataTable trackdata = new DataTable();

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                dgvSearch.DataSource = trackTA.SearchActivity(memberLogin.MID, txtSearch.Text);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        

        private void trackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            track trackUI = new track();
            this.Hide();
            trackUI.ShowDialog();
        }

        private void setGoalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activityGoals actGoal = new activityGoals();
            this.Hide();
            actGoal.ShowDialog();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char)13)
            {
                btnSearch.PerformClick();
            }
        }

        private void btnRefrash_Click(object sender, EventArgs e)
        {
            trackdata = trackTA.GetData();
            dgvSearch.DataSource=trackdata;
            txtSearch.Text=string.Empty;           
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search by Title...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search by Title...";
                txtSearch.ForeColor = SystemColors.GrayText;
            }
        }

        

        public searchActivity()
        {
            InitializeComponent();
           
        }
      
        private void searchActivity_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fitnessTrackerDataSet.Track' table. You can move, or remove it, as needed.
            this.trackTableAdapter.Fill(this.fitnessTrackerDataSet.Track);
            dgvSearch.DataSource = trackTA.GetData();
            dgvSearch.Refresh();
            txtSearch.Text = "Search by Title...";
        }
    }
}
