using TestShop.Data.Infrastructure;
using TestShop.Model.Models;

namespace TestShop.Data.Repositories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory>
    {
    }

    public class ProductCategoryRepository : RepositoryBase<ProductCategory>
    {
        public ProductCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}