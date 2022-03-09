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
        private readonly ShoesStoreDatabaseContext shoesStoreDatabaseContext;
        public SizeRepository(ShoesStoreDatabaseContext shoesStoreDatabaseContext)
        {
            this.shoesStoreDatabaseContext = shoesStoreDatabaseContext;
        }
        public async Task<IEnumerable<SizeProduct>> GetSizesByProductId(int productId)
        {
            return await shoesStoreDatabaseContext.SizeProducts
                .Where(s => s.ProductId == productId)
                .Include(e=>e.Size)
                .OrderBy(e=>e.Size.SizeName)
                .ToListAsync();
        }
    }
}
