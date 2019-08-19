using Microsoft.EntityFrameworkCore;

namespace NameApi.Models
{
    public class NameContext : DbContext
    {
        public NameContext(DbContextOptions<NameContext> options)
            : base(options)
        {
        }

        public DbSet<NameItem> NameItems { get; set; }
    }
}