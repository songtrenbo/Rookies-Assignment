using Backend.Models;
using FluentAssertions;
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
    public class TestCategoryRepository: IDisposable
    {
        protected readonly ShoesStoreDatabaseContext _shoesStoreDatabaseContext;

        public void Dispose()
        {
            _shoesStoreDatabaseContext.Database.EnsureDeleted();
            _shoesStoreDatabaseContext.Dispose();
        }
        public TestCategoryRepository()
        {
            var options = new DbContextOptionsBuilder<ShoesStoreDatabaseContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

            _shoesStoreDatabaseContext = new ShoesStoreDatabaseContext(options);

        }

        [Fact]
        public async Task GetCategoriesAsync_ReturnCategoryCollection()
        {
            // Arrange
            _shoesStoreDatabaseContext.Categories.AddRange(CategoriesMockData.GetCategories());
            _shoesStoreDatabaseContext.SaveChanges();

            var sut = new CategoryRepository(_shoesStoreDatabaseContext);

            // Act
            var result = await sut.GetCategoies();

            // Assert: Check if get all category
            result.Should().HaveCount(CategoriesMockData.GetCategories().Count);
        }

        [Fact]
        public async Task SaveAsync_AddNewCategory()
        {
            // Arrange
            var newCategory = CategoriesMockData.NewCategory();
            _shoesStoreDatabaseContext.Categories.AddRange(CategoriesMockData.GetCategories());
            _shoesStoreDatabaseContext.SaveChanges();

            var sut = new CategoryRepository(_shoesStoreDatabaseContext);

            // Act
            await sut.AddCategory(newCategory);

            //Assert: check if add success a category and list.count += 1
            int expectedRecordCount = (CategoriesMockData.GetCategories().Count() + 1);
            _shoesStoreDatabaseContext.Categories.Count().Should().Be(expectedRecordCount);
        }

        [Fact]
        public async Task GetCategoryAsync_ReturnOneCategory()
        {
            // Arrange
            const int categoryId = 1;
            _shoesStoreDatabaseContext.Categories.AddRange(CategoriesMockData.GetCategories());
            _shoesStoreDatabaseContext.SaveChanges();

            var sut = new CategoryRepository(_shoesStoreDatabaseContext);

            // Act
            var result = await sut.GetCategory(categoryId);

            // Assert: Check if get 1 category is success, not null
            result.Should().NotBeNull();
        }

        [Fact]
        public async Task DeleteCategoriesAsync_ReturnLostOneCategory()
        {
            // Arrange
            _shoesStoreDatabaseContext.Categories.AddRange(CategoriesMockData.GetCategories());
            _shoesStoreDatabaseContext.SaveChanges();

            var sut = new CategoryRepository(_shoesStoreDatabaseContext);

            // Act
            await sut.DeleteCategory(1);

            //Assert: Check if delete success and list.count -= 1
            int expectedRecordCount = (CategoriesMockData.GetCategories().Count() - 1);
            _shoesStoreDatabaseContext.Categories.Count().Should().Be(expectedRecordCount);
        }
    }
}
