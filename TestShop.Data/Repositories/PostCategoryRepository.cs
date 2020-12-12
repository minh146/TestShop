using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TestShop.Model.Models;

namespace TestShop.Data.Repositories
{
    public interface IPostCategoryRepository : IRepository<PostCategory>
    {

    }
   public class PostCategoryRepository : RepositoryBase<PostCategory>
    {
        public PostCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
