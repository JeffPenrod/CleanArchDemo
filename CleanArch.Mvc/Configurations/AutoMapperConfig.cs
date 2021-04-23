using CleanArch.Application.AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace CleanArch.Mvc.Configurations
{
    public static class AutoMapperConfig
    {

        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(CleanArch.Application.AutoMapper.AutoMapperConfiguration));
            AutoMapperConfiguration.RegisterMappings();
        }

    }
}
