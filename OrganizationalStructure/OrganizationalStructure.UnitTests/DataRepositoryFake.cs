using OrganizationalStructure.Application;
using OrganizationalStructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationalStructure.UnitTests
{
    public class DataRepositoryFake : IDataRepository
    {
        private readonly List<Department> departmentList;
        public DataRepositoryFake()
        {
            departmentList = new List<Department>()
            {
                new Department() {Id = 1, DepartmentName = "CEO", DepartmentDescription = "Chief Operating Officer" , ManagingDepartmentId = null},
                new Department() {Id = 2, DepartmentName = "CFO", DepartmentDescription= "Chief Financial Officer", ManagingDepartmentId= 1},
                new Department() {Id = 3, DepartmentName = "CTO", DepartmentDescription="Chief Technology Officer", ManagingDepartmentId = 1}
            };
        }
        public async Task<Department> CreateDepartment(Department department)
        {
            departmentList.Add(department);
            return department;
            
        }

        public async Task<Department> DeleteDepartment(int id)
        {
            var department = new Department();
            foreach(var dept in departmentList)
            {
                if(dept.Id == id)
                {
                    department = dept;
                    break;
                }
            }
            if(department.Id == id)
            {
                departmentList.Remove(department);
            }

            return department;
        }

        public async Task<List<Department>> GetAllDepartments()
        {
            return departmentList;
        }

        public async Task<Department> GetDepartmentById(int id)
        {
            foreach(var department in departmentList)
            {
                if(department.Id == id)
                {
                    return department;
                }
            }
            return new Department();
        }

        public async Task<Department> UpdateDepartment(Department department)
        {
            var deptIndex = departmentList.IndexOf(department);
            if(deptIndex != -1)
            {
                departmentList[deptIndex] = department;
            }
            return department;
        }
    }
}
