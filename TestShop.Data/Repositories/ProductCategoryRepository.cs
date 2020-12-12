using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestShop.Data.Infrastructure;
using TestShop.Model.Models;

namespace TestShop.Data.Repositories
{
    public interface IProductCategoryRepository :IRepository<ProductCategory>
    {

    }
   public class ProductCategoryRepository :RepositoryBase<ProductCategory>
    {
        public ProductCategoryRepository(IDbFactory dbFactory) :base(dbFactory)
        {

        }
    }
}
