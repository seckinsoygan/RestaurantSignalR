using Microsoft.Extensions.DependencyInjection;
using SignalR.DAL.Shared;

namespace SignalR.BLL.DependencyResolvers
{
    public static class DbContextServiceInjection
    {
        public static IServiceCollection AddDbContextService(this IServiceCollection services)
        {
            services.AddSingleton<AppDbContext>();
            return services;
        }
    }
}
