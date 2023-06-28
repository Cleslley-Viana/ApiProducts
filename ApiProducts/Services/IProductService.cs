using ApiProducts.Models;

namespace ApiProducts.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
        Product Save(Product product);
        Product? Get(int id);
        Product Change(Product product);
        void Delete(int id);
    }
}
