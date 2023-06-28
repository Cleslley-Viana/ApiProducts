using ApiProducts.Context;
using ApiProducts.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiProducts.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.AsNoTracking();
        }

        public Product? Get(int id)
        {
            return _context.Products.Find(id);
        }

        public Product Save(Product product)
        {
            var saved = _context.Products.Add(product);
            _context.SaveChanges();

            return saved.Entity;
        }


        public Product Change(Product product)
        {
            var updated = _context.Products.Update(product);
            _context.SaveChanges();

            return updated.Entity;
        }

        public void Delete(int id)
        {
           var saved = _context.Products.FirstOrDefault(x => x.Id == id);

            if (saved == null) return;

            _context.Products.Remove(saved);
            _context.SaveChanges();
        }
    }
}
