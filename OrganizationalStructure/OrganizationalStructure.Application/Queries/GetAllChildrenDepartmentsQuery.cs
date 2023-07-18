using MediatR;
using OrganizationalStructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationalStructure.Application.Queries
{
    public class GetAllChildrenDepartmentsQuery:IRequest<List<Department>>
    {
        public int Id { get; set; }
    }
}
