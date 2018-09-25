using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adai46
{
    class OperatingSystem : SeacherInfo
    {
        private const String from = "Win32_OperatingSystem";

        private String _os;
        private int _FreePhysicalMemory;
        private int _FreeSpaceInPagingFiles;
        private int _FreeVirtualMemory;
        private String _Manufacturer;
        private String _OSArchitecture;
        private String _RegisteredUser;
        private int _TotalVirtualMemorySize;
        private int _TotalRamMemory;
        private String _Version;
        private int _freeRamMemoryPersont;
        private int _usedRamMemoryPersont;
        private int _useRamMemory;

        public OperatingSystem()
        {
            _os = seacher(from, "Caption");
            _FreePhysicalMemory = baytToMbayts(seacher(from, "FreePhysicalMemory"));
            _FreeSpaceInPagingFiles = baytToMbayts(seacher(from, "FreeSpaceInPagingFiles"));
            _FreeVirtualMemory = baytToMbayts(seacher(from, "FreeVirtualMemory"));
            _Manufacturer = seacher(from, "Manufacturer");
            _OSArchitecture = seacher(from, "OSArchitecture");
            _RegisteredUser = seacher(from, "RegisteredUser");
            _TotalVirtualMemorySize = baytToMbayts(seacher(from, "TotalVirtualMemorySize"));
            _TotalRamMemory = baytToMbayts(seacher(from, "TotalVisibleMemorySize"));
            _Version = seacher(from, "Version");
            _freeRamMemoryPersont = freeMemoryInPersont();
            _usedRamMemoryPersont = usedRamMemoryInPersont();
            _useRamMemory = freeMemory();
        }

        public string Caption { get => _os; set => _os = value; }
        public int FreePhysicalMemory { get => _FreePhysicalMemory; set => _FreePhysicalMemory = value; }
        public int FreeSpaceInPagingFiles { get => _FreeSpaceInPagingFiles; set => _FreeSpaceInPagingFiles = value; }
        public int FreeVirtualMemory { get => _FreeVirtualMemory; set => _FreeVirtualMemory = value; }
        public string Manufacturer { get => _Manufacturer; set => _Manufacturer = value; }
        public string OSArchitecture { get => _OSArchitecture; set => _OSArchitecture = value; }
        public string RegisteredUser { get => _RegisteredUser; set => _RegisteredUser = value; }
        public int TotalVirtualMemorySize { get => _TotalVirtualMemorySize; set => _TotalVirtualMemorySize = value; }
        public int TotalVisibleMemorySize { get => _TotalRamMemory; set => _TotalRamMemory = value; }
        public string Version { get => _Version; set => _Version = value; }
        public int UsedRamMemoryPersont { get => _freeRamMemoryPersont; set => _freeRamMemoryPersont = value; }
        public int UseRamMemory { get => _useRamMemory; set => _useRamMemory = value; }
        public int freeMemoryPersont { get => _usedRamMemoryPersont; set => _usedRamMemoryPersont = value; }
        
        private int baytToMbayts(String bayts){
            return Convert.ToInt32(bayts) / 1024;
        }

        private int freeMemoryInPersont(){
            return (TotalVisibleMemorySize - FreePhysicalMemory) / (TotalVisibleMemorySize / 100);
        }

        private int freeMemory(){
            return TotalVisibleMemorySize - FreePhysicalMemory;
        }

        private int usedRamMemoryInPersont(){
            return 100 - freeMemoryPersont;
        }

    }
}
