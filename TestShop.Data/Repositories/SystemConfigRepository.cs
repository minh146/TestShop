using TestShop.Data.Infrastructure;
using TestShop.Model.Models;

namespace TestShop.Data.Repositories
{
    public class SystemConfigRepository : RepositoryBase<SystemConfig>
    {
        public SystemConfigRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}