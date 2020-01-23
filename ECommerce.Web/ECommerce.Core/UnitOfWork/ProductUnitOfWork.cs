using ECommerce.Core.Context;
using ECommerce.Core.Repositories;
using ECommerce.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Core.UnitOfWork
{
    public class ProductUnitOfWork : UnitOfWork<ProductContext>, IProductUnitOfWork
    {
       public IProductRepository ProductRepository { get; set; } 
        public ProductUnitOfWork( string connectionString , string migrationAssemblyName) 
            :base (connectionString , migrationAssemblyName)
        {
            ProductRepository = new ProductRepository(_dbContext);
        }
    }
}
