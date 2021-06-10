using AsiaQuest.BusinessObjects.Asssets;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsiaQuest.DataAccessLayer.EntityConfigurations
{
    public class AssetEntityConfiguration : IEntityTypeConfiguration<Asset>
    {
        public void Configure(EntityTypeBuilder<Asset> builder)
        {

        }
    }
}
