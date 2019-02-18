using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Platform.DAL.Entities;

namespace Platform.DAL.Repositories
{
    public class GenericEntityRepository<TEntity> : EntityRepositoryBase<DbContext, TEntity> where TEntity : EntityBase<int>, new()
    {
        public GenericEntityRepository(ILogger<DataAccess> logger) : base(logger, null)
        { }
    }
}
