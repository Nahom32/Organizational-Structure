using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationalStructure.Application.Commands.Validators
{
    public class UpdateDepartmentCommandValidator: AbstractValidator<UpdateDepartmentCommand>
    {
       
        public UpdateDepartmentCommandValidator()
        {
            RuleFor(x => x.DepartmentName).NotEmpty().MaximumLength(255);
            RuleFor(x => x.DepartmentDescription).NotEmpty().MaximumLength(255);
            RuleFor(x => x.ManagingDepartmentId).NotEmpty();
            
        }
        
    }
}
