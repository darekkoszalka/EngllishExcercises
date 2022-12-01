using System;
using EnglilshLesson.Infrastructure.Data;
using Microsoft.Extensions.DependencyInjection;

namespace EnglilshLesson.Infrastructure.DependencyInjections;

public static class InfrastructureDependencyInjection
{
	public static IServiceCollection AddInfrastructure(this IServiceCollection services)
	{
		services.AddDbContext<ApplicationDbContext>();
		services.AddDbContextFactory<ApplicationDbContext>();
		return services;
	}
}

