using MediatR;
using OrganizationalStructure.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationalStructure.Application.Commands.Handlers
{
    public class DeleteDepartmentCommandHandler : IRequestHandler<DeleteDepartmentCommand, Department>
    {
        private readonly IDataRepository _repository;
        public DeleteDepartmentCommandHandler(IDataRepository repository)
        {

            _repository = repository;

        }
        public async Task<Department> Handle(DeleteDepartmentCommand request, CancellationToken cancellationToken)
        {
            var department = await _repository.GetDepartmentById(request.Id);
            if(department != null)
            {
                await _repository.DeleteDepartment(request.Id);
                
            }
            return department;
        }
    }
}
