using FileCatalog.Biz;
using System;

namespace FileCatalog.Repositories
{
    public interface IRepository
    {
        void Save(Catalog catalog);
        Catalog Load();
        void Search(string searchString);
    }
}