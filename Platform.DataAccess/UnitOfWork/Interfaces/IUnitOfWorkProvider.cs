using Microsoft.EntityFrameworkCore;

namespace Platform.DAL.UnitOfWork.Interfaces
{
    public interface IUnitOfWorkProvider
    {
        IUnitOfWork CreateUnitOfWork(bool trackChanges = true, bool enableLogging = false);
        IUnitOfWork CreateUnitOfWork<TEntityContext>(bool trackChanges = true, bool enableLogging = false) where TEntityContext : DbContext;
    }
}
