using Backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Services
{
    public class BrandRepository : IBrandRepository
    {
        private readonly ShoesStoreDatabaseContext shoesStoreDatabaseContext;

        public BrandRepository(ShoesStoreDatabaseContext shoesStoreDatabaseContext)
        {
            this.shoesStoreDatabaseContext = shoesStoreDatabaseContext;
        }

        public async Task<Brand> AddBrand(Brand brand)
        {
            var result = await shoesStoreDatabaseContext.Brands.AddAsync(brand);
            await shoesStoreDatabaseContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Brand> DeleteBrand(int brandId)
        {
            var result = await shoesStoreDatabaseContext.Brands.FirstOrDefaultAsync(e => e.BrandId == brandId);
            if (result != null)
            {
                shoesStoreDatabaseContext.Brands.Remove(result);
                await shoesStoreDatabaseContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
        public async Task<Brand> GetBrand(int brandId)
        {
            return await shoesStoreDatabaseContext.Brands.FirstOrDefaultAsync(e => e.BrandId == brandId);
        }

        public async Task<IEnumerable<Brand>> GetBrands()
        {
            return await shoesStoreDatabaseContext.Brands.ToListAsync();
        }
        public async Task<Brand> UpdateBrand(Brand brand)
        {
            var result = await shoesStoreDatabaseContext.Brands.FirstOrDefaultAsync(e => e.BrandId == brand.BrandId);
            if (result != null)
            {
                result.BrandName = brand.BrandName;
                await shoesStoreDatabaseContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
    }
}
