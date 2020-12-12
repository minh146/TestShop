using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestShop.Data.Infrastructure;
using TestShop.Model.Models;

namespace TestShop.Data.Repositories
{
  public  class TagRepository :RepositoryBase<Tag>
    {
        public TagRepository(IDbFactory dbFactory) :base(dbFactory)
        {

        }
    }
}
