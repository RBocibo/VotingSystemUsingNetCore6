using Core.UnitOfWorkInterface;
using Infrastructure.UnitOfWork;

namespace API.Extensions.RepositoryExtensions
{
    public static class RepositoryConfigurations
    {
        public static void RepositoryConfiguration(this IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
        }
    }
}
