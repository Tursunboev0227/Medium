using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Medium.Application.Absatractions.Mapper;

namespace Medium.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection service)
        {
            service.AddMediatR(Assembly.GetExecutingAssembly());
            service.AddAutoMapper(typeof(AutoMapperProfile));
            return service;
        }
    }
}
