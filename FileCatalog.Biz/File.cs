using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCatalog.Biz
{
    /// <summary>
    /// Basic file type. Has a name, a creation date, a path, and a size.
    /// </summary>

    public class File : IFile
    {
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public string Path { get; set; }
        public long Size { get; set; }

        /// <summary>
        /// File constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dateCreated"></param>
        /// <param name="path"></param>
        /// <param name="size"></param>
        public File(string name, DateTime dateCreated, string path, long size)
        {
            Name = name;
            DateCreated = dateCreated;
            Path = path;
            Size = size;
        }

        public override string ToString()
        {
            return $"Name: {Name} Date Created: {DateCreated} Path: {Path} Size: {Size}";
        }
    }
}
