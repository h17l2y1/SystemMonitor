using System;
using System.Diagnostics;

namespace Adai46 {
    class CpuInfo : SeacherInfo
    {
        private const String from = "Win32_Processor";
        private String _Caption;
        private String _NumberOfLogicalProcessors;
        private String _LoadPercentage;
        private String _CurrentClockSpeed;
        private String _MaxClockSpeed;

        public CpuInfo()
        {
            _Caption = seacher(from, "Name");
            _NumberOfLogicalProcessors = seacher(from, "NumberOfLogicalProcessors");
            _LoadPercentage = seacher(from, "LoadPercentage");
            _CurrentClockSpeed = seacher(from, "CurrentClockSpeed");
            _MaxClockSpeed = seacher(from, "MaxClockSpeed");
        }

        public string Caption { get => _Caption; set => _Caption = value; }
        public string NumberOfLogicalProcessors { get => _NumberOfLogicalProcessors; set => _NumberOfLogicalProcessors = value; }
        public string LoadPercentage { get => _LoadPercentage; set => _LoadPercentage = value; }
        public string CurrentClockSpeed { get => _CurrentClockSpeed; set => _CurrentClockSpeed = value; }
        public string MaxClockSpeed { get => _MaxClockSpeed; set => _MaxClockSpeed = value; }

    }
}
