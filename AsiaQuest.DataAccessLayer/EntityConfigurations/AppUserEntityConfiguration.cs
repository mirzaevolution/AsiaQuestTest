using AsiaQuest.BusinessObjects.Identities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AsiaQuest.DataAccessLayer.EntityConfigurations
{
    public class AppUserEntityConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> entity)
        {
            entity.Property(c => c.FullName).IsRequired().HasMaxLength(250).IsUnicode(false);
        }
    }
}
