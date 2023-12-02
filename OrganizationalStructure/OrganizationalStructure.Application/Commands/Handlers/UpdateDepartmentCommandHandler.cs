using MediatR;
using OrganizationalStructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationalStructure.Application.Commands.Handlers
{
    public class UpdateDepartmentCommandHandler : IRequestHandler<UpdateDepartmentCommand, Department>
    {
        private readonly IDataRepository _repository;
        public UpdateDepartmentCommandHandler(IDataRepository repository)
        {

            _repository = repository;

        }
        public async Task<Department> Handle(UpdateDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department = new Department()
            {
                Id = request.Id,
                DepartmentName = request.DepartmentName,
                DepartmentDescription = request.DepartmentDescription,
                ManagingDepartmentId = request.ManagingDepartmentId,

            };
            await _repository.UpdateDepartment(department);
            return department;
        }
    }
}
