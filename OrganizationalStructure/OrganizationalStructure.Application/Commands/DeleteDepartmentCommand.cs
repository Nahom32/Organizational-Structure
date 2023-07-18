using MediatR;
using OrganizationalStructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationalStructure.Application.Commands
{
    public class DeleteDepartmentCommand:IRequest<Department>
    {
        public int Id { get; set; }
    }
}
