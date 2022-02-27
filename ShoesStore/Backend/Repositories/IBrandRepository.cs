using Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Services
{
    public interface IBrandRepository
    {
        Task<IEnumerable<Brand>> GetBrands();
        Task<Brand> GetBrand(int brandId);
        Task<Brand> AddBrand(Brand brand);
        Task<Brand> UpdateBrand(Brand brand);
        Task<Brand> DeleteBrand(int brandId);

    }
}
