using Backend.Models;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest.BackendTesting.Mock.MockData;
using UnitTest.BackendTesting.Mock.MockRepository;
using Xunit;

namespace UnitTest.BackendTesting.RepositoryTesting
{
    public class TestProductRepository: IDisposable
    {
        protected readonly ShoesStoreDatabaseContext _shoesStoreDatabaseContext;

        public void Dispose()
        {
            _shoesStoreDatabaseContext.Database.EnsureDeleted();
            _shoesStoreDatabaseContext.Dispose();
        }
        public TestProductRepository()
        {
            var options = new DbContextOptionsBuilder<ShoesStoreDatabaseContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

            _shoesStoreDatabaseContext = new ShoesStoreDatabaseContext(options);
                        
        }

        [Fact]
        public async Task GetProductsAsync_ReturnProductCollection()
        {
            // Arrange
            _shoesStoreDatabaseContext.Products.AddRange(ProductsMockData.GetProducts());
            _shoesStoreDatabaseContext.SaveChanges();

            var sut = new ProductRepository(_shoesStoreDatabaseContext);

            // Act
            var result = await sut.GetProducts();

            // Assert: Check if get all product
            result.Should().HaveCount(ProductsMockData.GetProducts().Count);
        }

        [Fact]
        public async Task SaveAsync_AddNewProduct()
        {
            // Arrange
            var newProduct = ProductsMockData.NewProduct();
            _shoesStoreDatabaseContext.Products.AddRange(ProductsMockData.GetProducts());
            _shoesStoreDatabaseContext.SaveChanges();

            var sut = new ProductRepository(_shoesStoreDatabaseContext);

            // Act
            await sut.AddProduct(newProduct);

            //Assert: check if add success a product and list.count += 1
            int expectedRecordCount = (ProductsMockData.GetProducts().Count() + 1);
            _shoesStoreDatabaseContext.Products.Count().Should().Be(expectedRecordCount);
        }

        [Fact]
        public async Task GetProductAsync_ReturnOneProduct()
        {
            // Arrange
            const int productId = 1;
            _shoesStoreDatabaseContext.Products.AddRange(ProductsMockData.GetProducts());
            _shoesStoreDatabaseContext.SaveChanges();

            var sut = new ProductRepository(_shoesStoreDatabaseContext);

            // Act
            var result = await sut.GetProduct(productId);

            // Assert: Check if get 1 product is success, not null
            result.Should().NotBeNull();
        }

        [Fact]
        public async Task DeleteProductsAsync_ReturnLostOneProduct()
        {
            // Arrange
            _shoesStoreDatabaseContext.Products.AddRange(ProductsMockData.GetProducts());
            _shoesStoreDatabaseContext.SaveChanges();

            var sut = new ProductRepository(_shoesStoreDatabaseContext);

            // Act
            await sut.DeleteProduct(1);

            //Assert: Check if delete success and list.count -= 1
            int expectedRecordCount = (ProductsMockData.GetProducts().Count() - 1);
            _shoesStoreDatabaseContext.Products.Count().Should().Be(expectedRecordCount);
        }
    }
}
