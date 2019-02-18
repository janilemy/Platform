using Microsoft.EntityFrameworkCore;

namespace Platform.DAL.Repositories.Interfaces
{
    public interface IRepositoryInjection
    {
        IRepositoryInjection SetContext(DbContext context);
    }
}
