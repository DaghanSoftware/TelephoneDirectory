using TelephoneDirectory.Core.Models.Entities;

namespace TelephoneDirectory.Core.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<List<Product>> GetProductsWithCategory();
    }
}
