using MediatR;
using OrganizationalStructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationalStructure.Application.Queries
{
    public class GetDepartmentByIdQuery:IRequest<Department>
    {

    }
}
