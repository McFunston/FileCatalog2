using System;

namespace FileCatalog.Repositories
{
    public interface IRepository
    {
        void Save();
        void Load();
        void Search(string searchString);
    }
}