using MediatR;
using OrganizationalStructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationalStructure.Application.Queries.Handlers
{
    public class GetAllDepartmentsQueryHandler : IRequestHandler<GetAllDepartmentsQuery, List<Department>>
    {
        private readonly IDataRepository _repository;
        public GetAllDepartmentsQueryHandler(IDataRepository repository)
        {

            _repository = repository;

        }
        public async Task<List<Department>> Handle(GetAllDepartmentsQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllDepartments();
        }
    }
}
