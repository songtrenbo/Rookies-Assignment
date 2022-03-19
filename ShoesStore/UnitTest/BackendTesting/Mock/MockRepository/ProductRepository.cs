using Backend.Models;
using Backend.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared;
using Shared.Dto;
using Shared.Dto.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.BackendTesting.Mock.MockRepository
{
    public class ProductRepository:IProductRepository
    {
        private readonly ShoesStoreDatabaseContext _shoesStoreDatabaseContext;

        public ProductRepository(ShoesStoreDatabaseContext shoesStoreDatabaseContext)
        {
            _shoesStoreDatabaseContext = shoesStoreDatabaseContext;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _shoesStoreDatabaseContext.Products.ToListAsync();
        }


        public async Task<Product> AddProduct([FromForm] ProductCreateRequest productCreateRequest)
        {
            var product = new Product
            {
                ProductName = productCreateRequest.ProductName,
                ProductDesc = productCreateRequest.ProductDesc,
                Price = productCreateRequest.Price,
                CategoryId = productCreateRequest.CategoryId,
                BrandId = productCreateRequest.BrandId,
                Stock = productCreateRequest.Stock,
                CreateDate = DateTime.Now
            };
            var result = await _shoesStoreDatabaseContext.Products.AddAsync(product);
            await _shoesStoreDatabaseContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Product> DeleteProduct(int productId)
        {
            var result = await _shoesStoreDatabaseContext.Products.FirstOrDefaultAsync(e => e.ProductId == productId);
            if (result != null)
            {
                _shoesStoreDatabaseContext.Products.Remove(result);
                await _shoesStoreDatabaseContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<Product> GetProduct(int productId)
        {
            return await _shoesStoreDatabaseContext.Products
              .FirstOrDefaultAsync(e => e.ProductId == productId);
        }


        public Task<IEnumerable<Product>> GetProductsByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResponseDto<ProductDto>> GetProductsPages([FromQuery] ProductCriteriaDto productCriteriaDto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetTop9NewProduct()
        {
            throw new NotImplementedException();
        }

        public Task<Product> UpdateProduct(int productId, [FromForm] ProductCreateRequest productCreateRequest)
        {
            throw new NotImplementedException();
        }
    }
}
