using Backend.Models;
using Backend.Repositories;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize]
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
        [AllowAnonymous]
        [HttpGet("List")]
        public async Task<ActionResult> GetProducts()
        {
            try
            {
                var result = await _productRepository.GetProducts();
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

        //Get 1 product by ID
        [AllowAnonymous]
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
        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
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
        [AllowAnonymous]
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
        [AllowAnonymous]
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
        [AllowAnonymous]
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

        //Create new order
        [HttpPost("CreateOrder")]
        [Authorize]
        public async Task<ActionResult<Order>> CreateOrder([FromBody] Order model)
        {
            try
            {
                if (model == null)
                {
                    return BadRequest();
                }

                var createOrder = await _productRepository.CreateOrder(model);
                return CreatedAtAction(nameof(CreateOrder), new { id = model.OrderId },
                    createOrder);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");
            }
        }

        //Create new order detail
        [HttpPost("CreateOrderDetail")]
        [Authorize]
        public async Task<ActionResult<OrderDetail>> CreateOrderDetail([FromBody] OrderDetail model)
        {
            try
            {
                if (model == null)
                {
                    return BadRequest();
                }

                var createOrderDetail = await _productRepository.CreateOrderDetail(model);
                return CreatedAtAction(nameof(CreateOrderDetail), new { id = model.OrderDetailsId },
                    createOrderDetail);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                                "Error retrieving data from the database");
            }
        }
    }
}
