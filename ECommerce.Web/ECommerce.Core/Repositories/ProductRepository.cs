using ECommerce.Core.Context;
using ECommerce.Core.Entities;
using ECommerce.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Core.Repositories
{
    public class ProductRepository : Repository<Product> , IProductRepository
    {
        public ProductRepository(IProductContext productContext)
            : base((ProductContext) productContext)
        {

        }
    }
}
