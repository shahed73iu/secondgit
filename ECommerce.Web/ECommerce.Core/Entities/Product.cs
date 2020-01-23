﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Core.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public IList<ProductImage> Images { get; set; }
        public IList<ProductCategory> Categories { get; set; }
        public Discount PriceDiscount { get; set; }

    }
}
