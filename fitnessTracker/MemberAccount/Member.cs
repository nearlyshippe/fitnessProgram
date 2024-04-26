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
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
            this.FormClosing += Member_FormClosing;
        }
        public class CommonMessageBox
        {
            public static bool ConfirmClose()
            {
                DialogResult result = MessageBox.Show("Are you sure you want to close this application?", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                return result == DialogResult.Yes;
            }
        }
        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberRegister mbRegister = new memberRegister();
            this.Hide();
            mbRegister.ShowDialog();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberLogin mbLogin = new memberLogin();
            this.Hide();
            mbLogin.ShowDialog();
        }

        private void Member_Load(object sender, EventArgs e)
        {

        }

        private void activityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivityInfo info=new ActivityInfo();
            this.Hide();
            info.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Member_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CommonMessageBox.ConfirmClose())
            {
                e.Cancel = true;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            memberLogin login = new memberLogin();
            this.Hide();
            login.ShowDialog();
        }

        private void btnStart_MouseEnter(object sender, EventArgs e)
        {
            btnStart.Cursor = Cursors.Hand;
        }

        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            btnStart.Cursor= Cursors.Default;
        }
    }
}
