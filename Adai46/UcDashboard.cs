using System;
using System.Windows.Forms;
using System.Collections;

namespace Adai46
{
    public partial class UcDashboard : UserControl
    {
        int val = 0;
        NetworkInfo network = new NetworkInfo();
        OperatingSystem os = new OperatingSystem();
        SystemInfo system = new SystemInfo();
        GpuInfo gpu = new GpuInfo();
        RomInfo rom = new RomInfo();
        SeacherInfo searcher = new SeacherInfo();

        //CpuInfo cpu = new CpuInfo();

        public UcDashboard()
        {
            InitializeComponent();
            WriteInfo();
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

        private void WriteInfo()
        {
            UserInfo();
            RamInfo();
            Nerwork();
            CompInfo();
        }

        // need activated CPU Name in release version
        private void CompInfo()
        {
            //lbCpuName.Text = cpu.Caption + "  "+ cpu.MaxClockSpeed;
            lbGpuName.Text = gpu.Name + "   " + Convert.ToInt32(gpu.Memory) / 1000 + " GB";
            lbmatherboardName.Text = system.MatherBoard;
            lbResolution.Text = Screen.PrimaryScreen.Bounds.Width.ToString() + "x" +
                                Screen.PrimaryScreen.Bounds.Height.ToString();
        }

        private void RamInfo()
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

        private void timer_Tick(object sender, EventArgs e)
        {
            float fcpu = pcCpu.NextValue();
            float fram = pcRam.NextValue();

            progressBarCircleCpu.Value = (int)fcpu;
            progressBarCircleRam.Value = (int)fram;

        }

        private void timerForStaticPersent_Tick(object sender, EventArgs e)
        {
            val += 1;
            progressBarCircleRom.Value = val;
            progressBarCircleGpu.Value = 20;
            if (progressBarCircleRom.Value == UsedRomPersent(searcher.getDrives()))
            {
                timerForStaticPersent.Stop();
            }
        }


    }
}
