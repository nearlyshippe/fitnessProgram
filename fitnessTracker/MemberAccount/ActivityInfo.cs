using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using fitnessTracker.ActivityList;
using static fitnessTracker.Program;

namespace fitnessTracker
{
    public partial class ActivityInfo : Form
    {
        public ActivityInfo()
        {
            InitializeComponent();
        }

        

        

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberLogin login=new memberLogin();
            this.Hide();
            login.ShowDialog();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            this.Hide();
            member.ShowDialog();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberRegister register=new memberRegister();
            this.Hide();
            register.ShowDialog();
        }

        

        private void walkingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            walking wPanel = new walking();
            activityPanel.Controls.Clear();
            activityPanel.Controls.Add(wPanel);
            msActivity.BackColor = Color.FromArgb(50,50,50);
        }

        private void swimmingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Swimming swimmingUI = new Swimming();
            activityPanel.Controls.Clear();
            activityPanel.Controls.Add(swimmingUI);
            msActivity.BackColor = Color.SteelBlue;
        }

        private void yogaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yoga yogaUI = new Yoga();
            activityPanel.Controls.Clear();
            activityPanel.Controls.Add(yogaUI);
            msActivity.BackColor = Color.DarkSlateGray;           
        }

        private void bikingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Biking bkUI = new Biking();
            activityPanel.Controls.Clear();
            activityPanel.Controls.Add(bkUI);
            msActivity.BackColor = Color.FromArgb(70,70,80);
        }

        private void jumpingRopeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JumpingRope jpUI = new JumpingRope();
            activityPanel.Controls.Clear();
            activityPanel.Controls.Add(jpUI);
            msActivity.BackColor = Color.FromArgb(75, 75, 75);
        }

        private void weightLiftingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Weightlift wlUI = new Weightlift();
            activityPanel.Controls.Clear();
            activityPanel.Controls.Add(wlUI);
            msActivity.BackColor = Color.FromArgb(110, 10, 20);
        }

        private void exitToolStripMenuItem_Click(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        
        private void ActivityInfo_Load(object sender, EventArgs e)
        {
            walking wPanel = new walking();
            activityPanel.Controls.Clear();
            activityPanel.Controls.Add(wPanel);
        }
    }
}
