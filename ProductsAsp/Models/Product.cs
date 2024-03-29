﻿using Microsoft.AspNetCore.Mvc;
using ProductsAsp.Models.FluentValidators;

namespace ProductsAsp.Models
{
    [ModelMetadataType(typeof(ProductFluentValidator))]
    public class Product
    {
        static int _staticId = 0;
        public int Id { get; set; } = ++_staticId;
        public string ProductName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Price { get; set; }
    }
}
