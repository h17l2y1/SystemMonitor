using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adai46
{
    class SystemInfo : SeacherInfo {

        private const String from = "Win32_ComputerSystem";
        private String _domain;
        private String _pcName;
        private String _userName;
        private String _matherBoard;

        public SystemInfo() {
            this._domain = seacher(from, "Domain");
            this._pcName = seacher(from, "Caption");
            this._userName = seacher(from, "PrimaryOwnerName");
            this._matherBoard = seacher(from, "Manufacturer");
        }

        public string Domain { get => _domain; private set => _domain = value; }
        public string PcName { get => _pcName; private set => _pcName = value; }
        public string UserName { get => _userName; private set => _userName = value; }
        public string MatherBoard { get => _matherBoard; private set => _matherBoard = value; }

        //public string Domain { get { return this._domain; } }
        //public string PcName { get { return this._pcName; } }
        //public string UserName { get { return this._userName; } }
        //public string MatherBoard { get { return this._matherBoard; } }


    }
}
