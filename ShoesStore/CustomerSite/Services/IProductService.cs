using Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerSite.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<IEnumerable<Product>> GetTop9NewProduct();
        Task<Product> GetProduct(int productId);
        Task<IEnumerable<Product>> GetProductsByCategory(int categoryId);
        Task<Order> CreateOrder(Order order,  string token);
        Task<OrderDetail> CreateOrderDetail(OrderDetail orderDetail, string token);
    }
}
