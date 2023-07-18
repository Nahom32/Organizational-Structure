using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using OrganizationalStructure.Domain;
using OrganizationalStructure.WebApi.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace OrganizationalStructure.UnitTests
{
    public class DepartmentControllerTest
    {
        private readonly DepartmentController _controller;
        private readonly Mock<IMediator> _mediator;
        public DepartmentControllerTest(Mock<IMediator> meditor)
        {
            _mediator = meditor;
            _controller = new DepartmentController(_mediator.Object);  
        }
        [Fact]
        public async Task Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult =await _controller.GetAll();
            // Assert
            Assert.NotNull(okResult);
        }
        [Fact]
        public async Task ShowAllValuesWhenCalled()
        {
            var result = await _controller.GetChildDepartments(1);

            Assert.NotNull(result);

        }
    }
}
