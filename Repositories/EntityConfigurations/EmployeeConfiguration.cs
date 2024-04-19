using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EntityConfigurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.FullName).IsRequired();
            builder.Property(e => e.IsActive).IsRequired();
            builder.HasMany(e => e.Contracts)
                   .WithOne(c => c.Employee)
                   .HasForeignKey(c => c.EmployeeId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
