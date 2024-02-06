using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationalStructure.Application.Commands.Validators
{
    public class CreateDepartmentCommandValidator: AbstractValidator<CreateDepartmentCommand>
    {
        public CreateDepartmentCommandValidator() 
        {
           
            RuleFor(x => x.DepartmentName).NotEmpty().MaximumLength(100);
            RuleFor(x => x.DepartmentDescription).NotEmpty().MaximumLength(255);
            RuleFor(x => x.ManagingDepartmentId).NotEmpty();
        
        }


    }
}
