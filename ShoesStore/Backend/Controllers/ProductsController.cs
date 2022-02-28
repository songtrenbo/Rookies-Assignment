using Backend.Models;
using Backend.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetProducts()
        {
            try
            {
                return Ok(await productRepository.GetProducts());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            try
            {
                var result = await productRepository.GetProduct(id);
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
        public async Task<ActionResult<Product>> CreateProduct(Product product)
        {
            try
            {
                if (product == null)
                {
                    return BadRequest();
                }

                var createProduct = await productRepository.AddProduct(product);
                return CreatedAtAction(nameof(GetProduct), new { id = createProduct.ProductId },
                    createProduct);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Product>> DeleteProduct(int id)
        {
            try
            {
                var productToDelete = await productRepository.GetProduct(id);

                if (productToDelete == null)
                {
                    return NotFound($"Product with Id = {id} not found");
                }

                return await productRepository.DeleteProduct(id);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                  "Error deleting data");
            }
        }


        [HttpPut("{id:int}")]
        public async Task<ActionResult<Product>> UpdateProduct(int id, Product product)
        {
            try
            {
                if (id != product.ProductId)
                {
                    return BadRequest("Product ID mismatch");
                }
                var productToUpdate = await productRepository.GetProduct(id);

                if (productToUpdate == null)
                {
                    return NotFound($"Product with Id = {id} not found");
                }

                return await productRepository.UpdateProduct(product);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                  "Error updating data");
            }
        }
    }
}
