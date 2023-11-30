using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using YadVashemOrdersContext;
using YadVashemOrdersContext.Interfaces;
using YadVashemOrdersServices.Interfaces;
using YadVashemOrdersServices.Services;
using YadVashemSystemServices;
using YadVashenOrdersRepositories;


namespace YadVashemOrdersServices
{
    public static class ExtentionService
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddRepositories();
            services.AddScoped<IService, YadVashemOrderService>();
            services.AddSingleton<IContext, YadVashemOrderContext>();
            services.AddAutoMapper(typeof(Mapper));
            
                // .... Ignore code before this

                // Auto Mapper Configurations
                var mapperConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new MappingProfile());
                });

                IMapper mapper = mapperConfig.CreateMapper();
                services.AddSingleton(mapper);

               

           
        }
    }
}
