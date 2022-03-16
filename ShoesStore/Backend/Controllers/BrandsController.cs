using Backend.Models;
using Backend.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared;
using Shared.Dto.Brand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandRepository _brandRepository;

        public BrandsController(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        //Get a list of brands
        [HttpGet("List")]
        public async Task<ActionResult> GetBrands()
        {
            try
            {
                return Ok(await _brandRepository.GetBrands());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        //Get 1 brand by ID
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Brand>> GetBrand(int id)
        {
            try
            {
                var result = await _brandRepository.GetBrand(id);
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

        //Create a new brand
        [HttpPost]
        public async Task<ActionResult<Brand>> CreateBrand([FromForm] BrandCreateRequest brandCreateRequest)
        {
            try
            {
                if(brandCreateRequest == null)
                {
                    return BadRequest();
                }

                var createBrand = await _brandRepository.AddBrand(brandCreateRequest);
                return CreatedAtAction(nameof(GetBrand), new { id = createBrand.BrandId},
                    createBrand);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");
            }
        }

        //Update 1 brand
        [HttpPut("{id:int}")]
        public async Task<ActionResult<Brand>> UpdateBrand(int id, [FromForm] BrandCreateRequest brandCreateRequest)
        {
            try
            {
                if (brandCreateRequest == null)
                {
                    return BadRequest();
                }
                var updateBrand = await _brandRepository.UpdateBrand(id, brandCreateRequest);
                return updateBrand;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");
            }
        }

        //Delete 1 brand
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Brand>> DeleteBrand(int id)
        {
            try
            {
                var brandToDelete = await _brandRepository.GetBrand(id);

                if(brandToDelete == null)
                {
                    return NotFound($"Brand with Id = {id} not found");
                }

                return await _brandRepository.DeleteBrand(id);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                  "Error deleting data");
            }
        }

        //Get a list of brands with pages, search, sort
        [HttpGet]
        public async Task<ActionResult> GetBrandsPages([FromQuery] BrandCriteriaDto brandCriteriaDto)
        {
            try
            {
                return Ok(await _brandRepository.Get(brandCriteriaDto));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
    }
}
