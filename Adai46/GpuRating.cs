using System;
using System.IO;

namespace Adai46
{
    class GpuRating
    {
        private static string PATH_TO_FILE = "GPULibr.txt";
        private string[,] GpuMass;
        private string _gpuCaption;

        private int gpuParamCount = 2;
        private int gpuCount = File.ReadAllLines(PATH_TO_FILE).Length;

        GpuInfo gpu = new GpuInfo();

        public GpuRating()
        {
            _gpuCaption = gpu.Name;
            Creater();
        }

        private void Creater()
        {
            GpuMass = new string[gpuCount, gpuParamCount];
            string[] Mass2 = File.ReadAllLines(PATH_TO_FILE, System.Text.Encoding.Default);

            // запись в массив глоб массив
            for (int i = 0; i < gpuCount; i++)
            {
                string str = Mass2[i];
                string[] words = str.Split(new char[] { '\t' });
                for (int j = 0; j < gpuParamCount; j++)
                {
                    GpuMass[i, j] = words[j];
                }
            }
        }

        private int IsHaveThisGpu()
        {
            for (int i = 0; i < GpuMass.Length / 2; i++)
            {
                if (GpuMass[i, 0].TrimEnd(' ') == _gpuCaption.TrimEnd(' '))
                {
                    return i;
                }
            }
            return -1;
        }

        private long CheckInRatingGpu()
        {
            if (IsHaveThisGpu() >= 0)
            {
                return Convert.ToInt32(GpuMass[IsHaveThisGpu(), 1]);
            }
            return 0;
        }

        public long GetGpuRating()
        {
            return CheckInRatingGpu();
        }
    }
}
