using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Shared;
using Shared.Dto;
using Shared.Dto.Brand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Repositories
{
    public interface IBrandRepository
    {
        Task<IEnumerable<Brand>> GetBrands();
        Task<PagedResponseDto<BrandDto>> Get([FromQuery] BrandCriteriaDto brandCriteriaDto);
        Task<Brand> GetBrand(int brandId);
        Task<Brand> AddBrand([FromForm] BrandCreateRequest brandCreateRequest);
        Task<Brand> UpdateBrand(int id, [FromForm] BrandCreateRequest brandCreateRequest);
        Task<Brand> DeleteBrand(int brandId);

    }
}
