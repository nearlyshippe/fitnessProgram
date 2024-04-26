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
    public partial class Activity : Form
    {
        fitnessTrackerDataSetTableAdapters.activitiesTableAdapter adActivity = new fitnessTrackerDataSetTableAdapters.activitiesTableAdapter();
        DataTable activityData = new DataTable();



        public Activity()
        {
            InitializeComponent();
        }
        public void clearBtn()
        {
            txtactivityID.Text = "";
            txtactivityTitle.Text = "";
            txtMetric1.Text = "";
            txtMetric2.Text = "";
            txtMetric3.Text = "";
        }

        public void activityAutoID()
        {
            activityData = adActivity.GetData();

            if (activityData.Rows.Count == 0)
            {
                txtactivityID.Text = "A-001";
            }
            else
            {
                int size = activityData.Rows.Count - 1;
                string oldid = activityData.Rows[size][0].ToString();

                int newid = Convert.ToInt16(oldid.Substring(2, 3));

                if (newid >= 1 && newid < 9)
                {
                    txtactivityID.Text = "A-00" + (newid + 1);
                }
                else if (newid >= 9 && newid < 99)
                {

                    txtactivityID.Text = "A-0" + (newid + 1);
                }
                else if (newid >= 99 && newid < 999)
                {

                    txtactivityID.Text = "A-" + (newid + 1);

                }
            }
        }
        private void Activity_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fitnessTrackerDataSet.activities' table. You can move, or remove it, as needed.
            this.activitiesTableAdapter.Fill(this.fitnessTrackerDataSet.activities);
            // TODO: This line of code loads data into the 'fitnessTrackerDataSet.admins' table. You can move, or remove it, as needed.
            this.adminsTableAdapter.Fill(this.fitnessTrackerDataSet.admins);
            activityAutoID();
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            activityCls actClass = new activityCls();
            actClass.AID = txtactivityID.Text;
            actClass.ATitle = txtactivityTitle.Text;
            actClass.Ametric1 = txtMetric1.Text;
            actClass.Ametric2 = txtMetric2.Text;
            actClass.Ametric3 = txtMetric3.Text;

            int data = adActivity.insertActivities(actClass.AID,actClass.ATitle,actClass.Ametric1,actClass.Ametric2,actClass.Ametric3);

            if (data > 0)
            {
                MessageBox.Show("Successfully Inserted Data");
                activityDataGrid.DataSource = data;
                activityDataGrid.Refresh();
                activityDataGrid.DataSource = adActivity.GetData();
                
                activityDataGrid.DataSource = activityData;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearBtn();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            adminDashBoard adminDash = new adminDashBoard();
            this.Hide();
            adminDash.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(txtactivityTitle.Text=="")
            {
                MessageBox.Show("Enter Activity Title :");
                txtactivityTitle.Focus();
            }
            else if (txtMetric1.Text == "")
            {
                MessageBox.Show("Enter Activity Title :");
                txtMetric1.Focus();
            }
            else if (txtMetric2.Text == "")
            {
                MessageBox.Show("Enter Activity Title :");
                txtMetric2.Focus();
            }
            else if (txtMetric3.Text == "")
            {
                MessageBox.Show("Enter Activity Title :");
                txtMetric3.Focus();
            }
            else
            {
                activityCls actCls = new activityCls();
                actCls.AID = txtactivityID.Text;
                actCls.ATitle = txtactivityTitle.Text;
                actCls.Ametric1 = txtMetric1.Text;
                actCls.Ametric2 = txtMetric2.Text;
                actCls.Ametric3 = txtMetric3.Text;

                adActivity.updateTitle(actCls.ATitle, actCls.AID);
                adActivity.updateMetric1(actCls.Ametric1,actCls.AID);
                adActivity.updateMetric2(actCls.Ametric2, actCls.AID);
                adActivity.updateMetric3(actCls.Ametric3, actCls.AID);
                MessageBox.Show("Updated!");

                activityData = adActivity.GetData();
                activityDataGrid.Refresh();
                activityDataGrid.DataSource = activityData;
                activityAutoID();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int deleterow = activityDataGrid.CurrentCell.RowIndex;
            activityDataGrid.Rows.RemoveAt(deleterow);
            adActivity.deleteActivity(txtactivityID.Text);

            MessageBox.Show("Seleted Metric is Deleted Successfully!");
        }

        private void activityDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = activityDataGrid.CurrentRow.Index;
            txtactivityID.Text= activityDataGrid[0, row].Value.ToString();
            txtactivityTitle.Text= activityDataGrid[1, row].Value.ToString();
            txtMetric1.Text = activityDataGrid[2, row].Value.ToString();
            txtMetric2.Text = activityDataGrid[3, row].Value.ToString();
            txtMetric3.Text = activityDataGrid[4, row].Value.ToString();
            
        }

        
    }
}
