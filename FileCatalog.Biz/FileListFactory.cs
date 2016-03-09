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
        /// <summary>
        /// Returns a list of interface IFile. Since it's async it returns it as a Task
        /// </summary>
        /// <param name="path">The path that we want to get a file list from</param>
        /// <returns></returns>
        public async static Task<List<IFile>> GetFileListFromPathAsync(string path)
        {
            try
            {
                var GetFileListTask = Task.Run(() =>
                 {
                     var folder = new DirectoryInfo(@path);
                     var fileList = new List<IFile>();

                     foreach (var fi in folder.EnumerateFiles())
                     {
                         var tempFile = new File(fi.Name, fi.CreationTime, fi.FullName.Substring(2), fi.Length, fi.Extension);
                         fileList.Add(tempFile);
                     }
                     return fileList;
                 });
                
                return await GetFileListTask;
            }
            catch (Exception)
            {
                return null;
                throw;
            }

        }
        public static ArchiveInfo GetArchiveInfo(string archiveName, string path)
        {
            try
            {
                var drive = new DriveInfo(@path);
                var archiveInfo = new ArchiveInfo(archiveName, drive.DriveType, drive.VolumeLabel);
                return archiveInfo;
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
    }
}
