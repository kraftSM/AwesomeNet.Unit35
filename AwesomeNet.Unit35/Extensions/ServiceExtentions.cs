using AwesomeNet.Unit35.Data.Repository;
using AwesomeNet.Unit35.Data.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;

namespace AwesomeNet.Unit35.Extensions
{
    public static class ServiceExtentions
    {
        public static IServiceCollection AddUnitOfWork(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }

        public static IServiceCollection AddCustomRepository<TEntity, IRepository>(this IServiceCollection services)
                 where TEntity : class
                 where IRepository : class, IRepository<TEntity>
        {
            services.AddScoped<IRepository<TEntity>, IRepository>();

            return services;
        }

    }
}
