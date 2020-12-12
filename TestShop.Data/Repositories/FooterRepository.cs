using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TestShop.Model.Models;

namespace TestShop.Data.Repositories
    
{
    public interface IFooterRepository : IRepository<Footer>
    {

    }
   public class FooterRepository : RepositoryBase<Footer>
    {
        public FooterRepository(IDbFactory dbFactory) :base(dbFactory)
        {

        }
    }
}
