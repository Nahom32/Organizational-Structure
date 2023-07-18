using OrganizationalStructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationalStructure.Application
{
    public interface IDataRepository
    {
        public Task<Department> CreateDepartment(Department department);
        public Task<Department> UpdateDepartment(Department department);
        public Task<List<Department>> GetAllDepartments();
        public Task<Department> GetDepartmentById(int id);
        public Task<Department> DeleteDepartment(int id);

    }
}
