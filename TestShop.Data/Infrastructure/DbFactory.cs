namespace TestShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private TestShopDbContext dbContext;

        public TestShopDbContext Init()
        {
            return dbContext ?? (dbContext = new TestShopDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}