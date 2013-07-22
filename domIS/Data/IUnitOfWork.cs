using System;
namespace Data
{
    public interface IUnitOfWork
    {
        UcastniciContext Context { get; }
        void Dispose();
        int Save();
    }
}
