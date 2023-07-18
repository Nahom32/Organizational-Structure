using MediatR;
using OrganizationalStructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace OrganizationalStructure.Application.Queries.Handlers
{
    public class GetAllChildrenDepartmentsQueryHandler : IRequestHandler<GetAllChildrenDepartmentsQuery, List<Department>>
    {
        private readonly IDataRepository _repository;
        public GetAllChildrenDepartmentsQueryHandler(IDataRepository repository)
        {

            _repository = repository;

        }
        public async Task<List<Department>> Handle(GetAllChildrenDepartmentsQuery request, CancellationToken cancellationToken)
        {
            var total_departments = await _repository.GetAllDepartments();
            var child_departments = new List<Department>();
            foreach(var department in total_departments)
            {
                if(department.ManagingDepartmentId == request.Id)
                {
                    child_departments.Add(department);
                }
            }
            return child_departments;
        }
    }
}
