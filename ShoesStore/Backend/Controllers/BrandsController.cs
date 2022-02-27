using Backend.Models;
using Backend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        private readonly IBrandRepository brandRepository;

        public BrandsController(IBrandRepository brandRepository)
        {
            this.brandRepository = brandRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetBrands()
        {
            try
            {
                return Ok(await brandRepository.GetBrands());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Brand>> GetBrand(int id)
        {
            try
            {
                var result = await brandRepository.GetBrand(id);
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

        [HttpPost]
        public async Task<ActionResult<Brand>> CreateBrand(Brand brand)
        {
            try
            {
                if(brand == null)
                {
                    return BadRequest();
                }

                var createBrand = await brandRepository.AddBrand(brand);
                return CreatedAtAction(nameof(GetBrand), new { id = createBrand.BrandId},
                    createBrand);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<Brand>> UpdateBrand(int id, Brand brand)
        {
            try
            {
                if (id != brand.BrandId)
                {
                    return BadRequest("Brand ID mismatch");
                }
                var brandToUpdate = await brandRepository.GetBrand(id);
                
                if(brandToUpdate == null)
                {
                    return NotFound($"Brand with Id = {id} not found");
                }

                return await brandRepository.UpdateBrand(brand);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                  "Error updating data");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Brand>> DeleteBrand(int id)
        {
            try
            {
                var brandToDelete = await brandRepository.GetBrand(id);

                if(brandToDelete == null)
                {
                    return NotFound($"Brand with Id = {id} not found");
                }

                return await brandRepository.DeleteBrand(id);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                  "Error deleting data");
            }
        }
    }
}
