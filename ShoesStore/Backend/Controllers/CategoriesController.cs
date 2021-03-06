using Backend.Models;
using Backend.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared;
using Shared.Dto.Category;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoriesController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        //Get a list of Categories
        [AllowAnonymous]
        [HttpGet("List")]
        public async Task<ActionResult> GetCategoies()
        {
            try
            {
                var result = await _categoryRepository.GetCategoies();
                if (result.Count() == 0)
                {
                    return NoContent();
                }
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        //Get a list of categories with pages, search, sort
        [AllowAnonymous]
        [HttpGet]
        public async Task<ActionResult> GetCategoriesPages([FromQuery] CategoryCriteriaDto categoryCriteriaDto)
        {
            try
            {
                return Ok(await _categoryRepository.GetCategoriesPages(categoryCriteriaDto));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        //Get 1 category by ID
        [AllowAnonymous]
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Category>> GetCategory(int id)
        {
            try
            {
                var result = await _categoryRepository.GetCategory(id);
                if (result == null)
                {
                    return NotFound();
                }
                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
        //Create a new category
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<ActionResult<Brand>> CreateCategory([FromForm] CategoryCreateRequest categoryCreateRequest)
        {
            try
            {
                if (categoryCreateRequest == null)
                {
                    return BadRequest();
                }

                var createCategory = await _categoryRepository.AddCategory(categoryCreateRequest);
                return CreatedAtAction(nameof(GetCategoies), new { id = createCategory.CategoryId },
                    createCategory);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");
            }
        }

        //Update 1 category
        [Authorize(Roles = "Admin")]
        [HttpPut("{id:int}")]
        public async Task<ActionResult<Category>> UpdateCategory(int id, [FromForm] CategoryCreateRequest categoryCreateRequest)
        {
            try
            {
                if (categoryCreateRequest == null)
                {
                    return BadRequest();
                }
                var updateCategory = await _categoryRepository.UpdateCategory(id, categoryCreateRequest);
                return updateCategory;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");
            }
        }

        //Delete 1 category
        [Authorize(Roles = "Admin")]
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Category>> DeleteCategory(int id)
        {
            try
            {
                var categoryToDelete = await _categoryRepository.GetCategory(id);

                if (categoryToDelete == null)
                {
                    return NotFound($"Brand with Id = {id} not found");
                }

                return await _categoryRepository.DeleteCategory(id);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                  "Error deleting data");
            }
        }

    }
}
