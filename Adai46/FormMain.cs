using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adai46
{
    public partial class FormMain : Form
    {

        public FormMain()
        {
            InitializeComponent();
            UcPanelDashboard.Show();
            UcPanelDisk.Hide();
        }

        private void btDashboard_Click(object sender, EventArgs e)
        {
            lbPanelName.Text = btDashboard.Text;

            UcPanelDashboard.Show();
            UcPanelPcRaring.Hide();
            UcPanelDisk.Hide();
        } 

        private void btDisk_Click(object sender, EventArgs e)
        {
            lbPanelName.Text = btDisks.Text;

            UcPanelDisk.Show();
            UcPanelPcRaring.Hide();
            UcPanelDashboard.Hide();
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbMinimaize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btPcRating_Click(object sender, EventArgs e)
        {
            lbPanelName.Text = btDashboard.Text;

            UcPanelPcRaring.Show();
            UcPanelDashboard.Hide();
            UcPanelDisk.Hide();
        }
    }
}
