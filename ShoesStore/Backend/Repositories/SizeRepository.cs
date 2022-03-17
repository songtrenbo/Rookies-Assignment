using Backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Repositories
{
    public class SizeRepository : ISizeRepository
    {
        private readonly ShoesStoreDatabaseContext _shoesStoreDatabaseContext;
        public SizeRepository(ShoesStoreDatabaseContext shoesStoreDatabaseContext)
        {
            _shoesStoreDatabaseContext = shoesStoreDatabaseContext;
        }
        public async Task<IEnumerable<SizeProduct>> GetSizesByProductId(int productId)
        {
            return await _shoesStoreDatabaseContext.SizeProducts
                .Where(s => s.ProductId == productId)
                .Include(e=>e.Size)
                .OrderBy(e=>e.Size.SizeName)
                .ToListAsync();
        }
    }
}
