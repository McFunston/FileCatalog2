using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCatalog.Biz
{
    public class FileList : IFileList
    {
        public int Length { get { return ListofFiles.Count; } }
        public List<IFile> ListofFiles { get; set; }
        
        public FileList()
        {
            ListofFiles = new List<IFile>();
        }
    }
}
