using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.Common.DTOs;
using Task.Service.Interfaces;
using Task.Service.Services;
using Tasl.Repository;

namespace Task.Service
{
    public static class ServiceCollectionExtension
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddRepositories();
            services.AddScoped<IUserService, UserService>();
            services.AddAutoMapper(typeof(Mapper));
        }
    }
}
