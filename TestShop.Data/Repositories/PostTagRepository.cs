using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestShop.Data.Infrastructure;
using TestShop.Model.Models;

namespace TestShop.Data.Repositories
{
    public interface IPostTagRepository :IRepository<PostTag>
    {

    }

   public class PostTagRepository : RepositoryBase<PostTag>,IPostTagRepository
    {
        public PostTagRepository(IDbFactory dbFactory) :base(dbFactory)
        {

        }
    }
}
