using ApiProducts.Models;

namespace ApiProducts.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product Save(Product product);
        Product? Get(int id);
        Product Change(Product product);
        void Delete(int id);

    }
}
