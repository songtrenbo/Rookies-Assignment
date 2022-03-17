using Backend.Models;
using Backend.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared;
using Shared.Dto.Product;
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
        private readonly IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        //Get a list of products
        [HttpGet("List")]
        public async Task<ActionResult> GetProducts()
        {
            try
            {
                return Ok(await _productRepository.GetProducts());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        //Get 1 product by ID
        [HttpGet("{id:int}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            try
            {
                var result = await _productRepository.GetProduct(id);
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

        //Create a new product
        [HttpPost]
        public async Task<ActionResult<Product>> CreateProduct([FromForm] ProductCreateRequest productCreateRequest)
        {
            try
            {
                if (productCreateRequest == null)
                {
                    return BadRequest();
                }

                var createProduct = await _productRepository.AddProduct(productCreateRequest);
                return CreatedAtAction(nameof(GetProduct), new { id = createProduct.ProductId },
                    createProduct);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");
            }
        }

        //Delete a product with ID
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<Product>> DeleteProduct(int id)
        {
            try
            {
                var productToDelete = await _productRepository.GetProduct(id);

                if (productToDelete == null)
                {
                    return NotFound($"Product with Id = {id} not found");
                }

                return await _productRepository.DeleteProduct(id);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                  "Error deleting data");
            }
        }

        //Update 1 product
        [HttpPut("{id:int}")]
        public async Task<ActionResult<Product>> UpdateProduct(int id, [FromForm] ProductCreateRequest productCreateRequest)
        {
            try
            {
                if (productCreateRequest == null)
                {
                    return BadRequest();
                }
                var updateBrand = await _productRepository.UpdateProduct(id, productCreateRequest);
                return updateBrand;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");
            }
        }

        //Get a list of top 9 new products
        [HttpGet("GetTop9NewProduct")]
        public async Task<ActionResult> GetTop9NewProduct()
        {
            try
            {
                return Ok(await _productRepository.GetTop9NewProduct());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        //Get a list of products with categoryId
        [HttpGet("Category/{id:int}")]
        public async Task<ActionResult> GetProductsByCategory(int id)
        {
            try
            {
                return Ok(await _productRepository.GetProductsByCategory(id));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        //Get a list of products with pages, search, sort
        [HttpGet]
        public async Task<ActionResult> GetProductsPages([FromQuery] ProductCriteriaDto productCriteriaDto)
        {
            try
            {
                return Ok(await _productRepository.GetProductsPages(productCriteriaDto));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
    }
}
