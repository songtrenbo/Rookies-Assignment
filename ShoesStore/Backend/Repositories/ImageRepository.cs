using Backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Repositories
{
    public class ImageRepository : IImageRepository
    {
        private readonly ShoesStoreDatabaseContext shoesStoreDatabaseContext;

        public ImageRepository(ShoesStoreDatabaseContext shoesStoreDatabaseContext)
        {
            this.shoesStoreDatabaseContext = shoesStoreDatabaseContext;
        }

        public async Task<IEnumerable<Image>> GetImages(int productId)
        {
            return await shoesStoreDatabaseContext.Images.Where(e => e.ProductId == productId).ToListAsync();
        }
    }
}
