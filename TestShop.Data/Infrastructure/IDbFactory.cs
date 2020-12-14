using System;

namespace TestShop.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        TestShopDbContext Init();
    }
}