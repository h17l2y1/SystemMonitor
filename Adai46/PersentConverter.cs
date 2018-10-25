using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adai46
{
    class PersentConverter
    {
        public int freeMemoryInPersont(int totalSize, int freeSize)
        {
            return (totalSize - freeSize) / (totalSize / 100);
        }

        public int freeMemory(int totalSize, int freeSize)
        {
            return totalSize - freeSize;
        }

        public int usedRamMemoryInPersont(int totalSize, int freeSize)
        {
            return 100 - freeMemoryInPersont(totalSize, freeSize);
        }
    }
}
