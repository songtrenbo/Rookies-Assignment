using AutoMapper;
using Backend.Extensions;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared;
using Shared.Dto;
using Shared.Dto.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ShoesStoreDatabaseContext _shoesStoreDatabaseContext;
        private readonly IMapper _mapper;

        public ProductRepository(ShoesStoreDatabaseContext shoesStoreDatabaseContext, IMapper mapper)
        {
            _shoesStoreDatabaseContext = shoesStoreDatabaseContext;
            _mapper = mapper;
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
                .Include(e=>e.Brand)
                .Include(e=>e.Images)
                .Include(e=>e.Category)
                .Include(e=>e.SizeProducts)
                .Include(e=>e.Rates)
                .FirstOrDefaultAsync(e => e.ProductId == productId);
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _shoesStoreDatabaseContext.Products
                .Include(e => e.Images)
                .Include(e => e.SizeProducts)
                .Include(e => e.Rates)
                .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductsByCategory(int categoryId)
        {
            return await _shoesStoreDatabaseContext.Products
                .Where(s => s.CategoryId == categoryId)
                .Include(e => e.Images)
                .Include(e => e.SizeProducts)
                .Include(e => e.Rates)
                .ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetTop9NewProduct()
        {
            return await _shoesStoreDatabaseContext.Products
                .Include(e => e.Images)
                .Include(e => e.SizeProducts)
                .Include(e => e.Rates)
                .OrderByDescending(e => e.CreateDate).Take(9)
                .ToListAsync();
        }

        public async Task<Product> UpdateProduct(int productId, [FromForm] ProductCreateRequest productCreateRequest)
        {
            var product = await _shoesStoreDatabaseContext.Products.FindAsync(productId);
            if (product != null)
            {
                product.ProductName = productCreateRequest.ProductName;
                product.ProductDesc = productCreateRequest.ProductDesc;
                product.Price = productCreateRequest.Price;
                product.CategoryId = productCreateRequest.CategoryId;
                product.BrandId = productCreateRequest.BrandId;
                product.Stock = productCreateRequest.Stock;
                product.UpdateDate = DateTime.Now;

                await _shoesStoreDatabaseContext.SaveChangesAsync();
                _shoesStoreDatabaseContext.Products.Update(product);
                return product;
            }
            return null;
        }



        //Get products with pages, search, sort
        public async Task<PagedResponseDto<ProductDto>> GetProductsPages([FromQuery] ProductCriteriaDto productCriteriaDto)
        {
            var productQuery = _shoesStoreDatabaseContext
                               .Products
                               .AsQueryable();
            productQuery = ProductFilter(productQuery, productCriteriaDto);

            var pagedProducts = await productQuery
                                .AsNoTracking()
                                .PaginateAsync(productCriteriaDto);

            var productDto = _mapper.Map<IEnumerable<ProductDto>>(pagedProducts.Items);
            return new PagedResponseDto<ProductDto>
            {
                CurrentPage = pagedProducts.CurrentPage,
                TotalPages = pagedProducts.TotalPages,
                TotalItems = pagedProducts.TotalItems,
                Search = productCriteriaDto.Search,
                SortColumn = productCriteriaDto.SortColumn,
                SortOrder = productCriteriaDto.SortOrder,
                Limit = productCriteriaDto.Limit,
                Items = productDto
            };
        }

        //Fliter products
        private IQueryable<Product> ProductFilter(
           IQueryable<Product> productQuery,
           ProductCriteriaDto productCriteriaDto)
        {
            if (!String.IsNullOrEmpty(productCriteriaDto.Search))
            {
                productQuery = productQuery.Where(b =>
                    b.ProductName.Contains(productCriteriaDto.Search));
            }
            return productQuery;
        }
    }
}
