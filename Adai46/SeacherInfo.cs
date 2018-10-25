using System;
using System.Management;
using System.Collections;

namespace Adai46
{
    class SeacherInfo {
        
        // Движок вытягивания данных из железа
        private String searchEngine(String from, String what) {
            ManagementClass obj = new ManagementClass(from);
            ManagementObjectCollection mcol = obj.GetInstances();
            string result = "";
            foreach (ManagementObject strt in mcol) {
                result += Convert.ToString(strt[what]).Trim();
            }
            return result;
        }

        public String seacher(String from, String what) {
            return searchEngine(from, what);
        }

        // Велосипед...
        // Даже не хочу комментировать
        public ArrayList getDrives(){
            ManagementClass obj = new ManagementClass("Win32_LogicalDisk");
            ManagementObjectCollection mcol = obj.GetInstances();

            ArrayList list = new ArrayList();
            int currentDisk = 0;
            foreach (ManagementObject strt in mcol)
            {
                list.Add(new RomInfo());
                ((RomInfo)list[currentDisk]).Name = Convert.ToString(strt["Name"]);
                ((RomInfo)list[currentDisk]).NameOfParts = Convert.ToString(strt["Caption"]);
                ((RomInfo)list[currentDisk]).FileSystem = Convert.ToString(strt["FileSystem"]);
                ((RomInfo)list[currentDisk]).FreeSpace = Convert.ToInt64(strt["FreeSpace"]);
                ((RomInfo)list[currentDisk]).TotalSize = Convert.ToInt64(strt["Size"]);
                currentDisk++;
            }
            return list;
        }

    }
}
