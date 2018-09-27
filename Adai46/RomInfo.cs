using System;
using System.IO;

namespace Adai46
{
    class RomInfo : SeacherInfo {

        private String _nameOfParts;
        private String _fileSystem;
        private long _FreeSpace;
        private string _name;
        private long _size;

        public string Name { get => _name; set => _name = value; }
        public string NameOfParts { get => _nameOfParts; set => _nameOfParts = value; }
        public string FileSystem { get => _fileSystem; set => _fileSystem = value; }
        public long FreeSpace { get => _FreeSpace; set => _FreeSpace = value; }
        public long TotalSize { get => _size; set => _size = value; }
   
    }
}
