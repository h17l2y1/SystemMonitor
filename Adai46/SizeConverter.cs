using System;


namespace Adai46
{
    class SizeConverter
    {
        public int byteToGByte(long bytes)
        {
            long longGByte = bytes / 1048576000;
            return Convert.ToInt32(longGByte);
        }

        public int byteToMByte(long bayt)
        {
            long longGBayt = bayt / 1048576;
            return Convert.ToInt32(longGBayt);
        }

        public int byteToMBytes(string bytes)
        {
            return Convert.ToInt32(bytes) / 1024;
        }
    }
}
