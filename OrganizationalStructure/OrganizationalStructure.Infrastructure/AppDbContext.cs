using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OrganizationalStructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationalStructure.Infrastructure
{
     public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
            .HasKey(d => d.Id);

            // Specify the relationship between Department and ManagingDepartment
            modelBuilder.Entity<Department>()
                .HasOne(d => d.ManagingDepartment) // A Department can have one ManagingDepartment
                .WithMany() // A Department can manage multiple other Departments
                .HasForeignKey(d => d.ManagingDepartmentId) // The foreign key to store the ManagingDepartmentId
                .OnDelete(DeleteBehavior.Restrict);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Department> Departments { get; set; }
    }
}
