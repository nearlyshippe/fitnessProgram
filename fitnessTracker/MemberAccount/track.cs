using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static fitnessTracker.Program;

namespace fitnessTracker
{
    public partial class track : Form
    {
        fitnessTrackerDataSetTableAdapters.activitiesTableAdapter activityTA=new fitnessTrackerDataSetTableAdapters.activitiesTableAdapter();
        fitnessTrackerDataSetTableAdapters.TrackTableAdapter trackTA=new fitnessTrackerDataSetTableAdapters.TrackTableAdapter();
        
        DataTable trackData = new DataTable();
        customMessage custom=new customMessage();
        public track()
        {
            InitializeComponent();
        }

        private void track_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'fitnessTrackerDataSet.Track' table. You can move, or remove it, as needed.
            this.trackTableAdapter.Fill(this.fitnessTrackerDataSet.Track);
            trackData=trackTA.GetData();
            dgvTrack.DataSource = trackData;
            trackTA.selectDataByMemberID(memberLogin.MID);
            
        }

        private void dgvTrack_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Visible=true;
            int row = dgvTrack.CurrentRow.Index;
            txtTrackID.Text = dgvTrack[0, row].Value.ToString();
            txtGoal.Text = dgvTrack[7, row].Value.ToString();
            dgvTrack.Refresh();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (txtTrackID.Text == "")
            {
                custom.Message = "Error: Track ID Missing. Click on a cell in the 'Track ID' column to edit the track.";
                custom.ShowDialog();
            }
            else if (txtMET.Text == "")
            {
                custom.Message = "MET Value Missing. Please enter the MET value to calculate!";
                custom.ShowDialog();
            }
            else if (txtWeight.Text == "")
            {
                custom.Message = "Body Weight Missing. Please enter the body weight in kilograms to calculate.";
                custom.ShowDialog();
            }
            else if (txtTime.Text == "")
            {
                custom.Message = "Missing Duration. Please enter the activity duration in hours. For example, 30 minutes should be entered as 0.5.";
                custom.ShowDialog();
            }
            else
            {
                int met, weight, hour;
                met = Convert.ToInt32(txtMET.Text);
                weight = Convert.ToInt32(txtWeight.Text);
                hour = Convert.ToInt32(txtTime.Text);

                int calResult = met * weight * hour;
                txtTotalCal.Text = calResult.ToString();
            }                      
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtTrackID.Text !="")
            {
                string goalcal=txtGoal.Text;
                if (goalcal.Any(char.IsLetter))
                {
                    custom.Message = "Invalid Input. Please enter numeric values for the goal calories.";
                    custom.ShowDialog();
                }
                else if (goalcal.Any(char.IsDigit))
                {
                    int goalCal = Convert.ToInt32(goalcal);
                    if (Convert.ToInt32(txtTotalCal.Text) >= goalCal)
                    {
                        int data = trackTA.updateStatus("Complete", Convert.ToInt32(txtTotalCal.Text), txtTrackID.Text);
                        custom.Message = "Goal Achieved:You have successfully reached your target calories.";
                        custom.ShowDialog();
                        dgvTrack.DataSource = trackTA.selectDataByMemberID(memberLogin.MID);
                        dgvTrack.Refresh();
                    }
                    else
                    {
                        custom.Message = "Goal Not Met: Calories burned are below target.";
                        custom.ShowDialog();
                        
                    }
                }
                
            }                                
        }

        private void setGoalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            activityGoals actGoal = new activityGoals();
            this.Hide();
            actGoal.ShowDialog();
        }

        
        private void sEARCHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchActivity sAct = new searchActivity();
            this.Hide();
            sAct.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTrack.SelectedRows.Count > 0)
            {
                
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected row?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                
                if (result == DialogResult.Yes)
                {
                    int dRow = dgvTrack.CurrentCell.RowIndex;
                    dgvTrack.Rows.RemoveAt(dRow);
                    trackTA.deleteTrackHistory(txtTrackID.Text);
                    custom.Message = "Selected Row Deleted Successfully!";
                    custom.ShowDialog();
                }
            }
            else
            {
                
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTrackID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
