
using System;

namespace Adai46
{
    class TotalRating
    {
        private string _cpuRating;
        private string _gpuRating;
        private string _ramRating;

        private const string NON = "NON";
        private const string VERYLOW = "verylow";
        private const string LOW = "low";
        private const string MID = "middle";
        private const string TOP = "top";

        public string CpuRating { get => _cpuRating; private set => _cpuRating = value; }
        public string GpuRating { get => _gpuRating; private set => _gpuRating = value; }
        public string RamRating { get => _ramRating; private set => _ramRating = value; }

        public TotalRating()
        {
            _cpuRating = CpuEvaluation();
            _gpuRating = GpuEvaluation();
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
            var gpuRating = new GpuRating();
            long gpuPerfomance = gpuRating.GetGpuRating();
            if (gpuPerfomance < 20000)
                return VERYLOW;
            else if (gpuPerfomance > 20001 && gpuPerfomance < 100000)
                return LOW;
            else if (gpuPerfomance > 100001 && gpuPerfomance < 1000000)
                return MID;
            else
                return TOP;
        }

        private string CpuEvaluation()
        {
            var cpuRating = new CpuRating();
            double cpuPerfomance = cpuRating.GetCpuRating();
            if (cpuPerfomance < 14.500)
                return LOW;
            else if (cpuPerfomance > 14.501 && cpuPerfomance < 30.000)
                return MID;
            else
                return TOP;
        }



        
    }
}
