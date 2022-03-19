using Backend.Controllers;
using Backend.Repositories;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest.BackendTesting.Mock.MockData;
using Xunit;

namespace UnitTest.BackendTesting.ControllerAPITesting
{
    public class TestProductController
    {
        [Fact]
        public async Task GetProducts_ShouldReturn200Status()
        {
            // Arrange
            var productRepository = new Mock<IProductRepository>();
            productRepository.Setup(_ => _.GetProducts()).ReturnsAsync(ProductsMockData.GetProducts());
            var sut = new ProductsController(productRepository.Object);

            // Act
            var result = (OkObjectResult)await sut.GetProducts();


            // Assert: Check if success get all products
            result.StatusCode.Should().Be(200);
        }

        [Fact]
        public async Task GetProducts_ShouldReturn204NoContentStatus()
        {
            // Arrange
            var productRepository = new Mock<IProductRepository>();
            productRepository.Setup(_ => _.GetProducts()).ReturnsAsync(ProductsMockData.GetEmptyProducts());
            var sut = new ProductsController(productRepository.Object);

            // Act
            var result = (NoContentResult)await sut.GetProducts();


            // Assert: Check if list is empty
            result.StatusCode.Should().Be(204);
            productRepository.Verify(_ => _.GetProducts(), Times.Exactly(1));
        }

        [Fact]
        public async Task CreateProduct()
        {
            // Arrange
            var productRepository = new Mock<IProductRepository>();
            var newProduct = ProductsMockData.NewProduct();
            var sut = new ProductsController(productRepository.Object);

            // Act
            var result = await sut.CreateProduct(newProduct);

            // Assert: check if do Add product 1 time
            productRepository.Verify(_ => _.AddProduct(newProduct), Times.Exactly(1));
        }

        [Fact]
        public async Task UpdateProduct()
        {
            // Arrange
            var productRepository = new Mock<IProductRepository>();
            var newProduct = ProductsMockData.NewProduct();
            var sut = new ProductsController(productRepository.Object);

            // Act
            var result = await sut.UpdateProduct(1,newProduct);

            // Assert: check if do Update product 1 time
            productRepository.Verify(_ => _.UpdateProduct(1,newProduct), Times.Exactly(1));
        }

        [Fact]
        public async Task GetProduct()
        {
            // Arrange
            const int productId = 1;
            var productRepository = new Mock<IProductRepository>();
            productRepository.Setup(_ => _.GetProduct(productId)).ReturnsAsync(ProductsMockData.GetOneProduct());

            var sut = new ProductsController(productRepository.Object);

            // Act
            var result = await sut.GetProduct(productId);

            // Assert: check if do Get product by id 1 time
            productRepository.Verify(_ => _.GetProduct(productId), Times.Exactly(1));
        }

        [Fact]
        public async Task DeleteProduct()
        {
            // Arrange
            const int productId = 1;
            var productRepository = new Mock<IProductRepository>();
            productRepository.Setup(_ => _.GetProduct(productId)).ReturnsAsync(ProductsMockData.GetOneProduct());
            
            var sut = new ProductsController(productRepository.Object);

            // Act
            var result = await sut.DeleteProduct(productId);

            // Assert: check if do Delete product 1 time
            productRepository.Verify(_ => _.DeleteProduct(productId), Times.Exactly(1));
        }
    }
}
