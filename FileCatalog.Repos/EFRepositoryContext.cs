using FileCatalog.Biz;
using System.Data.Entity;

namespace FileCatalog.Repositories
{
    class EFRepositoryContext: DbContext
    {
        public EFRepositoryContext(): base()
        {

        }

        public DbSet<Catalog> Catalogs { get; set; }
    }
}
