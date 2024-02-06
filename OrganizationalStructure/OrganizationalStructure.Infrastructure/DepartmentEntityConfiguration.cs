using OrganizationalStructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OrganizationalStructure.Infrastructure
{
    public class DepartmentEntityConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.ToTable("department");
            builder.HasKey(emp => emp.Id);
            builder.Property(emp => emp.Id)
                    .IsRequired();
            builder.Property(emp => emp.DepartmentName)
                    .HasColumnName("department_name")
                    .HasMaxLength(10)
                    .IsRequired();

            builder.Property(emp => emp.ManagingDepartmentId)
                    .HasColumnName("managing_dept_id");
            builder.HasOne(d => d.ManagingDepartment)
            .WithMany()
            .HasForeignKey(d => d.ManagingDepartmentId)
            .OnDelete(DeleteBehavior.Restrict);




        }
    }
}
