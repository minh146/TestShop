﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TestShop.Model.Models;

namespace TestShop.Data.Repositories
{
    public interface IOrderDetailRepository :IRepository<OrderDetail>
    {

    }
    public class OrderDetailRepository : RepositoryBase<OrderDetail>,IOrderDetailRepository
    {
        public OrderDetailRepository(IDbFactory dbFactory) :base(dbFactory)
            {

            }
    }
}
