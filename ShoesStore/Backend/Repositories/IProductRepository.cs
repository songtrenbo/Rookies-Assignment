using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Shared;
using Shared.Dto;
using Shared.Dto.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<Product> GetProduct(int productId);
        Task<Product> AddProduct([FromForm] ProductCreateRequest productCreateRequest);
        Task<Product> UpdateProduct(int productId, [FromForm] ProductCreateRequest productCreateRequest);
        Task<Product> DeleteProduct(int productId);
        Task<IEnumerable<Product>> GetTop9NewProduct();
        Task<IEnumerable<Product>> GetProductsByCategory(int categoryId);
        Task<PagedResponseDto<ProductDto>> GetProductsPages([FromQuery] ProductCriteriaDto productCriteriaDto);
        Task<Order> CreateOrder([FromBody] Order order);
        Task<OrderDetail> CreateOrderDetail([FromBody] OrderDetail orderDetail);
    }
}
