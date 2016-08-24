using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCatalog.Repositories
{
    class EFRepositoryContext: DbContext
    {
        public EFRepositoryContext(): base()
        {

        }

        //public DbSet<Catalog> Catalogs { get; set; }
    }
}
