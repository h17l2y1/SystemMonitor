using NLog;
using System;
using System.Windows.Forms;

namespace Adai46
{
    public partial class FormMain : Form
    {

        private static Logger logger = LogManager.GetCurrentClassLogger();

        public FormMain()
        {
            logger.Trace("----Start program----");
            InitializeComponent();
            UcPanelDashboard.Show();
            UcPanelDisk.Hide();
            UcPanelPcRaring.Hide();
        }

        private void btDashboard_Click(object sender, EventArgs e)
        {
            lbPanelName.Text = btDashboard.Text;

            logger.Trace("Click dashboard");

            UcPanelDashboard.Show();
            UcPanelPcRaring.Hide();
            UcPanelDisk.Hide();
        } 

        private void btDisk_Click(object sender, EventArgs e)
        {
            lbPanelName.Text = btDisks.Text;
            logger.Trace("Click  Disk");
            UcPanelDisk.Show();
            UcPanelPcRaring.Hide();
            UcPanelDashboard.Hide();
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            logger.Trace("----- Exit -----");
            Application.Exit();
        }

        private void lbMinimaize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            logger.Trace("Minimaze");
        }

        private void btPcRating_Click(object sender, EventArgs e)
        {
            lbPanelName.Text = btDashboard.Text;
            logger.Trace("Click Pc Rating ");
            UcPanelPcRaring.Show();
            UcPanelDashboard.Hide();
            UcPanelDisk.Hide();
        }
    }
}
