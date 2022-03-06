using Backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ShoesStoreDatabaseContext shoesStoreDatabaseContext;
        public CategoryRepository(ShoesStoreDatabaseContext shoesStoreDatabaseContext)
        {
            this.shoesStoreDatabaseContext = shoesStoreDatabaseContext;
        }
        public async Task<IEnumerable<Category>> GetCategoies()
        {
            return await shoesStoreDatabaseContext.Categories.ToListAsync();
        }
    }
}
