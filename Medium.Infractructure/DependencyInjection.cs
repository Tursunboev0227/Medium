using Medium.Application.Absatractions;
using Medium.Infractructure.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium.Infractructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection service, IConfiguration configuration) 
        { 
         service.AddDbContext<IApplicationDbContext, ApplicationDbContext>(options =>
         {
             options.UseNpgsql(configuration.GetConnectionString("DefaultConnectionString"));
         });
         
            return service;
        }
    }
}
