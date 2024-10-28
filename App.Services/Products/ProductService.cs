﻿using App.Repositories.Products;
using System.Net;

namespace App.Services.Products
{
    public class ProductService(IProductRepository productRepository):IProductService
    {
        public async Task<ServiceResult<Product>> GetProductByIdAsync(int id)
        {
            var product = await productRepository.GetByIdAsync(id);
            if (product is null)
            {
                ServiceResult<Product>.Fail("Product not found", HttpStatusCode.NotFound);
            }
            return ServiceResult<Product>.Success(product!);
        }

    }
}
