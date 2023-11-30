using Microsoft.Extensions.DependencyInjection;
using YadVashenOrdersRepositories.Interfaces;
using YadVashenOrdersRepositories.repositories;

namespace YadVashenOrdersRepositories
{
    public static class ExtentionRepository
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IRepository, OrdersRepository>();
        }
    }
}
