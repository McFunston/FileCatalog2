using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCatalog.Biz
{
    public interface IFileList : IEnumerable
    {
        int Length { get; } 
        List<IFile> ListofFiles { get; set; }
    }
}
