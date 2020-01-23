using ECommerce.Core.Context;
using ECommerce.Core.Repositories;
using ECommerce.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Core.UnitOfWork
{
    public interface IProductUnitOfWork : IUnitOfWork<ProductContext>
    {
        IProductRepository ProductRepository { get; set; }
    }
}
