using AutoMapper;
using Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shared.Dto;
using Shared.Dto.Brand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;
using Backend.Extensions;

namespace Backend.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private readonly ShoesStoreDatabaseContext _shoesStoreDatabaseContext;
        private readonly IMapper _mapper;

        public BrandRepository(ShoesStoreDatabaseContext shoesStoreDatabaseContext, IMapper mapper)
        {
            _shoesStoreDatabaseContext = shoesStoreDatabaseContext;
            _mapper = mapper;
        }

        public async Task<Brand> AddBrand(Brand brand)
        {
            var result = await _shoesStoreDatabaseContext.Brands.AddAsync(brand);
            await _shoesStoreDatabaseContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<Brand> DeleteBrand(int brandId)
        {
            var result = await _shoesStoreDatabaseContext.Brands.FirstOrDefaultAsync(e => e.BrandId == brandId);
            if (result != null)
            {
                _shoesStoreDatabaseContext.Brands.Remove(result);
                await _shoesStoreDatabaseContext.SaveChangesAsync();
                return result;
            }
            return null;
        }
        public async Task<Brand> GetBrand(int brandId)
        {
            return await _shoesStoreDatabaseContext.Brands.FirstOrDefaultAsync(e => e.BrandId == brandId);
        }

        public async Task<IEnumerable<Brand>> GetBrands()
        {
            return await _shoesStoreDatabaseContext.Brands.ToListAsync();
        }
        public async Task<Brand> UpdateBrand(Brand brand)
        {
            var result = await _shoesStoreDatabaseContext.Brands.FirstOrDefaultAsync(e => e.BrandId == brand.BrandId);
            if (result != null)
            {
                result.BrandName = brand.BrandName;
                await _shoesStoreDatabaseContext.SaveChangesAsync();
                return result;
            }
            return null;
        }

        //Get brands with pages, search, sort
        public async Task<PagedResponseDto<BrandDto>> Get([FromQuery] BrandCriteriaDto brandCriteriaDto)
        {
            var brandQuery = _shoesStoreDatabaseContext
                               .Brands
                               .AsQueryable();
            brandQuery = BrandFilter(brandQuery, brandCriteriaDto);

            var pagedBrands = await brandQuery
                                .AsNoTracking()
                                .PaginateAsync(brandCriteriaDto);

            var brandDto = _mapper.Map<IEnumerable<BrandDto>>(pagedBrands.Items);
            return new PagedResponseDto<BrandDto>
            {
                CurrentPage = pagedBrands.CurrentPage,
                TotalPages = pagedBrands.TotalPages,
                TotalItems = pagedBrands.TotalItems,
                Search = brandCriteriaDto.Search,
                SortColumn = brandCriteriaDto.SortColumn,
                SortOrder = brandCriteriaDto.SortOrder,
                Limit = brandCriteriaDto.Limit,
                Items = brandDto
            };
        }

        //Fliter brands
        private IQueryable<Brand> BrandFilter(
           IQueryable<Brand> brandQuery,
           BrandCriteriaDto brandCriteriaDto)
        {
            if (!String.IsNullOrEmpty(brandCriteriaDto.Search))
            {
                brandQuery = brandQuery.Where(b =>
                    b.BrandName.Contains(brandCriteriaDto.Search));
            }

            return brandQuery;
        }
    }
}
