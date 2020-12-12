using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestShop.Data.Infrastructure;
using TestShop.Model.Models;

namespace TestShop.Data.Repositories
{
   public class SupportOnlineRepository : RepositoryBase<SupportOnline>
    {
        public SupportOnlineRepository(IDbFactory dbFactory) : base(dbFactory) 
        {
        }
    }
}
