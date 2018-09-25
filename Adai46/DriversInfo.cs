using System;
using System.IO;

namespace Adai46
{
    class DriversInfo
    {
        DriveInfo[] myDrives = DriveInfo.GetDrives();

        private static int _DiskPart;
        private String _Name;
        private String _TotalMemory;
        private String _FreeMemory;
        private String _UsedMemory;

        public DriversInfo(int diskNumber)
        {
            _DiskPart = diskNumber;
            _Name = name();
            _TotalMemory = Convert.ToString(baytToMbayts(totalSize()));
            _FreeMemory = Convert.ToString(baytToMbayts(freeSize()));
            _UsedMemory = Convert.ToString(baytToMbayts(usedSize()));
        }

        public string Name { get => _Name; set => _Name = value; }
        public string TotalSize { get => _TotalMemory; set => _TotalMemory = value; }
        public string FreeSize { get => _FreeMemory; set => _FreeMemory = value; }
        public string UsedMemory { get => _UsedMemory; set => _UsedMemory = value; }

        private String name()
        {
            return Convert.ToString((myDrives[_DiskPart]));
        }

        private long totalSize()
        {
            return myDrives[_DiskPart].TotalSize;
        }

        private long freeSize()
        {
            return myDrives[_DiskPart].TotalFreeSpace;
        }

        private long usedSize()
        {
            return totalSize() - freeSize();
        }

        private int baytToMbayts(long bayts)
        {
            return Convert.ToInt32(bayts / 1024 / 1024);
        }
    }
}
