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
        private readonly ShoesStoreDatabaseContext _shoesStoreDatabaseContext;

        public ImageRepository(ShoesStoreDatabaseContext shoesStoreDatabaseContext)
        {
            _shoesStoreDatabaseContext = shoesStoreDatabaseContext;
        }

        public async Task<IEnumerable<Image>> GetImages(int productId)
        {
            return await _shoesStoreDatabaseContext.Images.Where(e => e.ProductId == productId).ToListAsync();
        }
    }
}
