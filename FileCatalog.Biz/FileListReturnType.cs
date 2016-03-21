using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCatalog.Biz
{
    public class FileListReturnType
    {
        public bool Success { get; set; }
        public List<IFile> FileList { get; set; }
        public string ErrorMessage { get; set; }
    }
}
