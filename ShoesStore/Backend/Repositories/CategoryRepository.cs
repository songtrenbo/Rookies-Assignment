using AutoMapper;
using Backend.Extensions;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared;
using Shared.Dto;
using Shared.Dto.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ShoesStoreDatabaseContext _shoesStoreDatabaseContext;
        private readonly IMapper _mapper;
        public CategoryRepository(ShoesStoreDatabaseContext shoesStoreDatabaseContext, IMapper mapper)
        {
            _shoesStoreDatabaseContext = shoesStoreDatabaseContext;
            _mapper = mapper;
        }
        public async Task<IEnumerable<Category>> GetCategoies()
        {
            return await _shoesStoreDatabaseContext.Categories.ToListAsync();
        }
        public async Task<Category> GetCategory(int categorId)
        {
            return await _shoesStoreDatabaseContext.Categories.FirstOrDefaultAsync(e => e.CategoryId == categorId);
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


        public async Task<PagedResponseDto<CategoryDto>> GetCategoriesPages([FromQuery] CategoryCriteriaDto categoryCriteriaDto)
        {
            var categoryQuery = _shoesStoreDatabaseContext
                               .Categories
                               .AsQueryable();
            categoryQuery = CategoryFilter(categoryQuery, categoryCriteriaDto);

            var pagedCategories = await categoryQuery
                                .AsNoTracking()
                                .PaginateAsync(categoryCriteriaDto);

            var categoryDto = _mapper.Map<IEnumerable<CategoryDto>>(pagedCategories.Items);
            return new PagedResponseDto<CategoryDto>
            {
                CurrentPage = pagedCategories.CurrentPage,
                TotalPages = pagedCategories.TotalPages,
                TotalItems = pagedCategories.TotalItems,
                Search = categoryCriteriaDto.Search,
                SortColumn = categoryCriteriaDto.SortColumn,
                SortOrder = categoryCriteriaDto.SortOrder,
                Limit = categoryCriteriaDto.Limit,
                Items = categoryDto
            };
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

        //Fliter categories
        private IQueryable<Category> CategoryFilter(
           IQueryable<Category> categoryQuery,
           CategoryCriteriaDto categoryCriteriaDto)
        {
            if (!String.IsNullOrEmpty(categoryCriteriaDto.Search))
            {
                categoryQuery = categoryQuery.Where(b =>
                    b.CategoryName.Contains(categoryCriteriaDto.Search));
            }

            return categoryQuery;
        }
    }
}
