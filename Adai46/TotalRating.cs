
using System;

namespace Adai46
{
    class TotalRating
    {
        private string _cpuRating;
        private string _gpuRating;
        private string _ramRating;
        private readonly string _cpuName;
        private readonly string _gpuName;

        private const string NON = "NON";
        private const string VERYLOW = "verylow";
        private const string LOW = "low";
        private const string MID = "middle";
        private const string TOP = "top";

        public string CpuRating { get => _cpuRating; private set => _cpuRating = value; }
        public string GpuRating { get => _gpuRating; private set => _gpuRating = value; }
        public string RamRating { get => _ramRating; private set => _ramRating = value; }

        //CpuInfo cpu = new CpuInfo();
        GpuInfo gpu = new GpuInfo();

        public TotalRating()
        {
            _cpuName = "AMD FX(tm)-8300 Eight-Core Processor";
            _gpuName = gpu.Name;
            _gpuRating = GpuEvaluation();
            _cpuRating = CpuEvaluation();
            _ramRating = RamEvaluation();
        }

        private string RamEvaluation()
        {
            var os = new OperatingSystem();
            var totalRam = os.TotalVisibleMemorySize;
            if (totalRam < 3900)
                return LOW;
            else if (totalRam > 3901 && totalRam < 4200)
                return MID;
            else
                return TOP;
        }

        private string GpuEvaluation()
        {
            var Rating = new Rating("GPULibr.txt", _gpuName);
            long Perfomance = Convert.ToInt64(Rating.GetRating());
            if (Perfomance == 0)
                return NON;
            else if (Perfomance < 20000)
                return LOW;
            else if (Perfomance > 20001 && Perfomance < 100000)
                return VERYLOW;
            else if (Perfomance > 100001 && Perfomance < 1000000)
                return MID;
            else
                return TOP;
        }

        private string CpuEvaluation()
        {
            var Rating = new Rating("CPULibr.txt", _cpuName);
            double Perfomance = Rating.GetRating();
            if (Perfomance == 0)
                return NON;
            else if (Perfomance < 14.500)
                return LOW;
            else if (Perfomance > 14.501 && Perfomance < 30.000)
                return MID;
            else
                return TOP;
        }
        
    }
}
