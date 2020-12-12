using System;
using TestShop.Data;

namespace TeduShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        TestShopDbContext Init();
    }
}