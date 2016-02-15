using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCatalog.Biz
{
    interface IFile
    {
        string Name { get;}
        DateTime DateCreated { get;}
        string Path { get; }
        long Size { get;}
    }
}
