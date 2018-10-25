using NLog;
using System;

namespace Adai46 {
    class CpuInfo : SeacherInfo
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        private const String from = "Win32_Processor";
        private String _name;
        //private String _NumberOfLogicalProcessors;
        //private String _LoadPercentage;
        //private String _CurrentClockSpeed;
        private String _MaxClockSpeed;

        public CpuInfo()
        {
            _name = seacher(from, "Name");
            //_NumberOfLogicalProcessors = seacher(from, "NumberOfLogicalProcessors");
            //_LoadPercentage = seacher(from, "LoadPercentage");
            //_CurrentClockSpeed = seacher(from, "CurrentClockSpeed");
            _MaxClockSpeed = seacher(from, "MaxClockSpeed");
            logger.Debug("Scaning CPU");
        }

        public string Name { get => _name; }
        //public string NumberOfLogicalProcessors { get => _NumberOfLogicalProcessors; set => _NumberOfLogicalProcessors = value; }
        //public string LoadPercentage { get => _LoadPercentage; set => _LoadPercentage = value; }
        //public string CurrentClockSpeed { get => _CurrentClockSpeed; set => _CurrentClockSpeed = value; }
        public string MaxClockSpeed { get => _MaxClockSpeed; set => _MaxClockSpeed = value; }

    }
}
