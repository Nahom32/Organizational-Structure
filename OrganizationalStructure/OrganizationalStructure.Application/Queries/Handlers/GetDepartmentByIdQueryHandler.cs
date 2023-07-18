using MediatR;
using OrganizationalStructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationalStructure.Application.Queries.Handlers
{
    public class GetDepartmentByIdQueryHandler : IRequestHandler<GetDepartmentByIdQuery, Department>
    {
        private readonly IDataRepository _repository;
        public GetDepartmentByIdQueryHandler(IDataRepository repository)
        {

            _repository = repository;

        }
        public async Task<Department> Handle(GetDepartmentByIdQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetDepartmentById(request.Id);
        }
    }
}
