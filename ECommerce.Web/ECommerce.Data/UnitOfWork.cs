using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Data
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : DbContext
    {
        protected readonly T _dbContext;
        public UnitOfWork(string connectionString, string migrationAssemblyName)
            => _dbContext = (T)Activator.CreateInstance(typeof(T), connectionString, migrationAssemblyName);
        
        public void Dispose() => _dbContext?.Dispose();        
        public void save() => _dbContext?.SaveChanges();
    }
}
