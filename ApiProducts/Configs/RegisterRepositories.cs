using ApiProducts.Repositories;

namespace ApiProducts.Configs
{
    public static class RegisterRepositories
    {
        public static void RegisterMyRepositories(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
