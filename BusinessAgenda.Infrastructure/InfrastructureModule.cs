using BusinessAgenda.Core.Repositories;
using BusinessAgenda.Infrastructure.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessAgenda.Infrastructure
{
    public static class InfrastructureModule
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddRepositories()
                .AddData(configuration);
            return services;
        }

            private static IServiceCollection AddData(this IServiceCollection services, IConfiguration configuration)
            {
                // Configura o DbContext para usar o banco de dados em memória
                services.AddDbContext<BusinessAgendaDbContext>(options =>
                    options.UseInMemoryDatabase("BusinessAgendaDb"));
                return services;
            }
       
        private static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IMeetingRepository, MeetingRepository>();

            return services;
        }
    }
}
