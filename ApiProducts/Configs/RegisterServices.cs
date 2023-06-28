using ApiProducts.Services;

namespace ApiProducts.Configs
{
    public static class RegisterServices
    {
        public static void RegisterMyServices(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
        }
    }
}

