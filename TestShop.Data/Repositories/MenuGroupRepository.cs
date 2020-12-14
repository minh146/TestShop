using TestShop.Data.Infrastructure;
using TestShop.Model.Models;

namespace TestShop.Data.Repositories
{
    public interface IMenuGroupRepository : IRepository<MenuGroup>
    {
    }

    public class MenuGroupRepository : RepositoryBase<MenuGroup>, IMenuGroupRepository

    {
        public MenuGroupRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}