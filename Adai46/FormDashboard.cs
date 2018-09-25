using System;
using System.Collections;
using System.Windows.Forms;

namespace Adai46
{
    public partial class FormDashboard : Form
    {

        int val,val2,val3,val4;

        NetworkInfo network = new NetworkInfo();
        OperatingSystem os = new OperatingSystem();
        SystemInfo system = new SystemInfo();
        GpuInfo gpu = new GpuInfo();
        RomInfo rom = new RomInfo();
        SeacherInfo searcher = new SeacherInfo();

        //CpuInfo cpu = new CpuInfo();

        FormDisks formDisks = new FormDisks();

        public FormDashboard()
        {
            InitializeComponent();
            WriteInfo();
            StartTimers();
        }

        private int UsedRomPersent(ArrayList drives)
        {
            long countTotalMem = 0;
            long countFreeMem = 0;
            foreach (RomInfo drive in drives)
            {
                countTotalMem += countTotalMem + drive.TotalSize;
                countFreeMem += countFreeMem + drive.FreeSpace;
            }
            return Convert.ToInt32(100 - (countFreeMem / (countTotalMem / 100)));

        }

        private void StartTimers()
        {
            timerForProgressBar.Start();
            timerForProgressBar2.Start();
            timerForProgressBar3.Start();
            timerForProgressBar4.Start();
        }

        private void WriteInfo()
        {
            UserInfo();
            WriteRamInfo();
            Nerwork();
            CompInfo();
        }

        // need activated CPU Name
        private void CompInfo()
        {
            //lbCpuName.Text = cpu.Caption + "  "+ cpu.MaxClockSpeed;
            lbGpuName.Text = gpu.Name+"   "+ Convert.ToInt32(gpu.Memory) / 1000 +" GB";
            lbmatherboardName.Text = system.MatherBoard;
            lbResolution.Text = Screen.PrimaryScreen.Bounds.Width.ToString() + "x" +
                                Screen.PrimaryScreen.Bounds.Height.ToString();
        }

        private void WriteRamInfo()
        {
            lbPersentUsedRam.Text = "RAM: " + Convert.ToString(os.UsedRamMemoryPersont) + " %";
            lbRamUsed.Text = Convert.ToString(os.UseRamMemory) + "/" + Convert.ToString(os.TotalVisibleMemorySize) + " MB";
            progressBarLineRam.Value = os.UsedRamMemoryPersont;
        }

        private void Nerwork()
        {
            lbIpAdress.Text = network.IpAdress;
            lbCheckNetConn.Text = network.CheckInternetConnection();
        }

        private void UserInfo()
        {
            lbUserName.Text = system.UserName;
            lbPcName.Text = system.PcName;
            lbOsVersion.Text = os.Caption;
        }

        // Attention VELOSIPED 18+ !!!!!!!!!

        private void timerForProgressBar_Tick(object sender, EventArgs e)
        {
            val += 1;
            progressBarCircleRam.Value = val;
            if (progressBarCircleRam.Value == os.UsedRamMemoryPersont)
            {
                timerForProgressBar.Stop();
            }
        }

        // chenge VALUE from 6 to Convert.ToInt32(cpu.LoadPercentage)
        private void timerForProgressBar2_Tick(object sender, EventArgs e)
        {
            val2 += 1;
            progressBarCircleCpu.Value = val2;
            if (progressBarCircleCpu.Value == /*Convert.ToInt32(cpu.LoadPercentage)*/ 6)
            {
                timerForProgressBar2.Stop();
            }
        }

        private void timerForProgressBar3_Tick(object sender, EventArgs e)
        {
            val3 += 1;
            progressBarCircleRom.Value = val3;
            if (progressBarCircleRom.Value == UsedRomPersent(searcher.getrDrives()))
            {
                timerForProgressBar3.Stop();
            }
        }

        private void timerForProgressBar4_Tick(object sender, EventArgs e)
        {
            val4 += 1;
            progressBarCircleGpu.Value = val4;
            if (progressBarCircleGpu.Value == 22)
            {
                timerForProgressBar4.Stop();
            }
        }


    }
}
