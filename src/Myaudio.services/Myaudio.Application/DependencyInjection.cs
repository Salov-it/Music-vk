﻿using Microsoft.Extensions.DependencyInjection;
using MediatR;
using System.Reflection;

namespace Myaudio.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
           // services.AddScoped<>():
            return services;
        }
    }
}
