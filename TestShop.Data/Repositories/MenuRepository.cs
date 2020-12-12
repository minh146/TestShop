using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TestShop.Model.Models;

namespace TestShop.Data.Repositories
{
    public interface IMenuRepository :IRepository<Menu>
    {

    }
   public class MenuRepository : RepositoryBase<Menu>
    {
        public MenuRepository(IDbFactory dbFactory) :base (dbFactory)
        {

        }
    }
}
