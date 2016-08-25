﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileCatalog.Biz;

namespace FileCatalog.Repositories
{
    public class EFRepository : IRepository
    {
        EFRepositoryContext EFR = new EFRepositoryContext();

        public Catalog Load()
        {
            throw new NotImplementedException();
        }

        public void Save(Catalog catalog)
        {
            EFR.Catalogs.Add(catalog);
            EFR.SaveChanges();
        }

        public void Search(string searchString)
        {
            throw new NotImplementedException();
        }
    }
}
