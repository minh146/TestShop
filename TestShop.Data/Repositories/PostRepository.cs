using TestShop.Data.Infrastructure;
using TestShop.Model.Models;

namespace TestShop.Data.Repositories
{
    public interface IPostRepository : IRepository<Post>
    {
    }

    public class PostRepository : RepositoryBase<Post>, IPostRepository

    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}