using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCatalog.Biz
{
    public static class FileListFactory
    {
        public static List<File> GetFileListFromPath(string path)
        {
            var folder = new DirectoryInfo(path);
            var fileList = new List<File>();
            foreach (var fi in folder.EnumerateFiles())
            {
                var tempFile = new File(fi.Name, fi.CreationTime, fi.FullName.Substring(2), fi.Length);
                fileList.Add(tempFile);
            }
            return fileList;
        }
    }
}
