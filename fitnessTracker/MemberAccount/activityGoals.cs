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
    public partial class activityGoals : Form
    {
        fitnessTrackerDataSetTableAdapters.TrackTableAdapter trackTA=new fitnessTrackerDataSetTableAdapters.TrackTableAdapter();
        fitnessTrackerDataSetTableAdapters.MemberstbTableAdapter memberTA=new fitnessTrackerDataSetTableAdapters.MemberstbTableAdapter();
        fitnessTrackerDataSetTableAdapters.activitiesTableAdapter activityTA=new fitnessTrackerDataSetTableAdapters.activitiesTableAdapter();

        DataTable activityData=new DataTable();
        public activityGoals()
        {
            InitializeComponent();
        }

        public void TrackAutoID()
        {
            DataTable trackData =new DataTable();
            trackData = trackTA.GetData();

            if (trackData.Rows.Count == 0)
            {
                lblTrackID.Text = "T-001";
            }
            else
            {
                int size = trackData.Rows.Count - 1;
                string oldid = trackData.Rows[size][0].ToString();

                int newid = Convert.ToInt16(oldid.Substring(2, 3));

                if (newid >= 1 && newid < 9)
                {
                    lblTrackID.Text = "T-00" + (newid + 1);
                }
                else if (newid >= 9 && newid < 99)
                {

                    lblTrackID.Text = "T-0" + (newid + 1);
                }
                else if (newid >= 99 && newid < 999)
                {

                    lblTrackID.Text = "T-" + (newid + 1);

                }
            }
        }
        public void selectactivity()
        {
            activityData=activityTA.GetData();
            if (activityData.Rows.Count > 0)
            {
                DataRow datarow=activityData.NewRow();
                cbActivity.DataSource = activityData;
                cbActivity.DisplayMember = "ActivityName";
                cbActivity.ValueMember = "ActivityID";
            }
        }
        private void activityGoals_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fitnessTrackerDataSet.activities' table. You can move, or remove it, as needed.
            this.activitiesTableAdapter.Fill(this.fitnessTrackerDataSet.activities);

            lblID.Text = memberLogin.MID;
            lblName.Text = memberLogin.MName;
            TrackAutoID();
            selectactivity();
            txtActID.Text = string.Empty;
        }

        private void cbActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id=cbActivity.SelectedValue.ToString();
            
            txtActID.Text = id;
            //activityTA.selectActivity(txtActID.Text);
            if(activityData.Rows.Count > 0)
            {
                int row=cbActivity.SelectedIndex;
                txtmetric1.Text=activityData.Rows[row]["Metric1"].ToString();
                txtmetric2.Text = activityData.Rows[row]["Metric2"].ToString();
                txtmetric3.Text = activityData.Rows[row]["Metric3"].ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string goal=txtGoal.Text;
            if(cbActivity.SelectedIndex<0)
            {
                MessageBox.Show("Please Select Activity!");
            }
            else if (string.IsNullOrWhiteSpace(txtGoal.Text)&&!goal.Any(char.IsDigit))
            {
                MessageBox.Show("Goal is Empty!And shoud be number");
            }
            else
            {
                int recodrCount = trackTA.trackLog(lblTrackID.Text, cbActivity.Text, "Incomplete", lblID.Text, txtActID.Text, DateTime.Now, Convert.ToInt32(txtGoal.Text));
                if (recodrCount > 0)
                {
                    MessageBox.Show("Goal insert success!");
                    track t = new track();
                    this.Hide();
                    t.ShowDialog();
                }
            }
            
            
        }

        private void trackingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            track trackUI = new track();
            this.Hide();
            trackUI.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            memberLogin memberLogin = new memberLogin();
            this.Hide();
            memberLogin.ShowDialog();
        }

        private void sEARCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchActivity sAct=new searchActivity();
            this.Hide();
            sAct.ShowDialog();
        }

        private void pnUI_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
