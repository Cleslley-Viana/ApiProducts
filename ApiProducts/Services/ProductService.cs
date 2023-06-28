using ApiProducts.Models;
using ApiProducts.Repositories;

namespace ApiProducts.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService (IProductRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Product> GetAll()
        {
            return _repository.GetAll();
        }

        public Product Save(Product product)
        {
            return _repository.Save(product);
        }

        public Product? Get(int id)
        {
            return _repository.Get(id);
        }
        public Product Change(Product product)
        {
            return _repository.Change(product);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
