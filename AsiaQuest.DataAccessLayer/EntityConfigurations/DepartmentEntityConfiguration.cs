using AsiaQuest.BusinessObjects.Masters;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AsiaQuest.DataAccessLayer.EntityConfigurations
{
    public class DepartmentEntityConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Name).IsRequired().IsUnicode(false);
            entity.HasMany(c => c.Assets).WithOne(c => c.Department).HasForeignKey(c => c.DepartmentId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
