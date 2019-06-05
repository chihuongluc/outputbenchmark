using System;

namespace OBM.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        OBMDbContext Init();
    }
}