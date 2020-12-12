﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TestShop.Model.Models;

namespace TestShop.Data.Repositories
{
    public interface IPostRepository :IRepository<Post>
    {

    }
  public class PostRepository : RepositoryBase<Post>, IPostRepository
    
    {
        public PostRepository(IDbFactory dbFactory) :base(dbFactory)
        {

        }
    }
}