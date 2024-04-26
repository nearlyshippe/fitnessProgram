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

namespace fitnessTracker.AdminAccount
{
    public partial class AdminWelcome : Form
    {
        public AdminWelcome()
        {
            InitializeComponent();
        }
        public class CommonMessageBox
        {
            public static bool ConfirmClose()
            {
                DialogResult result = MessageBox.Show("Are you sure you want to close this application?", "Confirm Close", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                return result == DialogResult.Yes;
            }
        }

        private void lOGINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminLogin adminLogin = new adminLogin();
            this.Hide();
            adminLogin.ShowDialog();
            
        }

        private void rEGISTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adminRegister adminregister = new adminRegister();
            this.Hide();
            adminregister.ShowDialog();
        }

        private void AdminWelcome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!CommonMessageBox.ConfirmClose())
            {
                e.Cancel = true;
            }
        }
        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AdminWelcome_Load(object sender, EventArgs e)
        {

        }
    }
}
