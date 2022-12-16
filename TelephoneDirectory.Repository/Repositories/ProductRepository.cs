using Microsoft.EntityFrameworkCore;
using TelephoneDirectory.Core.Models.Entities;
using TelephoneDirectory.Core.Repositories;

namespace TelephoneDirectory.Repository.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Product>> GetProductsWithCategory()
        {
            return await _context.Products.Include(x => x.Category).ToListAsync();
        }
    }
}
