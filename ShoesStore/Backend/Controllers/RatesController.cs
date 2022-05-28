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
    public class RatesController : ControllerBase
    {
        private readonly IRateRepository _rateRepository;

        public RatesController(IRateRepository rateRepository)
        {
            _rateRepository = rateRepository;
        }
        //Get a list of rates
        [HttpGet]
        public async Task<ActionResult> GetRates()
        {
            try
            {
                return Ok(await _rateRepository.GetRates());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        //Get a list of rates with productId
        [HttpGet("Product/{id:int}")]
        public async Task<ActionResult> GetRatesByProductId(int id)
        {
            try
            {
                return Ok(await _rateRepository.GetRatesByProductId(id));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }

        //Get rate points of product
        [HttpGet("RatePoints/{id:int}")]
        public async Task<ActionResult> GetSumRateByProductId(int id)
        {
            try
            {
                return Ok(await _rateRepository.GetSumRateByProductId(id));
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from the database");
            }
        }
    }
}
