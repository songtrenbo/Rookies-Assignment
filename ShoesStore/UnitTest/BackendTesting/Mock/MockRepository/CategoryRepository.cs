using Backend.Models;
using Backend.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared;
using Shared.Dto;
using Shared.Dto.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest.BackendTesting.Mock.MockRepository
{
    class CategoryRepository: ICategoryRepository
    {
        private readonly ShoesStoreDatabaseContext _shoesStoreDatabaseContext;

        public CategoryRepository(ShoesStoreDatabaseContext shoesStoreDatabaseContext)
        {
            _shoesStoreDatabaseContext = shoesStoreDatabaseContext;
        }

        public async Task<Category> AddCategory([FromForm] CategoryCreateRequest categoryCreateRequest)
        {
            var category = new Category
            {
                CategoryName = categoryCreateRequest.CategoryName
            };


            var result = await _shoesStoreDatabaseContext.Categories.AddAsync(category);
            await _shoesStoreDatabaseContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Category> DeleteCategory(int categoryId)
        {
            var result = await _shoesStoreDatabaseContext.Categories.FirstOrDefaultAsync(e => e.CategoryId == categoryId);
            if (result != null)
            {
                _shoesStoreDatabaseContext.Categories.Remove(result);
                await _shoesStoreDatabaseContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

        public async Task<IEnumerable<Category>> GetCategoies()
        {
            return await _shoesStoreDatabaseContext.Categories.ToListAsync();
        }

        public Task<PagedResponseDto<CategoryDto>> GetCategoriesPages([FromQuery] CategoryCriteriaDto categoryCriteriaDto)
        {
            throw new NotImplementedException();
        }

        public async Task<Category> GetCategory(int categoryId)
        {
            return await _shoesStoreDatabaseContext.Categories.FirstOrDefaultAsync(e => e.CategoryId == categoryId);
        }

        public async Task<Category> UpdateCategory(int id, [FromForm] CategoryCreateRequest categoryCreateRequest)
        {
            var category = await _shoesStoreDatabaseContext.Categories.FindAsync(id);
            if (category != null)
            {
                category.CategoryName = categoryCreateRequest.CategoryName;
                await _shoesStoreDatabaseContext.SaveChangesAsync();
                _shoesStoreDatabaseContext.Categories.Update(category);
                return category;
            }
            return null;
        }
    }
}
