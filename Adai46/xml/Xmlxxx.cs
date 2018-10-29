using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Adai46.xml
{
    class Xmlxxx
    {
        private string _pathToXml = "xml";
        private string _fileName = "config.xml";
        private string _toFile;

        public void xCreate()
        {
            Directory.CreateDirectory(_pathToXml);
            if (!File.Exists(_pathToXml + "/" + _fileName))
                File.Create(_pathToXml + "/" + _fileName);
            _toFile = _pathToXml + "/" + _fileName;
        }

        public void xWrite(string UserName, string osName, string CpuName, string GpuName, string Resolution, int RamCount, string MatherboardName)
        {
            List<Parameters> config = new List<Parameters>();
            config.Add(new Parameters {
                UserName = UserName,
                Cpu = CpuName,
                Resolution = Resolution,
                Gpu = GpuName,
                Os = osName,
                Ram = RamCount,
                Matherboard = MatherboardName
            });

            XmlSerializer serial = new XmlSerializer(typeof(List<Parameters>));
            using (FileStream fs = new FileStream(Environment.CurrentDirectory +
                "//xml/config.xml", FileMode.Create, FileAccess.Write))
            {
                serial.Serialize(fs, config);
            }
        }


    }
}
