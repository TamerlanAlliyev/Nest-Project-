﻿using Nest.Data;
using Nest.Models;

namespace Nest.ViewModels
{
    public class ProductVM
    {

        public List<Product> Products { get; set; }
        public List<Category> Categories { get; set; }
        public List<ProductImage> Images { get; set; }
        public List<SizeWeight> SizeWeights { get; set; }
        public List<CustomerRating> CustomerRatings { get; set; }

    }
}
