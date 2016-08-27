using FileCatalog.Biz;
using System.Data.Entity;

namespace FileCatalog.Repositories
{
    public class EFRepositoryContext: DbContext
    {
        public EFRepositoryContext(): base()
        {
            
        }

        public DbSet<File> Files { get; set; }
        public DbSet<Archive> Archives { get; set; }
        
        //public DbSet<Catalog> Catalogs { get; set; }
        
    }
}
