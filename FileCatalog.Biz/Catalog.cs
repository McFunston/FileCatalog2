using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCatalog.Biz
{
    public class Catalog
    {
        public Dictionary<Archive, ICollection<IFile>> FileSet { get; set; }
        public Catalog(Archive archive, List<IFile> files)
        {
            FileSet.Add(archive, files);
        }
        public Catalog()
        {
                
        }
    }
}
