using Microsoft.EntityFrameworkCore;
using Platform.DAL.Context.Interfaces;

namespace Platform.DAL.DataContext
{
    public class EntityContextBase<TContext> : DbContext, IEntityContext where TContext : DbContext
    {
        //public string ConnectionString { get; set; }

        public EntityContextBase(DbContextOptions<TContext> options): base(options)
        { }
    }
}
