using Microsoft.Extensions.DependencyInjection;
using MediatR;
using System.Reflection;
using Medium.Application.Absatractions.Mapper;
using Medium.Domain.Entities;


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