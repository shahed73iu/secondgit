using ECommerce.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Core.Context
{
    public interface IProductContext
    {
        DbSet<Product> Products { get; set; }
        DbSet<ProductImage> ProductImages { get; set; }
        DbSet<Category> Category { get; set; }
        DbSet<ProductCategory> ProductCategory { get; set; }
        DbSet<FixedAmountDiscount> FixedAmountDiscounts { get; set; }
        DbSet<PercentageDiscount> PercentageDiscounts { get; set; }
    }
}
