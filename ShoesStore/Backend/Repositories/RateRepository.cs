using Backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Repositories
{
    public class RateRepository : IRateRepository
    {
        private readonly ShoesStoreDatabaseContext _shoesStoreDatabaseContext;
        public RateRepository(ShoesStoreDatabaseContext shoesStoreDatabaseContext)
        {
            _shoesStoreDatabaseContext = shoesStoreDatabaseContext;
        }
        public async Task<IEnumerable<Rate>> GetRates()
        {
            return await _shoesStoreDatabaseContext.Rates.ToListAsync();
        }
        public async Task<IEnumerable<Rate>> GetRatesByProductId(int productId)
        {
            return await _shoesStoreDatabaseContext.Rates.Where(s => s.ProductId == productId)
                .Include(s=>s.User)
                .ToListAsync();
        }

        public async Task<double> GetSumRateByProductId(int productId)
        {
            double pointResult = 0;
            var rate = await _shoesStoreDatabaseContext.Rates.Where(s => s.ProductId == productId).ToListAsync();
            foreach (var item in rate)
            {
                pointResult += item.Points;
            }
            return pointResult = Math.Round(pointResult / rate.Count(),0);
        }
    }
}
