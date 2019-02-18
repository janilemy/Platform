using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Platform.DAL.DataContext
{
    public static class ModelBuilderExtensions
    {
        public static void DisableCascadingDeletes(this ModelBuilder modelBuilder)
        {
            foreach(var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(x => x.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}
