using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TestShop.Model.Models;

namespace TestShop.Data.Repositories
{
    public interface IPageRepository :IRepository<Page>
    {

    }
   public class PageRepository : RepositoryBase<Page>
    {
        public PageRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
