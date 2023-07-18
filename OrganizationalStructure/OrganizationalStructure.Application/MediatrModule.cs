using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OrganizationalStructure.Application
{
    public static class MediatrModule
    {
        public static IServiceCollection AddMediatrModule(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddMediatR(_ => _.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            return serviceCollection;
        }
    }
}
