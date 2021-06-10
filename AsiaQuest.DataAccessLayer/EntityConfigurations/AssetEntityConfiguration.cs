using AsiaQuest.BusinessObjects.Asssets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AsiaQuest.DataAccessLayer.EntityConfigurations
{
    public class AssetEntityConfiguration : IEntityTypeConfiguration<Asset>
    {
        public void Configure(EntityTypeBuilder<Asset> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.AssetCode).IsRequired().IsUnicode(false).HasMaxLength(100);
            entity.Property(c => c.AssetName).IsRequired().IsUnicode(false).HasMaxLength(250);
            entity.Property(c => c.AssetCategoryId).IsRequired();
            entity.Property(c => c.DepartmentId).IsRequired();
            entity.Property(c => c.PurchaseDate).IsRequired();
            entity.Property(c => c.Price).IsRequired();
            entity.Property(c => c.SupplierName).HasMaxLength(250).IsRequired();
        }
    }
}
