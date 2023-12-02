using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrganizationalStructure.Application.Commands;
using OrganizationalStructure.Application.Queries;
using OrganizationalStructure.Domain;



namespace OrganizationalStructure.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IMediator _mediator;
        public DepartmentController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var departments = await _mediator.Send(new GetAllDepartmentsQuery());
            return Ok(departments);

        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDepartmentById(int id)
        {
            var department = await _mediator.Send(new GetDepartmentByIdQuery() { Id = id });
            if (department == null)
            {
                return BadRequest();
            }
            else
            {
                return Ok(department);  
            }
        }
        [HttpGet("{id}/child")]
        public async Task<IActionResult>GetChildDepartments(int id)
        {
            var departments = await _mediator.Send(new GetAllChildrenDepartmentsQuery() { Id = id });
            return Ok(departments);
        }
        [HttpPost]
        public async Task<IActionResult>CreateDepartment([FromBody]Department department)
        {
            if (ModelState.IsValid)
            {
                var command = new CreateDepartmentCommand()
                {
                    DepartmentName = department.DepartmentName,
                    DepartmentDescription  = department.DepartmentDescription,
                    ManagingDepartmentId = department.ManagingDepartmentId

                };
               var dept = await _mediator.Send(command);
                return Ok(dept);


            }
            else
            {
                return BadRequest();
            }
           
        }
        [HttpPut]
        public async Task<IActionResult>UpdateDepartment([FromBody]Department department)
        {
            if (ModelState.IsValid)
            {
                var command = new UpdateDepartmentCommand()
                {
                    Id = department.Id,
                    DepartmentName = department.DepartmentName,
                    DepartmentDescription = department.DepartmentDescription,
                    ManagingDepartmentId = department.ManagingDepartmentId
                };
                var dept = await _mediator.Send(command);
                return Ok(dept);

            }
            else
            {
                return BadRequest();
            }
        }
        [HttpDelete]
        public async Task<IActionResult>DeleteDepartment(int id)
        {
            var command = new DeleteDepartmentCommand()
            {
                Id = id
            };
            var dept = await _mediator.Send(command);
            return Ok(dept);

        }

    }
}
