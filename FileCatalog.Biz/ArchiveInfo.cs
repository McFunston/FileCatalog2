using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCatalog.Biz
{
    class ArchiveInfo
    {
        public string Name { get; set; }
        public DriveType DriveType { get; set; }
        public string Label { get; set; }

        public ArchiveInfo(string name, DriveType driveType, string label)
        {
            Name = name;
            DriveType = driveType;
            Label = label;
        }
    }
}
