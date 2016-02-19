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
        public async static Task<FileList> GetFileListFromPath(string path)
        {
            try
            {
                var GetFileListTask = Task.Run(() =>
                 {
                     var folder = new DirectoryInfo(@path);
                     FileList fileList = new FileList();

                     foreach (var fi in folder.EnumerateFiles())
                     {
                         var tempFile = new File(fi.Name, fi.CreationTime, fi.FullName.Substring(2), fi.Length);
                         fileList.ListofFiles.Add(tempFile);
                     }
                     return fileList;
                 });
                await (GetFileListTask);
                return GetFileListTask.Result;
            }
            catch (Exception)
            {
                return null;
            }

        }
    }
}
