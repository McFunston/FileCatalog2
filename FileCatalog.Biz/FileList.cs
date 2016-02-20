﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCatalog.Biz
{
    /// <summary>
    /// A simple list of type IFile
    /// </summary>
    public class FileList : IFileList
    {
        public List<IFile> ListofFiles { get; set; }
        
        public FileList()
        {
            ListofFiles = new List<IFile>();
        }
    }
}
