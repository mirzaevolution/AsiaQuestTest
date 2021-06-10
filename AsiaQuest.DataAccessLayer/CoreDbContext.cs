using Microsoft.EntityFrameworkCore;
using AsiaQuest.BusinessObjects.Asssets;
using AsiaQuest.BusinessObjects.Identities;
using AsiaQuest.BusinessObjects.Masters;
using AsiaQuest.DataAccessLayer.EntityConfigurations;

namespace AsiaQuest.DataAccessLayer
{
    public class CoreDbContext : DbContext
    {
        public CoreDbContext(DbContextOptions<CoreDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AppUserEntityConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentEntityConfiguration());
            modelBuilder.ApplyConfiguration(new AssetCategoryEntityConfiguration());
            modelBuilder.ApplyConfiguration(new AssetEntityConfiguration());
        }
        public virtual DbSet<AppUser> AppUsers { get; set; }
        public virtual DbSet<AppRole> AppRoles { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Asset> Assets { get; set; }
        public virtual DbSet<AssetCategory> AssetCategories { get; set; }
    }
}
