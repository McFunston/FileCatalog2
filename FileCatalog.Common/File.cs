﻿using System;
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
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public string Path { get; set; }
        public long Size { get; set; }
        public string Extension { get; set; }
        public Archive archive { get; set; }
        /// <summary>
        /// File constructor
        /// </summary>
        /// <param name="name">File Name</param>
        /// <param name="dateCreated">File creation date</param>
        /// <param name="path">Full path</param>
        /// <param name="size">File size</param>
        public File(string name, DateTime dateCreated, string path, long size, string extension)
        {
            Name = name;
            DateCreated = dateCreated;
            Path = path;
            Size = size;
            Extension = extension;
        }

        /// <summary>
        /// ToString override for unit tests
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Name: {Name} Date Created: {DateCreated} Path: {Path} Size: {Size}";
        }
    }
}
