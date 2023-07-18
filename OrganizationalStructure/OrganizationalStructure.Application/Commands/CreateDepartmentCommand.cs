using MediatR;
using OrganizationalStructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationalStructure.Application.Commands
{
    public class CreateDepartmentCommand:IRequest<Department>
    {
       
        public string DepartmentName { get; set; }
        public string DepartmentDescription { get; set; }
        public int? ManagingDepartmentId { get; set; }
        public Department? ManagingDepartment { get; set; }
    }
}
