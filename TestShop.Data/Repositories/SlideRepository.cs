using TestShop.Data.Infrastructure;
using TestShop.Model.Models;

namespace TestShop.Data.Repositories
{
    public class SlideRepository : RepositoryBase<Slide>
    {
        public SlideRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }