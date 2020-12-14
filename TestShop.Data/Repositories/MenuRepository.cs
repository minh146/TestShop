using TestShop.Data.Infrastructure;
using TestShop.Model.Models;

namespace TestShop.Data.Repositories
{
    public interface IMenuRepository : IRepository<Menu>
    {
    }

    public class MenuRepository : RepositoryBase<Menu>
    {
        public MenuRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}