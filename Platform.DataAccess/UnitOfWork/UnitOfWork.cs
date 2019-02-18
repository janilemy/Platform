using Microsoft.EntityFrameworkCore;
using Platform.DAL.UnitOfWork.Interfaces;
using System;

namespace Platform.DAL.UnitOfWork
{
    public class UnitOfWork : UnitOfWorkBase<DbContext>, IUnitOfWork
    {
        public UnitOfWork(DbContext context, IServiceProvider provider) : base(context, provider)
        { }
    }
}
