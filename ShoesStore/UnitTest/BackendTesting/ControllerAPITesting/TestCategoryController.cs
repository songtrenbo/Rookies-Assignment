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
    public class TestCategoryController
    {
        [Fact]
        public async Task GetCategories_ShouldReturn200Status()
        {
            // Arrange
            var categoryRepository = new Mock<ICategoryRepository>();
            categoryRepository.Setup(_ => _.GetCategoies()).ReturnsAsync(CategoriesMockData.GetCategories());
            var sut = new CategoriesController(categoryRepository.Object);

            // Act
            var result = (OkObjectResult)await sut.GetCategoies();


            // Assert: Check if success get all categories
            result.StatusCode.Should().Be(200);
        }

        [Fact]
        public async Task GetCategories_ShouldReturn204NoContentStatus()
        {
            // Arrange
            var categoryRepository = new Mock<ICategoryRepository>();
            categoryRepository.Setup(_ => _.GetCategoies()).ReturnsAsync(CategoriesMockData.GetEmptyCategories());
            var sut = new CategoriesController(categoryRepository.Object);

            // Act
            var result = (NoContentResult)await sut.GetCategoies();


            // Assert: Check if list is empty
            result.StatusCode.Should().Be(204);
            categoryRepository.Verify(_ => _.GetCategoies(), Times.Exactly(1));
        }

        [Fact]
        public async Task CreateCategory()
        {
            // Arrange
            var categoryRepository = new Mock<ICategoryRepository>();
            var newCategory = CategoriesMockData.NewCategory();
            var sut = new CategoriesController(categoryRepository.Object);

            // Act
            var result = await sut.CreateCategory(newCategory);

            // Assert: check if do Add category 1 time
            categoryRepository.Verify(_ => _.AddCategory(newCategory), Times.Exactly(1));
        }

        [Fact]
        public async Task UpdateCategory()
        {
            // Arrange
            var categoryRepository = new Mock<ICategoryRepository>();
            var newCategory = CategoriesMockData.NewCategory();
            var sut = new CategoriesController(categoryRepository.Object);

            // Act
            var result = await sut.UpdateCategory(1, newCategory);

            // Assert: check if do Update category 1 time
            categoryRepository.Verify(_ => _.UpdateCategory(1, newCategory), Times.Exactly(1));
        }

        [Fact]
        public async Task GetCategory()
        {
            // Arrange
            const int categoryId = 1;
            var categoryRepository = new Mock<ICategoryRepository>();
            categoryRepository.Setup(_ => _.GetCategory(categoryId)).ReturnsAsync(CategoriesMockData.GetOneCategory());

            var sut = new CategoriesController(categoryRepository.Object);

            // Act
            var result = await sut.GetCategory(categoryId);

            // Assert: check if do Get category by id 1 time
            categoryRepository.Verify(_ => _.GetCategory(categoryId), Times.Exactly(1));
        }

        [Fact]
        public async Task DeleteCategory()
        {
            // Arrange
            const int categoryId = 1;
            var categoryRepository = new Mock<ICategoryRepository>();
            categoryRepository.Setup(_ => _.GetCategory(categoryId)).ReturnsAsync(CategoriesMockData.GetOneCategory());

            var sut = new CategoriesController(categoryRepository.Object);

            // Act
            var result = await sut.DeleteCategory(categoryId);

            // Assert: check if do Delete category 1 time
            categoryRepository.Verify(_ => _.DeleteCategory(categoryId), Times.Exactly(1));
        }
    }
}
