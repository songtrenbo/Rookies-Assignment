using Backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Repositories
{
    public interface ISizeRepository
    {
        Task<IEnumerable<SizeProduct>> GetSizesByProductId(int productId);

    }
}
