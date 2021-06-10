using AsiaQuest.BusinessObjects.Asssets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AsiaQuest.DataAccessLayer.EntityConfigurations
{
    public class AssetCategoryEntityConfiguration : IEntityTypeConfiguration<AssetCategory>
    {
        public void Configure(EntityTypeBuilder<AssetCategory> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Name).HasMaxLength(200).IsRequired().IsUnicode(false);
            entity.HasMany(c => c.Assets).WithOne(c => c.AssetCategory).HasForeignKey(c => c.AssetCategoryId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
