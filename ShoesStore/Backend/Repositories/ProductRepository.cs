using Backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ShoesStoreDatabaseContext shoesStoreDatabaseContext;

        public ProductRepository(ShoesStoreDatabaseContext shoesStoreDatabaseContext)
        {
            this.shoesStoreDatabaseContext = shoesStoreDatabaseContext;
        }

        public async Task<Product> AddProduct(Product product)
        {
            var result = await shoesStoreDatabaseContext.Products.AddAsync(product);
            await shoesStoreDatabaseContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Product> DeleteProduct(int productId)
        {
            var result = await shoesStoreDatabaseContext.Products.FirstOrDefaultAsync(e => e.ProductId == productId);
            if (result != null)
            {
                shoesStoreDatabaseContext.Products.Remove(result);
                await shoesStoreDatabaseContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<Product> GetProduct(int productId)
        {            
            return await shoesStoreDatabaseContext.Products
                .Include(e=>e.Brand)
                .Include(e=>e.Images)
                .Include(e=>e.Category)
                .Include(e=>e.SizeProducts)
                .Include(e=>e.Rates)
                .FirstOrDefaultAsync(e => e.ProductId == productId);
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await shoesStoreDatabaseContext.Products
                .Include(e => e.Images)
                .Include(e => e.SizeProducts)
                .Include(e => e.Rates)
                .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductsByCategory(int categoryId)
        {
            return await shoesStoreDatabaseContext.Products
                .Where(s => s.CategoryId == categoryId)
                .Include(e => e.Images)
                .Include(e => e.SizeProducts)
                .Include(e => e.Rates)
                .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetTop9NewProduct()
        {
            return await shoesStoreDatabaseContext.Products
                .Include(e => e.Images)
                .Include(e => e.SizeProducts)
                .Include(e => e.Rates)
                .OrderByDescending(e => e.CreateDate).Take(9)
                .ToListAsync();
        }

        public async Task<Product> UpdateProduct(Product product)
        {
            var result = await shoesStoreDatabaseContext.Products.FirstOrDefaultAsync(e => e.ProductId == product.ProductId);
            if (result != null)
            {
                result.ProductName = product.ProductName;
                result.ProductDesc = product.ProductDesc;
                result.Price = product.Price;
                result.Stock = product.Stock;


                await shoesStoreDatabaseContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
