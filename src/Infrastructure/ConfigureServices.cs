﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class ConfigureServices
{
    public static IServiceCollection AddInfraStructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        return services;
    }
}
