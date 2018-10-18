using System;
using System.IO;


namespace Adai46
{
    class CpuRating 
    {
        private static string PATH_TO_FILE = "CPULibr.txt";
        private string[,] CpuMass;
        private string cpuCaption;

        private int cpuParamCount = 2;
        private int cpuCount = File.ReadAllLines(PATH_TO_FILE).Length;

        //CpuInfo cpu = new CpuInfo();
        
        public CpuRating()
        {
            //cpuCaption = cpu.Name;
            cpuCaption = "Intel(R) Core(TM) i7-4790K CPU @ 4.00GHz";
            Creater();
        }

        private void Creater()
        {
            CpuMass = new string[cpuCount, cpuParamCount];
            string[] Mass2 = File.ReadAllLines(PATH_TO_FILE, System.Text.Encoding.Default);

            // запись в массив глоб массив
            for (int i = 0; i < cpuCount; i++)
            {
                string str = Mass2[i];
                string[] words = str.Split(new char[] { '\t' });
                for (int j = 0; j < cpuParamCount; j++)
                {
                    CpuMass[i, j] = words[j];
                }
            }
        }

        private int IsHaveThisCpu()
        {
            for (int i = 0; i < CpuMass.Length / 2; i++)
            {
                if (CpuMass[i, 0].TrimEnd(' ') == cpuCaption.TrimEnd(' '))
                {
                    return i;
                }
            }
            return -1;
        }

        private double CheckInRatingCpu()
        {
            if (IsHaveThisCpu() >= 0)
            {
                return Convert.ToDouble(CpuMass[IsHaveThisCpu(), 1]);
            }
            return 0;
        }

        public double GetCpuRating()
        {
            return CheckInRatingCpu();
        }
    }
}
