using TestShop.Data.Infrastructure;
using TestShop.Model.Models;

namespace TestShop.Data.Repositories
{
    public class VisitorStatisticRepository : RepositoryBase<VisitorStatistic>
    {
        public VisitorStatisticRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}