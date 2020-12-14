using TestShop.Data.Infrastructure;
using TestShop.Model.Models;

namespace TestShop.Data.Repositories
{
    public interface IPageRepository : IRepository<Page>
    {
    }

    public class PageRepository : RepositoryBase<Page>
    {
        public PageRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}