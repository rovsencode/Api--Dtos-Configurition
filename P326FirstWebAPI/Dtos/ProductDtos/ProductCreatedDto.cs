﻿namespace P326FirstWebAPI.Dtos.ProductDtos
{
    public class ProductCreatedDto
    {
        public string Name { get; set; }
        public double SalePrice { get; set; }
        public double CostPrice { get; set; }
        public bool IsActive { get; set; }
    }
}
