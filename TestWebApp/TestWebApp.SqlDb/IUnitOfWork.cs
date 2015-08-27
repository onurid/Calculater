using System;

namespace TestWebApp.SqlDb
{
    public interface IUnitOfWork : IDisposable
    {
        int Commit();
    }
}