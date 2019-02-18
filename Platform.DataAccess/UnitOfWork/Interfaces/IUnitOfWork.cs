using Platform.DAL.Repositories.Interfaces;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Platform.DAL.UnitOfWork.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        int SaveChanges();
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);

        IRepository<TEntity> GetRepository<TEntity>();
        TRepository GetCustomRepository<TRepository>();
    }
}
