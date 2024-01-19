using System;
using FluentValidation;
using Application.Users;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
	public static class DependencyInjection
	{
	
		public static IServiceCollection AddApplication(this IServiceCollection services)
		{
			var assembly = typeof(DependencyInjection).Assembly;

			services.AddMediatR(configuration =>
			  configuration.RegisterServicesFromAssembly(assembly));
            services.AddSingleton(new User("User"));
            services.AddValidatorsFromAssembly(assembly);
            



            return services;
		}
        
    }
}

