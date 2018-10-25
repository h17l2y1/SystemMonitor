using NLog;
using System;
using System.Diagnostics;

namespace Adai46
{

    class GpuInfo : SeacherInfo
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        private static String from = "Win32_VideoController";

        private String _memory;
        private String _name;

        public GpuInfo()
        {
            _memory = Convert.ToString(baytToMBytes(seacher(from, "AdapterRAM")));
            _name = seacher(from, "Caption");
            logger.Debug("Scaning GPU");
        }

        public string Memory { get => _memory; set => _memory = value; }
        public string Name { get => _name; set => _name = value; }

        private int baytToMBytes(String bayts){
            //long gpuBytes = Convert.ToInt64(bayts);
            //int a = Convert.ToInt32(gpuBytes / 1048576);
            int a = 2;
            return a;
        }
        



    }
}
