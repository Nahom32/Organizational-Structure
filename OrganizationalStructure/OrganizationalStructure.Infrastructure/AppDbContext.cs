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
           
            modelBuilder.ApplyConfiguration(new DepartmentEntityConfiguration());
        }
        public DbSet<Department> Departments { get; set; }
    }
}
