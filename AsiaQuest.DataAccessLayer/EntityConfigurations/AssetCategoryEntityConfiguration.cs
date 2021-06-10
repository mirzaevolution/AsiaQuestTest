using AsiaQuest.BusinessObjects.Asssets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsiaQuest.DataAccessLayer.EntityConfigurations
{
    public class AssetCategoryEntityConfiguration : IEntityTypeConfiguration<AssetCategory>
    {
        public void Configure(EntityTypeBuilder<AssetCategory> builder)
        {
            throw new NotImplementedException();
        }
    }
}
