namespace OBM.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private OBMDbContext dbContext;

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }

        public OBMDbContext Init()
        {
            return dbContext ?? (dbContext = new OBMDbContext());
        }
    }
}