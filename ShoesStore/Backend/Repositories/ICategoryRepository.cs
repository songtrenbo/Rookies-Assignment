using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Shared;
using Shared.Dto;
using Shared.Dto.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetCategoies();
        Task<Category> GetCategory(int categoryId);
        Task<PagedResponseDto<CategoryDto>> GetCategoriesPages([FromQuery] CategoryCriteriaDto categoryCriteriaDto); 
        Task<Category> AddCategory([FromForm] CategoryCreateRequest categoryCreateRequest);
        Task<Category> UpdateCategory(int id, [FromForm] CategoryCreateRequest categoryCreateRequest);
        Task<Category> DeleteCategory(int categoryId);
    }
}
