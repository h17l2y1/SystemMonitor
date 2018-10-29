using System;
using NLog;

namespace Adai46
{
    class TotalRating
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        private const string NON = "NON";
        private const string VERYLOW = "verylow";
        private const string LOW = "low";
        private const string MID = "middle";
        private const string TOP = "top";


        public string GpuRating { get => GpuEvaluation(); } 
        public string CpuRating { get => CpuEvaluation(); }
        public string RamRating { get => RamEvaluation(); }


        // 3 метода по получению оценки компа 

        private string GpuEvaluation()
        {
            logger.Debug("Add all GPU to databse");
            string gpuName = new GpuInfo().Name;

            var Rating = new Rating("GPULibr.txt", gpuName);
            long Perfomance = Convert.ToInt64(Rating.GetRating());

            if (Perfomance == 0)
            {
                logger.Warn("GPU rating not searched");
                return NON;
            }
            else if (Perfomance < 20000)
            {
                logger.Debug("GPU rating searched: " + gpuName);
                return LOW;
            }
            else if (Perfomance > 20001 && Perfomance < 100000) {
                logger.Debug("GPU rating searched: " + gpuName);
                return VERYLOW;
                }
            else if (Perfomance > 100001 && Perfomance < 1000000)
            {
                logger.Debug("GPU rating searched: " + gpuName);
                return MID;
            }
            else
            {
                logger.Debug("GPU rating searched: " + gpuName);
                return TOP;
            }
        }

        private string CpuEvaluation()
        {
            logger.Debug("Add all CPU to databse");
            string cpuName = new CpuInfo().Name;

            var Rating = new Rating("CPULibr.txt", cpuName);
            double Perfomance = Rating.GetRating();

            if (Perfomance == 0)
            {
                logger.Warn("CPU rating no searched");
                return NON;
            }
            else if (Perfomance < 14.500)
            {
                logger.Debug("CPU rating searched: "+ cpuName);
                return LOW;
            }
            else if (Perfomance > 14.501 && Perfomance < 30.000)
            {
                logger.Debug("CPU rating searched: " + cpuName);
                return MID;
            }
            else
            {
                logger.Debug("CPU rating searched: " + cpuName);
                return TOP;
            }

        }

        private string RamEvaluation()
        {
            logger.Debug("Scanning RAM");
            var totalRam = new OperatingSystem().TotalVisibleMemorySize;

            if (totalRam < 3900)
                return LOW;
            else if (totalRam > 3901 && totalRam < 4200)
                return MID;
            else
                return TOP;
        }

    }
}
