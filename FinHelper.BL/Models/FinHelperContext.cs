using Microsoft.EntityFrameworkCore;

namespace FinHelper.BL.Models
{
    public class FinHelperContext : DbContext
    {
        public FinHelperContext(DbContextOptions<FinHelperContext> options) : base(options)
        {
        }

        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<GroupEntity> Groups { get; set; }
        public DbSet<OperationEntity> Operations { get; set; }

    }
}
