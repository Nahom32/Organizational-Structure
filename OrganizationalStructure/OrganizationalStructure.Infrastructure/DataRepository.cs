using Microsoft.EntityFrameworkCore;
using OrganizationalStructure.Application;
using OrganizationalStructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationalStructure.Infrastructure
{
    public class DataRepository : IDataRepository
    {
        private readonly AppDbContext _context;
        public DataRepository(AppDbContext context)
        {
            _context = context; 
        }
        public async Task<Department> CreateDepartment(Department department)
        {
            await _context.Departments.AddAsync(department);
            await _context.SaveChangesAsync();
            return department;
        }

        public async Task<Department> DeleteDepartment(int id)
        {
            var department = await _context.Departments.FirstOrDefaultAsync(i => i.Id == id);
            if (department != null)
            {
                _context.Departments.Remove(department);
                await _context.SaveChangesAsync();
                return department;
            }
            else
            {
                return new Department
                {
                    Id = 0,
                    DepartmentName = "",
                    DepartmentDescription = "",
                };
            }
        }

        public async Task<List<Department>> GetAllDepartments()
        {
            return await _context.Departments.Include(x=>x.ManagingDepartment).ToListAsync();
        }

        public async Task<Department> GetDepartmentById(int id)
        {
            var department = await _context.Departments.Include(x=>x.ManagingDepartment).FirstOrDefaultAsync(i => i.Id == id);
            if (department != null)
            {
                return department;
            }
            else
            {
                return new Department
                {
                    Id = 0,
                    DepartmentName = "",
                    DepartmentDescription = "",
                };
            }
        }

        public async Task<Department> UpdateDepartment(Department department)
        {
            _context.Departments.Update(department);
            await _context.SaveChangesAsync();
            return department;
        }
    }
}
