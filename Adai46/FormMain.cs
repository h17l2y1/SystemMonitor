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
        FormDashboard formDashboard = new FormDashboard();
        FormDisks formDisks = new FormDisks();

        public FormMain()
        {
            InitializeComponent(); 

        }

        private void btDashboard_Click(object sender, EventArgs e)
        {
            lbPanelName.Text = btDashboard.Text;
            formDashboard.Dock = DockStyle.Fill;
            formDashboard.MdiParent = this;
            formDashboard.Show();
            formDisks.Hide();
        } 

        private void btDisk_Click(object sender, EventArgs e)
        {
            lbPanelName.Text = btDisks.Text;
            formDashboard.Hide();

            formDisks.Dock = DockStyle.Fill;
            formDisks.MdiParent = this;
            formDisks.Show();
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbMinimaize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            formDashboard.Dock = DockStyle.Fill;
            formDashboard.MdiParent = this;
            formDashboard.Show();
        }

    }
}
