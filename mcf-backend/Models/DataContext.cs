using Microsoft.EntityFrameworkCore;

namespace mcf_backend.Models
{
    public class DataContext : DbContext
        
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        public DbSet<MsStorageLocation> StorageLocations { get; set; }
        public DbSet<TrBpkb> BPKBs { get; set; }

    }
}
