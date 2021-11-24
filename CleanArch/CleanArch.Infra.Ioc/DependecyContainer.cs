using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.Repository;
using CleanArch.Infra.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Ioc
{
    public class DependecyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<ICourseServices, CourseServices>();

            //Infra.Data Layer
            services.AddScoped<ICourseRepo, CourseRepository>();
        }
    }
}
