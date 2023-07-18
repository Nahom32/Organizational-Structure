using MediatR;
using OrganizationalStructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationalStructure.Application.Commands.Handlers
{
    public class CreateDepartmentCommandHandler : IRequestHandler<CreateDepartmentCommand, Department>
    {
        private readonly IDataRepository _repository;
        public CreateDepartmentCommandHandler(IDataRepository repository)
        {

            _repository = repository;

        }
        public async Task<Department> Handle(CreateDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department = new Department()
            {
                DepartmentName = request.DepartmentName,
                DepartmentDescription = request.DepartmentDescription,
                ManagingDepartmentId = request.ManagingDepartmentId,

            };
            await _repository.CreateDepartment(department);
            return department;
        }
    }
}
